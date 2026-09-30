using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The shipping country associated with this InvoiceResult, valid values being the 3-letter ISO code for the country.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Country197>))]
public sealed record Country197 : OpenStringEnum<Country197>
{
    private Country197(string value) : base(value)
    {
    }

    public static readonly Country197 Abw = new("ABW");

    public static readonly Country197 Afg = new("AFG");

    public static readonly Country197 Ago = new("AGO");

    public static readonly Country197 Aia = new("AIA");

    public static readonly Country197 Ala = new("ALA");

    public static readonly Country197 Alb = new("ALB");

    public static readonly Country197 And = new("AND");

    public static readonly Country197 Are = new("ARE");

    public static readonly Country197 Arg = new("ARG");

    public static readonly Country197 Arm = new("ARM");

    public static readonly Country197 Asm = new("ASM");

    public static readonly Country197 Ata = new("ATA");

    public static readonly Country197 Atf = new("ATF");

    public static readonly Country197 Atg = new("ATG");

    public static readonly Country197 Aus = new("AUS");

    public static readonly Country197 Aut = new("AUT");

    public static readonly Country197 Aze = new("AZE");

    public static readonly Country197 Bdi = new("BDI");

    public static readonly Country197 Bel = new("BEL");

    public static readonly Country197 Ben = new("BEN");

    public static readonly Country197 Bes = new("BES");

    public static readonly Country197 Bfa = new("BFA");

    public static readonly Country197 Bgd = new("BGD");

    public static readonly Country197 Bgr = new("BGR");

    public static readonly Country197 Bhr = new("BHR");

    public static readonly Country197 Bhs = new("BHS");

    public static readonly Country197 Bih = new("BIH");

    public static readonly Country197 Blm = new("BLM");

    public static readonly Country197 Blr = new("BLR");

    public static readonly Country197 Blz = new("BLZ");

    public static readonly Country197 Bmu = new("BMU");

    public static readonly Country197 Bol = new("BOL");

    public static readonly Country197 Bra = new("BRA");

    public static readonly Country197 Brb = new("BRB");

    public static readonly Country197 Brn = new("BRN");

    public static readonly Country197 Btn = new("BTN");

    public static readonly Country197 Bvt = new("BVT");

    public static readonly Country197 Bwa = new("BWA");

    public static readonly Country197 Caf = new("CAF");

    public static readonly Country197 Can = new("CAN");

    public static readonly Country197 Cck = new("CCK");

    public static readonly Country197 Che = new("CHE");

    public static readonly Country197 Chl = new("CHL");

    public static readonly Country197 Chn = new("CHN");

    public static readonly Country197 Civ = new("CIV");

    public static readonly Country197 Cmr = new("CMR");

    public static readonly Country197 Cod = new("COD");

    public static readonly Country197 Cog = new("COG");

    public static readonly Country197 Cok = new("COK");

    public static readonly Country197 Col = new("COL");

    public static readonly Country197 Com = new("COM");

    public static readonly Country197 Cpv = new("CPV");

    public static readonly Country197 Cri = new("CRI");

    public static readonly Country197 Cub = new("CUB");

    public static readonly Country197 Cuw = new("CUW");

    public static readonly Country197 Cxr = new("CXR");

    public static readonly Country197 Cym = new("CYM");

    public static readonly Country197 Cyp = new("CYP");

    public static readonly Country197 Cze = new("CZE");

    public static readonly Country197 Deu = new("DEU");

    public static readonly Country197 Dji = new("DJI");

    public static readonly Country197 Dma = new("DMA");

    public static readonly Country197 Dnk = new("DNK");

    public static readonly Country197 Dom = new("DOM");

    public static readonly Country197 Dza = new("DZA");

    public static readonly Country197 Ecu = new("ECU");

    public static readonly Country197 Egy = new("EGY");

    public static readonly Country197 Eri = new("ERI");

    public static readonly Country197 Esh = new("ESH");

    public static readonly Country197 Esp = new("ESP");

    public static readonly Country197 Est = new("EST");

    public static readonly Country197 Eth = new("ETH");

    public static readonly Country197 Fin = new("FIN");

    public static readonly Country197 Fji = new("FJI");

    public static readonly Country197 Flk = new("FLK");

    public static readonly Country197 Fra = new("FRA");

    public static readonly Country197 Fro = new("FRO");

    public static readonly Country197 Fsm = new("FSM");

    public static readonly Country197 Gab = new("GAB");

    public static readonly Country197 Gbr = new("GBR");

    public static readonly Country197 Geo = new("GEO");

    public static readonly Country197 Ggy = new("GGY");

    public static readonly Country197 Gha = new("GHA");

    public static readonly Country197 Gib = new("GIB");

    public static readonly Country197 Gin = new("GIN");

    public static readonly Country197 Glp = new("GLP");

    public static readonly Country197 Gmb = new("GMB");

    public static readonly Country197 Gnb = new("GNB");

    public static readonly Country197 Gnq = new("GNQ");

    public static readonly Country197 Grc = new("GRC");

    public static readonly Country197 Grd = new("GRD");

    public static readonly Country197 Grl = new("GRL");

    public static readonly Country197 Gtm = new("GTM");

    public static readonly Country197 Guf = new("GUF");

    public static readonly Country197 Gum = new("GUM");

    public static readonly Country197 Guy = new("GUY");

    public static readonly Country197 Hkg = new("HKG");

    public static readonly Country197 Hmd = new("HMD");

    public static readonly Country197 Hnd = new("HND");

    public static readonly Country197 Hrv = new("HRV");

    public static readonly Country197 Hti = new("HTI");

    public static readonly Country197 Hun = new("HUN");

    public static readonly Country197 Idn = new("IDN");

    public static readonly Country197 Imn = new("IMN");

    public static readonly Country197 Ind = new("IND");

    public static readonly Country197 Iot = new("IOT");

    public static readonly Country197 Irl = new("IRL");

    public static readonly Country197 Irn = new("IRN");

