using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TerminalType>))]
public sealed record TerminalType : OpenStringEnum<TerminalType>
{
    private TerminalType(string value) : base(value)
    {
    }

    public static readonly TerminalType _125158Llc = new("125158LLC");

    public static readonly TerminalType _3Delta = new("3Delta");

    public static readonly TerminalType _3DeltaPws = new("3DeltaPws");

    public static readonly TerminalType _911SoftwareCreditline = new("911SoftwareCreditline");

    public static readonly TerminalType AbcLiquors = new("abcLiquors");

    public static readonly TerminalType Abc610Se = new("abc610SE");

    public static readonly TerminalType AchDirect = new("achDirect");

    public static readonly TerminalType AciRcsSwitch = new("aciRcsSwitch");

    public static readonly TerminalType AcoSoftware = new("acoSoftware");

    public static readonly TerminalType ActivantFalcon = new("activantFalcon");

    public static readonly TerminalType AdsGilbarco = new("adsGilbarco");

    public static readonly TerminalType AdvancedMobilePayment = new("advancedMobilePayment");

    public static readonly TerminalType Adyen = new("adyen");

    public static readonly TerminalType Ahcc = new("ahcc");

    public static readonly TerminalType Ajb = new("ajb");

    public static readonly TerminalType AjbFipayDirectTandem = new("ajbFipayDirectTandem");

    public static readonly TerminalType AjbIcip610 = new("ajbIcip610");

    public static readonly TerminalType AjbRtsIbm = new("ajbRtsIbm");

    public static readonly TerminalType AjbRtsTandem = new("ajbRtsTandem");

    public static readonly TerminalType AjbBevn = new("ajbBevn");

    public static readonly TerminalType AjbRue21 = new("ajbRue21");

    public static readonly TerminalType AjbSpoch = new("ajbSpoch");

    public static readonly TerminalType AllureGlobal = new("allureGlobal");

    public static readonly TerminalType AlohaEnhanced610 = new("alohaEnhanced610");

    public static readonly TerminalType AlohaTerm = new("alohaTerm");

    public static readonly TerminalType AprivaGateway = new("aprivaGateway");

    public static readonly TerminalType AprivaIwl255 = new("aprivaIwl255");

    public static readonly TerminalType Apriva610 = new("apriva610");

    public static readonly TerminalType AprivapayAtt = new("aprivapayAtt");

    public static readonly TerminalType AprivapayMobile = new("aprivapayMobile");

    public static readonly TerminalType AptosEpicorRetail = new("aptosEpicorRetail");

    public static readonly TerminalType Ascom = new("ascom");

    public static readonly TerminalType Asig = new("asig");

    public static readonly TerminalType Aurus = new("aurus");

    public static readonly TerminalType AuthorizeNet = new("authorizeNet");

    public static readonly TerminalType AutomatedCashSystems = new("automatedCashSystems");

    public static readonly TerminalType B2KSystems = new("b2kSystems");

    public static readonly TerminalType BevnSoftware = new("bevnSoftware");

    public static readonly TerminalType Billabong = new("billabong");

    public static readonly TerminalType Bncb = new("bncb");

    public static readonly TerminalType BobEvans610 = new("bobEvans610");

    public static readonly TerminalType BookstoreManager = new("bookstoreManager");

    public static readonly TerminalType Boost2Delta = new("boost2Delta");

    public static readonly TerminalType BoostBoraPayer = new("boostBoraPayer");

    public static readonly TerminalType BoostDirectInsite = new("boostDirectInsite");

    public static readonly TerminalType BoostMpg = new("boostMpg");

    public static readonly TerminalType BreakawayVisionPos = new("breakawayVisionPos");

    public static readonly TerminalType Bridgepay = new("bridgepay");

    public static readonly TerminalType BrinkSoftware = new("brinkSoftware");

    public static readonly TerminalType BuyAtab = new("buyAtab");

    public static readonly TerminalType CaclGift = new("caclGift");

    public static readonly TerminalType CardinalHealth610 = new("cardinalHealth610");

    public static readonly TerminalType Cayan = new("cayan");

    public static readonly TerminalType CcciWebsite = new("ccciWebsite");

    public static readonly TerminalType CdsGlobalPaydq = new("cdsGlobalPaydq");

    public static readonly TerminalType CenposHostCapture = new("cenposHostCapture");

    public static readonly TerminalType CenposIsoEmd = new("cenposIsoEmd");

    public static readonly TerminalType Cfre610 = new("cfre610");

    public static readonly TerminalType ChargePayments = new("chargePayments");

    public static readonly TerminalType ChargesmartPaywareConnect = new("chargesmartPaywareConnect");

    public static readonly TerminalType Chrb610 = new("chrb610");

    public static readonly TerminalType Chsp = new("chsp");

    public static readonly TerminalType CkfrIntrixSupercharge = new("ckfrIntrixSupercharge");

    public static readonly TerminalType Clre610Salepoint = new("clre610Salepoint");

    public static readonly TerminalType ComdataSmartdesq = new("comdataSmartdesq");

    public static readonly TerminalType Commerciant = new("commerciant");

    public static readonly TerminalType CrackerBarrel = new("crackerBarrel");

    public static readonly TerminalType CrainAtlanta = new("crainAtlanta");

    public static readonly TerminalType CraneVendingServices = new("craneVendingServices");

    public static readonly TerminalType CreditCall = new("creditCall");

    public static readonly TerminalType CtrSystems = new("ctrSystems");

    public static readonly TerminalType CubicPaymentApplication = new("cubicPaymentApplication");

    public static readonly TerminalType CyberSource = new("cyberSource");

    public static readonly TerminalType CyberSourceVsntConversion = new("cyberSourceVsntConversion");

    public static readonly TerminalType CyberSourceVsntResellerBasic = new("cyberSourceVsntResellerBasic");

    public static readonly TerminalType CyberSourceVsntResellerPremier = new("cyberSourceVsntResellerPremier");

    public static readonly TerminalType DataBusnessSystems = new("dataBusnessSystems");

    public static readonly TerminalType DataCap = new("dataCap");

    public static readonly TerminalType DataCapDialTran = new("dataCapDialTran");

    public static readonly TerminalType DataCapEpayRepro = new("dataCapEpayRepro");

    public static readonly TerminalType DataCapGiftEpay = new("dataCapGiftEpay");

    public static readonly TerminalType DataCapIpTran = new("dataCapIpTran");

    public static readonly TerminalType DataCapIpTranLt = new("dataCapIpTranLt");

    public static readonly TerminalType DataCapIpTranLtMoble = new("dataCapIpTranLtMoble");

    public static readonly TerminalType DataCapNetEpay = new("dataCapNetEpay");

    public static readonly TerminalType DataCapTranRepro = new("dataCapTranRepro");

    public static readonly TerminalType DataCapTwinTran = new("dataCapTwinTran");

    public static readonly TerminalType DataCapTwinTxnServer = new("dataCapTwinTxnServer");

    public static readonly TerminalType DataVantage = new("dataVantage");

    public static readonly TerminalType DataVantageFnln610 = new("dataVantageFnln610");

    public static readonly TerminalType DbsTplusEnHanced = new("dbsTplusEnHanced");

    public static readonly TerminalType DbsTransactionPlus = new("dbsTransactionPlus");

    public static readonly TerminalType DealBird = new("dealBird");

    public static readonly TerminalType Dejavoo = new("dejavoo");

    public static readonly TerminalType Delego = new("delego");

    public static readonly TerminalType Digicom = new("digicom");

    public static readonly TerminalType DirectInsite = new("directInsite");

    public static readonly TerminalType DiscGoTech = new("discGoTech");

    public static readonly TerminalType Dl610Snt = new("dl610Snt");

    public static readonly TerminalType DlglVarSoftware = new("dlglVarSoftware");

    public static readonly TerminalType Dlgl610S = new("dlgl610s");

    public static readonly TerminalType DominosAci = new("dominosAci");

    public static readonly TerminalType EcommercePlus = new("ecommercePlus");

    public static readonly TerminalType Edgil = new("edgil");

    public static readonly TerminalType EesCompanies = new("eesCompanies");

    public static readonly TerminalType ElavonEnConcert610 = new("elavonEnConcert610");

    public static readonly TerminalType ElavonFuseboxGateway = new("elavonFuseboxGateway");

    public static readonly TerminalType ElavonProtobase = new("elavonProtobase");

    public static readonly TerminalType ElavonPayments = new("elavonPayments");

    public static readonly TerminalType Elpl610R = new("elpl610r");

    public static readonly TerminalType EpayHealthcareMonetra = new("epayHealthcareMonetra");

    public static readonly TerminalType Equinox = new("equinox");

    public static readonly TerminalType EsdCard = new("esdCard");

    public static readonly TerminalType Eatouch = new("eatouch");

    public static readonly TerminalType ExatouchVsb = new("exatouchVsb");

    public static readonly TerminalType Exit41 = new("exit41");

    public static readonly TerminalType ExpressTriPos = new("expressTriPos");

    public static readonly TerminalType EzDine = new("ezDine");

    public static readonly TerminalType EzRetail = new("ezRetail");

    public static readonly TerminalType Fandango = new("fandango");

    public static readonly TerminalType FirstGlobalBillingSapwalletVsb = new("firstGlobalBillingSapwalletVsb");

    public static readonly TerminalType Fitb610S = new("fitb610s");

    public static readonly TerminalType Fredmeyr610 = new("fredmeyr610");

    public static readonly TerminalType FreedomPay = new("freedomPay");

    public static readonly TerminalType FtniGatewayEtran = new("ftniGatewayEtran");

    public static readonly TerminalType FuturePosVsb = new("futurePosVsb");

    public static readonly TerminalType GambleidTsevo = new("GambleidTsevo");

    public static readonly TerminalType Giftango = new("Giftango");

    public static readonly TerminalType Givex = new("Givex");

    public static readonly TerminalType GmsPaymentGateway = new("gmsPaymentGateway");

    public static readonly TerminalType GmsPajb = new("gmsPajb");

    public static readonly TerminalType GnctSoftware = new("gnctSoftware");

    public static readonly TerminalType GoEMerchant = new("goEMerchant");

    public static readonly TerminalType Govolution = new("govolution");

    public static readonly TerminalType GrantStreet = new("grantStreet");

    public static readonly TerminalType GreatLakesScrip = new("greatLakesScrip");

    public static readonly TerminalType GreatLakesScripVar = new("greatLakesScripVar");

    public static readonly TerminalType GsiCommerce = new("gsiCommerce");

    public static readonly TerminalType Handpoint = new("handpoint");

    public static readonly TerminalType HarleyOwnersGroup = new("harleyOwnersGroup");

    public static readonly TerminalType Highradius = new("highradius");

    public static readonly TerminalType Hp = new("hp");

    public static readonly TerminalType Hypercom5500M = new("hypercom5500m");

    public static readonly TerminalType HypercomPaymentServer = new("hypercomPaymentServer");

    public static readonly TerminalType HypercomT4205 = new("hypercomT4205");

    public static readonly TerminalType HypercomT4205E2E = new("hypercomT4205E2e");

    public static readonly TerminalType HypercomT4210 = new("hypercomT4210");

    public static readonly TerminalType HypercomT4210E2E = new("hypercomT4210E2e");

    public static readonly TerminalType Hypercom4220Dial = new("hypercom4220Dial");

    public static readonly TerminalType Hypercom4220DialE2E = new("hypercom4220DialE2e");

    public static readonly TerminalType Hypercom4220Ssl = new("hypercom4220Ssl");

    public static readonly TerminalType Hypercom4220SslE2E = new("hypercom4220SslE2e");

    public static readonly TerminalType I2CVsb = new("i2cVsb");

    public static readonly TerminalType Ibmace = new("ibmace");

    public static readonly TerminalType IcVerify = new("icVerify");

    public static readonly TerminalType IncentPay = new("incentPay");

    public static readonly TerminalType Index = new("index");

    public static readonly TerminalType Ingenico610 = new("ingenico610");

    public static readonly TerminalType Ingenico720 = new("ingenico720");

    public static readonly TerminalType IngenicoIct2203XDial = new("ingenicoIct2203xDial");

    public static readonly TerminalType IngenicoIct2203XDialE2Ee = new("ingenicoIct2203xDialE2ee");

    public static readonly TerminalType IngenicoIct2203XDialPilot = new("ingenicoIct2203xDialPilot");

    public static readonly TerminalType IngenicoIct2203XSsl = new("ingenicoIct2203xSsl");

    public static readonly TerminalType IngenicoIct2203XSslE2Ee = new("ingenicoIct2203xSslE2ee");

    public static readonly TerminalType IngenicoIct2203XSslPilot = new("ingenicoIct2203xSSLPilot");

    public static readonly TerminalType IngenicoIct220Ctls3XDial = new("ingenicoIct220Ctls3xDial");

    public static readonly TerminalType IngenicoIct220Ctls3XDialEe2E = new("ingenicoIct220Ctls3xDialEe2e");

    public static readonly TerminalType IngenicoIct220Ctls3XSsl = new("ingenicoIct220Ctls3xSsl");

    public static readonly TerminalType IngenicoIct220Ctls3XSslE2Ee = new("ingenicoIct220Ctls3xSslE2ee");

    public static readonly TerminalType IngenicoIct2503XDial = new("ingenicoIct2503xDial");

    public static readonly TerminalType IngenicoIct2503XDialE2Ee = new("ingenicoIct2503xDialE2ee");

    public static readonly TerminalType IngenicoIct2503XSsl = new("ingenicoIct2503xSsl");

    public static readonly TerminalType IngenicoIct2503XSsle2Ee = new("ingenicoIct2503xSSLE2ee");

    public static readonly TerminalType IngenicoIwl222BtDial = new("ingenicoIwl222BtDial");

    public static readonly TerminalType IngenicoIwl222BtDialE2Ee = new("ingenicoIwl222BtDialE2ee");

    public static readonly TerminalType IngenicoIwl222BtSsl = new("ingenicoIwl222BtSsl");

    public static readonly TerminalType IngenicoIwl222BtSSlE2Ee = new("ingenicoIwl222BtSSlE2ee");

    public static readonly TerminalType IngenicoIwl252BtDial = new("ingenicoIwl252BtDial");

    public static readonly TerminalType IngenicoIw252BtDialE2Ee = new("ingenicoIw252BtDialE2ee");

    public static readonly TerminalType IngenicoIw252BtSsl = new("ingenicoIw252BtSsl");

    public static readonly TerminalType IngenicoIw252BtSslE2Ee = new("ingenicoIw252BtSslE2ee");

    public static readonly TerminalType IngenicoIw2553G = new("ingenicoIw2553g");

    public static readonly TerminalType IngenicoIw2553GE2Ee = new("ingenicoIw2553gE2ee");

    public static readonly TerminalType IngenicoSiEnterprise = new("ingenicoSiEnterprise");

    public static readonly TerminalType Instamed = new("instamed");

    public static readonly TerminalType IpayGateway = new("ipayGateway");

    public static readonly TerminalType Isd = new("isd");

    public static readonly TerminalType IslandPacific = new("islandPacific");

    public static readonly TerminalType IsvOpenmotionVsb = new("isvOpenmotionVsb");

    public static readonly TerminalType Isv510 = new("isv510");

    public static readonly TerminalType Isv600 = new("isv600");

    public static readonly TerminalType Isv610 = new("isv610");

    public static readonly TerminalType IsvVsk = new("isvVsk");

    public static readonly TerminalType Itransact = new("itransact");

    public static readonly TerminalType JewlSoftware = new("jewlSoftware");

    public static readonly TerminalType JockeyEcomm = new("jockeyEcomm");

    public static readonly TerminalType JockeyRetail = new("jockeyRetail");

    public static readonly TerminalType Kachyng = new("kachyng");

    public static readonly TerminalType Klik = new("klik");

    public static readonly TerminalType KmartGift = new("kmartGift");

    public static readonly TerminalType Kubra = new("kubra");

    public static readonly TerminalType LightYear = new("lightYear");

    public static readonly TerminalType Linked2Pay = new("linked2Pay");

