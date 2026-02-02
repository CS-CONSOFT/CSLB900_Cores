using Microsoft.Extensions.Logging;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSCore.Redis
{
    public interface IRedisConnection : IDisposable
    {
        IDatabase GetDatabase(int db = -1);
        IConnectionMultiplexer GetConnectionMultiplexer();
        bool TestConnection();
    }
    public class ConnectRedis : IRedisConnection
    {
        private readonly Lazy<ConnectionMultiplexer> _connection;
        private readonly ILogger<ConnectRedis>? _logger;
        private bool _disposed = false;

        public ConnectRedis(ConfigurationOptions configuration)
        {
            _connection
                = new Lazy<ConnectionMultiplexer>(() => ConnectionMultiplexer.Connect(new ConfigurationOptions
                {
                    EndPoints = configuration.EndPoints,
                    Password = configuration.Password,
                    User = configuration.User,
                }));
        }

        public ConnectRedis(string configurationString, ILogger<ConnectRedis>? logger = null)
        {
            _logger = logger;
            _logger?.LogInformation("🔧 Construtor ConnectRedis chamado. Configurando conexão Redis...");
            
            _connection
                = new Lazy<ConnectionMultiplexer>(() =>
                {
                    try
                    {
                        _logger?.LogInformation("⚡ Iniciando conexão ao Redis: {ConnectionString}",
                            configurationString);

                        var conn = ConnectionMultiplexer.Connect(configurationString);

                        conn.ConnectionFailed += (sender, args) =>
                        {
                            _logger?.LogError("❌ Falha na conexão Redis: {Exception} - {FailureType}",
                                args.Exception?.Message, args.FailureType);
                        };

                        conn.ConnectionRestored += (sender, args) =>
                        {
                            _logger?.LogInformation("🔄 Conexão Redis restaurada: {FailureType}", args.FailureType);
                        };

                        _logger?.LogInformation("✅ Conectado ao Redis com sucesso! Endpoints: {Endpoints}",
                            string.Join(", ", conn.GetEndPoints()));

                        return conn;
                    }
                    catch (Exception ex)
                    {
                        _logger?.LogError(ex, "❌ Erro ao conectar ao Redis: {ConnectionString}",
                            configurationString);
                        throw;
                    }
                });
            
            _logger?.LogInformation("✅ ConnectRedis instanciado. Conexão será estabelecida no primeiro uso.");
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        public IConnectionMultiplexer GetConnectionMultiplexer()
        {
            return _connection.Value;
        }

        public IDatabase GetDatabase(int db = -1)
        {
            return _connection.Value.GetDatabase(db);
        }

        public bool TestConnection()
        {
            try
            {
                _logger?.LogInformation("🧪 Testando conexão Redis...");
                var db = GetDatabase();
                var result = db.Ping();
                _logger?.LogInformation("✅ Ping Redis bem-sucedido: {Time}ms", result.TotalMilliseconds);
                return true;
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "❌ Falha no teste de conexão Redis");
                return false;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                if (_connection.IsValueCreated)
                {
                    _connection.Value?.Dispose();
                }
                _disposed = true;
            }
        }
    }
}
