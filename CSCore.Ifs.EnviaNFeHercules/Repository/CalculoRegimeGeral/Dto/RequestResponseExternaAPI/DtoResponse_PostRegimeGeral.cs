namespace CSCore.Ifs.EnviaNFeHercules.Repository.CalculoRegimeGeral.Dto.RequestResponseExternaAPI;

public record DtoResponse_PostRegimeGeral(
    List<Objeto> objetos,
    Total total
);

public record Objeto(
    int nObj,
    TribCalc tribCalc
);

public record TribCalc(
    IS IS,
    IBSCBS IBSCBS,
    GIBSCBSMono gIBSCBSMono,
    GTransfCred gTransfCred,
    GCredPresIBSZFM gCredPresIBSZFM
);

public record IS(
    int CSTIS,
    string cClassTribIS,
    decimal vBCIS,
    decimal pIS,
    decimal pISEspec,
    string uTrib,
    decimal qTrib,
    decimal vIS,
    string memoriaCalculo
);

public record IBSCBS(
    int CST,
    string cClassTrib,
    GIBSCBS gIBSCBS,
    GIBSCBSUF gIBSUF,
    GIBSCBSMun gIBSMun,
    GCBS gCBS,
    GTribRegular gTribRegular,
    GIBSCredPres gIBSCredPres,
    GCBSCredPres gCBSCredPres,
    GTribCompraGov gTribCompraGov
);

public record GIBSCBS(
    decimal vBC,
    GIBSCBSUF gIBSUF,
    GIBSCBSMun gIBSMun,
    GCBS gCBS,
    GTribRegular gTribRegular,
    GIBSCredPres gIBSCredPres,
    GCBSCredPres gCBSCredPres,
    GTribCompraGov gTribCompraGov
);

public record GIBSCBSUF(
    decimal pIBSUF,
    GDif gDif,
    GDevTrib gDevTrib,
    GRed gRed,
    decimal vIBSUF,
    string memoriaCalculo
);

public record GIBSCBSMun(
    decimal pIBSMun,
    GDif gDif,
    GDevTrib gDevTrib,
    GRed gRed,
    decimal vIBSMun,
    string memoriaCalculo
);

public record GCBS(
    decimal pCBS,
    GDif gDif,
    GDevTrib gDevTrib,
    GRed gRed,
    decimal vCBS,
    string memoriaCalculo
);

public record GTribRegular(
    int CSTReg,
    string cClassTribReg,
    decimal pAliqEfetRegIBSUF,
    decimal vTribRegIBSUF,
    decimal pAliqEfetRegIBSMun,
    decimal vTribRegIBSMun,
    decimal pAliqEfetRegCBS,
    decimal vTribRegCBS
);

public record GIBSCredPres(
    int cCredPres,
    decimal pCredPres,
    decimal vCredPres,
    decimal vCredPresCondSus
);

public record GCBSCredPres(
    int cCredPres,
    decimal pCredPres,
    decimal vCredPres,
    decimal vCredPresCondSus
);

public record GTribCompraGov(
    decimal pAliqIBSUF,
    decimal vTribIBSUF,
    decimal pAliqIBSMun,
    decimal vTribIBSMun,
    decimal pAliqCBS,
    decimal vTribCBS
);

public record GIBSCBSMono(
    decimal qBCMono,
    decimal adRemIBS,
    decimal adRemCBS,
    decimal vIBSMono,
    decimal vCBSMono,
    decimal qBCMonoReten,
    decimal adRemIBSReten,
    decimal vIBSMonoReten,
    decimal adRemCBSReten,
    decimal vCBSMonoReten,
    decimal qBCMonoRet,
    decimal adRemIBSRet,
    decimal vIBSMonoRet,
    decimal adRemCBSRet,
    decimal vCBSMonoRet,
    decimal pDifIBS,
    decimal vIBSMonoDif,
    decimal pDifCBS,
    decimal vCBSMonoDif,
    decimal vTotIBSMonoItem,
    decimal vTotCBSMonoItem
);

public record GTransfCred(
    decimal vIBS,
    decimal vCBS
);

public record GCredPresIBSZFM(
    int tpCredPresIBSZFM,
    decimal vCredPresIBSZFM
);

public record GDif(
    decimal pDif,
    decimal vDif
);

public record GDevTrib(
    decimal vDevTrib
);

public record GRed(
    decimal pRedAliq,
    decimal pAliqEfet
);

public record Total(
    TotalTribCalc tribCalc
);

public record TotalTribCalc(
    ISTot ISTot,
    IBSCBSTot IBSCBSTot
);

public record ISTot(
    decimal vIS
);

public record IBSCBSTot(
    decimal vBCIBSCBS,
    GIBS gIBS,
    GCBS gCBS,
    GMono gMono
);

public record GIBS(
    GIBSUF gIBSUF,
    GIBSMun gIBSMun,
    decimal vIBS,
    decimal vCredPres,
    decimal vCredPresCondSus
);

public record GIBSUF(
    decimal vDif,
    decimal vDevTrib,
    decimal vIBSUF
);

public record GIBSMun(
    decimal vDif,
    decimal vDevTrib,
    decimal vIBSMun
);



public record GMono(
    decimal vIBSMono,
    decimal vCBSMono,
    decimal vIBSMonoReten,
    decimal vCBSMonoReten,
    decimal vIBSMonoRet,
    decimal vCBSMonoRet
);