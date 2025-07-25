namespace CSCore.Domain.EstaticasLabel.GG
{
    public static class Entities
    {
        public static class GG071_Status
        {
            public const string Aberto = "Aberto";
            public const string Solicitado = "Solicitado";
            public const string Erro = "Erro";
            public const string Atendido = "Atendido";
            public const string Cancelado = "Cancelado";
            /*
             Solicitado
             Atendido
             Cancelado
             Erro
             */
        }


        public static class GG072Stq
        {
            public const string Aberto = "Aberto";
            public const string Baixado = "Baixado";
            public const string Estornado = "Estornado";
            public const string Erro = "Erro";
            public const string Inventario = "Inventário";
            public const string SemSaldo = "Sem Saldo";
            public const string Cancelado = "Cancelado";
        }

        public static class BB008_Tipo
        {
            public const string d1_Dias = "1.Dias";
            public const string d2_ParcelaDias = "2.Parcela + Dias";
            public const string d3_ParcelaMes = "3.Parcela + Meses";
            public const string d9_Avista = "9.À vista";
        }

        public static class FF102_Ent
        {
            public const string Entrada = "Entrada";
            public const string Parcela = "Parcela";
        }

        public static class FF120_TRACKAPI
        {
            public const string Preparando = "Preparando Boleto";
            public const string Enviando = "Enviando Boleto";
            public const string FinalizadoEnvio = "Finalizado Envio Boleto";
        }

        public static class ff112_cnab
        {
            public const string APIPRD = "API produção";
        }


        public static class FF112_G028
        {
            public const string R = "Arquivo Remessa";
        }


        public static class ff112_C026
        {
            public const string NaoProtestar = "Nao Protestar";
            public const string CancelamentoProtestoAutomatico = "Cancelamento Protesto Automatico";
            public const string NegativacaosemProtesto = "Negativação sem Protesto";
        }

        public static class csicp_bb012_GruCta
        {
            public const string Outros = "Pessoa Fisica";
        }

        public static class FF102_Sit
        {
            public const string Aberto = "Aberto";
            public const string BxParcial = "Baixa Parcial";
            public const string Liquidado = "Liquidado";
            public const string Cancelado = "Cancelado";
            public const string Renegociado = "Renegociado";
            public const string Consignado = "Consignado";
            public const string Provisao = "Provisao";
            public const string Canc_Sistema = "Cancelado Sistema";
            public const string Devolvido = "Devolvido";
            public const string Permutado = "Permutado";
        }


        public static class GG028EntSaida
        {
            public const string Entrada = "Entrada";
            public const string Saida = "Saida";
        }

        public static class BB01201_Con
        {
            public const string AVista = "A Vista";
            public const string AVistaCF = "A VistaCF";
            public const string Faturado = "Faturado";
            public const string Convenio = "Convenio";
            public const string Cheque = "Cheque";
            public const string CartaoInterno = "Modo Cartão Interno";
            public const string CartaoExterno = "Cartão Externo";
        }

        public static class BB062_Sta
        {
            public const string Aberto = "Aberto";
            public const string Programado = "Programado";
            public const string Fechado = "Fechado";

        }

        public static class BB061_TP
        {
            public const string Titular = "Titular";
            public const string Dependente = "Dependente";
        }
        public static class GG073EntSaida
        {
            public const string Entrada = "Entrada";
            public const string Saida = "Saída";
        }

        public static class AA030_TpToken
        {
            public const string Clearsale = "Clearsale";
        }

        public static class GG028Nat
        {
            public const string Estoque_1_22 = "1.22 - Estoque";
            public const string ReqExterna_1_11 = "1.11 - Requisição Externa";
            public const string ReqInterna_1_11 = "1.10 - Requisição Interna";
            public const string Inventario = "1.09 - Inventario";
            public const string TransferenciaSALDO = "1.16 - Transferência de Saldo";
        }

        public static class CodCS_GG054Sta
        {
            public const int Aberto = 1;
            public const int Descartado = 2;
            public const int Inventariado = 3;
            public const int Administrativo = 4;
        }

        public static class CodCS_GG055Sta
        {
            public const int Aberto = 1;
            public const int Transferido = 2;
        }

        public static class CodCS_GG032Sta
        {
            public const string Solicitado = "Solicitado";
            public const string Bloqueado = "Bloqueado";
            public const string Concluido = "Concluido";
        }

        public static class GG030Sta
        {
            public const string Solicitado = "Solicitado";
        }

        public static class CodCS_GG032TpInv
        {
            public const string Normal = "Normal";
            public const string Administrativo = "Administrativo";
            public const string Fiscal = "Fiscal";
        }
        public static class GG030_Status
        {
            public const string Solicitado = "Solicitado";
            public const string Atendido = "Atendido";
        }
        public static class GG023_Val
        {
            public const string Venda = "Venda";
            public const string CustoReal = "Custo Real";
            public const string Custo = "Custo";
            public const string Reposicao = "Reposição";
            public const string CustoMedio = "Custo Médio";
            public const string ECommerce = "E-Commerce";
        }

        public static class GG019_CgBar
        {
            public const string Sistema = "Sistema";
        }

        public static class GG001_TAlmox_Virtual
        {
            public const string Virtual = "Virtual";
        }
        public static class GG045_Status
        {
            public const string Aberto = "Aberto";
            public const string Transferido = "Transferido";
            public const string Estornado = "Estornado";
        }
        public static class GG046_EntSai
        {
            public const string Entrada = "Entrada";
            public const string Saida = "Saída";
        }

        public static class GG046_Stat
        {
            public const string Aberto = "Aberto";
            public const string Transferido_Mais = "Transferido (+)";
            public const string Transferido_Menos = "Transferido (-)";
        }
    }
}