    public static readonly TerminalType LongRangeSystemsLrs = new("longRangeSystemsLrs");

    public static readonly TerminalType LumberVisaK = new("lumberVisaK");

    public static readonly TerminalType LumgPos = new("lumgPos");

    public static readonly TerminalType MagicWrighter = new("magicWrighter");

    public static readonly TerminalType MagnetCardServices = new("magnetCardServices");

    public static readonly TerminalType MainstreetMonetra510 = new("mainstreetMonetra510");

    public static readonly TerminalType MainstreetMonetra610 = new("mainstreetMonetra610");

    public static readonly TerminalType MastercardOpenapi = new("mastercardOpenapi");

    public static readonly TerminalType MastercardPaymentGateway = new("mastercardPaymentGateway");

    public static readonly TerminalType MeiApriva = new("meiApriva");

    public static readonly TerminalType MenusoftDigitalDining = new("menusoftDigitalDining");

    public static readonly TerminalType MerchantLinkCdg = new("merchantLinkCDG");

    public static readonly TerminalType MerchantLinkCredit = new("merchantLinkCredit");

    public static readonly TerminalType MeritSolar = new("meritSolar");

    public static readonly TerminalType MicrosSymphony = new("microsSymphony");

    public static readonly TerminalType MicrosalePos = new("microsalePos");

    public static readonly TerminalType MidniteExpressSlipstream = new("midniteExpressSlipstream");

    public static readonly TerminalType MightyTicket = new("mightyTicket");

    public static readonly TerminalType MilleniumRetailSolutions = new("milleniumRetailSolutions");

    public static readonly TerminalType MobileAccept = new("mobileAccept");

    public static readonly TerminalType MobileAcceptFlatRate = new("mobileAcceptFlatRate");

    public static readonly TerminalType MobileCheckoutQms = new("mobileCheckoutQms");

    public static readonly TerminalType MobileCheckoutStandard = new("mobileCheckoutStandard");

    public static readonly TerminalType MonetraAuth = new("monetraAuth");

    public static readonly TerminalType MonroMuffler = new("monroMuffler");

    public static readonly TerminalType MpayGateway = new("mpayGateway");

    public static readonly TerminalType MtxepsWineps = new("mtxepsWineps");

    public static readonly TerminalType Mvsp = new("mvsp");

    public static readonly TerminalType NcrAdvancedRestaurant = new("ncrAdvancedRestaurant");

    public static readonly TerminalType NcrCinema = new("ncrCinema");

    public static readonly TerminalType NcrCounterpoint510 = new("ncrCounterpoint510");

    public static readonly TerminalType NcrCounterpoint610 = new("ncrCounterpoint610");

    public static readonly TerminalType NcrRetalixConnectedPayments = new("ncrRetalixConnectedPayments");

    public static readonly TerminalType NcrSilver = new("ncrSilver");

    public static readonly TerminalType NcrSilverPro = new("ncrSilverPro");

    public static readonly TerminalType NcrSilverProQms = new("ncrSilverProQms");

    public static readonly TerminalType NeoGames610 = new("neoGames610");

    public static readonly TerminalType NetworkMerchants = new("networkMerchants");

    public static readonly TerminalType NsbEps = new("nsbEps");

    public static readonly TerminalType NourdersOdp = new("nourdersOdp");

    public static readonly TerminalType Nurit2159 = new("nurit2159");

    public static readonly TerminalType Nurit8400EDial = new("nurit8400EDial");

    public static readonly TerminalType OCharleys = new("oCharleys");

    public static readonly TerminalType Olo = new("olo");

    public static readonly TerminalType OpConnect = new("opConnect");

    public static readonly TerminalType OptimalPaymentsGateway = new("optimalPaymentsGateway");

    public static readonly TerminalType OrccCollectPay = new("orccCollectPay");

    public static readonly TerminalType OrccAciWorldwide = new("orccAciWorldwide");

    public static readonly TerminalType OrderTalk = new("orderTalk");

    public static readonly TerminalType PaVitalcheck = new("paVitalcheck");

    public static readonly TerminalType PaFidelityExpress = new("paFidelityExpress");

    public static readonly TerminalType PaGrantStreet = new("paGrantStreet");

    public static readonly TerminalType Parkmobile = new("parkmobile");

    public static readonly TerminalType PaxSp30Casio = new("paxSp30Casio");

    public static readonly TerminalType PayGov = new("payGov");

    public static readonly TerminalType PaydiantSj = new("paydiantSj");

    public static readonly TerminalType PayFirstEdcVpos = new("payFirstEdcVpos");

    public static readonly TerminalType PaypalPayflowLink = new("paypalPayflowLink");

    public static readonly TerminalType PaypalPayflowLinkReseller = new("paypalPayflowLinkReseller");

    public static readonly TerminalType PaypalPayflowPro = new("paypalPayflowPro");

    public static readonly TerminalType PaypalPayflowProReseller = new("paypalPayflowProReseller");

    public static readonly TerminalType Payright = new("payright");

    public static readonly TerminalType PaytechVsb = new("paytechVsb");

    public static readonly TerminalType PcAmerica = new("pcAmerica");

    public static readonly TerminalType Plstq610 = new("PLSTQ610");

    public static readonly TerminalType PlugNPlay = new("plugNPlay");

    public static readonly TerminalType Poynt = new("poynt");

    public static readonly TerminalType Precida = new("precida");

    public static readonly TerminalType PricetonCardConnect = new("pricetonCardConnect");

    public static readonly TerminalType PrincetonEcommCollectpay = new("princetonEcommCollectpay");

    public static readonly TerminalType PrincetonPayments = new("princetonPayments");

    public static readonly TerminalType PrincetonPayware = new("princetonPayware");

    public static readonly TerminalType PropSoftware = new("propSoftware");

    public static readonly TerminalType PurecommerceVsb = new("purecommerceVsb");

    public static readonly TerminalType PxpSolutionsRetail = new("pxpSolutionsRetail");

    public static readonly TerminalType RediantRposLighthouse = new("rediantRposLighthouse");

    public static readonly TerminalType RainbowApparel = new("rainbowApparel");

    public static readonly TerminalType Rdyc610S = new("rdyc610s");

    public static readonly TerminalType RedOakPs = new("redOakPs");

    public static readonly TerminalType RedfinNetwork = new("redfinNetwork");

    public static readonly TerminalType RemcoSoftware = new("remcoSoftware");

    public static readonly TerminalType RentACenter = new("rentACenter");

    public static readonly TerminalType ReproOnlyIngIct220Dial = new("reproOnlyIngIct220Dial");

    public static readonly TerminalType ReproOnlyIngIct220DialE2Ee = new("reproOnlyIngIct220DialE2ee");

    public static readonly TerminalType ReproOnlyIngIct220SslE2Ee = new("reproOnlyIngIct220SslE2ee");

    public static readonly TerminalType ReproOnlyIngIct250Dial = new("reproOnlyIngIct250Dial");

    public static readonly TerminalType ReproOnlyIngIct250DialE2Ee = new("reproOnlyIngIct250DialE2ee");

    public static readonly TerminalType ReproOnlyIngIct250Ssl = new("reproOnlyIngIct250Ssl");

    public static readonly TerminalType ReproOnlyIngIct250SslE2Ee = new("reproOnlyIngIct250SslE2ee");

    public static readonly TerminalType ReproOnlyVerifoneVx520DcDial = new("reproOnlyVerifoneVx520DcDial");

    public static readonly TerminalType ReproOnlyVerifoneVx520DcSsl = new("reproOnlyVerifoneVx520DcSsl");

    public static readonly TerminalType ReproOnlyVerifoneVx520DialCtls = new("reproOnlyVerifoneVx520DialCtls");

    public static readonly TerminalType ReproOnlyVerifoneVx520SslCtls = new("reproOnlyVerifoneVx520SslCtls");

    public static readonly TerminalType RetrieverSoftware = new("retrieverSoftware");

    public static readonly TerminalType RevlinkCollect = new("revlinkCollect");

    public static readonly TerminalType Revtrak = new("revtrak");

    public static readonly TerminalType ReamMobile = new("reamMobile");

    public static readonly TerminalType RoamMobileTest = new("roamMobileTest");

    public static readonly TerminalType RoamData = new("roamData");

    public static readonly TerminalType Salepoint = new("salepoint");

    public static readonly TerminalType SalepointClaires = new("salepointClaires");

    public static readonly TerminalType SbcSolutions = new("sbcSolutions");

    public static readonly TerminalType SecureTrading = new("secureTrading");

    public static readonly TerminalType SequoiaRetialSystems = new("sequoiaRetialSystems");

    public static readonly TerminalType Shci610 = new("shci610");

    public static readonly TerminalType Shift4OnTheNet = new("shift4OnTheNet");

    public static readonly TerminalType SightlinePayments = new("sightlinePayments");

    public static readonly TerminalType SlimCdEntNonReseller = new("slimCdEntNonReseller");

    public static readonly TerminalType SlimCdEnterprise = new("slimCdEnterprise");

    public static readonly TerminalType SlimCdPro = new("slimCdPro");

    public static readonly TerminalType SlimCdProNonReseller = new("slimCdProNonReseller");

    public static readonly TerminalType Snlh610 = new("snlh610");

    public static readonly TerminalType SouthernDataComm = new("southernDataComm");

    public static readonly TerminalType SpsEzpay = new("spsEzpay");

    public static readonly TerminalType SquirrelSystems = new("squirrelSystems");

    public static readonly TerminalType Ster610 = new("ster610");

    public static readonly TerminalType StorisVision9 = new("storisVision9");

    public static readonly TerminalType StstSoftware = new("ststSoftware");

    public static readonly TerminalType Talbots = new("talbots");

    public static readonly TerminalType TangiblePayments = new("tangiblePayments");

    public static readonly TerminalType TapToPayIphone = new("tapToPayIphone");

    public static readonly TerminalType TenderRetail = new("tenderRetail");

    public static readonly TerminalType Tillster = new("tillster");

    public static readonly TerminalType TnspayGateway = new("tnspayGateway");

    public static readonly TerminalType Toast = new("toast");

    public static readonly TerminalType ToyzPos = new("toyzPos");

    public static readonly TerminalType TransactionWirelessSvs = new("transactionWirelessSvs");

    public static readonly TerminalType Transax = new("transax");

    public static readonly TerminalType Tranzgate = new("tranzgate");

    public static readonly TerminalType Trem610 = new("trem610");

    public static readonly TerminalType Triversity = new("triversity");

    public static readonly TerminalType TriversityPos = new("triversityPos");

    public static readonly TerminalType TrustcommVault610 = new("trustcommVault610");

    public static readonly TerminalType TrustcommVault600 = new("trustcommVault600");

    public static readonly TerminalType Trustcommerce2011 = new("trustcommerce2011");

    public static readonly TerminalType TsysAmexPipPcSoftware = new("tsysAmexPipPcSoftware");

    public static readonly TerminalType TsysAmexPipTerminal = new("tsysAmexPipTerminal");

    public static readonly TerminalType TsysDialPay = new("tsysDialPay");

    public static readonly TerminalType TsysPosPort = new("tsysPosPort");

    public static readonly TerminalType Twitpay = new("twitpay");

    public static readonly TerminalType Uhaul = new("uhaul");

    public static readonly TerminalType UicBezel8 = new("uicBezel8");

    public static readonly TerminalType UpSolution610 = new("upSolution610");

    public static readonly TerminalType UsaEpay = new("usaEpay");

    public static readonly TerminalType Usfs = new("usfs");

    public static readonly TerminalType Ventek = new("ventek");

    public static readonly TerminalType Verifone = new("verifone");

    public static readonly TerminalType Verifone510Terminal = new("verifone510Terminal");

    public static readonly TerminalType Verifone600Terminal = new("verifone600Terminal");

    public static readonly TerminalType Verifone610 = new("verifone610");

    public static readonly TerminalType VerifoneOmni3200 = new("verifoneOmni3200");

    public static readonly TerminalType VerifonePaywareConnect = new("verifonePaywareConnect");

    public static readonly TerminalType VerifonePaywareMobile = new("verifonePaywareMobile");

    public static readonly TerminalType VerifonePaywarePc = new("verifonePaywarePc");

    public static readonly TerminalType VerifonePaywareTranactRita = new("verifonePaywareTranactRita");

    public static readonly TerminalType VerifonePcChargeGoSoftware = new("verifonePcChargeGoSoftware");

    public static readonly TerminalType VerifonePoint = new("verifonePoint");

    public static readonly TerminalType VerifonePointEntMx = new("verifonePointEntMx");

    public static readonly TerminalType VerifonePointEntVx = new("verifonePointEntVx");

    public static readonly TerminalType VerifoneRuby = new("verifoneRuby");

    public static readonly TerminalType VerifoneVx510 = new("verifoneVx510");

    public static readonly TerminalType VerifoneVx510DcDial = new("verifoneVx510DcDial");

    public static readonly TerminalType VerifoneVx510DcIp = new("verifoneVx510DcIp");

    public static readonly TerminalType VerifoneVx510DcSsl = new("verifoneVx510DcSsl");

    public static readonly TerminalType VerifoneVx510Le = new("verifoneVx510le");

    public static readonly TerminalType VerifoneVx520DcDialCtlsE2Ee = new("verifoneVx520DcDialCtlsE2ee");

    public static readonly TerminalType VerifoneVx520DcDialE2Ee = new("verifoneVx520DcDialE2ee");

    public static readonly TerminalType VerifoneVx520DcIp1 = new("verifoneVx520DcIp1");

    public static readonly TerminalType VerifoneVx520DcIp2 = new("verifoneVx520DcIp2");

    public static readonly TerminalType VerifoneVx520DcIpCtls = new("verifoneVx520DcIpCtls");

    public static readonly TerminalType VerifoneVx520DcIpCtlsE2Ee = new("verifoneVx520DcIpCtlsE2ee");

    public static readonly TerminalType VerifoneVx520DcSslCtlsE2Ee = new("verifoneVx520DcSslCtlsE2ee");

    public static readonly TerminalType VerifoneVx520DcSslE2Ee = new("verifoneVx520DcSslE2ee");

    public static readonly TerminalType VerifoneVx520DialOnly = new("verifoneVx520DialOnly");

    public static readonly TerminalType VerifoneVx570Dial = new("verifoneVx570Dial");

    public static readonly TerminalType VerifoneVx570Ip = new("verifoneVx570Ip");

    public static readonly TerminalType VerifoneVx570Ssl = new("verifoneVx570Ssl");

    public static readonly TerminalType VerifoneVx6803GGprs = new("verifoneVx6803gGprs");

    public static readonly TerminalType VicoSoftware = new("vicoSoftware");

    public static readonly TerminalType VirtualTerminal = new("virtualTerminal");

    public static readonly TerminalType VistaEntertainment = new("vistaEntertainment");

    public static readonly TerminalType Vitalcheck = new("vitalcheck");

    public static readonly TerminalType VmcAddOnAndroidByodQmd = new("vmcAddOnAndroidByodQmd");

    public static readonly TerminalType VmcAddOnAndroidByodStandard = new("vmcAddOnAndroidByodStandard");

    public static readonly TerminalType VmcAddOnBundleByodQms = new("vmcAddOnBundleByodQms");

    public static readonly TerminalType VmcAddOnBundleByodStandard = new("vmcAddOnBundleByodStandard");

    public static readonly TerminalType VmcAddOnBundleCellularQmd = new("vmcAddOnBundleCellularQmd");

    public static readonly TerminalType VmcAddOnBundleCellularStandard = new("vmcAddOnBundleCellularStandard");

    public static readonly TerminalType VmcAddOnBundleWifiQmd = new("vmcAddOnBundleWifiQmd");

    public static readonly TerminalType VmcAddOnBundleWifiStandard = new("vmcAddOnBundleWifiStandard");

    public static readonly TerminalType VmcFieldBundleByodQmd = new("vmcFieldBundleByodQmd");

    public static readonly TerminalType VmcFieldBundleByodStandard = new("vmcFieldBundleByodStandard");