    public static readonly Country197 Irq = new("IRQ");

    public static readonly Country197 Isl = new("ISL");

    public static readonly Country197 Isr = new("ISR");

    public static readonly Country197 Ita = new("ITA");

    public static readonly Country197 Jam = new("JAM");

    public static readonly Country197 Jey = new("JEY");

    public static readonly Country197 Jor = new("JOR");

    public static readonly Country197 Jpn = new("JPN");

    public static readonly Country197 Kaz = new("KAZ");

    public static readonly Country197 Ken = new("KEN");

    public static readonly Country197 Kgz = new("KGZ");

    public static readonly Country197 Khm = new("KHM");

    public static readonly Country197 Kir = new("KIR");

    public static readonly Country197 Kna = new("KNA");

    public static readonly Country197 Kor = new("KOR");

    public static readonly Country197 Kwt = new("KWT");

    public static readonly Country197 Lao = new("LAO");

    public static readonly Country197 Lbn = new("LBN");

    public static readonly Country197 Lbr = new("LBR");

    public static readonly Country197 Lby = new("LBY");

    public static readonly Country197 Lca = new("LCA");

    public static readonly Country197 Lie = new("LIE");

    public static readonly Country197 Lka = new("LKA");

    public static readonly Country197 Lso = new("LSO");

    public static readonly Country197 Ltu = new("LTU");

    public static readonly Country197 Lux = new("LUX");

    public static readonly Country197 Lva = new("LVA");

    public static readonly Country197 Mac = new("MAC");

    public static readonly Country197 Maf = new("MAF");

    public static readonly Country197 Mar = new("MAR");

    public static readonly Country197 Mco = new("MCO");

    public static readonly Country197 Mda = new("MDA");

    public static readonly Country197 Mdg = new("MDG");

    public static readonly Country197 Mdv = new("MDV");

    public static readonly Country197 Mex = new("MEX");

    public static readonly Country197 Mhl = new("MHL");

    public static readonly Country197 Mkd = new("MKD");

    public static readonly Country197 Mli = new("MLI");

    public static readonly Country197 Mlt = new("MLT");

    public static readonly Country197 Mmr = new("MMR");

    public static readonly Country197 Mne = new("MNE");

    public static readonly Country197 Mng = new("MNG");

    public static readonly Country197 Mnp = new("MNP");

    public static readonly Country197 Moz = new("MOZ");

    public static readonly Country197 Mrt = new("MRT");

    public static readonly Country197 Msr = new("MSR");

    public static readonly Country197 Mtq = new("MTQ");

    public static readonly Country197 Mus = new("MUS");

    public static readonly Country197 Mwi = new("MWI");

    public static readonly Country197 Mys = new("MYS");

    public static readonly Country197 Myt = new("MYT");

    public static readonly Country197 Nam = new("NAM");

    public static readonly Country197 Ncl = new("NCL");

    public static readonly Country197 Ner = new("NER");

    public static readonly Country197 Nfk = new("NFK");

    public static readonly Country197 Nga = new("NGA");

    public static readonly Country197 Nic = new("NIC");

    public static readonly Country197 Niu = new("NIU");

    public static readonly Country197 Nld = new("NLD");

    public static readonly Country197 Nor = new("NOR");

    public static readonly Country197 Npl = new("NPL");

    public static readonly Country197 Nru = new("NRU");

    public static readonly Country197 Nzl = new("NZL");

    public static readonly Country197 Omn = new("OMN");

    public static readonly Country197 Pak = new("PAK");

    public static readonly Country197 Pan = new("PAN");

    public static readonly Country197 Pcn = new("PCN");

    public static readonly Country197 Per = new("PER");

    public static readonly Country197 Phl = new("PHL");

    public static readonly Country197 Plw = new("PLW");

    public static readonly Country197 Png = new("PNG");

    public static readonly Country197 Pol = new("POL");

    public static readonly Country197 Pri = new("PRI");

    public static readonly Country197 Prk = new("PRK");

    public static readonly Country197 Prt = new("PRT");

    public static readonly Country197 Pry = new("PRY");

    public static readonly Country197 Pse = new("PSE");

    public static readonly Country197 Pyf = new("PYF");

    public static readonly Country197 Qat = new("QAT");

    public static readonly Country197 Reu = new("REU");

    public static readonly Country197 Rou = new("ROU");

    public static readonly Country197 Rus = new("RUS");

    public static readonly Country197 Rwa = new("RWA");

    public static readonly Country197 Sau = new("SAU");

    public static readonly Country197 Sdn = new("SDN");

    public static readonly Country197 Sen = new("SEN");

    public static readonly Country197 Sgp = new("SGP");

    public static readonly Country197 Sgs = new("SGS");

    public static readonly Country197 Shn = new("SHN");

    public static readonly Country197 Sjm = new("SJM");

    public static readonly Country197 Slb = new("SLB");

    public static readonly Country197 Sle = new("SLE");

    public static readonly Country197 Slv = new("SLV");

    public static readonly Country197 Smr = new("SMR");

    public static readonly Country197 Som = new("SOM");

    public static readonly Country197 Spm = new("SPM");

    public static readonly Country197 Srb = new("SRB");

    public static readonly Country197 Ssd = new("SSD");

    public static readonly Country197 Stp = new("STP");

    public static readonly Country197 Sur = new("SUR");

    public static readonly Country197 Svk = new("SVK");

    public static readonly Country197 Svn = new("SVN");

    public static readonly Country197 Swe = new("SWE");

    public static readonly Country197 Swz = new("SWZ");

    public static readonly Country197 Sxm = new("SXM");

    public static readonly Country197 Syc = new("SYC");

    public static readonly Country197 Syr = new("SYR");

    public static readonly Country197 Tca = new("TCA");

    public static readonly Country197 Tcd = new("TCD");

    public static readonly Country197 Tgo = new("TGO");

    public static readonly Country197 Tha = new("THA");

    public static readonly Country197 Tjk = new("TJK");

    public static readonly Country197 Tkl = new("TKL");

