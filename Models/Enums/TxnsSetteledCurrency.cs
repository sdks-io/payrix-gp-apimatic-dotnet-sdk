using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TxnsSetteledCurrency>))]
public sealed record TxnsSetteledCurrency : OpenStringEnum<TxnsSetteledCurrency>
{
    private TxnsSetteledCurrency(string value) : base(value)
    {
    }

    public static readonly TxnsSetteledCurrency Aed = new("AED");

    public static readonly TxnsSetteledCurrency Afn = new("AFN");

    public static readonly TxnsSetteledCurrency All = new("ALL");

    public static readonly TxnsSetteledCurrency Amd = new("AMD");

    public static readonly TxnsSetteledCurrency Ang = new("ANG");

    public static readonly TxnsSetteledCurrency Aoa = new("AOA");

    public static readonly TxnsSetteledCurrency Ars = new("ARS");

    public static readonly TxnsSetteledCurrency Aud = new("AUD");

    public static readonly TxnsSetteledCurrency Awg = new("AWG");

    public static readonly TxnsSetteledCurrency Azn = new("AZN");

    public static readonly TxnsSetteledCurrency Bam = new("BAM");

    public static readonly TxnsSetteledCurrency Bbd = new("BBD");

    public static readonly TxnsSetteledCurrency Bdt = new("BDT");

    public static readonly TxnsSetteledCurrency Bgn = new("BGN");

    public static readonly TxnsSetteledCurrency Bhd = new("BHD");

    public static readonly TxnsSetteledCurrency Bif = new("BIF");

    public static readonly TxnsSetteledCurrency Bmd = new("BMD");

    public static readonly TxnsSetteledCurrency Bnd = new("BND");

    public static readonly TxnsSetteledCurrency Bob = new("BOB");

    public static readonly TxnsSetteledCurrency Bov = new("BOV");

    public static readonly TxnsSetteledCurrency Brl = new("BRL");

    public static readonly TxnsSetteledCurrency Bsd = new("BSD");

    public static readonly TxnsSetteledCurrency Btn = new("BTN");

    public static readonly TxnsSetteledCurrency Bwp = new("BWP");

    public static readonly TxnsSetteledCurrency Byn = new("BYN");

    public static readonly TxnsSetteledCurrency Bzd = new("BZD");

    public static readonly TxnsSetteledCurrency Cad = new("CAD");

    public static readonly TxnsSetteledCurrency Cdf = new("CDF");

    public static readonly TxnsSetteledCurrency Che = new("CHE");

    public static readonly TxnsSetteledCurrency Chf = new("CHF");

    public static readonly TxnsSetteledCurrency Chw = new("CHW");

    public static readonly TxnsSetteledCurrency Clf = new("CLF");

    public static readonly TxnsSetteledCurrency Clp = new("CLP");

    public static readonly TxnsSetteledCurrency Cny = new("CNY");

    public static readonly TxnsSetteledCurrency Cop = new("COP");

    public static readonly TxnsSetteledCurrency Cou = new("COU");

    public static readonly TxnsSetteledCurrency Crc = new("CRC");

    public static readonly TxnsSetteledCurrency Cuc = new("CUC");

    public static readonly TxnsSetteledCurrency Cup = new("CUP");

    public static readonly TxnsSetteledCurrency Cve = new("CVE");

    public static readonly TxnsSetteledCurrency Czk = new("CZK");

    public static readonly TxnsSetteledCurrency Djf = new("DJF");

    public static readonly TxnsSetteledCurrency Dkk = new("DKK");

    public static readonly TxnsSetteledCurrency Dop = new("DOP");

    public static readonly TxnsSetteledCurrency Dzd = new("DZD");

    public static readonly TxnsSetteledCurrency Egp = new("EGP");

    public static readonly TxnsSetteledCurrency Ern = new("ERN");

    public static readonly TxnsSetteledCurrency Etb = new("ETB");

    public static readonly TxnsSetteledCurrency Eur = new("EUR");

    public static readonly TxnsSetteledCurrency Fjd = new("FJD");

    public static readonly TxnsSetteledCurrency Fkp = new("FKP");

    public static readonly TxnsSetteledCurrency Gbp = new("GBP");

    public static readonly TxnsSetteledCurrency Gel = new("GEL");

    public static readonly TxnsSetteledCurrency Ghs = new("GHS");

    public static readonly TxnsSetteledCurrency Gip = new("GIP");

    public static readonly TxnsSetteledCurrency Gmd = new("GMD");

    public static readonly TxnsSetteledCurrency Gnf = new("GNF");

    public static readonly TxnsSetteledCurrency Gtq = new("GTQ");

    public static readonly TxnsSetteledCurrency Gyd = new("GYD");

    public static readonly TxnsSetteledCurrency Hkd = new("HKD");