    public static readonly TerminalType VmcFieldBundleCellularQms = new("vmcFieldBundleCellularQms");

    public static readonly TerminalType VmcFieldBundleCellularStandard = new("vmcFieldBundleCellularStandard");

    public static readonly TerminalType VmcStoreAndroidByodQms = new("vmcStoreAndroidByodQms");

    public static readonly TerminalType VmcStoreAndroidByodStandard = new("vmcStoreAndroidByodStandard");

    public static readonly TerminalType VmcStoreBundleByodQms = new("vmcStoreBundleByodQms");

    public static readonly TerminalType VmcStoreBundleByodStandard = new("vmcStoreBundleByodStandard");

    public static readonly TerminalType VmcStoreBundleCellularQms = new("vmcStoreBundleCellularQms");

    public static readonly TerminalType VmcStoreBundleCellularStandard = new("vmcStoreBundleCellularStandard");

    public static readonly TerminalType VmcStoreBundleWifiQms = new("vmcStoreBundleWifiQms");

    public static readonly TerminalType VmcStoreBundleWifiStandard = new("vmcStoreBundleWifiStandard");

    public static readonly TerminalType VPlus = new("vPlus");

    public static readonly TerminalType Vsb = new("vsb");

    public static readonly TerminalType VsbGreenbeanRecycle = new("vsbGreenbeanRecycle");

    public static readonly TerminalType VsbKaizen = new("vsbKaizen");

    public static readonly TerminalType VsbOrderbridge = new("vsbOrderbridge");

    public static readonly TerminalType VsbPhonixManagedNetwork = new("vsbPhonixManagedNetwork");

    public static readonly TerminalType VsbSamurai = new("vsbSamurai");

    public static readonly TerminalType VsbVisat = new("vsbVisat");

    public static readonly TerminalType VsbWiretrust = new("vsbWiretrust");

    public static readonly TerminalType VsbXgateway = new("vsbXgateway");

    public static readonly TerminalType WandGift = new("wandGift");

    public static readonly TerminalType WaySystemsMtt5000 = new("waySystemsMtt5000");

    public static readonly TerminalType WendysCom = new("wendysCom");

    public static readonly TerminalType Whirl = new("whirl");

    public static readonly TerminalType Winn610S = new("winn610s");

    public static readonly TerminalType XpaySoftware = new("xpaySoftware");

    public static readonly TerminalType Xpient610 = new("xpient610");

    public static readonly TerminalType XpientSolutions = new("xpientSolutions");