    public static readonly Country197 Tkm = new("TKM");

    public static readonly Country197 Tls = new("TLS");

    public static readonly Country197 Ton = new("TON");

    public static readonly Country197 Tto = new("TTO");

    public static readonly Country197 Tun = new("TUN");

    public static readonly Country197 Tur = new("TUR");

    public static readonly Country197 Tuv = new("TUV");

    public static readonly Country197 Twn = new("TWN");

    public static readonly Country197 Tza = new("TZA");

    public static readonly Country197 Uga = new("UGA");

    public static readonly Country197 Ukr = new("UKR");

    public static readonly Country197 Umi = new("UMI");

    public static readonly Country197 Ury = new("URY");

    public static readonly Country197 Usa = new("USA");

    public static readonly Country197 Uzb = new("UZB");

    public static readonly Country197 Vat = new("VAT");

    public static readonly Country197 Vct = new("VCT");

    public static readonly Country197 Ven = new("VEN");

    public static readonly Country197 Vgb = new("VGB");

    public static readonly Country197 Vir = new("VIR");

    public static readonly Country197 Vnm = new("VNM");

    public static readonly Country197 Vut = new("VUT");

    public static readonly Country197 Wlf = new("WLF");

    public static readonly Country197 Wsm = new("WSM");

    public static readonly Country197 Xxk = new("XXK");

    public static readonly Country197 Yem = new("YEM");

    public static readonly Country197 Zaf = new("ZAF");

    public static readonly Country197 Zmb = new("ZMB");

    public static readonly Country197 Zwe = new("ZWE");