    public static readonly TxnsSetteledCurrency Hnl = new("HNL");

    public static readonly TxnsSetteledCurrency Hrk = new("HRK");

    public static readonly TxnsSetteledCurrency Htg = new("HTG");

    public static readonly TxnsSetteledCurrency Huf = new("HUF");

    public static readonly TxnsSetteledCurrency Idr = new("IDR");

    public static readonly TxnsSetteledCurrency Ils = new("ILS");

    public static readonly TxnsSetteledCurrency Inr = new("INR");

    public static readonly TxnsSetteledCurrency Iqd = new("IQD");

    public static readonly TxnsSetteledCurrency Irr = new("IRR");

    public static readonly TxnsSetteledCurrency Isk = new("ISK");

    public static readonly TxnsSetteledCurrency Jmd = new("JMD");

    public static readonly TxnsSetteledCurrency Jod = new("JOD");

    public static readonly TxnsSetteledCurrency Jpy = new("JPY");

    public static readonly TxnsSetteledCurrency Kes = new("KES");

    public static readonly TxnsSetteledCurrency Kgs = new("KGS");

    public static readonly TxnsSetteledCurrency Khr = new("KHR");

    public static readonly TxnsSetteledCurrency Kmf = new("KMF");

    public static readonly TxnsSetteledCurrency Kpw = new("KPW");

    public static readonly TxnsSetteledCurrency Krw = new("KRW");

    public static readonly TxnsSetteledCurrency Kwd = new("KWD");

    public static readonly TxnsSetteledCurrency Kyd = new("KYD");

    public static readonly TxnsSetteledCurrency Kzt = new("KZT");

    public static readonly TxnsSetteledCurrency Lak = new("LAK");

    public static readonly TxnsSetteledCurrency Lbp = new("LBP");

    public static readonly TxnsSetteledCurrency Lkr = new("LKR");

    public static readonly TxnsSetteledCurrency Lrd = new("LRD");

    public static readonly TxnsSetteledCurrency Lsl = new("LSL");

    public static readonly TxnsSetteledCurrency Lyd = new("LYD");

    public static readonly TxnsSetteledCurrency Mad = new("MAD");

    public static readonly TxnsSetteledCurrency Mdl = new("MDL");

    public static readonly TxnsSetteledCurrency Mga = new("MGA");

    public static readonly TxnsSetteledCurrency Mkd = new("MKD");

    public static readonly TxnsSetteledCurrency Mmk = new("MMK");

    public static readonly TxnsSetteledCurrency Mnt = new("MNT");

    public static readonly TxnsSetteledCurrency Mop = new("MOP");

    public static readonly TxnsSetteledCurrency Mru = new("MRU");

    public static readonly TxnsSetteledCurrency Mur = new("MUR");

    public static readonly TxnsSetteledCurrency Mvr = new("MVR");

    public static readonly TxnsSetteledCurrency Mwk = new("MWK");

    public static readonly TxnsSetteledCurrency Mxn = new("MXN");

    public static readonly TxnsSetteledCurrency Mxv = new("MXV");

    public static readonly TxnsSetteledCurrency Myr = new("MYR");

    public static readonly TxnsSetteledCurrency Mzn = new("MZN");

    public static readonly TxnsSetteledCurrency Nad = new("NAD");

    public static readonly TxnsSetteledCurrency Ngn = new("NGN");

    public static readonly TxnsSetteledCurrency Nio = new("NIO");

    public static readonly TxnsSetteledCurrency Nok = new("NOK");

    public static readonly TxnsSetteledCurrency Npr = new("NPR");

    public static readonly TxnsSetteledCurrency Nzd = new("NZD");

    public static readonly TxnsSetteledCurrency Omr = new("OMR");

    public static readonly TxnsSetteledCurrency Pab = new("PAB");

    public static readonly TxnsSetteledCurrency Pen = new("PEN");

    public static readonly TxnsSetteledCurrency Pgk = new("PGK");

    public static readonly TxnsSetteledCurrency Php = new("PHP");

    public static readonly TxnsSetteledCurrency Pkr = new("PKR");

    public static readonly TxnsSetteledCurrency Pln = new("PLN");

    public static readonly TxnsSetteledCurrency Pyg = new("PYG");

    public static readonly TxnsSetteledCurrency Qar = new("QAR");

    public static readonly TxnsSetteledCurrency Ron = new("RON");

    public static readonly TxnsSetteledCurrency Rsd = new("RSD");

    public static readonly TxnsSetteledCurrency Rub = new("RUB");

    public static readonly TxnsSetteledCurrency Rwf = new("RWF");

    public static readonly TxnsSetteledCurrency Sar = new("SAR");

    public static readonly TxnsSetteledCurrency Sbd = new("SBD");