    public TResult Match<TResult>(Func<TResult> on_125158Llc,
        Func<TResult> on_3Delta,
        Func<TResult> on_3DeltaPws,
        Func<TResult> on_911SoftwareCreditline,
        Func<TResult> onAbcLiquors,
        Func<TResult> onAbc610Se,
        Func<TResult> onAchDirect,
        Func<TResult> onAciRcsSwitch,
        Func<TResult> onAcoSoftware,
        Func<TResult> onActivantFalcon,
        Func<TResult> onAdsGilbarco,
        Func<TResult> onAdvancedMobilePayment,
        Func<TResult> onAdyen,
        Func<TResult> onAhcc,
        Func<TResult> onAjb,
        Func<TResult> onAjbFipayDirectTandem,
        Func<TResult> onAjbIcip610,
        Func<TResult> onAjbRtsIbm,
        Func<TResult> onAjbRtsTandem,
        Func<TResult> onAjbBevn,
        Func<TResult> onAjbRue21,
        Func<TResult> onAjbSpoch,
        Func<TResult> onAllureGlobal,
        Func<TResult> onAlohaEnhanced610,
        Func<TResult> onAlohaTerm,
        Func<TResult> onAprivaGateway,
        Func<TResult> onAprivaIwl255,
        Func<TResult> onApriva610,
        Func<TResult> onAprivapayAtt,
        Func<TResult> onAprivapayMobile,
        Func<TResult> onAptosEpicorRetail,
        Func<TResult> onAscom,
        Func<TResult> onAsig,
        Func<TResult> onAurus,
        Func<TResult> onAuthorizeNet,
        Func<TResult> onAutomatedCashSystems,
        Func<TResult> onB2KSystems,
        Func<TResult> onBevnSoftware,
        Func<TResult> onBillabong,
        Func<TResult> onBncb,
        Func<TResult> onBobEvans610,
        Func<TResult> onBookstoreManager,
        Func<TResult> onBoost2Delta,
        Func<TResult> onBoostBoraPayer,
        Func<TResult> onBoostDirectInsite,
        Func<TResult> onBoostMpg,
        Func<TResult> onBreakawayVisionPos,
        Func<TResult> onBridgepay,
        Func<TResult> onBrinkSoftware,
        Func<TResult> onBuyAtab,
        Func<TResult> onCaclGift,
        Func<TResult> onCardinalHealth610,
        Func<TResult> onCayan,
        Func<TResult> onCcciWebsite,
        Func<TResult> onCdsGlobalPaydq,
        Func<TResult> onCenposHostCapture,
        Func<TResult> onCenposIsoEmd,
        Func<TResult> onCfre610,
        Func<TResult> onChargePayments,
        Func<TResult> onChargesmartPaywareConnect,
        Func<TResult> onChrb610,
        Func<TResult> onChsp,
        Func<TResult> onCkfrIntrixSupercharge,
        Func<TResult> onClre610Salepoint,
        Func<TResult> onComdataSmartdesq,
        Func<TResult> onCommerciant,
        Func<TResult> onCrackerBarrel,
        Func<TResult> onCrainAtlanta,
        Func<TResult> onCraneVendingServices,
        Func<TResult> onCreditCall,
        Func<TResult> onCtrSystems,
        Func<TResult> onCubicPaymentApplication,
        Func<TResult> onCyberSource,
        Func<TResult> onCyberSourceVsntConversion,
        Func<TResult> onCyberSourceVsntResellerBasic,
        Func<TResult> onCyberSourceVsntResellerPremier,
        Func<TResult> onDataBusnessSystems,
        Func<TResult> onDataCap,
        Func<TResult> onDataCapDialTran,
        Func<TResult> onDataCapEpayRepro,
        Func<TResult> onDataCapGiftEpay,
        Func<TResult> onDataCapIpTran,
        Func<TResult> onDataCapIpTranLt,
        Func<TResult> onDataCapIpTranLtMoble,
        Func<TResult> onDataCapNetEpay,
        Func<TResult> onDataCapTranRepro,
        Func<TResult> onDataCapTwinTran,
        Func<TResult> onDataCapTwinTxnServer,
        Func<TResult> onDataVantage,
        Func<TResult> onDataVantageFnln610,
        Func<TResult> onDbsTplusEnHanced,
        Func<TResult> onDbsTransactionPlus,
        Func<TResult> onDealBird,
        Func<TResult> onDejavoo,
        Func<TResult> onDelego,
        Func<TResult> onDigicom,
        Func<TResult> onDirectInsite,
        Func<TResult> onDiscGoTech,
        Func<TResult> onDl610Snt,
        Func<TResult> onDlglVarSoftware,
        Func<TResult> onDlgl610S,
        Func<TResult> onDominosAci,
        Func<TResult> onEcommercePlus,
        Func<TResult> onEdgil,
        Func<TResult> onEesCompanies,
        Func<TResult> onElavonEnConcert610,
        Func<TResult> onElavonFuseboxGateway,
        Func<TResult> onElavonProtobase,
        Func<TResult> onElavonPayments,
        Func<TResult> onElpl610R,
        Func<TResult> onEpayHealthcareMonetra,
        Func<TResult> onEquinox,
        Func<TResult> onEsdCard,
        Func<TResult> onEatouch,
        Func<TResult> onExatouchVsb,
        Func<TResult> onExit41,
        Func<TResult> onExpressTriPos,
        Func<TResult> onEzDine,
        Func<TResult> onEzRetail,
        Func<TResult> onFandango,
        Func<TResult> onFirstGlobalBillingSapwalletVsb,
        Func<TResult> onFitb610S,
        Func<TResult> onFredmeyr610,
        Func<TResult> onFreedomPay,
        Func<TResult> onFtniGatewayEtran,
        Func<TResult> onFuturePosVsb,
        Func<TResult> onGambleidTsevo,
        Func<TResult> onGiftango,
        Func<TResult> onGivex,
        Func<TResult> onGmsPaymentGateway,
        Func<TResult> onGmsPajb,
        Func<TResult> onGnctSoftware,
        Func<TResult> onGoEMerchant,
        Func<TResult> onGovolution,
        Func<TResult> onGrantStreet,
        Func<TResult> onGreatLakesScrip,
        Func<TResult> onGreatLakesScripVar,
        Func<TResult> onGsiCommerce,
        Func<TResult> onHandpoint,
        Func<TResult> onHarleyOwnersGroup,
        Func<TResult> onHighradius,
        Func<TResult> onHp,
        Func<TResult> onHypercom5500M,
        Func<TResult> onHypercomPaymentServer,
        Func<TResult> onHypercomT4205,
        Func<TResult> onHypercomT4205E2E,
        Func<TResult> onHypercomT4210,
        Func<TResult> onHypercomT4210E2E,
        Func<TResult> onHypercom4220Dial,
        Func<TResult> onHypercom4220DialE2E,
        Func<TResult> onHypercom4220Ssl,
        Func<TResult> onHypercom4220SslE2E,
        Func<TResult> onI2CVsb,
        Func<TResult> onIbmace,
        Func<TResult> onIcVerify,
        Func<TResult> onIncentPay,
        Func<TResult> onIndex,
        Func<TResult> onIngenico610,
        Func<TResult> onIngenico720,
        Func<TResult> onIngenicoIct2203XDial,
        Func<TResult> onIngenicoIct2203XDialE2Ee,
        Func<TResult> onIngenicoIct2203XDialPilot,
        Func<TResult> onIngenicoIct2203XSsl,
        Func<TResult> onIngenicoIct2203XSslE2Ee,
        Func<TResult> onIngenicoIct2203XSslPilot,
        Func<TResult> onIngenicoIct220Ctls3XDial,
        Func<TResult> onIngenicoIct220Ctls3XDialEe2E,
        Func<TResult> onIngenicoIct220Ctls3XSsl,
        Func<TResult> onIngenicoIct220Ctls3XSslE2Ee,
        Func<TResult> onIngenicoIct2503XDial,
        Func<TResult> onIngenicoIct2503XDialE2Ee,
        Func<TResult> onIngenicoIct2503XSsl,
        Func<TResult> onIngenicoIct2503XSsle2Ee,
        Func<TResult> onIngenicoIwl222BtDial,
        Func<TResult> onIngenicoIwl222BtDialE2Ee,
        Func<TResult> onIngenicoIwl222BtSsl,
        Func<TResult> onIngenicoIwl222BtSSlE2Ee,
        Func<TResult> onIngenicoIwl252BtDial,
        Func<TResult> onIngenicoIw252BtDialE2Ee,
        Func<TResult> onIngenicoIw252BtSsl,
        Func<TResult> onIngenicoIw252BtSslE2Ee,
        Func<TResult> onIngenicoIw2553G,
        Func<TResult> onIngenicoIw2553GE2Ee,
        Func<TResult> onIngenicoSiEnterprise,
        Func<TResult> onInstamed,
        Func<TResult> onIpayGateway,
        Func<TResult> onIsd,
        Func<TResult> onIslandPacific,
        Func<TResult> onIsvOpenmotionVsb,
        Func<TResult> onIsv510,
        Func<TResult> onIsv600,
        Func<TResult> onIsv610,
        Func<TResult> onIsvVsk,
        Func<TResult> onItransact,
        Func<TResult> onJewlSoftware,
        Func<TResult> onJockeyEcomm,
        Func<TResult> onJockeyRetail,
        Func<TResult> onKachyng,
        Func<TResult> onKlik,
        Func<TResult> onKmartGift,
        Func<TResult> onKubra,
        Func<TResult> onLightYear,
        Func<TResult> onLinked2Pay,
        Func<TResult> onLongRangeSystemsLrs,
        Func<TResult> onLumberVisaK,
        Func<TResult> onLumgPos,
        Func<TResult> onMagicWrighter,
        Func<TResult> onMagnetCardServices,
        Func<TResult> onMainstreetMonetra510,
        Func<TResult> onMainstreetMonetra610,
        Func<TResult> onMastercardOpenapi,
        Func<TResult> onMastercardPaymentGateway,
        Func<TResult> onMeiApriva,
        Func<TResult> onMenusoftDigitalDining,
        Func<TResult> onMerchantLinkCdg,
        Func<TResult> onMerchantLinkCredit,
        Func<TResult> onMeritSolar,
        Func<TResult> onMicrosSymphony,
        Func<TResult> onMicrosalePos,
        Func<TResult> onMidniteExpressSlipstream,
        Func<TResult> onMightyTicket,
        Func<TResult> onMilleniumRetailSolutions,
        Func<TResult> onMobileAccept,
        Func<TResult> onMobileAcceptFlatRate,
        Func<TResult> onMobileCheckoutQms,
        Func<TResult> onMobileCheckoutStandard,
        Func<TResult> onMonetraAuth,
        Func<TResult> onMonroMuffler,
        Func<TResult> onMpayGateway,
        Func<TResult> onMtxepsWineps,
        Func<TResult> onMvsp,
        Func<TResult> onNcrAdvancedRestaurant,
        Func<TResult> onNcrCinema,
        Func<TResult> onNcrCounterpoint510,
        Func<TResult> onNcrCounterpoint610,
        Func<TResult> onNcrRetalixConnectedPayments,
        Func<TResult> onNcrSilver,
        Func<TResult> onNcrSilverPro,
        Func<TResult> onNcrSilverProQms,
        Func<TResult> onNeoGames610,
        Func<TResult> onNetworkMerchants,
        Func<TResult> onNsbEps,
        Func<TResult> onNourdersOdp,
        Func<TResult> onNurit2159,
        Func<TResult> onNurit8400EDial,
        Func<TResult> onOCharleys,
        Func<TResult> onOlo,
        Func<TResult> onOpConnect,
        Func<TResult> onOptimalPaymentsGateway,
        Func<TResult> onOrccCollectPay,
        Func<TResult> onOrccAciWorldwide,
        Func<TResult> onOrderTalk,
        Func<TResult> onPaVitalcheck,
        Func<TResult> onPaFidelityExpress,
        Func<TResult> onPaGrantStreet,
        Func<TResult> onParkmobile,
        Func<TResult> onPaxSp30Casio,
        Func<TResult> onPayGov,
        Func<TResult> onPaydiantSj,
        Func<TResult> onPayFirstEdcVpos,
        Func<TResult> onPaypalPayflowLink,
        Func<TResult> onPaypalPayflowLinkReseller,
        Func<TResult> onPaypalPayflowPro,
        Func<TResult> onPaypalPayflowProReseller,
        Func<TResult> onPayright,
        Func<TResult> onPaytechVsb,
        Func<TResult> onPcAmerica,
        Func<TResult> onPlstq610,
        Func<TResult> onPlugNPlay,
        Func<TResult> onPoynt,
        Func<TResult> onPrecida,
        Func<TResult> onPricetonCardConnect,
        Func<TResult> onPrincetonEcommCollectpay,
        Func<TResult> onPrincetonPayments,
        Func<TResult> onPrincetonPayware,
        Func<TResult> onPropSoftware,
        Func<TResult> onPurecommerceVsb,
        Func<TResult> onPxpSolutionsRetail,
        Func<TResult> onRediantRposLighthouse,
        Func<TResult> onRainbowApparel,
        Func<TResult> onRdyc610S,
        Func<TResult> onRedOakPs,
        Func<TResult> onRedfinNetwork,
        Func<TResult> onRemcoSoftware,
        Func<TResult> onRentACenter,
        Func<TResult> onReproOnlyIngIct220Dial,
        Func<TResult> onReproOnlyIngIct220DialE2Ee,
        Func<TResult> onReproOnlyIngIct220SslE2Ee,
        Func<TResult> onReproOnlyIngIct250Dial,
        Func<TResult> onReproOnlyIngIct250DialE2Ee,
        Func<TResult> onReproOnlyIngIct250Ssl,
        Func<TResult> onReproOnlyIngIct250SslE2Ee,
        Func<TResult> onReproOnlyVerifoneVx520DcDial,
        Func<TResult> onReproOnlyVerifoneVx520DcSsl,
        Func<TResult> onReproOnlyVerifoneVx520DialCtls,
        Func<TResult> onReproOnlyVerifoneVx520SslCtls,
        Func<TResult> onRetrieverSoftware,
        Func<TResult> onRevlinkCollect,
        Func<TResult> onRevtrak,
        Func<TResult> onReamMobile,
        Func<TResult> onRoamMobileTest,
        Func<TResult> onRoamData,
        Func<TResult> onSalepoint,
        Func<TResult> onSalepointClaires,
        Func<TResult> onSbcSolutions,
        Func<TResult> onSecureTrading,
        Func<TResult> onSequoiaRetialSystems,
        Func<TResult> onShci610,
        Func<TResult> onShift4OnTheNet,
        Func<TResult> onSightlinePayments,
        Func<TResult> onSlimCdEntNonReseller,
        Func<TResult> onSlimCdEnterprise,
        Func<TResult> onSlimCdPro,
        Func<TResult> onSlimCdProNonReseller,
        Func<TResult> onSnlh610,
        Func<TResult> onSouthernDataComm,
        Func<TResult> onSpsEzpay,
        Func<TResult> onSquirrelSystems,
        Func<TResult> onSter610,
        Func<TResult> onStorisVision9,
        Func<TResult> onStstSoftware,
        Func<TResult> onTalbots,
        Func<TResult> onTangiblePayments,
        Func<TResult> onTapToPayIphone,
        Func<TResult> onTenderRetail,
        Func<TResult> onTillster,
        Func<TResult> onTnspayGateway,
        Func<TResult> onToast,
        Func<TResult> onToyzPos,
        Func<TResult> onTransactionWirelessSvs,
        Func<TResult> onTransax,
        Func<TResult> onTranzgate,
        Func<TResult> onTrem610,
        Func<TResult> onTriversity,
        Func<TResult> onTriversityPos,
        Func<TResult> onTrustcommVault610,
        Func<TResult> onTrustcommVault600,
        Func<TResult> onTrustcommerce2011,
        Func<TResult> onTsysAmexPipPcSoftware,
        Func<TResult> onTsysAmexPipTerminal,
        Func<TResult> onTsysDialPay,
        Func<TResult> onTsysPosPort,
        Func<TResult> onTwitpay,
        Func<TResult> onUhaul,
        Func<TResult> onUicBezel8,
        Func<TResult> onUpSolution610,
        Func<TResult> onUsaEpay,
        Func<TResult> onUsfs,
        Func<TResult> onVentek,
        Func<TResult> onVerifone,
        Func<TResult> onVerifone510Terminal,
        Func<TResult> onVerifone600Terminal,
        Func<TResult> onVerifone610,
        Func<TResult> onVerifoneOmni3200,
        Func<TResult> onVerifonePaywareConnect,
        Func<TResult> onVerifonePaywareMobile,
        Func<TResult> onVerifonePaywarePc,
        Func<TResult> onVerifonePaywareTranactRita,
        Func<TResult> onVerifonePcChargeGoSoftware,
        Func<TResult> onVerifonePoint,
        Func<TResult> onVerifonePointEntMx,
        Func<TResult> onVerifonePointEntVx,
        Func<TResult> onVerifoneRuby,
        Func<TResult> onVerifoneVx510,
        Func<TResult> onVerifoneVx510DcDial,
        Func<TResult> onVerifoneVx510DcIp,
        Func<TResult> onVerifoneVx510DcSsl,
        Func<TResult> onVerifoneVx510Le,
        Func<TResult> onVerifoneVx520DcDialCtlsE2Ee,
        Func<TResult> onVerifoneVx520DcDialE2Ee,
        Func<TResult> onVerifoneVx520DcIp1,
        Func<TResult> onVerifoneVx520DcIp2,
        Func<TResult> onVerifoneVx520DcIpCtls,
        Func<TResult> onVerifoneVx520DcIpCtlsE2Ee,
        Func<TResult> onVerifoneVx520DcSslCtlsE2Ee,
        Func<TResult> onVerifoneVx520DcSslE2Ee,
        Func<TResult> onVerifoneVx520DialOnly,
        Func<TResult> onVerifoneVx570Dial,
        Func<TResult> onVerifoneVx570Ip,
        Func<TResult> onVerifoneVx570Ssl,
        Func<TResult> onVerifoneVx6803GGprs,
        Func<TResult> onVicoSoftware,
        Func<TResult> onVirtualTerminal,
        Func<TResult> onVistaEntertainment,
        Func<TResult> onVitalcheck,
        Func<TResult> onVmcAddOnAndroidByodQmd,
        Func<TResult> onVmcAddOnAndroidByodStandard,
        Func<TResult> onVmcAddOnBundleByodQms,
        Func<TResult> onVmcAddOnBundleByodStandard,
        Func<TResult> onVmcAddOnBundleCellularQmd,
        Func<TResult> onVmcAddOnBundleCellularStandard,
        Func<TResult> onVmcAddOnBundleWifiQmd,
        Func<TResult> onVmcAddOnBundleWifiStandard,
        Func<TResult> onVmcFieldBundleByodQmd,
        Func<TResult> onVmcFieldBundleByodStandard,
        Func<TResult> onVmcFieldBundleCellularQms,
        Func<TResult> onVmcFieldBundleCellularStandard,
        Func<TResult> onVmcStoreAndroidByodQms,
        Func<TResult> onVmcStoreAndroidByodStandard,
        Func<TResult> onVmcStoreBundleByodQms,
        Func<TResult> onVmcStoreBundleByodStandard,
        Func<TResult> onVmcStoreBundleCellularQms,
        Func<TResult> onVmcStoreBundleCellularStandard,
        Func<TResult> onVmcStoreBundleWifiQms,
        Func<TResult> onVmcStoreBundleWifiStandard,
        Func<TResult> onVPlus,
        Func<TResult> onVsb,
        Func<TResult> onVsbGreenbeanRecycle,
        Func<TResult> onVsbKaizen,
        Func<TResult> onVsbOrderbridge,
        Func<TResult> onVsbPhonixManagedNetwork,
        Func<TResult> onVsbSamurai,
        Func<TResult> onVsbVisat,
        Func<TResult> onVsbWiretrust,
        Func<TResult> onVsbXgateway,
        Func<TResult> onWandGift,
        Func<TResult> onWaySystemsMtt5000,
        Func<TResult> onWendysCom,
        Func<TResult> onWhirl,
        Func<TResult> onWinn610S,
        Func<TResult> onXpaySoftware,
        Func<TResult> onXpient610,
        Func<TResult> onXpientSolutions,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _125158Llc => on_125158Llc(),
            _ when this == _3Delta => on_3Delta(),
            _ when this == _3DeltaPws => on_3DeltaPws(),
            _ when this == _911SoftwareCreditline => on_911SoftwareCreditline(),
            _ when this == AbcLiquors => onAbcLiquors(),
            _ when this == Abc610Se => onAbc610Se(),
            _ when this == AchDirect => onAchDirect(),
            _ when this == AciRcsSwitch => onAciRcsSwitch(),
            _ when this == AcoSoftware => onAcoSoftware(),
            _ when this == ActivantFalcon => onActivantFalcon(),
            _ when this == AdsGilbarco => onAdsGilbarco(),
            _ when this == AdvancedMobilePayment => onAdvancedMobilePayment(),
            _ when this == Adyen => onAdyen(),
            _ when this == Ahcc => onAhcc(),
            _ when this == Ajb => onAjb(),
            _ when this == AjbFipayDirectTandem => onAjbFipayDirectTandem(),
            _ when this == AjbIcip610 => onAjbIcip610(),
            _ when this == AjbRtsIbm => onAjbRtsIbm(),
            _ when this == AjbRtsTandem => onAjbRtsTandem(),
            _ when this == AjbBevn => onAjbBevn(),
            _ when this == AjbRue21 => onAjbRue21(),
            _ when this == AjbSpoch => onAjbSpoch(),
            _ when this == AllureGlobal => onAllureGlobal(),
            _ when this == AlohaEnhanced610 => onAlohaEnhanced610(),
            _ when this == AlohaTerm => onAlohaTerm(),
            _ when this == AprivaGateway => onAprivaGateway(),
            _ when this == AprivaIwl255 => onAprivaIwl255(),
            _ when this == Apriva610 => onApriva610(),
            _ when this == AprivapayAtt => onAprivapayAtt(),
            _ when this == AprivapayMobile => onAprivapayMobile(),
            _ when this == AptosEpicorRetail => onAptosEpicorRetail(),
            _ when this == Ascom => onAscom(),
            _ when this == Asig => onAsig(),
            _ when this == Aurus => onAurus(),
            _ when this == AuthorizeNet => onAuthorizeNet(),
            _ when this == AutomatedCashSystems => onAutomatedCashSystems(),
            _ when this == B2KSystems => onB2KSystems(),
            _ when this == BevnSoftware => onBevnSoftware(),
            _ when this == Billabong => onBillabong(),
            _ when this == Bncb => onBncb(),
            _ when this == BobEvans610 => onBobEvans610(),
            _ when this == BookstoreManager => onBookstoreManager(),
            _ when this == Boost2Delta => onBoost2Delta(),
            _ when this == BoostBoraPayer => onBoostBoraPayer(),
            _ when this == BoostDirectInsite => onBoostDirectInsite(),
            _ when this == BoostMpg => onBoostMpg(),
            _ when this == BreakawayVisionPos => onBreakawayVisionPos(),
            _ when this == Bridgepay => onBridgepay(),
            _ when this == BrinkSoftware => onBrinkSoftware(),
            _ when this == BuyAtab => onBuyAtab(),
            _ when this == CaclGift => onCaclGift(),
            _ when this == CardinalHealth610 => onCardinalHealth610(),
            _ when this == Cayan => onCayan(),
            _ when this == CcciWebsite => onCcciWebsite(),
            _ when this == CdsGlobalPaydq => onCdsGlobalPaydq(),
            _ when this == CenposHostCapture => onCenposHostCapture(),
            _ when this == CenposIsoEmd => onCenposIsoEmd(),
            _ when this == Cfre610 => onCfre610(),
            _ when this == ChargePayments => onChargePayments(),
            _ when this == ChargesmartPaywareConnect => onChargesmartPaywareConnect(),
            _ when this == Chrb610 => onChrb610(),
            _ when this == Chsp => onChsp(),
            _ when this == CkfrIntrixSupercharge => onCkfrIntrixSupercharge(),
            _ when this == Clre610Salepoint => onClre610Salepoint(),
            _ when this == ComdataSmartdesq => onComdataSmartdesq(),
            _ when this == Commerciant => onCommerciant(),
            _ when this == CrackerBarrel => onCrackerBarrel(),
            _ when this == CrainAtlanta => onCrainAtlanta(),
            _ when this == CraneVendingServices => onCraneVendingServices(),
            _ when this == CreditCall => onCreditCall(),
            _ when this == CtrSystems => onCtrSystems(),
            _ when this == CubicPaymentApplication => onCubicPaymentApplication(),
            _ when this == CyberSource => onCyberSource(),
            _ when this == CyberSourceVsntConversion => onCyberSourceVsntConversion(),
            _ when this == CyberSourceVsntResellerBasic => onCyberSourceVsntResellerBasic(),
            _ when this == CyberSourceVsntResellerPremier => onCyberSourceVsntResellerPremier(),
            _ when this == DataBusnessSystems => onDataBusnessSystems(),
            _ when this == DataCap => onDataCap(),
            _ when this == DataCapDialTran => onDataCapDialTran(),
            _ when this == DataCapEpayRepro => onDataCapEpayRepro(),
            _ when this == DataCapGiftEpay => onDataCapGiftEpay(),
            _ when this == DataCapIpTran => onDataCapIpTran(),
            _ when this == DataCapIpTranLt => onDataCapIpTranLt(),
            _ when this == DataCapIpTranLtMoble => onDataCapIpTranLtMoble(),
            _ when this == DataCapNetEpay => onDataCapNetEpay(),
            _ when this == DataCapTranRepro => onDataCapTranRepro(),
            _ when this == DataCapTwinTran => onDataCapTwinTran(),
            _ when this == DataCapTwinTxnServer => onDataCapTwinTxnServer(),
            _ when this == DataVantage => onDataVantage(),
            _ when this == DataVantageFnln610 => onDataVantageFnln610(),
            _ when this == DbsTplusEnHanced => onDbsTplusEnHanced(),
            _ when this == DbsTransactionPlus => onDbsTransactionPlus(),
            _ when this == DealBird => onDealBird(),
            _ when this == Dejavoo => onDejavoo(),
            _ when this == Delego => onDelego(),
            _ when this == Digicom => onDigicom(),
            _ when this == DirectInsite => onDirectInsite(),
            _ when this == DiscGoTech => onDiscGoTech(),
            _ when this == Dl610Snt => onDl610Snt(),
            _ when this == DlglVarSoftware => onDlglVarSoftware(),
            _ when this == Dlgl610S => onDlgl610S(),
            _ when this == DominosAci => onDominosAci(),
            _ when this == EcommercePlus => onEcommercePlus(),
            _ when this == Edgil => onEdgil(),
            _ when this == EesCompanies => onEesCompanies(),
            _ when this == ElavonEnConcert610 => onElavonEnConcert610(),
            _ when this == ElavonFuseboxGateway => onElavonFuseboxGateway(),
            _ when this == ElavonProtobase => onElavonProtobase(),
            _ when this == ElavonPayments => onElavonPayments(),
            _ when this == Elpl610R => onElpl610R(),
            _ when this == EpayHealthcareMonetra => onEpayHealthcareMonetra(),
            _ when this == Equinox => onEquinox(),
            _ when this == EsdCard => onEsdCard(),
            _ when this == Eatouch => onEatouch(),
            _ when this == ExatouchVsb => onExatouchVsb(),
            _ when this == Exit41 => onExit41(),
            _ when this == ExpressTriPos => onExpressTriPos(),
            _ when this == EzDine => onEzDine(),
            _ when this == EzRetail => onEzRetail(),
            _ when this == Fandango => onFandango(),
            _ when this == FirstGlobalBillingSapwalletVsb => onFirstGlobalBillingSapwalletVsb(),
            _ when this == Fitb610S => onFitb610S(),
            _ when this == Fredmeyr610 => onFredmeyr610(),
            _ when this == FreedomPay => onFreedomPay(),
            _ when this == FtniGatewayEtran => onFtniGatewayEtran(),
            _ when this == FuturePosVsb => onFuturePosVsb(),
            _ when this == GambleidTsevo => onGambleidTsevo(),
            _ when this == Giftango => onGiftango(),
            _ when this == Givex => onGivex(),
            _ when this == GmsPaymentGateway => onGmsPaymentGateway(),
            _ when this == GmsPajb => onGmsPajb(),
            _ when this == GnctSoftware => onGnctSoftware(),
            _ when this == GoEMerchant => onGoEMerchant(),
            _ when this == Govolution => onGovolution(),
            _ when this == GrantStreet => onGrantStreet(),
            _ when this == GreatLakesScrip => onGreatLakesScrip(),
            _ when this == GreatLakesScripVar => onGreatLakesScripVar(),
            _ when this == GsiCommerce => onGsiCommerce(),
            _ when this == Handpoint => onHandpoint(),
            _ when this == HarleyOwnersGroup => onHarleyOwnersGroup(),
            _ when this == Highradius => onHighradius(),
            _ when this == Hp => onHp(),
            _ when this == Hypercom5500M => onHypercom5500M(),
            _ when this == HypercomPaymentServer => onHypercomPaymentServer(),
            _ when this == HypercomT4205 => onHypercomT4205(),
            _ when this == HypercomT4205E2E => onHypercomT4205E2E(),
            _ when this == HypercomT4210 => onHypercomT4210(),
            _ when this == HypercomT4210E2E => onHypercomT4210E2E(),
            _ when this == Hypercom4220Dial => onHypercom4220Dial(),
            _ when this == Hypercom4220DialE2E => onHypercom4220DialE2E(),
            _ when this == Hypercom4220Ssl => onHypercom4220Ssl(),
            _ when this == Hypercom4220SslE2E => onHypercom4220SslE2E(),
            _ when this == I2CVsb => onI2CVsb(),
            _ when this == Ibmace => onIbmace(),
            _ when this == IcVerify => onIcVerify(),
            _ when this == IncentPay => onIncentPay(),
            _ when this == Index => onIndex(),
            _ when this == Ingenico610 => onIngenico610(),
            _ when this == Ingenico720 => onIngenico720(),
            _ when this == IngenicoIct2203XDial => onIngenicoIct2203XDial(),
            _ when this == IngenicoIct2203XDialE2Ee => onIngenicoIct2203XDialE2Ee(),
            _ when this == IngenicoIct2203XDialPilot => onIngenicoIct2203XDialPilot(),
            _ when this == IngenicoIct2203XSsl => onIngenicoIct2203XSsl(),
            _ when this == IngenicoIct2203XSslE2Ee => onIngenicoIct2203XSslE2Ee(),
            _ when this == IngenicoIct2203XSslPilot => onIngenicoIct2203XSslPilot(),
            _ when this == IngenicoIct220Ctls3XDial => onIngenicoIct220Ctls3XDial(),
            _ when this == IngenicoIct220Ctls3XDialEe2E => onIngenicoIct220Ctls3XDialEe2E(),
            _ when this == IngenicoIct220Ctls3XSsl => onIngenicoIct220Ctls3XSsl(),
            _ when this == IngenicoIct220Ctls3XSslE2Ee => onIngenicoIct220Ctls3XSslE2Ee(),
            _ when this == IngenicoIct2503XDial => onIngenicoIct2503XDial(),
            _ when this == IngenicoIct2503XDialE2Ee => onIngenicoIct2503XDialE2Ee(),
            _ when this == IngenicoIct2503XSsl => onIngenicoIct2503XSsl(),
            _ when this == IngenicoIct2503XSsle2Ee => onIngenicoIct2503XSsle2Ee(),
            _ when this == IngenicoIwl222BtDial => onIngenicoIwl222BtDial(),
            _ when this == IngenicoIwl222BtDialE2Ee => onIngenicoIwl222BtDialE2Ee(),
            _ when this == IngenicoIwl222BtSsl => onIngenicoIwl222BtSsl(),
            _ when this == IngenicoIwl222BtSSlE2Ee => onIngenicoIwl222BtSSlE2Ee(),
            _ when this == IngenicoIwl252BtDial => onIngenicoIwl252BtDial(),
            _ when this == IngenicoIw252BtDialE2Ee => onIngenicoIw252BtDialE2Ee(),
            _ when this == IngenicoIw252BtSsl => onIngenicoIw252BtSsl(),
            _ when this == IngenicoIw252BtSslE2Ee => onIngenicoIw252BtSslE2Ee(),
            _ when this == IngenicoIw2553G => onIngenicoIw2553G(),
            _ when this == IngenicoIw2553GE2Ee => onIngenicoIw2553GE2Ee(),
            _ when this == IngenicoSiEnterprise => onIngenicoSiEnterprise(),
            _ when this == Instamed => onInstamed(),
            _ when this == IpayGateway => onIpayGateway(),
            _ when this == Isd => onIsd(),
            _ when this == IslandPacific => onIslandPacific(),
            _ when this == IsvOpenmotionVsb => onIsvOpenmotionVsb(),
            _ when this == Isv510 => onIsv510(),
            _ when this == Isv600 => onIsv600(),
            _ when this == Isv610 => onIsv610(),
            _ when this == IsvVsk => onIsvVsk(),
            _ when this == Itransact => onItransact(),
            _ when this == JewlSoftware => onJewlSoftware(),
            _ when this == JockeyEcomm => onJockeyEcomm(),
            _ when this == JockeyRetail => onJockeyRetail(),
            _ when this == Kachyng => onKachyng(),
            _ when this == Klik => onKlik(),
            _ when this == KmartGift => onKmartGift(),
            _ when this == Kubra => onKubra(),
            _ when this == LightYear => onLightYear(),
            _ when this == Linked2Pay => onLinked2Pay(),
            _ when this == LongRangeSystemsLrs => onLongRangeSystemsLrs(),
            _ when this == LumberVisaK => onLumberVisaK(),
            _ when this == LumgPos => onLumgPos(),
            _ when this == MagicWrighter => onMagicWrighter(),
            _ when this == MagnetCardServices => onMagnetCardServices(),
            _ when this == MainstreetMonetra510 => onMainstreetMonetra510(),
            _ when this == MainstreetMonetra610 => onMainstreetMonetra610(),
            _ when this == MastercardOpenapi => onMastercardOpenapi(),
            _ when this == MastercardPaymentGateway => onMastercardPaymentGateway(),
            _ when this == MeiApriva => onMeiApriva(),
            _ when this == MenusoftDigitalDining => onMenusoftDigitalDining(),
            _ when this == MerchantLinkCdg => onMerchantLinkCdg(),
            _ when this == MerchantLinkCredit => onMerchantLinkCredit(),
            _ when this == MeritSolar => onMeritSolar(),
            _ when this == MicrosSymphony => onMicrosSymphony(),
            _ when this == MicrosalePos => onMicrosalePos(),
            _ when this == MidniteExpressSlipstream => onMidniteExpressSlipstream(),
            _ when this == MightyTicket => onMightyTicket(),
            _ when this == MilleniumRetailSolutions => onMilleniumRetailSolutions(),
            _ when this == MobileAccept => onMobileAccept(),
            _ when this == MobileAcceptFlatRate => onMobileAcceptFlatRate(),
            _ when this == MobileCheckoutQms => onMobileCheckoutQms(),
            _ when this == MobileCheckoutStandard => onMobileCheckoutStandard(),
            _ when this == MonetraAuth => onMonetraAuth(),
            _ when this == MonroMuffler => onMonroMuffler(),
            _ when this == MpayGateway => onMpayGateway(),
            _ when this == MtxepsWineps => onMtxepsWineps(),
            _ when this == Mvsp => onMvsp(),
            _ when this == NcrAdvancedRestaurant => onNcrAdvancedRestaurant(),
            _ when this == NcrCinema => onNcrCinema(),
            _ when this == NcrCounterpoint510 => onNcrCounterpoint510(),
            _ when this == NcrCounterpoint610 => onNcrCounterpoint610(),
            _ when this == NcrRetalixConnectedPayments => onNcrRetalixConnectedPayments(),
            _ when this == NcrSilver => onNcrSilver(),
            _ when this == NcrSilverPro => onNcrSilverPro(),
            _ when this == NcrSilverProQms => onNcrSilverProQms(),
            _ when this == NeoGames610 => onNeoGames610(),
            _ when this == NetworkMerchants => onNetworkMerchants(),
            _ when this == NsbEps => onNsbEps(),
            _ when this == NourdersOdp => onNourdersOdp(),
            _ when this == Nurit2159 => onNurit2159(),
            _ when this == Nurit8400EDial => onNurit8400EDial(),
            _ when this == OCharleys => onOCharleys(),
            _ when this == Olo => onOlo(),
            _ when this == OpConnect => onOpConnect(),
            _ when this == OptimalPaymentsGateway => onOptimalPaymentsGateway(),
            _ when this == OrccCollectPay => onOrccCollectPay(),
            _ when this == OrccAciWorldwide => onOrccAciWorldwide(),
            _ when this == OrderTalk => onOrderTalk(),
            _ when this == PaVitalcheck => onPaVitalcheck(),
            _ when this == PaFidelityExpress => onPaFidelityExpress(),
            _ when this == PaGrantStreet => onPaGrantStreet(),
            _ when this == Parkmobile => onParkmobile(),
            _ when this == PaxSp30Casio => onPaxSp30Casio(),
            _ when this == PayGov => onPayGov(),
            _ when this == PaydiantSj => onPaydiantSj(),
            _ when this == PayFirstEdcVpos => onPayFirstEdcVpos(),
            _ when this == PaypalPayflowLink => onPaypalPayflowLink(),
            _ when this == PaypalPayflowLinkReseller => onPaypalPayflowLinkReseller(),
            _ when this == PaypalPayflowPro => onPaypalPayflowPro(),
            _ when this == PaypalPayflowProReseller => onPaypalPayflowProReseller(),
            _ when this == Payright => onPayright(),
            _ when this == PaytechVsb => onPaytechVsb(),
            _ when this == PcAmerica => onPcAmerica(),
            _ when this == Plstq610 => onPlstq610(),
            _ when this == PlugNPlay => onPlugNPlay(),
            _ when this == Poynt => onPoynt(),
            _ when this == Precida => onPrecida(),
            _ when this == PricetonCardConnect => onPricetonCardConnect(),
            _ when this == PrincetonEcommCollectpay => onPrincetonEcommCollectpay(),
            _ when this == PrincetonPayments => onPrincetonPayments(),
            _ when this == PrincetonPayware => onPrincetonPayware(),
            _ when this == PropSoftware => onPropSoftware(),
            _ when this == PurecommerceVsb => onPurecommerceVsb(),
            _ when this == PxpSolutionsRetail => onPxpSolutionsRetail(),
            _ when this == RediantRposLighthouse => onRediantRposLighthouse(),
            _ when this == RainbowApparel => onRainbowApparel(),
            _ when this == Rdyc610S => onRdyc610S(),
            _ when this == RedOakPs => onRedOakPs(),
            _ when this == RedfinNetwork => onRedfinNetwork(),
            _ when this == RemcoSoftware => onRemcoSoftware(),
            _ when this == RentACenter => onRentACenter(),
            _ when this == ReproOnlyIngIct220Dial => onReproOnlyIngIct220Dial(),
            _ when this == ReproOnlyIngIct220DialE2Ee => onReproOnlyIngIct220DialE2Ee(),
            _ when this == ReproOnlyIngIct220SslE2Ee => onReproOnlyIngIct220SslE2Ee(),
            _ when this == ReproOnlyIngIct250Dial => onReproOnlyIngIct250Dial(),
            _ when this == ReproOnlyIngIct250DialE2Ee => onReproOnlyIngIct250DialE2Ee(),
            _ when this == ReproOnlyIngIct250Ssl => onReproOnlyIngIct250Ssl(),
            _ when this == ReproOnlyIngIct250SslE2Ee => onReproOnlyIngIct250SslE2Ee(),
            _ when this == ReproOnlyVerifoneVx520DcDial => onReproOnlyVerifoneVx520DcDial(),
            _ when this == ReproOnlyVerifoneVx520DcSsl => onReproOnlyVerifoneVx520DcSsl(),
            _ when this == ReproOnlyVerifoneVx520DialCtls => onReproOnlyVerifoneVx520DialCtls(),
            _ when this == ReproOnlyVerifoneVx520SslCtls => onReproOnlyVerifoneVx520SslCtls(),
            _ when this == RetrieverSoftware => onRetrieverSoftware(),
            _ when this == RevlinkCollect => onRevlinkCollect(),
            _ when this == Revtrak => onRevtrak(),
            _ when this == ReamMobile => onReamMobile(),
            _ when this == RoamMobileTest => onRoamMobileTest(),
            _ when this == RoamData => onRoamData(),
            _ when this == Salepoint => onSalepoint(),
            _ when this == SalepointClaires => onSalepointClaires(),
            _ when this == SbcSolutions => onSbcSolutions(),
            _ when this == SecureTrading => onSecureTrading(),
            _ when this == SequoiaRetialSystems => onSequoiaRetialSystems(),
            _ when this == Shci610 => onShci610(),
            _ when this == Shift4OnTheNet => onShift4OnTheNet(),
            _ when this == SightlinePayments => onSightlinePayments(),
            _ when this == SlimCdEntNonReseller => onSlimCdEntNonReseller(),
            _ when this == SlimCdEnterprise => onSlimCdEnterprise(),
            _ when this == SlimCdPro => onSlimCdPro(),
            _ when this == SlimCdProNonReseller => onSlimCdProNonReseller(),
            _ when this == Snlh610 => onSnlh610(),
            _ when this == SouthernDataComm => onSouthernDataComm(),
            _ when this == SpsEzpay => onSpsEzpay(),
            _ when this == SquirrelSystems => onSquirrelSystems(),
            _ when this == Ster610 => onSter610(),
            _ when this == StorisVision9 => onStorisVision9(),
            _ when this == StstSoftware => onStstSoftware(),
            _ when this == Talbots => onTalbots(),
            _ when this == TangiblePayments => onTangiblePayments(),
            _ when this == TapToPayIphone => onTapToPayIphone(),
            _ when this == TenderRetail => onTenderRetail(),
            _ when this == Tillster => onTillster(),
            _ when this == TnspayGateway => onTnspayGateway(),
            _ when this == Toast => onToast(),
            _ when this == ToyzPos => onToyzPos(),
            _ when this == TransactionWirelessSvs => onTransactionWirelessSvs(),
            _ when this == Transax => onTransax(),
            _ when this == Tranzgate => onTranzgate(),
            _ when this == Trem610 => onTrem610(),
            _ when this == Triversity => onTriversity(),
            _ when this == TriversityPos => onTriversityPos(),
            _ when this == TrustcommVault610 => onTrustcommVault610(),
            _ when this == TrustcommVault600 => onTrustcommVault600(),
            _ when this == Trustcommerce2011 => onTrustcommerce2011(),
            _ when this == TsysAmexPipPcSoftware => onTsysAmexPipPcSoftware(),
            _ when this == TsysAmexPipTerminal => onTsysAmexPipTerminal(),
            _ when this == TsysDialPay => onTsysDialPay(),
            _ when this == TsysPosPort => onTsysPosPort(),
            _ when this == Twitpay => onTwitpay(),
            _ when this == Uhaul => onUhaul(),
            _ when this == UicBezel8 => onUicBezel8(),
            _ when this == UpSolution610 => onUpSolution610(),
            _ when this == UsaEpay => onUsaEpay(),
            _ when this == Usfs => onUsfs(),
            _ when this == Ventek => onVentek(),
            _ when this == Verifone => onVerifone(),
            _ when this == Verifone510Terminal => onVerifone510Terminal(),
            _ when this == Verifone600Terminal => onVerifone600Terminal(),
            _ when this == Verifone610 => onVerifone610(),
            _ when this == VerifoneOmni3200 => onVerifoneOmni3200(),
            _ when this == VerifonePaywareConnect => onVerifonePaywareConnect(),
            _ when this == VerifonePaywareMobile => onVerifonePaywareMobile(),
            _ when this == VerifonePaywarePc => onVerifonePaywarePc(),
            _ when this == VerifonePaywareTranactRita => onVerifonePaywareTranactRita(),
            _ when this == VerifonePcChargeGoSoftware => onVerifonePcChargeGoSoftware(),
            _ when this == VerifonePoint => onVerifonePoint(),
            _ when this == VerifonePointEntMx => onVerifonePointEntMx(),
            _ when this == VerifonePointEntVx => onVerifonePointEntVx(),
            _ when this == VerifoneRuby => onVerifoneRuby(),
            _ when this == VerifoneVx510 => onVerifoneVx510(),
            _ when this == VerifoneVx510DcDial => onVerifoneVx510DcDial(),
            _ when this == VerifoneVx510DcIp => onVerifoneVx510DcIp(),
            _ when this == VerifoneVx510DcSsl => onVerifoneVx510DcSsl(),
            _ when this == VerifoneVx510Le => onVerifoneVx510Le(),
            _ when this == VerifoneVx520DcDialCtlsE2Ee => onVerifoneVx520DcDialCtlsE2Ee(),
            _ when this == VerifoneVx520DcDialE2Ee => onVerifoneVx520DcDialE2Ee(),
            _ when this == VerifoneVx520DcIp1 => onVerifoneVx520DcIp1(),
            _ when this == VerifoneVx520DcIp2 => onVerifoneVx520DcIp2(),
            _ when this == VerifoneVx520DcIpCtls => onVerifoneVx520DcIpCtls(),
            _ when this == VerifoneVx520DcIpCtlsE2Ee => onVerifoneVx520DcIpCtlsE2Ee(),
            _ when this == VerifoneVx520DcSslCtlsE2Ee => onVerifoneVx520DcSslCtlsE2Ee(),
            _ when this == VerifoneVx520DcSslE2Ee => onVerifoneVx520DcSslE2Ee(),
            _ when this == VerifoneVx520DialOnly => onVerifoneVx520DialOnly(),
            _ when this == VerifoneVx570Dial => onVerifoneVx570Dial(),
            _ when this == VerifoneVx570Ip => onVerifoneVx570Ip(),
            _ when this == VerifoneVx570Ssl => onVerifoneVx570Ssl(),
            _ when this == VerifoneVx6803GGprs => onVerifoneVx6803GGprs(),
            _ when this == VicoSoftware => onVicoSoftware(),
            _ when this == VirtualTerminal => onVirtualTerminal(),
            _ when this == VistaEntertainment => onVistaEntertainment(),
            _ when this == Vitalcheck => onVitalcheck(),
            _ when this == VmcAddOnAndroidByodQmd => onVmcAddOnAndroidByodQmd(),
            _ when this == VmcAddOnAndroidByodStandard => onVmcAddOnAndroidByodStandard(),
            _ when this == VmcAddOnBundleByodQms => onVmcAddOnBundleByodQms(),
            _ when this == VmcAddOnBundleByodStandard => onVmcAddOnBundleByodStandard(),
            _ when this == VmcAddOnBundleCellularQmd => onVmcAddOnBundleCellularQmd(),
            _ when this == VmcAddOnBundleCellularStandard => onVmcAddOnBundleCellularStandard(),
            _ when this == VmcAddOnBundleWifiQmd => onVmcAddOnBundleWifiQmd(),
            _ when this == VmcAddOnBundleWifiStandard => onVmcAddOnBundleWifiStandard(),
            _ when this == VmcFieldBundleByodQmd => onVmcFieldBundleByodQmd(),
            _ when this == VmcFieldBundleByodStandard => onVmcFieldBundleByodStandard(),
            _ when this == VmcFieldBundleCellularQms => onVmcFieldBundleCellularQms(),
            _ when this == VmcFieldBundleCellularStandard => onVmcFieldBundleCellularStandard(),
            _ when this == VmcStoreAndroidByodQms => onVmcStoreAndroidByodQms(),
            _ when this == VmcStoreAndroidByodStandard => onVmcStoreAndroidByodStandard(),
            _ when this == VmcStoreBundleByodQms => onVmcStoreBundleByodQms(),
            _ when this == VmcStoreBundleByodStandard => onVmcStoreBundleByodStandard(),
            _ when this == VmcStoreBundleCellularQms => onVmcStoreBundleCellularQms(),
            _ when this == VmcStoreBundleCellularStandard => onVmcStoreBundleCellularStandard(),
            _ when this == VmcStoreBundleWifiQms => onVmcStoreBundleWifiQms(),
            _ when this == VmcStoreBundleWifiStandard => onVmcStoreBundleWifiStandard(),
            _ when this == VPlus => onVPlus(),
            _ when this == Vsb => onVsb(),
            _ when this == VsbGreenbeanRecycle => onVsbGreenbeanRecycle(),
            _ when this == VsbKaizen => onVsbKaizen(),
            _ when this == VsbOrderbridge => onVsbOrderbridge(),
            _ when this == VsbPhonixManagedNetwork => onVsbPhonixManagedNetwork(),
            _ when this == VsbSamurai => onVsbSamurai(),
            _ when this == VsbVisat => onVsbVisat(),
            _ when this == VsbWiretrust => onVsbWiretrust(),
            _ when this == VsbXgateway => onVsbXgateway(),
            _ when this == WandGift => onWandGift(),
            _ when this == WaySystemsMtt5000 => onWaySystemsMtt5000(),
            _ when this == WendysCom => onWendysCom(),
            _ when this == Whirl => onWhirl(),
            _ when this == Winn610S => onWinn610S(),
            _ when this == XpaySoftware => onXpaySoftware(),
            _ when this == Xpient610 => onXpient610(),
            _ when this == XpientSolutions => onXpientSolutions(),
            _ => otherwise(Value)
        };