    public TResult Match<TResult>(Func<TResult> onAbw,
        Func<TResult> onAfg,
        Func<TResult> onAgo,
        Func<TResult> onAia,
        Func<TResult> onAla,
        Func<TResult> onAlb,
        Func<TResult> onAnd,
        Func<TResult> onAre,
        Func<TResult> onArg,
        Func<TResult> onArm,
        Func<TResult> onAsm,
        Func<TResult> onAta,
        Func<TResult> onAtf,
        Func<TResult> onAtg,
        Func<TResult> onAus,
        Func<TResult> onAut,
        Func<TResult> onAze,
        Func<TResult> onBdi,
        Func<TResult> onBel,
        Func<TResult> onBen,
        Func<TResult> onBes,
        Func<TResult> onBfa,
        Func<TResult> onBgd,
        Func<TResult> onBgr,
        Func<TResult> onBhr,
        Func<TResult> onBhs,
        Func<TResult> onBih,
        Func<TResult> onBlm,
        Func<TResult> onBlr,
        Func<TResult> onBlz,
        Func<TResult> onBmu,
        Func<TResult> onBol,
        Func<TResult> onBra,
        Func<TResult> onBrb,
        Func<TResult> onBrn,
        Func<TResult> onBtn,
        Func<TResult> onBvt,
        Func<TResult> onBwa,
        Func<TResult> onCaf,
        Func<TResult> onCan,
        Func<TResult> onCck,
        Func<TResult> onChe,
        Func<TResult> onChl,
        Func<TResult> onChn,
        Func<TResult> onCiv,
        Func<TResult> onCmr,
        Func<TResult> onCod,
        Func<TResult> onCog,
        Func<TResult> onCok,
        Func<TResult> onCol,
        Func<TResult> onCom,
        Func<TResult> onCpv,
        Func<TResult> onCri,
        Func<TResult> onCub,
        Func<TResult> onCuw,
        Func<TResult> onCxr,
        Func<TResult> onCym,
        Func<TResult> onCyp,
        Func<TResult> onCze,
        Func<TResult> onDeu,
        Func<TResult> onDji,
        Func<TResult> onDma,
        Func<TResult> onDnk,
        Func<TResult> onDom,
        Func<TResult> onDza,
        Func<TResult> onEcu,
        Func<TResult> onEgy,
        Func<TResult> onEri,
        Func<TResult> onEsh,
        Func<TResult> onEsp,
        Func<TResult> onEst,
        Func<TResult> onEth,
        Func<TResult> onFin,
        Func<TResult> onFji,
        Func<TResult> onFlk,
        Func<TResult> onFra,
        Func<TResult> onFro,
        Func<TResult> onFsm,
        Func<TResult> onGab,
        Func<TResult> onGbr,
        Func<TResult> onGeo,
        Func<TResult> onGgy,
        Func<TResult> onGha,
        Func<TResult> onGib,
        Func<TResult> onGin,
        Func<TResult> onGlp,
        Func<TResult> onGmb,
        Func<TResult> onGnb,
        Func<TResult> onGnq,
        Func<TResult> onGrc,
        Func<TResult> onGrd,
        Func<TResult> onGrl,
        Func<TResult> onGtm,
        Func<TResult> onGuf,
        Func<TResult> onGum,
        Func<TResult> onGuy,
        Func<TResult> onHkg,
        Func<TResult> onHmd,
        Func<TResult> onHnd,
        Func<TResult> onHrv,
        Func<TResult> onHti,
        Func<TResult> onHun,
        Func<TResult> onIdn,
        Func<TResult> onImn,
        Func<TResult> onInd,
        Func<TResult> onIot,
        Func<TResult> onIrl,
        Func<TResult> onIrn,
        Func<TResult> onIrq,
        Func<TResult> onIsl,
        Func<TResult> onIsr,
        Func<TResult> onIta,
        Func<TResult> onJam,
        Func<TResult> onJey,
        Func<TResult> onJor,
        Func<TResult> onJpn,
        Func<TResult> onKaz,
        Func<TResult> onKen,
        Func<TResult> onKgz,
        Func<TResult> onKhm,
        Func<TResult> onKir,
        Func<TResult> onKna,
        Func<TResult> onKor,
        Func<TResult> onKwt,
        Func<TResult> onLao,
        Func<TResult> onLbn,
        Func<TResult> onLbr,
        Func<TResult> onLby,
        Func<TResult> onLca,
        Func<TResult> onLie,
        Func<TResult> onLka,
        Func<TResult> onLso,
        Func<TResult> onLtu,
        Func<TResult> onLux,
        Func<TResult> onLva,
        Func<TResult> onMac,
        Func<TResult> onMaf,
        Func<TResult> onMar,
        Func<TResult> onMco,
        Func<TResult> onMda,
        Func<TResult> onMdg,
        Func<TResult> onMdv,
        Func<TResult> onMex,
        Func<TResult> onMhl,
        Func<TResult> onMkd,
        Func<TResult> onMli,
        Func<TResult> onMlt,
        Func<TResult> onMmr,
        Func<TResult> onMne,
        Func<TResult> onMng,
        Func<TResult> onMnp,
        Func<TResult> onMoz,
        Func<TResult> onMrt,
        Func<TResult> onMsr,
        Func<TResult> onMtq,
        Func<TResult> onMus,
        Func<TResult> onMwi,
        Func<TResult> onMys,
        Func<TResult> onMyt,
        Func<TResult> onNam,
        Func<TResult> onNcl,
        Func<TResult> onNer,
        Func<TResult> onNfk,
        Func<TResult> onNga,
        Func<TResult> onNic,
        Func<TResult> onNiu,
        Func<TResult> onNld,
        Func<TResult> onNor,
        Func<TResult> onNpl,
        Func<TResult> onNru,
        Func<TResult> onNzl,
        Func<TResult> onOmn,
        Func<TResult> onPak,
        Func<TResult> onPan,
        Func<TResult> onPcn,
        Func<TResult> onPer,
        Func<TResult> onPhl,
        Func<TResult> onPlw,
        Func<TResult> onPng,
        Func<TResult> onPol,
        Func<TResult> onPri,
        Func<TResult> onPrk,
        Func<TResult> onPrt,
        Func<TResult> onPry,
        Func<TResult> onPse,
        Func<TResult> onPyf,
        Func<TResult> onQat,
        Func<TResult> onReu,
        Func<TResult> onRou,
        Func<TResult> onRus,
        Func<TResult> onRwa,
        Func<TResult> onSau,
        Func<TResult> onSdn,
        Func<TResult> onSen,
        Func<TResult> onSgp,
        Func<TResult> onSgs,
        Func<TResult> onShn,
        Func<TResult> onSjm,
        Func<TResult> onSlb,
        Func<TResult> onSle,
        Func<TResult> onSlv,
        Func<TResult> onSmr,
        Func<TResult> onSom,
        Func<TResult> onSpm,
        Func<TResult> onSrb,
        Func<TResult> onSsd,
        Func<TResult> onStp,
        Func<TResult> onSur,
        Func<TResult> onSvk,
        Func<TResult> onSvn,
        Func<TResult> onSwe,
        Func<TResult> onSwz,
        Func<TResult> onSxm,
        Func<TResult> onSyc,
        Func<TResult> onSyr,
        Func<TResult> onTca,
        Func<TResult> onTcd,
        Func<TResult> onTgo,
        Func<TResult> onTha,
        Func<TResult> onTjk,
        Func<TResult> onTkl,
        Func<TResult> onTkm,
        Func<TResult> onTls,
        Func<TResult> onTon,
        Func<TResult> onTto,
        Func<TResult> onTun,
        Func<TResult> onTur,
        Func<TResult> onTuv,
        Func<TResult> onTwn,
        Func<TResult> onTza,
        Func<TResult> onUga,
        Func<TResult> onUkr,
        Func<TResult> onUmi,
        Func<TResult> onUry,
        Func<TResult> onUsa,
        Func<TResult> onUzb,
        Func<TResult> onVat,
        Func<TResult> onVct,
        Func<TResult> onVen,
        Func<TResult> onVgb,
        Func<TResult> onVir,
        Func<TResult> onVnm,
        Func<TResult> onVut,
        Func<TResult> onWlf,
        Func<TResult> onWsm,
        Func<TResult> onXxk,
        Func<TResult> onYem,
        Func<TResult> onZaf,
        Func<TResult> onZmb,
        Func<TResult> onZwe,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Abw => onAbw(),
            _ when this == Afg => onAfg(),
            _ when this == Ago => onAgo(),
            _ when this == Aia => onAia(),
            _ when this == Ala => onAla(),
            _ when this == Alb => onAlb(),
            _ when this == And => onAnd(),
            _ when this == Are => onAre(),
            _ when this == Arg => onArg(),
            _ when this == Arm => onArm(),
            _ when this == Asm => onAsm(),
            _ when this == Ata => onAta(),
            _ when this == Atf => onAtf(),
            _ when this == Atg => onAtg(),
            _ when this == Aus => onAus(),
            _ when this == Aut => onAut(),
            _ when this == Aze => onAze(),
            _ when this == Bdi => onBdi(),
            _ when this == Bel => onBel(),
            _ when this == Ben => onBen(),
            _ when this == Bes => onBes(),
            _ when this == Bfa => onBfa(),
            _ when this == Bgd => onBgd(),
            _ when this == Bgr => onBgr(),
            _ when this == Bhr => onBhr(),
            _ when this == Bhs => onBhs(),
            _ when this == Bih => onBih(),
            _ when this == Blm => onBlm(),
            _ when this == Blr => onBlr(),
            _ when this == Blz => onBlz(),
            _ when this == Bmu => onBmu(),
            _ when this == Bol => onBol(),
            _ when this == Bra => onBra(),
            _ when this == Brb => onBrb(),
            _ when this == Brn => onBrn(),
            _ when this == Btn => onBtn(),
            _ when this == Bvt => onBvt(),
            _ when this == Bwa => onBwa(),
            _ when this == Caf => onCaf(),
            _ when this == Can => onCan(),
            _ when this == Cck => onCck(),
            _ when this == Che => onChe(),
            _ when this == Chl => onChl(),
            _ when this == Chn => onChn(),
            _ when this == Civ => onCiv(),
            _ when this == Cmr => onCmr(),
            _ when this == Cod => onCod(),
            _ when this == Cog => onCog(),
            _ when this == Cok => onCok(),
            _ when this == Col => onCol(),
            _ when this == Com => onCom(),
            _ when this == Cpv => onCpv(),
            _ when this == Cri => onCri(),
            _ when this == Cub => onCub(),
            _ when this == Cuw => onCuw(),
            _ when this == Cxr => onCxr(),
            _ when this == Cym => onCym(),
            _ when this == Cyp => onCyp(),
            _ when this == Cze => onCze(),
            _ when this == Deu => onDeu(),
            _ when this == Dji => onDji(),
            _ when this == Dma => onDma(),
            _ when this == Dnk => onDnk(),
            _ when this == Dom => onDom(),
            _ when this == Dza => onDza(),
            _ when this == Ecu => onEcu(),
            _ when this == Egy => onEgy(),
            _ when this == Eri => onEri(),
            _ when this == Esh => onEsh(),
            _ when this == Esp => onEsp(),
            _ when this == Est => onEst(),
            _ when this == Eth => onEth(),
            _ when this == Fin => onFin(),
            _ when this == Fji => onFji(),
            _ when this == Flk => onFlk(),
            _ when this == Fra => onFra(),
            _ when this == Fro => onFro(),
            _ when this == Fsm => onFsm(),
            _ when this == Gab => onGab(),
            _ when this == Gbr => onGbr(),
            _ when this == Geo => onGeo(),
            _ when this == Ggy => onGgy(),
            _ when this == Gha => onGha(),
            _ when this == Gib => onGib(),
            _ when this == Gin => onGin(),
            _ when this == Glp => onGlp(),
            _ when this == Gmb => onGmb(),
            _ when this == Gnb => onGnb(),
            _ when this == Gnq => onGnq(),
            _ when this == Grc => onGrc(),
            _ when this == Grd => onGrd(),
            _ when this == Grl => onGrl(),
            _ when this == Gtm => onGtm(),
            _ when this == Guf => onGuf(),
            _ when this == Gum => onGum(),
            _ when this == Guy => onGuy(),
            _ when this == Hkg => onHkg(),
            _ when this == Hmd => onHmd(),
            _ when this == Hnd => onHnd(),
            _ when this == Hrv => onHrv(),
            _ when this == Hti => onHti(),
            _ when this == Hun => onHun(),
            _ when this == Idn => onIdn(),
            _ when this == Imn => onImn(),
            _ when this == Ind => onInd(),
            _ when this == Iot => onIot(),
            _ when this == Irl => onIrl(),
            _ when this == Irn => onIrn(),
            _ when this == Irq => onIrq(),
            _ when this == Isl => onIsl(),
            _ when this == Isr => onIsr(),
            _ when this == Ita => onIta(),
            _ when this == Jam => onJam(),
            _ when this == Jey => onJey(),
            _ when this == Jor => onJor(),
            _ when this == Jpn => onJpn(),
            _ when this == Kaz => onKaz(),
            _ when this == Ken => onKen(),
            _ when this == Kgz => onKgz(),
            _ when this == Khm => onKhm(),
            _ when this == Kir => onKir(),
            _ when this == Kna => onKna(),
            _ when this == Kor => onKor(),
            _ when this == Kwt => onKwt(),
            _ when this == Lao => onLao(),
            _ when this == Lbn => onLbn(),
            _ when this == Lbr => onLbr(),
            _ when this == Lby => onLby(),
            _ when this == Lca => onLca(),
            _ when this == Lie => onLie(),
            _ when this == Lka => onLka(),
            _ when this == Lso => onLso(),
            _ when this == Ltu => onLtu(),
            _ when this == Lux => onLux(),
            _ when this == Lva => onLva(),
            _ when this == Mac => onMac(),
            _ when this == Maf => onMaf(),
            _ when this == Mar => onMar(),
            _ when this == Mco => onMco(),
            _ when this == Mda => onMda(),
            _ when this == Mdg => onMdg(),
            _ when this == Mdv => onMdv(),
            _ when this == Mex => onMex(),
            _ when this == Mhl => onMhl(),
            _ when this == Mkd => onMkd(),
            _ when this == Mli => onMli(),
            _ when this == Mlt => onMlt(),
            _ when this == Mmr => onMmr(),
            _ when this == Mne => onMne(),
            _ when this == Mng => onMng(),
            _ when this == Mnp => onMnp(),
            _ when this == Moz => onMoz(),
            _ when this == Mrt => onMrt(),
            _ when this == Msr => onMsr(),
            _ when this == Mtq => onMtq(),
            _ when this == Mus => onMus(),
            _ when this == Mwi => onMwi(),
            _ when this == Mys => onMys(),
            _ when this == Myt => onMyt(),
            _ when this == Nam => onNam(),
            _ when this == Ncl => onNcl(),
            _ when this == Ner => onNer(),
            _ when this == Nfk => onNfk(),
            _ when this == Nga => onNga(),
            _ when this == Nic => onNic(),
            _ when this == Niu => onNiu(),
            _ when this == Nld => onNld(),
            _ when this == Nor => onNor(),
            _ when this == Npl => onNpl(),
            _ when this == Nru => onNru(),
            _ when this == Nzl => onNzl(),
            _ when this == Omn => onOmn(),
            _ when this == Pak => onPak(),
            _ when this == Pan => onPan(),
            _ when this == Pcn => onPcn(),
            _ when this == Per => onPer(),
            _ when this == Phl => onPhl(),
            _ when this == Plw => onPlw(),
            _ when this == Png => onPng(),
            _ when this == Pol => onPol(),
            _ when this == Pri => onPri(),
            _ when this == Prk => onPrk(),
            _ when this == Prt => onPrt(),
            _ when this == Pry => onPry(),
            _ when this == Pse => onPse(),
            _ when this == Pyf => onPyf(),
            _ when this == Qat => onQat(),
            _ when this == Reu => onReu(),
            _ when this == Rou => onRou(),
            _ when this == Rus => onRus(),
            _ when this == Rwa => onRwa(),
            _ when this == Sau => onSau(),
            _ when this == Sdn => onSdn(),
            _ when this == Sen => onSen(),
            _ when this == Sgp => onSgp(),
            _ when this == Sgs => onSgs(),
            _ when this == Shn => onShn(),
            _ when this == Sjm => onSjm(),
            _ when this == Slb => onSlb(),
            _ when this == Sle => onSle(),
            _ when this == Slv => onSlv(),
            _ when this == Smr => onSmr(),
            _ when this == Som => onSom(),
            _ when this == Spm => onSpm(),
            _ when this == Srb => onSrb(),
            _ when this == Ssd => onSsd(),
            _ when this == Stp => onStp(),
            _ when this == Sur => onSur(),
            _ when this == Svk => onSvk(),
            _ when this == Svn => onSvn(),
            _ when this == Swe => onSwe(),
            _ when this == Swz => onSwz(),
            _ when this == Sxm => onSxm(),
            _ when this == Syc => onSyc(),
            _ when this == Syr => onSyr(),
            _ when this == Tca => onTca(),
            _ when this == Tcd => onTcd(),
            _ when this == Tgo => onTgo(),
            _ when this == Tha => onTha(),
            _ when this == Tjk => onTjk(),
            _ when this == Tkl => onTkl(),
            _ when this == Tkm => onTkm(),
            _ when this == Tls => onTls(),
            _ when this == Ton => onTon(),
            _ when this == Tto => onTto(),
            _ when this == Tun => onTun(),
            _ when this == Tur => onTur(),
            _ when this == Tuv => onTuv(),
            _ when this == Twn => onTwn(),
            _ when this == Tza => onTza(),
            _ when this == Uga => onUga(),
            _ when this == Ukr => onUkr(),
            _ when this == Umi => onUmi(),
            _ when this == Ury => onUry(),
            _ when this == Usa => onUsa(),
            _ when this == Uzb => onUzb(),
            _ when this == Vat => onVat(),
            _ when this == Vct => onVct(),
            _ when this == Ven => onVen(),
            _ when this == Vgb => onVgb(),
            _ when this == Vir => onVir(),
            _ when this == Vnm => onVnm(),
            _ when this == Vut => onVut(),
            _ when this == Wlf => onWlf(),
            _ when this == Wsm => onWsm(),
            _ when this == Xxk => onXxk(),
            _ when this == Yem => onYem(),
            _ when this == Zaf => onZaf(),
            _ when this == Zmb => onZmb(),
            _ when this == Zwe => onZwe(),
            _ => otherwise(Value)
        };