    public static readonly TxnsSetteledCurrency Scr = new("SCR");

    public static readonly TxnsSetteledCurrency Sdg = new("SDG");

    public static readonly TxnsSetteledCurrency Sek = new("SEK");

    public static readonly TxnsSetteledCurrency Sgd = new("SGD");

    public static readonly TxnsSetteledCurrency Shp = new("SHP");

    public static readonly TxnsSetteledCurrency Sll = new("SLL");

    public static readonly TxnsSetteledCurrency Sos = new("SOS");

    public static readonly TxnsSetteledCurrency Srd = new("SRD");

    public static readonly TxnsSetteledCurrency Ssp = new("SSP");

    public static readonly TxnsSetteledCurrency Stn = new("STN");

    public static readonly TxnsSetteledCurrency Svc = new("SVC");

    public static readonly TxnsSetteledCurrency Syp = new("SYP");

    public static readonly TxnsSetteledCurrency Szl = new("SZL");

    public static readonly TxnsSetteledCurrency Thb = new("THB");

    public static readonly TxnsSetteledCurrency Tjs = new("TJS");

    public static readonly TxnsSetteledCurrency Tmt = new("TMT");

    public static readonly TxnsSetteledCurrency Tnd = new("TND");

    public static readonly TxnsSetteledCurrency Top = new("TOP");

    public static readonly TxnsSetteledCurrency Try = new("TRY");

    public static readonly TxnsSetteledCurrency Ttd = new("TTD");

    public static readonly TxnsSetteledCurrency Twd = new("TWD");

    public static readonly TxnsSetteledCurrency Tzs = new("TZS");

    public static readonly TxnsSetteledCurrency Uah = new("UAH");

    public static readonly TxnsSetteledCurrency Ugx = new("UGX");

    public static readonly TxnsSetteledCurrency Usd = new("USD");

    public static readonly TxnsSetteledCurrency Usn = new("USN");

    public static readonly TxnsSetteledCurrency Uyi = new("UYI");

    public static readonly TxnsSetteledCurrency Uyu = new("UYU");

    public static readonly TxnsSetteledCurrency Uzs = new("UZS");

    public static readonly TxnsSetteledCurrency Vef = new("VEF");

    public static readonly TxnsSetteledCurrency Vnd = new("VND");

    public static readonly TxnsSetteledCurrency Vuv = new("VUV");

    public static readonly TxnsSetteledCurrency Wst = new("WST");

    public static readonly TxnsSetteledCurrency Xaf = new("XAF");

    public static readonly TxnsSetteledCurrency Xag = new("XAG");

    public static readonly TxnsSetteledCurrency Xau = new("XAU");

    public static readonly TxnsSetteledCurrency Xba = new("XBA");

    public static readonly TxnsSetteledCurrency Xbb = new("XBB");

    public static readonly TxnsSetteledCurrency Xbc = new("XBC");

    public static readonly TxnsSetteledCurrency Xbd = new("XBD");

    public static readonly TxnsSetteledCurrency Xcd = new("XCD");

    public static readonly TxnsSetteledCurrency Xdr = new("XDR");

    public static readonly TxnsSetteledCurrency Xof = new("XOF");

    public static readonly TxnsSetteledCurrency Xpd = new("XPD");

    public static readonly TxnsSetteledCurrency Xpf = new("XPF");

    public static readonly TxnsSetteledCurrency Xpt = new("XPT");

    public static readonly TxnsSetteledCurrency Xsu = new("XSU");

    public static readonly TxnsSetteledCurrency Xua = new("XUA");

    public static readonly TxnsSetteledCurrency Yer = new("YER");

    public static readonly TxnsSetteledCurrency Zar = new("ZAR");

    public static readonly TxnsSetteledCurrency Zmw = new("ZMW");

    public static readonly TxnsSetteledCurrency Zwl = new("ZWL");