    public void Match(Action on_125158Llc,
        Action on_3Delta,
        Action on_3DeltaPws,
        Action on_911SoftwareCreditline,
        Action onAbcLiquors,
        Action onAbc610Se,
        Action onAchDirect,
        Action onAciRcsSwitch,
        Action onAcoSoftware,
        Action onActivantFalcon,
        Action onAdsGilbarco,
        Action onAdvancedMobilePayment,
        Action onAdyen,
        Action onAhcc,
        Action onAjb,
        Action onAjbFipayDirectTandem,
        Action onAjbIcip610,
        Action onAjbRtsIbm,
        Action onAjbRtsTandem,
        Action onAjbBevn,
        Action onAjbRue21,
        Action onAjbSpoch,
        Action onAllureGlobal,
        Action onAlohaEnhanced610,
        Action onAlohaTerm,
        Action onAprivaGateway,
        Action onAprivaIwl255,
        Action onApriva610,
        Action onAprivapayAtt,
        Action onAprivapayMobile,
        Action onAptosEpicorRetail,
        Action onAscom,
        Action onAsig,
        Action onAurus,
        Action onAuthorizeNet,
        Action onAutomatedCashSystems,
        Action onB2KSystems,
        Action onBevnSoftware,
        Action onBillabong,
        Action onBncb,
        Action onBobEvans610,
        Action onBookstoreManager,
        Action onBoost2Delta,
        Action onBoostBoraPayer,
        Action onBoostDirectInsite,
        Action onBoostMpg,
        Action onBreakawayVisionPos,
        Action onBridgepay,
        Action onBrinkSoftware,
        Action onBuyAtab,
        Action onCaclGift,
        Action onCardinalHealth610,
        Action onCayan,
        Action onCcciWebsite,
        Action onCdsGlobalPaydq,
        Action onCenposHostCapture,
        Action onCenposIsoEmd,
        Action onCfre610,
        Action onChargePayments,
        Action onChargesmartPaywareConnect,
        Action onChrb610,
        Action onChsp,
        Action onCkfrIntrixSupercharge,
        Action onClre610Salepoint,
        Action onComdataSmartdesq,
        Action onCommerciant,
        Action onCrackerBarrel,
        Action onCrainAtlanta,
        Action onCraneVendingServices,
        Action onCreditCall,
        Action onCtrSystems,
        Action onCubicPaymentApplication,
        Action onCyberSource,
        Action onCyberSourceVsntConversion,
        Action onCyberSourceVsntResellerBasic,
        Action onCyberSourceVsntResellerPremier,
        Action onDataBusnessSystems,
        Action onDataCap,
        Action onDataCapDialTran,
        Action onDataCapEpayRepro,
        Action onDataCapGiftEpay,
        Action onDataCapIpTran,
        Action onDataCapIpTranLt,
        Action onDataCapIpTranLtMoble,
        Action onDataCapNetEpay,
        Action onDataCapTranRepro,
        Action onDataCapTwinTran,
        Action onDataCapTwinTxnServer,
        Action onDataVantage,
        Action onDataVantageFnln610,
        Action onDbsTplusEnHanced,
        Action onDbsTransactionPlus,
        Action onDealBird,
        Action onDejavoo,
        Action onDelego,
        Action onDigicom,
        Action onDirectInsite,
        Action onDiscGoTech,
        Action onDl610Snt,
        Action onDlglVarSoftware,
        Action onDlgl610S,
        Action onDominosAci,
        Action onEcommercePlus,
        Action onEdgil,
        Action onEesCompanies,
        Action onElavonEnConcert610,
        Action onElavonFuseboxGateway,
        Action onElavonProtobase,
        Action onElavonPayments,
        Action onElpl610R,
        Action onEpayHealthcareMonetra,
        Action onEquinox,
        Action onEsdCard,
        Action onEatouch,
        Action onExatouchVsb,
        Action onExit41,
        Action onExpressTriPos,
        Action onEzDine,
        Action onEzRetail,
        Action onFandango,
        Action onFirstGlobalBillingSapwalletVsb,
        Action onFitb610S,
        Action onFredmeyr610,
        Action onFreedomPay,
        Action onFtniGatewayEtran,
        Action onFuturePosVsb,
        Action onGambleidTsevo,
        Action onGiftango,
        Action onGivex,
        Action onGmsPaymentGateway,
        Action onGmsPajb,
        Action onGnctSoftware,
        Action onGoEMerchant,
        Action onGovolution,
        Action onGrantStreet,
        Action onGreatLakesScrip,
        Action onGreatLakesScripVar,
        Action onGsiCommerce,
        Action onHandpoint,
        Action onHarleyOwnersGroup,
        Action onHighradius,
        Action onHp,
        Action onHypercom5500M,
        Action onHypercomPaymentServer,
        Action onHypercomT4205,
        Action onHypercomT4205E2E,
        Action onHypercomT4210,
        Action onHypercomT4210E2E,
        Action onHypercom4220Dial,
        Action onHypercom4220DialE2E,
        Action onHypercom4220Ssl,
        Action onHypercom4220SslE2E,
        Action onI2CVsb,
        Action onIbmace,
        Action onIcVerify,
        Action onIncentPay,
        Action onIndex,
        Action onIngenico610,
        Action onIngenico720,
        Action onIngenicoIct2203XDial,
        Action onIngenicoIct2203XDialE2Ee,
        Action onIngenicoIct2203XDialPilot,
        Action onIngenicoIct2203XSsl,
        Action onIngenicoIct2203XSslE2Ee,
        Action onIngenicoIct2203XSslPilot,
        Action onIngenicoIct220Ctls3XDial,
        Action onIngenicoIct220Ctls3XDialEe2E,
        Action onIngenicoIct220Ctls3XSsl,
        Action onIngenicoIct220Ctls3XSslE2Ee,
        Action onIngenicoIct2503XDial,
        Action onIngenicoIct2503XDialE2Ee,
        Action onIngenicoIct2503XSsl,
        Action onIngenicoIct2503XSsle2Ee,
        Action onIngenicoIwl222BtDial,
        Action onIngenicoIwl222BtDialE2Ee,
        Action onIngenicoIwl222BtSsl,
        Action onIngenicoIwl222BtSSlE2Ee,
        Action onIngenicoIwl252BtDial,
        Action onIngenicoIw252BtDialE2Ee,
        Action onIngenicoIw252BtSsl,
        Action onIngenicoIw252BtSslE2Ee,
        Action onIngenicoIw2553G,
        Action onIngenicoIw2553GE2Ee,
        Action onIngenicoSiEnterprise,
        Action onInstamed,
        Action onIpayGateway,
        Action onIsd,
        Action onIslandPacific,
        Action onIsvOpenmotionVsb,
        Action onIsv510,
        Action onIsv600,
        Action onIsv610,
        Action onIsvVsk,
        Action onItransact,
        Action onJewlSoftware,
        Action onJockeyEcomm,
        Action onJockeyRetail,
        Action onKachyng,
        Action onKlik,
        Action onKmartGift,
        Action onKubra,
        Action onLightYear,
        Action onLinked2Pay,
        Action onLongRangeSystemsLrs,
        Action onLumberVisaK,
        Action onLumgPos,
        Action onMagicWrighter,
        Action onMagnetCardServices,
        Action onMainstreetMonetra510,
        Action onMainstreetMonetra610,
        Action onMastercardOpenapi,
        Action onMastercardPaymentGateway,
        Action onMeiApriva,
        Action onMenusoftDigitalDining,
        Action onMerchantLinkCdg,
        Action onMerchantLinkCredit,
        Action onMeritSolar,
        Action onMicrosSymphony,
        Action onMicrosalePos,
        Action onMidniteExpressSlipstream,
        Action onMightyTicket,
        Action onMilleniumRetailSolutions,
        Action onMobileAccept,
        Action onMobileAcceptFlatRate,
        Action onMobileCheckoutQms,
        Action onMobileCheckoutStandard,
        Action onMonetraAuth,
        Action onMonroMuffler,
        Action onMpayGateway,
        Action onMtxepsWineps,
        Action onMvsp,
        Action onNcrAdvancedRestaurant,
        Action onNcrCinema,
        Action onNcrCounterpoint510,
        Action onNcrCounterpoint610,
        Action onNcrRetalixConnectedPayments,
        Action onNcrSilver,
        Action onNcrSilverPro,
        Action onNcrSilverProQms,
        Action onNeoGames610,
        Action onNetworkMerchants,
        Action onNsbEps,
        Action onNourdersOdp,
        Action onNurit2159,
        Action onNurit8400EDial,
        Action onOCharleys,
        Action onOlo,
        Action onOpConnect,
        Action onOptimalPaymentsGateway,
        Action onOrccCollectPay,
        Action onOrccAciWorldwide,
        Action onOrderTalk,
        Action onPaVitalcheck,
        Action onPaFidelityExpress,
        Action onPaGrantStreet,
        Action onParkmobile,
        Action onPaxSp30Casio,
        Action onPayGov,
        Action onPaydiantSj,
        Action onPayFirstEdcVpos,
        Action onPaypalPayflowLink,
        Action onPaypalPayflowLinkReseller,
        Action onPaypalPayflowPro,
        Action onPaypalPayflowProReseller,
        Action onPayright,
        Action onPaytechVsb,
        Action onPcAmerica,
        Action onPlstq610,
        Action onPlugNPlay,
        Action onPoynt,
        Action onPrecida,
        Action onPricetonCardConnect,
        Action onPrincetonEcommCollectpay,
        Action onPrincetonPayments,
        Action onPrincetonPayware,
        Action onPropSoftware,
        Action onPurecommerceVsb,
        Action onPxpSolutionsRetail,
        Action onRediantRposLighthouse,
        Action onRainbowApparel,
        Action onRdyc610S,
        Action onRedOakPs,
        Action onRedfinNetwork,
        Action onRemcoSoftware,
        Action onRentACenter,
        Action onReproOnlyIngIct220Dial,
        Action onReproOnlyIngIct220DialE2Ee,
        Action onReproOnlyIngIct220SslE2Ee,
        Action onReproOnlyIngIct250Dial,
        Action onReproOnlyIngIct250DialE2Ee,
        Action onReproOnlyIngIct250Ssl,
        Action onReproOnlyIngIct250SslE2Ee,
        Action onReproOnlyVerifoneVx520DcDial,
        Action onReproOnlyVerifoneVx520DcSsl,
        Action onReproOnlyVerifoneVx520DialCtls,
        Action onReproOnlyVerifoneVx520SslCtls,
        Action onRetrieverSoftware,
        Action onRevlinkCollect,
        Action onRevtrak,
        Action onReamMobile,
        Action onRoamMobileTest,
        Action onRoamData,
        Action onSalepoint,
        Action onSalepointClaires,
        Action onSbcSolutions,
        Action onSecureTrading,
        Action onSequoiaRetialSystems,
        Action onShci610,
        Action onShift4OnTheNet,
        Action onSightlinePayments,
        Action onSlimCdEntNonReseller,
        Action onSlimCdEnterprise,
        Action onSlimCdPro,
        Action onSlimCdProNonReseller,
        Action onSnlh610,
        Action onSouthernDataComm,
        Action onSpsEzpay,
        Action onSquirrelSystems,
        Action onSter610,
        Action onStorisVision9,
        Action onStstSoftware,
        Action onTalbots,
        Action onTangiblePayments,
        Action onTapToPayIphone,
        Action onTenderRetail,
        Action onTillster,
        Action onTnspayGateway,
        Action onToast,
        Action onToyzPos,
        Action onTransactionWirelessSvs,
        Action onTransax,
        Action onTranzgate,
        Action onTrem610,
        Action onTriversity,
        Action onTriversityPos,
        Action onTrustcommVault610,
        Action onTrustcommVault600,
        Action onTrustcommerce2011,
        Action onTsysAmexPipPcSoftware,
        Action onTsysAmexPipTerminal,
        Action onTsysDialPay,
        Action onTsysPosPort,
        Action onTwitpay,
        Action onUhaul,
        Action onUicBezel8,
        Action onUpSolution610,
        Action onUsaEpay,
        Action onUsfs,
        Action onVentek,
        Action onVerifone,
        Action onVerifone510Terminal,
        Action onVerifone600Terminal,
        Action onVerifone610,
        Action onVerifoneOmni3200,
        Action onVerifonePaywareConnect,
        Action onVerifonePaywareMobile,
        Action onVerifonePaywarePc,
        Action onVerifonePaywareTranactRita,
        Action onVerifonePcChargeGoSoftware,
        Action onVerifonePoint,
        Action onVerifonePointEntMx,
        Action onVerifonePointEntVx,
        Action onVerifoneRuby,
        Action onVerifoneVx510,
        Action onVerifoneVx510DcDial,
        Action onVerifoneVx510DcIp,
        Action onVerifoneVx510DcSsl,
        Action onVerifoneVx510Le,
        Action onVerifoneVx520DcDialCtlsE2Ee,
        Action onVerifoneVx520DcDialE2Ee,
        Action onVerifoneVx520DcIp1,
        Action onVerifoneVx520DcIp2,
        Action onVerifoneVx520DcIpCtls,
        Action onVerifoneVx520DcIpCtlsE2Ee,
        Action onVerifoneVx520DcSslCtlsE2Ee,
        Action onVerifoneVx520DcSslE2Ee,
        Action onVerifoneVx520DialOnly,
        Action onVerifoneVx570Dial,
        Action onVerifoneVx570Ip,
        Action onVerifoneVx570Ssl,
        Action onVerifoneVx6803GGprs,
        Action onVicoSoftware,
        Action onVirtualTerminal,
        Action onVistaEntertainment,
        Action onVitalcheck,
        Action onVmcAddOnAndroidByodQmd,
        Action onVmcAddOnAndroidByodStandard,
        Action onVmcAddOnBundleByodQms,
        Action onVmcAddOnBundleByodStandard,
        Action onVmcAddOnBundleCellularQmd,
        Action onVmcAddOnBundleCellularStandard,
        Action onVmcAddOnBundleWifiQmd,
        Action onVmcAddOnBundleWifiStandard,
        Action onVmcFieldBundleByodQmd,
        Action onVmcFieldBundleByodStandard,
        Action onVmcFieldBundleCellularQms,
        Action onVmcFieldBundleCellularStandard,
        Action onVmcStoreAndroidByodQms,
        Action onVmcStoreAndroidByodStandard,
        Action onVmcStoreBundleByodQms,
        Action onVmcStoreBundleByodStandard,
        Action onVmcStoreBundleCellularQms,
        Action onVmcStoreBundleCellularStandard,
        Action onVmcStoreBundleWifiQms,
        Action onVmcStoreBundleWifiStandard,
        Action onVPlus,
        Action onVsb,
        Action onVsbGreenbeanRecycle,
        Action onVsbKaizen,
        Action onVsbOrderbridge,
        Action onVsbPhonixManagedNetwork,
        Action onVsbSamurai,
        Action onVsbVisat,
        Action onVsbWiretrust,
        Action onVsbXgateway,
        Action onWandGift,
        Action onWaySystemsMtt5000,
        Action onWendysCom,
        Action onWhirl,
        Action onWinn610S,
        Action onXpaySoftware,
        Action onXpient610,
        Action onXpientSolutions,
        Action<string> otherwise)
    {
        if (this == _125158Llc) on_125158Llc();
        else if (this == _3Delta) on_3Delta();
        else if (this == _3DeltaPws) on_3DeltaPws();
        else if (this == _911SoftwareCreditline) on_911SoftwareCreditline();
        else if (this == AbcLiquors) onAbcLiquors();
        else if (this == Abc610Se) onAbc610Se();
        else if (this == AchDirect) onAchDirect();
        else if (this == AciRcsSwitch) onAciRcsSwitch();
        else if (this == AcoSoftware) onAcoSoftware();
        else if (this == ActivantFalcon) onActivantFalcon();
        else if (this == AdsGilbarco) onAdsGilbarco();
        else if (this == AdvancedMobilePayment) onAdvancedMobilePayment();
        else if (this == Adyen) onAdyen();
        else if (this == Ahcc) onAhcc();
        else if (this == Ajb) onAjb();
        else if (this == AjbFipayDirectTandem) onAjbFipayDirectTandem();
        else if (this == AjbIcip610) onAjbIcip610();
        else if (this == AjbRtsIbm) onAjbRtsIbm();
        else if (this == AjbRtsTandem) onAjbRtsTandem();
        else if (this == AjbBevn) onAjbBevn();
        else if (this == AjbRue21) onAjbRue21();
        else if (this == AjbSpoch) onAjbSpoch();
        else if (this == AllureGlobal) onAllureGlobal();
        else if (this == AlohaEnhanced610) onAlohaEnhanced610();
        else if (this == AlohaTerm) onAlohaTerm();
        else if (this == AprivaGateway) onAprivaGateway();
        else if (this == AprivaIwl255) onAprivaIwl255();
        else if (this == Apriva610) onApriva610();
        else if (this == AprivapayAtt) onAprivapayAtt();
        else if (this == AprivapayMobile) onAprivapayMobile();
        else if (this == AptosEpicorRetail) onAptosEpicorRetail();
        else if (this == Ascom) onAscom();
        else if (this == Asig) onAsig();
        else if (this == Aurus) onAurus();
        else if (this == AuthorizeNet) onAuthorizeNet();
        else if (this == AutomatedCashSystems) onAutomatedCashSystems();
        else if (this == B2KSystems) onB2KSystems();
        else if (this == BevnSoftware) onBevnSoftware();
        else if (this == Billabong) onBillabong();
        else if (this == Bncb) onBncb();
        else if (this == BobEvans610) onBobEvans610();
        else if (this == BookstoreManager) onBookstoreManager();
        else if (this == Boost2Delta) onBoost2Delta();
        else if (this == BoostBoraPayer) onBoostBoraPayer();
        else if (this == BoostDirectInsite) onBoostDirectInsite();
        else if (this == BoostMpg) onBoostMpg();
        else if (this == BreakawayVisionPos) onBreakawayVisionPos();
        else if (this == Bridgepay) onBridgepay();
        else if (this == BrinkSoftware) onBrinkSoftware();
        else if (this == BuyAtab) onBuyAtab();
        else if (this == CaclGift) onCaclGift();
        else if (this == CardinalHealth610) onCardinalHealth610();
        else if (this == Cayan) onCayan();
        else if (this == CcciWebsite) onCcciWebsite();
        else if (this == CdsGlobalPaydq) onCdsGlobalPaydq();
        else if (this == CenposHostCapture) onCenposHostCapture();
        else if (this == CenposIsoEmd) onCenposIsoEmd();
        else if (this == Cfre610) onCfre610();
        else if (this == ChargePayments) onChargePayments();
        else if (this == ChargesmartPaywareConnect) onChargesmartPaywareConnect();
        else if (this == Chrb610) onChrb610();
        else if (this == Chsp) onChsp();
        else if (this == CkfrIntrixSupercharge) onCkfrIntrixSupercharge();
        else if (this == Clre610Salepoint) onClre610Salepoint();
        else if (this == ComdataSmartdesq) onComdataSmartdesq();
        else if (this == Commerciant) onCommerciant();
        else if (this == CrackerBarrel) onCrackerBarrel();
        else if (this == CrainAtlanta) onCrainAtlanta();
        else if (this == CraneVendingServices) onCraneVendingServices();
        else if (this == CreditCall) onCreditCall();
        else if (this == CtrSystems) onCtrSystems();
        else if (this == CubicPaymentApplication) onCubicPaymentApplication();
        else if (this == CyberSource) onCyberSource();
        else if (this == CyberSourceVsntConversion) onCyberSourceVsntConversion();
        else if (this == CyberSourceVsntResellerBasic) onCyberSourceVsntResellerBasic();
        else if (this == CyberSourceVsntResellerPremier) onCyberSourceVsntResellerPremier();
        else if (this == DataBusnessSystems) onDataBusnessSystems();
        else if (this == DataCap) onDataCap();
        else if (this == DataCapDialTran) onDataCapDialTran();
        else if (this == DataCapEpayRepro) onDataCapEpayRepro();
        else if (this == DataCapGiftEpay) onDataCapGiftEpay();
        else if (this == DataCapIpTran) onDataCapIpTran();
        else if (this == DataCapIpTranLt) onDataCapIpTranLt();
        else if (this == DataCapIpTranLtMoble) onDataCapIpTranLtMoble();
        else if (this == DataCapNetEpay) onDataCapNetEpay();
        else if (this == DataCapTranRepro) onDataCapTranRepro();
        else if (this == DataCapTwinTran) onDataCapTwinTran();
        else if (this == DataCapTwinTxnServer) onDataCapTwinTxnServer();
        else if (this == DataVantage) onDataVantage();
        else if (this == DataVantageFnln610) onDataVantageFnln610();
        else if (this == DbsTplusEnHanced) onDbsTplusEnHanced();
        else if (this == DbsTransactionPlus) onDbsTransactionPlus();
        else if (this == DealBird) onDealBird();
        else if (this == Dejavoo) onDejavoo();
        else if (this == Delego) onDelego();
        else if (this == Digicom) onDigicom();
        else if (this == DirectInsite) onDirectInsite();
        else if (this == DiscGoTech) onDiscGoTech();
        else if (this == Dl610Snt) onDl610Snt();
        else if (this == DlglVarSoftware) onDlglVarSoftware();
        else if (this == Dlgl610S) onDlgl610S();
        else if (this == DominosAci) onDominosAci();
        else if (this == EcommercePlus) onEcommercePlus();
        else if (this == Edgil) onEdgil();
        else if (this == EesCompanies) onEesCompanies();
        else if (this == ElavonEnConcert610) onElavonEnConcert610();
        else if (this == ElavonFuseboxGateway) onElavonFuseboxGateway();
        else if (this == ElavonProtobase) onElavonProtobase();
        else if (this == ElavonPayments) onElavonPayments();
        else if (this == Elpl610R) onElpl610R();
        else if (this == EpayHealthcareMonetra) onEpayHealthcareMonetra();
        else if (this == Equinox) onEquinox();
        else if (this == EsdCard) onEsdCard();
        else if (this == Eatouch) onEatouch();
        else if (this == ExatouchVsb) onExatouchVsb();
        else if (this == Exit41) onExit41();
        else if (this == ExpressTriPos) onExpressTriPos();
        else if (this == EzDine) onEzDine();
        else if (this == EzRetail) onEzRetail();
        else if (this == Fandango) onFandango();
        else if (this == FirstGlobalBillingSapwalletVsb) onFirstGlobalBillingSapwalletVsb();
        else if (this == Fitb610S) onFitb610S();
        else if (this == Fredmeyr610) onFredmeyr610();
        else if (this == FreedomPay) onFreedomPay();
        else if (this == FtniGatewayEtran) onFtniGatewayEtran();
        else if (this == FuturePosVsb) onFuturePosVsb();
        else if (this == GambleidTsevo) onGambleidTsevo();
        else if (this == Giftango) onGiftango();
        else if (this == Givex) onGivex();
        else if (this == GmsPaymentGateway) onGmsPaymentGateway();
        else if (this == GmsPajb) onGmsPajb();
        else if (this == GnctSoftware) onGnctSoftware();
        else if (this == GoEMerchant) onGoEMerchant();
        else if (this == Govolution) onGovolution();
        else if (this == GrantStreet) onGrantStreet();
        else if (this == GreatLakesScrip) onGreatLakesScrip();
        else if (this == GreatLakesScripVar) onGreatLakesScripVar();
        else if (this == GsiCommerce) onGsiCommerce();
        else if (this == Handpoint) onHandpoint();
        else if (this == HarleyOwnersGroup) onHarleyOwnersGroup();
        else if (this == Highradius) onHighradius();
        else if (this == Hp) onHp();
        else if (this == Hypercom5500M) onHypercom5500M();
        else if (this == HypercomPaymentServer) onHypercomPaymentServer();
        else if (this == HypercomT4205) onHypercomT4205();
        else if (this == HypercomT4205E2E) onHypercomT4205E2E();
        else if (this == HypercomT4210) onHypercomT4210();
        else if (this == HypercomT4210E2E) onHypercomT4210E2E();
        else if (this == Hypercom4220Dial) onHypercom4220Dial();
        else if (this == Hypercom4220DialE2E) onHypercom4220DialE2E();
        else if (this == Hypercom4220Ssl) onHypercom4220Ssl();
        else if (this == Hypercom4220SslE2E) onHypercom4220SslE2E();
        else if (this == I2CVsb) onI2CVsb();
        else if (this == Ibmace) onIbmace();
        else if (this == IcVerify) onIcVerify();
        else if (this == IncentPay) onIncentPay();
        else if (this == Index) onIndex();
        else if (this == Ingenico610) onIngenico610();
        else if (this == Ingenico720) onIngenico720();
        else if (this == IngenicoIct2203XDial) onIngenicoIct2203XDial();
        else if (this == IngenicoIct2203XDialE2Ee) onIngenicoIct2203XDialE2Ee();
        else if (this == IngenicoIct2203XDialPilot) onIngenicoIct2203XDialPilot();
        else if (this == IngenicoIct2203XSsl) onIngenicoIct2203XSsl();
        else if (this == IngenicoIct2203XSslE2Ee) onIngenicoIct2203XSslE2Ee();
        else if (this == IngenicoIct2203XSslPilot) onIngenicoIct2203XSslPilot();
        else if (this == IngenicoIct220Ctls3XDial) onIngenicoIct220Ctls3XDial();
        else if (this == IngenicoIct220Ctls3XDialEe2E) onIngenicoIct220Ctls3XDialEe2E();
        else if (this == IngenicoIct220Ctls3XSsl) onIngenicoIct220Ctls3XSsl();
        else if (this == IngenicoIct220Ctls3XSslE2Ee) onIngenicoIct220Ctls3XSslE2Ee();
        else if (this == IngenicoIct2503XDial) onIngenicoIct2503XDial();
        else if (this == IngenicoIct2503XDialE2Ee) onIngenicoIct2503XDialE2Ee();
        else if (this == IngenicoIct2503XSsl) onIngenicoIct2503XSsl();
        else if (this == IngenicoIct2503XSsle2Ee) onIngenicoIct2503XSsle2Ee();
        else if (this == IngenicoIwl222BtDial) onIngenicoIwl222BtDial();
        else if (this == IngenicoIwl222BtDialE2Ee) onIngenicoIwl222BtDialE2Ee();
        else if (this == IngenicoIwl222BtSsl) onIngenicoIwl222BtSsl();
        else if (this == IngenicoIwl222BtSSlE2Ee) onIngenicoIwl222BtSSlE2Ee();
        else if (this == IngenicoIwl252BtDial) onIngenicoIwl252BtDial();
        else if (this == IngenicoIw252BtDialE2Ee) onIngenicoIw252BtDialE2Ee();
        else if (this == IngenicoIw252BtSsl) onIngenicoIw252BtSsl();
        else if (this == IngenicoIw252BtSslE2Ee) onIngenicoIw252BtSslE2Ee();
        else if (this == IngenicoIw2553G) onIngenicoIw2553G();
        else if (this == IngenicoIw2553GE2Ee) onIngenicoIw2553GE2Ee();
        else if (this == IngenicoSiEnterprise) onIngenicoSiEnterprise();
        else if (this == Instamed) onInstamed();
        else if (this == IpayGateway) onIpayGateway();
        else if (this == Isd) onIsd();
        else if (this == IslandPacific) onIslandPacific();
        else if (this == IsvOpenmotionVsb) onIsvOpenmotionVsb();
        else if (this == Isv510) onIsv510();
        else if (this == Isv600) onIsv600();
        else if (this == Isv610) onIsv610();
        else if (this == IsvVsk) onIsvVsk();
        else if (this == Itransact) onItransact();
        else if (this == JewlSoftware) onJewlSoftware();
        else if (this == JockeyEcomm) onJockeyEcomm();
        else if (this == JockeyRetail) onJockeyRetail();
        else if (this == Kachyng) onKachyng();
        else if (this == Klik) onKlik();
        else if (this == KmartGift) onKmartGift();
        else if (this == Kubra) onKubra();
        else if (this == LightYear) onLightYear();
        else if (this == Linked2Pay) onLinked2Pay();
        else if (this == LongRangeSystemsLrs) onLongRangeSystemsLrs();
        else if (this == LumberVisaK) onLumberVisaK();
        else if (this == LumgPos) onLumgPos();
        else if (this == MagicWrighter) onMagicWrighter();
        else if (this == MagnetCardServices) onMagnetCardServices();
        else if (this == MainstreetMonetra510) onMainstreetMonetra510();
        else if (this == MainstreetMonetra610) onMainstreetMonetra610();
        else if (this == MastercardOpenapi) onMastercardOpenapi();
        else if (this == MastercardPaymentGateway) onMastercardPaymentGateway();
        else if (this == MeiApriva) onMeiApriva();
        else if (this == MenusoftDigitalDining) onMenusoftDigitalDining();
        else if (this == MerchantLinkCdg) onMerchantLinkCdg();
        else if (this == MerchantLinkCredit) onMerchantLinkCredit();
        else if (this == MeritSolar) onMeritSolar();
        else if (this == MicrosSymphony) onMicrosSymphony();
        else if (this == MicrosalePos) onMicrosalePos();
        else if (this == MidniteExpressSlipstream) onMidniteExpressSlipstream();
        else if (this == MightyTicket) onMightyTicket();
        else if (this == MilleniumRetailSolutions) onMilleniumRetailSolutions();
        else if (this == MobileAccept) onMobileAccept();
        else if (this == MobileAcceptFlatRate) onMobileAcceptFlatRate();
        else if (this == MobileCheckoutQms) onMobileCheckoutQms();
        else if (this == MobileCheckoutStandard) onMobileCheckoutStandard();
        else if (this == MonetraAuth) onMonetraAuth();
        else if (this == MonroMuffler) onMonroMuffler();
        else if (this == MpayGateway) onMpayGateway();
        else if (this == MtxepsWineps) onMtxepsWineps();
        else if (this == Mvsp) onMvsp();
        else if (this == NcrAdvancedRestaurant) onNcrAdvancedRestaurant();
        else if (this == NcrCinema) onNcrCinema();
        else if (this == NcrCounterpoint510) onNcrCounterpoint510();
        else if (this == NcrCounterpoint610) onNcrCounterpoint610();
        else if (this == NcrRetalixConnectedPayments) onNcrRetalixConnectedPayments();
        else if (this == NcrSilver) onNcrSilver();
        else if (this == NcrSilverPro) onNcrSilverPro();
        else if (this == NcrSilverProQms) onNcrSilverProQms();
        else if (this == NeoGames610) onNeoGames610();
        else if (this == NetworkMerchants) onNetworkMerchants();
        else if (this == NsbEps) onNsbEps();
        else if (this == NourdersOdp) onNourdersOdp();
        else if (this == Nurit2159) onNurit2159();
        else if (this == Nurit8400EDial) onNurit8400EDial();
        else if (this == OCharleys) onOCharleys();
        else if (this == Olo) onOlo();
        else if (this == OpConnect) onOpConnect();
        else if (this == OptimalPaymentsGateway) onOptimalPaymentsGateway();
        else if (this == OrccCollectPay) onOrccCollectPay();
        else if (this == OrccAciWorldwide) onOrccAciWorldwide();
        else if (this == OrderTalk) onOrderTalk();
        else if (this == PaVitalcheck) onPaVitalcheck();
        else if (this == PaFidelityExpress) onPaFidelityExpress();
        else if (this == PaGrantStreet) onPaGrantStreet();
        else if (this == Parkmobile) onParkmobile();
        else if (this == PaxSp30Casio) onPaxSp30Casio();
        else if (this == PayGov) onPayGov();
        else if (this == PaydiantSj) onPaydiantSj();
        else if (this == PayFirstEdcVpos) onPayFirstEdcVpos();
        else if (this == PaypalPayflowLink) onPaypalPayflowLink();
        else if (this == PaypalPayflowLinkReseller) onPaypalPayflowLinkReseller();
        else if (this == PaypalPayflowPro) onPaypalPayflowPro();
        else if (this == PaypalPayflowProReseller) onPaypalPayflowProReseller();
        else if (this == Payright) onPayright();
        else if (this == PaytechVsb) onPaytechVsb();
        else if (this == PcAmerica) onPcAmerica();
        else if (this == Plstq610) onPlstq610();
        else if (this == PlugNPlay) onPlugNPlay();
        else if (this == Poynt) onPoynt();
        else if (this == Precida) onPrecida();
        else if (this == PricetonCardConnect) onPricetonCardConnect();
        else if (this == PrincetonEcommCollectpay) onPrincetonEcommCollectpay();
        else if (this == PrincetonPayments) onPrincetonPayments();
        else if (this == PrincetonPayware) onPrincetonPayware();
        else if (this == PropSoftware) onPropSoftware();
        else if (this == PurecommerceVsb) onPurecommerceVsb();
        else if (this == PxpSolutionsRetail) onPxpSolutionsRetail();
        else if (this == RediantRposLighthouse) onRediantRposLighthouse();
        else if (this == RainbowApparel) onRainbowApparel();
        else if (this == Rdyc610S) onRdyc610S();
        else if (this == RedOakPs) onRedOakPs();
        else if (this == RedfinNetwork) onRedfinNetwork();
        else if (this == RemcoSoftware) onRemcoSoftware();
        else if (this == RentACenter) onRentACenter();
        else if (this == ReproOnlyIngIct220Dial) onReproOnlyIngIct220Dial();
        else if (this == ReproOnlyIngIct220DialE2Ee) onReproOnlyIngIct220DialE2Ee();
        else if (this == ReproOnlyIngIct220SslE2Ee) onReproOnlyIngIct220SslE2Ee();
        else if (this == ReproOnlyIngIct250Dial) onReproOnlyIngIct250Dial();
        else if (this == ReproOnlyIngIct250DialE2Ee) onReproOnlyIngIct250DialE2Ee();
        else if (this == ReproOnlyIngIct250Ssl) onReproOnlyIngIct250Ssl();
        else if (this == ReproOnlyIngIct250SslE2Ee) onReproOnlyIngIct250SslE2Ee();
        else if (this == ReproOnlyVerifoneVx520DcDial) onReproOnlyVerifoneVx520DcDial();
        else if (this == ReproOnlyVerifoneVx520DcSsl) onReproOnlyVerifoneVx520DcSsl();
        else if (this == ReproOnlyVerifoneVx520DialCtls) onReproOnlyVerifoneVx520DialCtls();
        else if (this == ReproOnlyVerifoneVx520SslCtls) onReproOnlyVerifoneVx520SslCtls();
        else if (this == RetrieverSoftware) onRetrieverSoftware();
        else if (this == RevlinkCollect) onRevlinkCollect();
        else if (this == Revtrak) onRevtrak();
        else if (this == ReamMobile) onReamMobile();
        else if (this == RoamMobileTest) onRoamMobileTest();
        else if (this == RoamData) onRoamData();
        else if (this == Salepoint) onSalepoint();
        else if (this == SalepointClaires) onSalepointClaires();
        else if (this == SbcSolutions) onSbcSolutions();
        else if (this == SecureTrading) onSecureTrading();
        else if (this == SequoiaRetialSystems) onSequoiaRetialSystems();
        else if (this == Shci610) onShci610();
        else if (this == Shift4OnTheNet) onShift4OnTheNet();
        else if (this == SightlinePayments) onSightlinePayments();
        else if (this == SlimCdEntNonReseller) onSlimCdEntNonReseller();
        else if (this == SlimCdEnterprise) onSlimCdEnterprise();
        else if (this == SlimCdPro) onSlimCdPro();
        else if (this == SlimCdProNonReseller) onSlimCdProNonReseller();
        else if (this == Snlh610) onSnlh610();
        else if (this == SouthernDataComm) onSouthernDataComm();
        else if (this == SpsEzpay) onSpsEzpay();
        else if (this == SquirrelSystems) onSquirrelSystems();
        else if (this == Ster610) onSter610();
        else if (this == StorisVision9) onStorisVision9();
        else if (this == StstSoftware) onStstSoftware();
        else if (this == Talbots) onTalbots();
        else if (this == TangiblePayments) onTangiblePayments();
        else if (this == TapToPayIphone) onTapToPayIphone();
        else if (this == TenderRetail) onTenderRetail();
        else if (this == Tillster) onTillster();
        else if (this == TnspayGateway) onTnspayGateway();
        else if (this == Toast) onToast();
        else if (this == ToyzPos) onToyzPos();
        else if (this == TransactionWirelessSvs) onTransactionWirelessSvs();
        else if (this == Transax) onTransax();
        else if (this == Tranzgate) onTranzgate();
        else if (this == Trem610) onTrem610();
        else if (this == Triversity) onTriversity();
        else if (this == TriversityPos) onTriversityPos();
        else if (this == TrustcommVault610) onTrustcommVault610();
        else if (this == TrustcommVault600) onTrustcommVault600();
        else if (this == Trustcommerce2011) onTrustcommerce2011();
        else if (this == TsysAmexPipPcSoftware) onTsysAmexPipPcSoftware();
        else if (this == TsysAmexPipTerminal) onTsysAmexPipTerminal();
        else if (this == TsysDialPay) onTsysDialPay();
        else if (this == TsysPosPort) onTsysPosPort();
        else if (this == Twitpay) onTwitpay();
        else if (this == Uhaul) onUhaul();
        else if (this == UicBezel8) onUicBezel8();
        else if (this == UpSolution610) onUpSolution610();
        else if (this == UsaEpay) onUsaEpay();
        else if (this == Usfs) onUsfs();
        else if (this == Ventek) onVentek();
        else if (this == Verifone) onVerifone();
        else if (this == Verifone510Terminal) onVerifone510Terminal();
        else if (this == Verifone600Terminal) onVerifone600Terminal();
        else if (this == Verifone610) onVerifone610();
        else if (this == VerifoneOmni3200) onVerifoneOmni3200();
        else if (this == VerifonePaywareConnect) onVerifonePaywareConnect();
        else if (this == VerifonePaywareMobile) onVerifonePaywareMobile();
        else if (this == VerifonePaywarePc) onVerifonePaywarePc();
        else if (this == VerifonePaywareTranactRita) onVerifonePaywareTranactRita();
        else if (this == VerifonePcChargeGoSoftware) onVerifonePcChargeGoSoftware();
        else if (this == VerifonePoint) onVerifonePoint();
        else if (this == VerifonePointEntMx) onVerifonePointEntMx();
        else if (this == VerifonePointEntVx) onVerifonePointEntVx();
        else if (this == VerifoneRuby) onVerifoneRuby();
        else if (this == VerifoneVx510) onVerifoneVx510();
        else if (this == VerifoneVx510DcDial) onVerifoneVx510DcDial();
        else if (this == VerifoneVx510DcIp) onVerifoneVx510DcIp();
        else if (this == VerifoneVx510DcSsl) onVerifoneVx510DcSsl();
        else if (this == VerifoneVx510Le) onVerifoneVx510Le();
        else if (this == VerifoneVx520DcDialCtlsE2Ee) onVerifoneVx520DcDialCtlsE2Ee();
        else if (this == VerifoneVx520DcDialE2Ee) onVerifoneVx520DcDialE2Ee();
        else if (this == VerifoneVx520DcIp1) onVerifoneVx520DcIp1();
        else if (this == VerifoneVx520DcIp2) onVerifoneVx520DcIp2();
        else if (this == VerifoneVx520DcIpCtls) onVerifoneVx520DcIpCtls();
        else if (this == VerifoneVx520DcIpCtlsE2Ee) onVerifoneVx520DcIpCtlsE2Ee();
        else if (this == VerifoneVx520DcSslCtlsE2Ee) onVerifoneVx520DcSslCtlsE2Ee();
        else if (this == VerifoneVx520DcSslE2Ee) onVerifoneVx520DcSslE2Ee();
        else if (this == VerifoneVx520DialOnly) onVerifoneVx520DialOnly();
        else if (this == VerifoneVx570Dial) onVerifoneVx570Dial();
        else if (this == VerifoneVx570Ip) onVerifoneVx570Ip();
        else if (this == VerifoneVx570Ssl) onVerifoneVx570Ssl();
        else if (this == VerifoneVx6803GGprs) onVerifoneVx6803GGprs();
        else if (this == VicoSoftware) onVicoSoftware();
        else if (this == VirtualTerminal) onVirtualTerminal();
        else if (this == VistaEntertainment) onVistaEntertainment();
        else if (this == Vitalcheck) onVitalcheck();
        else if (this == VmcAddOnAndroidByodQmd) onVmcAddOnAndroidByodQmd();
        else if (this == VmcAddOnAndroidByodStandard) onVmcAddOnAndroidByodStandard();
        else if (this == VmcAddOnBundleByodQms) onVmcAddOnBundleByodQms();
        else if (this == VmcAddOnBundleByodStandard) onVmcAddOnBundleByodStandard();
        else if (this == VmcAddOnBundleCellularQmd) onVmcAddOnBundleCellularQmd();
        else if (this == VmcAddOnBundleCellularStandard) onVmcAddOnBundleCellularStandard();
        else if (this == VmcAddOnBundleWifiQmd) onVmcAddOnBundleWifiQmd();
        else if (this == VmcAddOnBundleWifiStandard) onVmcAddOnBundleWifiStandard();
        else if (this == VmcFieldBundleByodQmd) onVmcFieldBundleByodQmd();
        else if (this == VmcFieldBundleByodStandard) onVmcFieldBundleByodStandard();
        else if (this == VmcFieldBundleCellularQms) onVmcFieldBundleCellularQms();
        else if (this == VmcFieldBundleCellularStandard) onVmcFieldBundleCellularStandard();
        else if (this == VmcStoreAndroidByodQms) onVmcStoreAndroidByodQms();
        else if (this == VmcStoreAndroidByodStandard) onVmcStoreAndroidByodStandard();
        else if (this == VmcStoreBundleByodQms) onVmcStoreBundleByodQms();
        else if (this == VmcStoreBundleByodStandard) onVmcStoreBundleByodStandard();
        else if (this == VmcStoreBundleCellularQms) onVmcStoreBundleCellularQms();
        else if (this == VmcStoreBundleCellularStandard) onVmcStoreBundleCellularStandard();
        else if (this == VmcStoreBundleWifiQms) onVmcStoreBundleWifiQms();
        else if (this == VmcStoreBundleWifiStandard) onVmcStoreBundleWifiStandard();
        else if (this == VPlus) onVPlus();
        else if (this == Vsb) onVsb();
        else if (this == VsbGreenbeanRecycle) onVsbGreenbeanRecycle();
        else if (this == VsbKaizen) onVsbKaizen();
        else if (this == VsbOrderbridge) onVsbOrderbridge();
        else if (this == VsbPhonixManagedNetwork) onVsbPhonixManagedNetwork();
        else if (this == VsbSamurai) onVsbSamurai();
        else if (this == VsbVisat) onVsbVisat();
        else if (this == VsbWiretrust) onVsbWiretrust();
        else if (this == VsbXgateway) onVsbXgateway();
        else if (this == WandGift) onWandGift();
        else if (this == WaySystemsMtt5000) onWaySystemsMtt5000();
        else if (this == WendysCom) onWendysCom();
        else if (this == Whirl) onWhirl();
        else if (this == Winn610S) onWinn610S();
        else if (this == XpaySoftware) onXpaySoftware();
        else if (this == Xpient610) onXpient610();
        else if (this == XpientSolutions) onXpientSolutions();
        else otherwise(Value);
    }
}