    public void Match(Action onAbw,
        Action onAfg,
        Action onAgo,
        Action onAia,
        Action onAla,
        Action onAlb,
        Action onAnd,
        Action onAre,
        Action onArg,
        Action onArm,
        Action onAsm,
        Action onAta,
        Action onAtf,
        Action onAtg,
        Action onAus,
        Action onAut,
        Action onAze,
        Action onBdi,
        Action onBel,
        Action onBen,
        Action onBes,
        Action onBfa,
        Action onBgd,
        Action onBgr,
        Action onBhr,
        Action onBhs,
        Action onBih,
        Action onBlm,
        Action onBlr,
        Action onBlz,
        Action onBmu,
        Action onBol,
        Action onBra,
        Action onBrb,
        Action onBrn,
        Action onBtn,
        Action onBvt,
        Action onBwa,
        Action onCaf,
        Action onCan,
        Action onCck,
        Action onChe,
        Action onChl,
        Action onChn,
        Action onCiv,
        Action onCmr,
        Action onCod,
        Action onCog,
        Action onCok,
        Action onCol,
        Action onCom,
        Action onCpv,
        Action onCri,
        Action onCub,
        Action onCuw,
        Action onCxr,
        Action onCym,
        Action onCyp,
        Action onCze,
        Action onDeu,
        Action onDji,
        Action onDma,
        Action onDnk,
        Action onDom,
        Action onDza,
        Action onEcu,
        Action onEgy,
        Action onEri,
        Action onEsh,
        Action onEsp,
        Action onEst,
        Action onEth,
        Action onFin,
        Action onFji,
        Action onFlk,
        Action onFra,
        Action onFro,
        Action onFsm,
        Action onGab,
        Action onGbr,
        Action onGeo,
        Action onGgy,
        Action onGha,
        Action onGib,
        Action onGin,
        Action onGlp,
        Action onGmb,
        Action onGnb,
        Action onGnq,
        Action onGrc,
        Action onGrd,
        Action onGrl,
        Action onGtm,
        Action onGuf,
        Action onGum,
        Action onGuy,
        Action onHkg,
        Action onHmd,
        Action onHnd,
        Action onHrv,
        Action onHti,
        Action onHun,
        Action onIdn,
        Action onImn,
        Action onInd,
        Action onIot,
        Action onIrl,
        Action onIrn,
        Action onIrq,
        Action onIsl,
        Action onIsr,
        Action onIta,
        Action onJam,
        Action onJey,
        Action onJor,
        Action onJpn,
        Action onKaz,
        Action onKen,
        Action onKgz,
        Action onKhm,
        Action onKir,
        Action onKna,
        Action onKor,
        Action onKwt,
        Action onLao,
        Action onLbn,
        Action onLbr,
        Action onLby,
        Action onLca,
        Action onLie,
        Action onLka,
        Action onLso,
        Action onLtu,
        Action onLux,
        Action onLva,
        Action onMac,
        Action onMaf,
        Action onMar,
        Action onMco,
        Action onMda,
        Action onMdg,
        Action onMdv,
        Action onMex,
        Action onMhl,
        Action onMkd,
        Action onMli,
        Action onMlt,
        Action onMmr,
        Action onMne,
        Action onMng,
        Action onMnp,
        Action onMoz,
        Action onMrt,
        Action onMsr,
        Action onMtq,
        Action onMus,
        Action onMwi,
        Action onMys,
        Action onMyt,
        Action onNam,
        Action onNcl,
        Action onNer,
        Action onNfk,
        Action onNga,
        Action onNic,
        Action onNiu,
        Action onNld,
        Action onNor,
        Action onNpl,
        Action onNru,
        Action onNzl,
        Action onOmn,
        Action onPak,
        Action onPan,
        Action onPcn,
        Action onPer,
        Action onPhl,
        Action onPlw,
        Action onPng,
        Action onPol,
        Action onPri,
        Action onPrk,
        Action onPrt,
        Action onPry,
        Action onPse,
        Action onPyf,
        Action onQat,
        Action onReu,
        Action onRou,
        Action onRus,
        Action onRwa,
        Action onSau,
        Action onSdn,
        Action onSen,
        Action onSgp,
        Action onSgs,
        Action onShn,
        Action onSjm,
        Action onSlb,
        Action onSle,
        Action onSlv,
        Action onSmr,
        Action onSom,
        Action onSpm,
        Action onSrb,
        Action onSsd,
        Action onStp,
        Action onSur,
        Action onSvk,
        Action onSvn,
        Action onSwe,
        Action onSwz,
        Action onSxm,
        Action onSyc,
        Action onSyr,
        Action onTca,
        Action onTcd,
        Action onTgo,
        Action onTha,
        Action onTjk,
        Action onTkl,
        Action onTkm,
        Action onTls,
        Action onTon,
        Action onTto,
        Action onTun,
        Action onTur,
        Action onTuv,
        Action onTwn,
        Action onTza,
        Action onUga,
        Action onUkr,
        Action onUmi,
        Action onUry,
        Action onUsa,
        Action onUzb,
        Action onVat,
        Action onVct,
        Action onVen,
        Action onVgb,
        Action onVir,
        Action onVnm,
        Action onVut,
        Action onWlf,
        Action onWsm,
        Action onXxk,
        Action onYem,
        Action onZaf,
        Action onZmb,
        Action onZwe,
        Action<string> otherwise)
    {
        if (this == Abw) onAbw();
        else if (this == Afg) onAfg();
        else if (this == Ago) onAgo();
        else if (this == Aia) onAia();
        else if (this == Ala) onAla();
        else if (this == Alb) onAlb();
        else if (this == And) onAnd();
        else if (this == Are) onAre();
        else if (this == Arg) onArg();
        else if (this == Arm) onArm();
        else if (this == Asm) onAsm();
        else if (this == Ata) onAta();
        else if (this == Atf) onAtf();
        else if (this == Atg) onAtg();
        else if (this == Aus) onAus();
        else if (this == Aut) onAut();
        else if (this == Aze) onAze();
        else if (this == Bdi) onBdi();
        else if (this == Bel) onBel();
        else if (this == Ben) onBen();
        else if (this == Bes) onBes();
        else if (this == Bfa) onBfa();
        else if (this == Bgd) onBgd();
        else if (this == Bgr) onBgr();
        else if (this == Bhr) onBhr();
        else if (this == Bhs) onBhs();
        else if (this == Bih) onBih();
        else if (this == Blm) onBlm();
        else if (this == Blr) onBlr();
        else if (this == Blz) onBlz();
        else if (this == Bmu) onBmu();
        else if (this == Bol) onBol();
        else if (this == Bra) onBra();
        else if (this == Brb) onBrb();
        else if (this == Brn) onBrn();
        else if (this == Btn) onBtn();
        else if (this == Bvt) onBvt();
        else if (this == Bwa) onBwa();
        else if (this == Caf) onCaf();
        else if (this == Can) onCan();
        else if (this == Cck) onCck();
        else if (this == Che) onChe();
        else if (this == Chl) onChl();
        else if (this == Chn) onChn();
        else if (this == Civ) onCiv();
        else if (this == Cmr) onCmr();
        else if (this == Cod) onCod();
        else if (this == Cog) onCog();
        else if (this == Cok) onCok();
        else if (this == Col) onCol();
        else if (this == Com) onCom();
        else if (this == Cpv) onCpv();
        else if (this == Cri) onCri();
        else if (this == Cub) onCub();
        else if (this == Cuw) onCuw();
        else if (this == Cxr) onCxr();
        else if (this == Cym) onCym();
        else if (this == Cyp) onCyp();
        else if (this == Cze) onCze();
        else if (this == Deu) onDeu();
        else if (this == Dji) onDji();
        else if (this == Dma) onDma();
        else if (this == Dnk) onDnk();
        else if (this == Dom) onDom();
        else if (this == Dza) onDza();
        else if (this == Ecu) onEcu();
        else if (this == Egy) onEgy();
        else if (this == Eri) onEri();
        else if (this == Esh) onEsh();
        else if (this == Esp) onEsp();
        else if (this == Est) onEst();
        else if (this == Eth) onEth();
        else if (this == Fin) onFin();
        else if (this == Fji) onFji();
        else if (this == Flk) onFlk();
        else if (this == Fra) onFra();
        else if (this == Fro) onFro();
        else if (this == Fsm) onFsm();
        else if (this == Gab) onGab();
        else if (this == Gbr) onGbr();
        else if (this == Geo) onGeo();
        else if (this == Ggy) onGgy();
        else if (this == Gha) onGha();
        else if (this == Gib) onGib();
        else if (this == Gin) onGin();
        else if (this == Glp) onGlp();
        else if (this == Gmb) onGmb();
        else if (this == Gnb) onGnb();
        else if (this == Gnq) onGnq();
        else if (this == Grc) onGrc();
        else if (this == Grd) onGrd();
        else if (this == Grl) onGrl();
        else if (this == Gtm) onGtm();
        else if (this == Guf) onGuf();
        else if (this == Gum) onGum();
        else if (this == Guy) onGuy();
        else if (this == Hkg) onHkg();
        else if (this == Hmd) onHmd();
        else if (this == Hnd) onHnd();
        else if (this == Hrv) onHrv();
        else if (this == Hti) onHti();
        else if (this == Hun) onHun();
        else if (this == Idn) onIdn();
        else if (this == Imn) onImn();
        else if (this == Ind) onInd();
        else if (this == Iot) onIot();
        else if (this == Irl) onIrl();
        else if (this == Irn) onIrn();
        else if (this == Irq) onIrq();
        else if (this == Isl) onIsl();
        else if (this == Isr) onIsr();
        else if (this == Ita) onIta();
        else if (this == Jam) onJam();
        else if (this == Jey) onJey();
        else if (this == Jor) onJor();
        else if (this == Jpn) onJpn();
        else if (this == Kaz) onKaz();
        else if (this == Ken) onKen();
        else if (this == Kgz) onKgz();
        else if (this == Khm) onKhm();
        else if (this == Kir) onKir();
        else if (this == Kna) onKna();
        else if (this == Kor) onKor();
        else if (this == Kwt) onKwt();
        else if (this == Lao) onLao();
        else if (this == Lbn) onLbn();
        else if (this == Lbr) onLbr();
        else if (this == Lby) onLby();
        else if (this == Lca) onLca();
        else if (this == Lie) onLie();
        else if (this == Lka) onLka();
        else if (this == Lso) onLso();
        else if (this == Ltu) onLtu();
        else if (this == Lux) onLux();
        else if (this == Lva) onLva();
        else if (this == Mac) onMac();
        else if (this == Maf) onMaf();
        else if (this == Mar) onMar();
        else if (this == Mco) onMco();
        else if (this == Mda) onMda();
        else if (this == Mdg) onMdg();
        else if (this == Mdv) onMdv();
        else if (this == Mex) onMex();
        else if (this == Mhl) onMhl();
        else if (this == Mkd) onMkd();
        else if (this == Mli) onMli();
        else if (this == Mlt) onMlt();
        else if (this == Mmr) onMmr();
        else if (this == Mne) onMne();
        else if (this == Mng) onMng();
        else if (this == Mnp) onMnp();
        else if (this == Moz) onMoz();
        else if (this == Mrt) onMrt();
        else if (this == Msr) onMsr();
        else if (this == Mtq) onMtq();
        else if (this == Mus) onMus();
        else if (this == Mwi) onMwi();
        else if (this == Mys) onMys();
        else if (this == Myt) onMyt();
        else if (this == Nam) onNam();
        else if (this == Ncl) onNcl();
        else if (this == Ner) onNer();
        else if (this == Nfk) onNfk();
        else if (this == Nga) onNga();
        else if (this == Nic) onNic();
        else if (this == Niu) onNiu();
        else if (this == Nld) onNld();
        else if (this == Nor) onNor();
        else if (this == Npl) onNpl();
        else if (this == Nru) onNru();
        else if (this == Nzl) onNzl();
        else if (this == Omn) onOmn();
        else if (this == Pak) onPak();
        else if (this == Pan) onPan();
        else if (this == Pcn) onPcn();
        else if (this == Per) onPer();
        else if (this == Phl) onPhl();
        else if (this == Plw) onPlw();
        else if (this == Png) onPng();
        else if (this == Pol) onPol();
        else if (this == Pri) onPri();
        else if (this == Prk) onPrk();
        else if (this == Prt) onPrt();
        else if (this == Pry) onPry();
        else if (this == Pse) onPse();
        else if (this == Pyf) onPyf();
        else if (this == Qat) onQat();
        else if (this == Reu) onReu();
        else if (this == Rou) onRou();
        else if (this == Rus) onRus();
        else if (this == Rwa) onRwa();
        else if (this == Sau) onSau();
        else if (this == Sdn) onSdn();
        else if (this == Sen) onSen();
        else if (this == Sgp) onSgp();
        else if (this == Sgs) onSgs();
        else if (this == Shn) onShn();
        else if (this == Sjm) onSjm();
        else if (this == Slb) onSlb();
        else if (this == Sle) onSle();
        else if (this == Slv) onSlv();
        else if (this == Smr) onSmr();
        else if (this == Som) onSom();
        else if (this == Spm) onSpm();
        else if (this == Srb) onSrb();
        else if (this == Ssd) onSsd();
        else if (this == Stp) onStp();
        else if (this == Sur) onSur();
        else if (this == Svk) onSvk();
        else if (this == Svn) onSvn();
        else if (this == Swe) onSwe();
        else if (this == Swz) onSwz();
        else if (this == Sxm) onSxm();
        else if (this == Syc) onSyc();
        else if (this == Syr) onSyr();
        else if (this == Tca) onTca();
        else if (this == Tcd) onTcd();
        else if (this == Tgo) onTgo();
        else if (this == Tha) onTha();
        else if (this == Tjk) onTjk();
        else if (this == Tkl) onTkl();
        else if (this == Tkm) onTkm();
        else if (this == Tls) onTls();
        else if (this == Ton) onTon();
        else if (this == Tto) onTto();
        else if (this == Tun) onTun();
        else if (this == Tur) onTur();
        else if (this == Tuv) onTuv();
        else if (this == Twn) onTwn();
        else if (this == Tza) onTza();
        else if (this == Uga) onUga();
        else if (this == Ukr) onUkr();
        else if (this == Umi) onUmi();
        else if (this == Ury) onUry();
        else if (this == Usa) onUsa();
        else if (this == Uzb) onUzb();
        else if (this == Vat) onVat();
        else if (this == Vct) onVct();
        else if (this == Ven) onVen();
        else if (this == Vgb) onVgb();
        else if (this == Vir) onVir();
        else if (this == Vnm) onVnm();
        else if (this == Vut) onVut();
        else if (this == Wlf) onWlf();
        else if (this == Wsm) onWsm();
        else if (this == Xxk) onXxk();
        else if (this == Yem) onYem();
        else if (this == Zaf) onZaf();
        else if (this == Zmb) onZmb();
        else if (this == Zwe) onZwe();
        else otherwise(Value);
    }
}