    public TResult Match<TResult>(Func<TResult> onAed,
        Func<TResult> onAfn,
        Func<TResult> onAll,
        Func<TResult> onAmd,
        Func<TResult> onAng,
        Func<TResult> onAoa,
        Func<TResult> onArs,
        Func<TResult> onAud,
        Func<TResult> onAwg,
        Func<TResult> onAzn,
        Func<TResult> onBam,
        Func<TResult> onBbd,
        Func<TResult> onBdt,
        Func<TResult> onBgn,
        Func<TResult> onBhd,
        Func<TResult> onBif,
        Func<TResult> onBmd,
        Func<TResult> onBnd,
        Func<TResult> onBob,
        Func<TResult> onBov,
        Func<TResult> onBrl,
        Func<TResult> onBsd,
        Func<TResult> onBtn,
        Func<TResult> onBwp,
        Func<TResult> onByn,
        Func<TResult> onBzd,
        Func<TResult> onCad,
        Func<TResult> onCdf,
        Func<TResult> onChe,
        Func<TResult> onChf,
        Func<TResult> onChw,
        Func<TResult> onClf,
        Func<TResult> onClp,
        Func<TResult> onCny,
        Func<TResult> onCop,
        Func<TResult> onCou,
        Func<TResult> onCrc,
        Func<TResult> onCuc,
        Func<TResult> onCup,
        Func<TResult> onCve,
        Func<TResult> onCzk,
        Func<TResult> onDjf,
        Func<TResult> onDkk,
        Func<TResult> onDop,
        Func<TResult> onDzd,
        Func<TResult> onEgp,
        Func<TResult> onErn,
        Func<TResult> onEtb,
        Func<TResult> onEur,
        Func<TResult> onFjd,
        Func<TResult> onFkp,
        Func<TResult> onGbp,
        Func<TResult> onGel,
        Func<TResult> onGhs,
        Func<TResult> onGip,
        Func<TResult> onGmd,
        Func<TResult> onGnf,
        Func<TResult> onGtq,
        Func<TResult> onGyd,
        Func<TResult> onHkd,
        Func<TResult> onHnl,
        Func<TResult> onHrk,
        Func<TResult> onHtg,
        Func<TResult> onHuf,
        Func<TResult> onIdr,
        Func<TResult> onIls,
        Func<TResult> onInr,
        Func<TResult> onIqd,
        Func<TResult> onIrr,
        Func<TResult> onIsk,
        Func<TResult> onJmd,
        Func<TResult> onJod,
        Func<TResult> onJpy,
        Func<TResult> onKes,
        Func<TResult> onKgs,
        Func<TResult> onKhr,
        Func<TResult> onKmf,
        Func<TResult> onKpw,
        Func<TResult> onKrw,
        Func<TResult> onKwd,
        Func<TResult> onKyd,
        Func<TResult> onKzt,
        Func<TResult> onLak,
        Func<TResult> onLbp,
        Func<TResult> onLkr,
        Func<TResult> onLrd,
        Func<TResult> onLsl,
        Func<TResult> onLyd,
        Func<TResult> onMad,
        Func<TResult> onMdl,
        Func<TResult> onMga,
        Func<TResult> onMkd,
        Func<TResult> onMmk,
        Func<TResult> onMnt,
        Func<TResult> onMop,
        Func<TResult> onMru,
        Func<TResult> onMur,
        Func<TResult> onMvr,
        Func<TResult> onMwk,
        Func<TResult> onMxn,
        Func<TResult> onMxv,
        Func<TResult> onMyr,
        Func<TResult> onMzn,
        Func<TResult> onNad,
        Func<TResult> onNgn,
        Func<TResult> onNio,
        Func<TResult> onNok,
        Func<TResult> onNpr,
        Func<TResult> onNzd,
        Func<TResult> onOmr,
        Func<TResult> onPab,
        Func<TResult> onPen,
        Func<TResult> onPgk,
        Func<TResult> onPhp,
        Func<TResult> onPkr,
        Func<TResult> onPln,
        Func<TResult> onPyg,
        Func<TResult> onQar,
        Func<TResult> onRon,
        Func<TResult> onRsd,
        Func<TResult> onRub,
        Func<TResult> onRwf,
        Func<TResult> onSar,
        Func<TResult> onSbd,
        Func<TResult> onScr,
        Func<TResult> onSdg,
        Func<TResult> onSek,
        Func<TResult> onSgd,
        Func<TResult> onShp,
        Func<TResult> onSll,
        Func<TResult> onSos,
        Func<TResult> onSrd,
        Func<TResult> onSsp,
        Func<TResult> onStn,
        Func<TResult> onSvc,
        Func<TResult> onSyp,
        Func<TResult> onSzl,
        Func<TResult> onThb,
        Func<TResult> onTjs,
        Func<TResult> onTmt,
        Func<TResult> onTnd,
        Func<TResult> onTop,
        Func<TResult> onTry,
        Func<TResult> onTtd,
        Func<TResult> onTwd,
        Func<TResult> onTzs,
        Func<TResult> onUah,
        Func<TResult> onUgx,
        Func<TResult> onUsd,
        Func<TResult> onUsn,
        Func<TResult> onUyi,
        Func<TResult> onUyu,
        Func<TResult> onUzs,
        Func<TResult> onVef,
        Func<TResult> onVnd,
        Func<TResult> onVuv,
        Func<TResult> onWst,
        Func<TResult> onXaf,
        Func<TResult> onXag,
        Func<TResult> onXau,
        Func<TResult> onXba,
        Func<TResult> onXbb,
        Func<TResult> onXbc,
        Func<TResult> onXbd,
        Func<TResult> onXcd,
        Func<TResult> onXdr,
        Func<TResult> onXof,
        Func<TResult> onXpd,
        Func<TResult> onXpf,
        Func<TResult> onXpt,
        Func<TResult> onXsu,
        Func<TResult> onXua,
        Func<TResult> onYer,
        Func<TResult> onZar,
        Func<TResult> onZmw,
        Func<TResult> onZwl,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Aed => onAed(),
            _ when this == Afn => onAfn(),
            _ when this == All => onAll(),
            _ when this == Amd => onAmd(),
            _ when this == Ang => onAng(),
            _ when this == Aoa => onAoa(),
            _ when this == Ars => onArs(),
            _ when this == Aud => onAud(),
            _ when this == Awg => onAwg(),
            _ when this == Azn => onAzn(),
            _ when this == Bam => onBam(),
            _ when this == Bbd => onBbd(),
            _ when this == Bdt => onBdt(),
            _ when this == Bgn => onBgn(),
            _ when this == Bhd => onBhd(),
            _ when this == Bif => onBif(),
            _ when this == Bmd => onBmd(),
            _ when this == Bnd => onBnd(),
            _ when this == Bob => onBob(),
            _ when this == Bov => onBov(),
            _ when this == Brl => onBrl(),
            _ when this == Bsd => onBsd(),
            _ when this == Btn => onBtn(),
            _ when this == Bwp => onBwp(),
            _ when this == Byn => onByn(),
            _ when this == Bzd => onBzd(),
            _ when this == Cad => onCad(),
            _ when this == Cdf => onCdf(),
            _ when this == Che => onChe(),
            _ when this == Chf => onChf(),
            _ when this == Chw => onChw(),
            _ when this == Clf => onClf(),
            _ when this == Clp => onClp(),
            _ when this == Cny => onCny(),
            _ when this == Cop => onCop(),
            _ when this == Cou => onCou(),
            _ when this == Crc => onCrc(),
            _ when this == Cuc => onCuc(),
            _ when this == Cup => onCup(),
            _ when this == Cve => onCve(),
            _ when this == Czk => onCzk(),
            _ when this == Djf => onDjf(),
            _ when this == Dkk => onDkk(),
            _ when this == Dop => onDop(),
            _ when this == Dzd => onDzd(),
            _ when this == Egp => onEgp(),
            _ when this == Ern => onErn(),
            _ when this == Etb => onEtb(),
            _ when this == Eur => onEur(),
            _ when this == Fjd => onFjd(),
            _ when this == Fkp => onFkp(),
            _ when this == Gbp => onGbp(),
            _ when this == Gel => onGel(),
            _ when this == Ghs => onGhs(),
            _ when this == Gip => onGip(),
            _ when this == Gmd => onGmd(),
            _ when this == Gnf => onGnf(),
            _ when this == Gtq => onGtq(),
            _ when this == Gyd => onGyd(),
            _ when this == Hkd => onHkd(),
            _ when this == Hnl => onHnl(),
            _ when this == Hrk => onHrk(),
            _ when this == Htg => onHtg(),
            _ when this == Huf => onHuf(),
            _ when this == Idr => onIdr(),
            _ when this == Ils => onIls(),
            _ when this == Inr => onInr(),
            _ when this == Iqd => onIqd(),
            _ when this == Irr => onIrr(),
            _ when this == Isk => onIsk(),
            _ when this == Jmd => onJmd(),
            _ when this == Jod => onJod(),
            _ when this == Jpy => onJpy(),
            _ when this == Kes => onKes(),
            _ when this == Kgs => onKgs(),
            _ when this == Khr => onKhr(),
            _ when this == Kmf => onKmf(),
            _ when this == Kpw => onKpw(),
            _ when this == Krw => onKrw(),
            _ when this == Kwd => onKwd(),
            _ when this == Kyd => onKyd(),
            _ when this == Kzt => onKzt(),
            _ when this == Lak => onLak(),
            _ when this == Lbp => onLbp(),
            _ when this == Lkr => onLkr(),
            _ when this == Lrd => onLrd(),
            _ when this == Lsl => onLsl(),
            _ when this == Lyd => onLyd(),
            _ when this == Mad => onMad(),
            _ when this == Mdl => onMdl(),
            _ when this == Mga => onMga(),
            _ when this == Mkd => onMkd(),
            _ when this == Mmk => onMmk(),
            _ when this == Mnt => onMnt(),
            _ when this == Mop => onMop(),
            _ when this == Mru => onMru(),
            _ when this == Mur => onMur(),
            _ when this == Mvr => onMvr(),
            _ when this == Mwk => onMwk(),
            _ when this == Mxn => onMxn(),
            _ when this == Mxv => onMxv(),
            _ when this == Myr => onMyr(),
            _ when this == Mzn => onMzn(),
            _ when this == Nad => onNad(),
            _ when this == Ngn => onNgn(),
            _ when this == Nio => onNio(),
            _ when this == Nok => onNok(),
            _ when this == Npr => onNpr(),
            _ when this == Nzd => onNzd(),
            _ when this == Omr => onOmr(),
            _ when this == Pab => onPab(),
            _ when this == Pen => onPen(),
            _ when this == Pgk => onPgk(),
            _ when this == Php => onPhp(),
            _ when this == Pkr => onPkr(),
            _ when this == Pln => onPln(),
            _ when this == Pyg => onPyg(),
            _ when this == Qar => onQar(),
            _ when this == Ron => onRon(),
            _ when this == Rsd => onRsd(),
            _ when this == Rub => onRub(),
            _ when this == Rwf => onRwf(),
            _ when this == Sar => onSar(),
            _ when this == Sbd => onSbd(),
            _ when this == Scr => onScr(),
            _ when this == Sdg => onSdg(),
            _ when this == Sek => onSek(),
            _ when this == Sgd => onSgd(),
            _ when this == Shp => onShp(),
            _ when this == Sll => onSll(),
            _ when this == Sos => onSos(),
            _ when this == Srd => onSrd(),
            _ when this == Ssp => onSsp(),
            _ when this == Stn => onStn(),
            _ when this == Svc => onSvc(),
            _ when this == Syp => onSyp(),
            _ when this == Szl => onSzl(),
            _ when this == Thb => onThb(),
            _ when this == Tjs => onTjs(),
            _ when this == Tmt => onTmt(),
            _ when this == Tnd => onTnd(),
            _ when this == Top => onTop(),
            _ when this == Try => onTry(),
            _ when this == Ttd => onTtd(),
            _ when this == Twd => onTwd(),
            _ when this == Tzs => onTzs(),
            _ when this == Uah => onUah(),
            _ when this == Ugx => onUgx(),
            _ when this == Usd => onUsd(),
            _ when this == Usn => onUsn(),
            _ when this == Uyi => onUyi(),
            _ when this == Uyu => onUyu(),
            _ when this == Uzs => onUzs(),
            _ when this == Vef => onVef(),
            _ when this == Vnd => onVnd(),
            _ when this == Vuv => onVuv(),
            _ when this == Wst => onWst(),
            _ when this == Xaf => onXaf(),
            _ when this == Xag => onXag(),
            _ when this == Xau => onXau(),
            _ when this == Xba => onXba(),
            _ when this == Xbb => onXbb(),
            _ when this == Xbc => onXbc(),
            _ when this == Xbd => onXbd(),
            _ when this == Xcd => onXcd(),
            _ when this == Xdr => onXdr(),
            _ when this == Xof => onXof(),
            _ when this == Xpd => onXpd(),
            _ when this == Xpf => onXpf(),
            _ when this == Xpt => onXpt(),
            _ when this == Xsu => onXsu(),
            _ when this == Xua => onXua(),
            _ when this == Yer => onYer(),
            _ when this == Zar => onZar(),
            _ when this == Zmw => onZmw(),
            _ when this == Zwl => onZwl(),
            _ => otherwise(Value)
        };

    public void Match(Action onAed,
        Action onAfn,
        Action onAll,
        Action onAmd,
        Action onAng,
        Action onAoa,
        Action onArs,
        Action onAud,
        Action onAwg,
        Action onAzn,
        Action onBam,
        Action onBbd,
        Action onBdt,
        Action onBgn,
        Action onBhd,
        Action onBif,
        Action onBmd,
        Action onBnd,
        Action onBob,
        Action onBov,
        Action onBrl,
        Action onBsd,
        Action onBtn,
        Action onBwp,
        Action onByn,
        Action onBzd,
        Action onCad,
        Action onCdf,
        Action onChe,
        Action onChf,
        Action onChw,
        Action onClf,
        Action onClp,
        Action onCny,
        Action onCop,
        Action onCou,
        Action onCrc,
        Action onCuc,
        Action onCup,
        Action onCve,
        Action onCzk,
        Action onDjf,
        Action onDkk,
        Action onDop,
        Action onDzd,
        Action onEgp,
        Action onErn,
        Action onEtb,
        Action onEur,
        Action onFjd,
        Action onFkp,
        Action onGbp,
        Action onGel,
        Action onGhs,
        Action onGip,
        Action onGmd,
        Action onGnf,
        Action onGtq,
        Action onGyd,
        Action onHkd,
        Action onHnl,
        Action onHrk,
        Action onHtg,
        Action onHuf,
        Action onIdr,
        Action onIls,
        Action onInr,
        Action onIqd,
        Action onIrr,
        Action onIsk,
        Action onJmd,
        Action onJod,
        Action onJpy,
        Action onKes,
        Action onKgs,
        Action onKhr,
        Action onKmf,
        Action onKpw,
        Action onKrw,
        Action onKwd,
        Action onKyd,
        Action onKzt,
        Action onLak,
        Action onLbp,
        Action onLkr,
        Action onLrd,
        Action onLsl,
        Action onLyd,
        Action onMad,
        Action onMdl,
        Action onMga,
        Action onMkd,
        Action onMmk,
        Action onMnt,
        Action onMop,
        Action onMru,
        Action onMur,
        Action onMvr,
        Action onMwk,
        Action onMxn,
        Action onMxv,
        Action onMyr,
        Action onMzn,
        Action onNad,
        Action onNgn,
        Action onNio,
        Action onNok,
        Action onNpr,
        Action onNzd,
        Action onOmr,
        Action onPab,
        Action onPen,
        Action onPgk,
        Action onPhp,
        Action onPkr,
        Action onPln,
        Action onPyg,
        Action onQar,
        Action onRon,
        Action onRsd,
        Action onRub,
        Action onRwf,
        Action onSar,
        Action onSbd,
        Action onScr,
        Action onSdg,
        Action onSek,
        Action onSgd,
        Action onShp,
        Action onSll,
        Action onSos,
        Action onSrd,
        Action onSsp,
        Action onStn,
        Action onSvc,
        Action onSyp,
        Action onSzl,
        Action onThb,
        Action onTjs,
        Action onTmt,
        Action onTnd,
        Action onTop,
        Action onTry,
        Action onTtd,
        Action onTwd,
        Action onTzs,
        Action onUah,
        Action onUgx,
        Action onUsd,
        Action onUsn,
        Action onUyi,
        Action onUyu,
        Action onUzs,
        Action onVef,
        Action onVnd,
        Action onVuv,
        Action onWst,
        Action onXaf,
        Action onXag,
        Action onXau,
        Action onXba,
        Action onXbb,
        Action onXbc,
        Action onXbd,
        Action onXcd,
        Action onXdr,
        Action onXof,
        Action onXpd,
        Action onXpf,
        Action onXpt,
        Action onXsu,
        Action onXua,
        Action onYer,
        Action onZar,
        Action onZmw,
        Action onZwl,
        Action<string> otherwise)
    {
        if (this == Aed) onAed();
        else if (this == Afn) onAfn();
        else if (this == All) onAll();
        else if (this == Amd) onAmd();
        else if (this == Ang) onAng();
        else if (this == Aoa) onAoa();
        else if (this == Ars) onArs();
        else if (this == Aud) onAud();
        else if (this == Awg) onAwg();
        else if (this == Azn) onAzn();
        else if (this == Bam) onBam();
        else if (this == Bbd) onBbd();
        else if (this == Bdt) onBdt();
        else if (this == Bgn) onBgn();
        else if (this == Bhd) onBhd();
        else if (this == Bif) onBif();
        else if (this == Bmd) onBmd();
        else if (this == Bnd) onBnd();
        else if (this == Bob) onBob();
        else if (this == Bov) onBov();
        else if (this == Brl) onBrl();
        else if (this == Bsd) onBsd();
        else if (this == Btn) onBtn();
        else if (this == Bwp) onBwp();
        else if (this == Byn) onByn();
        else if (this == Bzd) onBzd();
        else if (this == Cad) onCad();
        else if (this == Cdf) onCdf();
        else if (this == Che) onChe();
        else if (this == Chf) onChf();
        else if (this == Chw) onChw();
        else if (this == Clf) onClf();
        else if (this == Clp) onClp();
        else if (this == Cny) onCny();
        else if (this == Cop) onCop();
        else if (this == Cou) onCou();
        else if (this == Crc) onCrc();
        else if (this == Cuc) onCuc();
        else if (this == Cup) onCup();
        else if (this == Cve) onCve();
        else if (this == Czk) onCzk();
        else if (this == Djf) onDjf();
        else if (this == Dkk) onDkk();
        else if (this == Dop) onDop();
        else if (this == Dzd) onDzd();
        else if (this == Egp) onEgp();
        else if (this == Ern) onErn();
        else if (this == Etb) onEtb();
        else if (this == Eur) onEur();
        else if (this == Fjd) onFjd();
        else if (this == Fkp) onFkp();
        else if (this == Gbp) onGbp();
        else if (this == Gel) onGel();
        else if (this == Ghs) onGhs();
        else if (this == Gip) onGip();
        else if (this == Gmd) onGmd();
        else if (this == Gnf) onGnf();
        else if (this == Gtq) onGtq();
        else if (this == Gyd) onGyd();
        else if (this == Hkd) onHkd();
        else if (this == Hnl) onHnl();
        else if (this == Hrk) onHrk();
        else if (this == Htg) onHtg();
        else if (this == Huf) onHuf();
        else if (this == Idr) onIdr();
        else if (this == Ils) onIls();
        else if (this == Inr) onInr();
        else if (this == Iqd) onIqd();
        else if (this == Irr) onIrr();
        else if (this == Isk) onIsk();
        else if (this == Jmd) onJmd();
        else if (this == Jod) onJod();
        else if (this == Jpy) onJpy();
        else if (this == Kes) onKes();
        else if (this == Kgs) onKgs();
        else if (this == Khr) onKhr();
        else if (this == Kmf) onKmf();
        else if (this == Kpw) onKpw();
        else if (this == Krw) onKrw();
        else if (this == Kwd) onKwd();
        else if (this == Kyd) onKyd();
        else if (this == Kzt) onKzt();
        else if (this == Lak) onLak();
        else if (this == Lbp) onLbp();
        else if (this == Lkr) onLkr();
        else if (this == Lrd) onLrd();
        else if (this == Lsl) onLsl();
        else if (this == Lyd) onLyd();
        else if (this == Mad) onMad();
        else if (this == Mdl) onMdl();
        else if (this == Mga) onMga();
        else if (this == Mkd) onMkd();
        else if (this == Mmk) onMmk();
        else if (this == Mnt) onMnt();
        else if (this == Mop) onMop();
        else if (this == Mru) onMru();
        else if (this == Mur) onMur();
        else if (this == Mvr) onMvr();
        else if (this == Mwk) onMwk();
        else if (this == Mxn) onMxn();
        else if (this == Mxv) onMxv();
        else if (this == Myr) onMyr();
        else if (this == Mzn) onMzn();
        else if (this == Nad) onNad();
        else if (this == Ngn) onNgn();
        else if (this == Nio) onNio();
        else if (this == Nok) onNok();
        else if (this == Npr) onNpr();
        else if (this == Nzd) onNzd();
        else if (this == Omr) onOmr();
        else if (this == Pab) onPab();
        else if (this == Pen) onPen();
        else if (this == Pgk) onPgk();
        else if (this == Php) onPhp();
        else if (this == Pkr) onPkr();
        else if (this == Pln) onPln();
        else if (this == Pyg) onPyg();
        else if (this == Qar) onQar();
        else if (this == Ron) onRon();
        else if (this == Rsd) onRsd();
        else if (this == Rub) onRub();
        else if (this == Rwf) onRwf();
        else if (this == Sar) onSar();
        else if (this == Sbd) onSbd();
        else if (this == Scr) onScr();
        else if (this == Sdg) onSdg();
        else if (this == Sek) onSek();
        else if (this == Sgd) onSgd();
        else if (this == Shp) onShp();
        else if (this == Sll) onSll();
        else if (this == Sos) onSos();
        else if (this == Srd) onSrd();
        else if (this == Ssp) onSsp();
        else if (this == Stn) onStn();
        else if (this == Svc) onSvc();
        else if (this == Syp) onSyp();
        else if (this == Szl) onSzl();
        else if (this == Thb) onThb();
        else if (this == Tjs) onTjs();
        else if (this == Tmt) onTmt();
        else if (this == Tnd) onTnd();
        else if (this == Top) onTop();
        else if (this == Try) onTry();
        else if (this == Ttd) onTtd();
        else if (this == Twd) onTwd();
        else if (this == Tzs) onTzs();
        else if (this == Uah) onUah();
        else if (this == Ugx) onUgx();
        else if (this == Usd) onUsd();
        else if (this == Usn) onUsn();
        else if (this == Uyi) onUyi();
        else if (this == Uyu) onUyu();
        else if (this == Uzs) onUzs();
        else if (this == Vef) onVef();
        else if (this == Vnd) onVnd();
        else if (this == Vuv) onVuv();
        else if (this == Wst) onWst();
        else if (this == Xaf) onXaf();
        else if (this == Xag) onXag();
        else if (this == Xau) onXau();
        else if (this == Xba) onXba();
        else if (this == Xbb) onXbb();
        else if (this == Xbc) onXbc();
        else if (this == Xbd) onXbd();
        else if (this == Xcd) onXcd();
        else if (this == Xdr) onXdr();
        else if (this == Xof) onXof();
        else if (this == Xpd) onXpd();
        else if (this == Xpf) onXpf();
        else if (this == Xpt) onXpt();
        else if (this == Xsu) onXsu();
        else if (this == Xua) onXua();
        else if (this == Yer) onYer();
        else if (this == Zar) onZar();
        else if (this == Zmw) onZmw();
        else if (this == Zwl) onZwl();
        else otherwise(Value);
    }
}
