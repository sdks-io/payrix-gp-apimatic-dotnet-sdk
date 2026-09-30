using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of terminal. This field is stored as an integer and must be between 1 and 419. &lt;details&gt;&lt;summary&gt;Valid Values&lt;/summary&gt;
///
/// - <c>125158LLC</c> - <b>12:51:58 LLC POS</b>
/// <list type="bullet">
///   <item><description><c>3Delta</c> - <b>3 Delta Systems Virtual Terminal</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>3DeltaPws</c> - <b>3 Delta Systems Payment WorkSuite</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>911SoftwareCreditline</c> - <b>911 Software Credit Line</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>abcLiquors</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>abc610SE</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>achDirect</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>aciRcsSwitch</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>acoSoftware</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>activantFalcon</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>adsGilbarco</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>advancedMobilePayment</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>adyen</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ahcc</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ajb</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ajbFipayDirectTandem</c>- <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ajbIcip610</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ajbRtsIbm</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ajbRtsTandem</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ajbBevn</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ajbRue21</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ajbSpoch</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>allureGlobal</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>alohaEnhanced610</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>alohaTerm</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>aprivaGateway</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>aprivaIwl255</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>apriva610</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>aprivapayAtt</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>aprivapayMobile</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>aptosEpicorRetail</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ascom</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>asig</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>aurus</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>authorizeNet</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>automatedCashSystems</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>b2kSystems</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>bevnSoftware</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>billabong</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>bncb</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>bobEvans610</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>bookstoreManager</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>boost2Delta</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>boostBoraPayer</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>boostDirectInsite</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>boostMpg</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>breakawayVisionPos</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>bridgepay</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>brinkSoftware</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>buyAtab</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>caclGift</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>cardinalHealth610</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>cayan</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ccciWebsite</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>cdsGlobalPaydq</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>cenposHostCapture</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>cenposIsoEmd</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>cfre610</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>chargePayments</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>chargesmartPaywareConnect</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>chrb610</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>chsp</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ckfrIntrixSupercharge</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>clre610Salepoint</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>comdataSmartdesq</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>commerciant</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>crackerBarrel</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>crainAtlanta</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>craneVendingServices</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>creditCall</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ctrSystems</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>cubicPaymentApplication</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>cyberSource</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>cyberSourceVsntConversion</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>cyberSourceVsntResellerBasic</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>cyberSourceVsntResellerPremier</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>dataBusnessSystems</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>dataCap</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>dataCapDialTran</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>dataCapEpayRepro</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>dataCapGiftEpay</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>dataCapIpTran</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>dataCapIpTranLt</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>dataCapIpTranLtMoble</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>dataCapNetEpay</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>dataCapTranRepro</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>dataCapTwinTran</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>dataCapTwinTxnServer</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>dataVantage</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>dataVantageFnln610</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>dbsTplusEnHanced</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>dbsTransactionPlus</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>dealBird</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>dejavoo</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>delego</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>digicom</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>directInsite</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>discGoTech</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>dl610Snt</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>dlglVarSoftware</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>dlgl610s</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>dominosAci</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ecommercePlus</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>edgil</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>eesCompanies</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>elavonEnConcert610</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>elavonFuseboxGateway</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>elavonProtobase</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>elavonPayments</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>elpl610r</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>epayHealthcareMonetra</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>equinox</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>esdCard</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>eatouch</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>exatouchVsb</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>exit41</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ezDine</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ezRetail</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>fandango</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>firstGlobalBillingSapwalletVsb</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>fitb610s</c> - <b>''</b></description></item>
///   <item><description><c>fredmeyr610</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>freedomPay</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ftniGatewayEtran</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>futurePosVsb</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>GambleidTsevo</c> - <b>GambleID / TSEVO POS</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>Giftango</c> - <b>Giftango POS</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>Givex</c> - <b>Givex POS</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>gmsPaymentGateway</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>gmsPajb</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>gnctSoftware</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>goEMerchant</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>govolution</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>grantStreet</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>greatLakesScrip</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>greatLakesScripVar</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>gsiCommerce</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>handpoint</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>harleyOwnersGroup</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>highradius</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>hp</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>hypercom5500m</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>hypercomPaymentServer</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>hypercomT4205</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>hypercomT4205E2e</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>hypercomT4210</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>hypercomT4210E2e</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>hypercom4220Dial</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>hypercom4220DialE2e</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>hypercom4220Ssl</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>hypercom4220SslE2e</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>i2cVsb</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ibmace</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>icVerify</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>incentPay</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>index</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ingenico610</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ingenico720</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ingenicoIct2203xDial</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ingenicoIct2203xDialE2ee</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ingenicoIct2203xDialPilot</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ingenicoIct2203xSsl</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ingenicoIct2203xSslE2ee</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ingenicoIct2203xSSLPilot</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ingenicoIct220Ctls3xDial</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ingenicoIct220Ctls3xDialEe2e</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ingenicoIct220Ctls3xSsl</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ingenicoIct220Ctls3xSslE2ee</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ingenicoIct2503xDial</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ingenicoIct2503xDialE2ee</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ingenicoIct2503xSsl</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ingenicoIct2503xSSLE2ee</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ingenicoIwl222BtDial</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ingenicoIwl222BtDialE2ee</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ingenicoIwl222BtSsl</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ingenicoIwl222BtSSlE2ee</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ingenicoIwl252BtDial</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ingenicoIw252BtDialE2ee</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ingenicoIw252BtSsl</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ingenicoIw252BtSslE2ee</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ingenicoIw2553g</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ingenicoIw2553gE2ee</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ingenicoSiEnterprise</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>instamed</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ipayGateway</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>isd</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>islandPacific</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>isvOpenmotionVsb</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>isv510</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>isv600</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>isv610</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>isvVsk</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>itransact</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>jewlSoftware</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>jockeyEcomm</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>jockeyRetail</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>kachyng</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>klik</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>kmartGift</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>kubra</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>lightYear</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>linked2Pay</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>longRangeSystemsLrs</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>lumberVisaK</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>lumgPos</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>magicWrighter</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>magnetCardServices</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>mainstreetMonetra510</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>mainstreetMonetra610</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>mastercardOpenapi</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>mastercardPaymentGateway</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>meiApriva</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>menusoftDigitalDining</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>merchantLinkCDG</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>merchantLinkCredit</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>meritSolar</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>microsSymphony</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>microsalePos</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>midniteExpressSlipstream</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>mightyTicket</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>milleniumRetailSolutions</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>mobileAccept</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>mobileAcceptFlatRate</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>mobileCheckoutQms</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>mobileCheckoutStandard</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>monetraAuth</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>monroMuffler</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>mpayGateway</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>mtxepsWineps</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>mvsp</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ncrAdvancedRestaurant</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ncrCinema</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ncrCounterpoint510</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ncrCounterpoint610</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ncrRetalixConnectedPayments</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ncrSilver</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ncrSilverPro</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ncrSilverProQms</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>neoGames610</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>networkMerchants</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>nsbEps</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>nourdersOdp</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>nurit2159</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>nurit8400EDial</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>oCharleys</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>olo</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>opConnect</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>optimalPaymentsGateway</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>orccCollectPay</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>orccAciWorldwide</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>orderTalk</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>paVitalcheck</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>paFidelityExpress</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>paGrantStreet</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>parkmobile</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>paxSp30Casio</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>payGov</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>paydiantSj</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>payFirstEdcVpos</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>paypalPayflowLink</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>paypalPayflowLinkReseller</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>paypalPayflowPro</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>paypalPayflowProReseller</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>payright</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>paytechVsb</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>pcAmerica</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>PLSTQ610</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>plugNPlay</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>poynt</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>precida</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>pricetonCardConnect</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>princetonEcommCollectpay</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>princetonPayments</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>princetonPayware</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>propSoftware</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>purecommerceVsb</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>pxpSolutionsRetail</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>rediantRposLighthouse</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>rainbowApparel</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>rdyc610s</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>redOakPs</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>redfinNetwork</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>remcoSoftware</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>rentACenter</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>reproOnlyIngIct220Dial</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>reproOnlyIngIct220DialE2ee</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>reproOnlyIngIct220SslE2ee</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>reproOnlyIngIct250Dial</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>reproOnlyIngIct250DialE2ee</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>reproOnlyIngIct250Ssl</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>reproOnlyIngIct250SslE2ee</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>reproOnlyVerifoneVx520DcDial</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>reproOnlyVerifoneVx520DcSsl</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>reproOnlyVerifoneVx520DialCtls</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>reproOnlyVerifoneVx520SslCtls</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>retrieverSoftware</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>revlinkCollect</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>revtrak</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>reamMobile</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>roamMobileTest</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>roamData</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>salepoint</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>salepointClaires</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>sbcSolutions</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>secureTrading</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>sequoiaRetialSystems</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>shci610</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>shift4OnTheNet</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>sightlinePayments</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>slimCdEntNonReseller</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>slimCdEnterprise</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>slimCdPro</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>slimCdProNonReseller</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>snlh610</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>southernDataComm</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>spsEzpay</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>squirrelSystems</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ster610</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>storisVision9</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ststSoftware</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>talbots</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>tangiblePayments</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>tapToPayIphone</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>tenderRetail</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>tillster</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>tnspayGateway</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>toast</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>toyzPos</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>transactionWirelessSvs</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>transax</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>tranzgate</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>trem610</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>triversity</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>triversityPos</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>trustcommVault610</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>trustcommVault600</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>trustcommerce2011</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>tsysAmexPipPcSoftware</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>tsysAmexPipTerminal</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>tsysDialPay</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>tsysPosPort</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>twitpay</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>uhaul</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>uicBezel8</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>upSolution610</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>usaEpay</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>usfs</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ventek</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifone</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifone510Terminal</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifone600Terminal</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifone610</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifoneOmni3200</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifonePaywareConnect</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifonePaywareMobile</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifonePaywarePc</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifonePaywareTranactRita</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifonePcChargeGoSoftware</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifonePoint</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifonePointEntMx</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifonePointEntVx</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifoneRuby</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifoneVx510</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifoneVx510DcDial</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifoneVx510DcIp</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifoneVx510DcSsl</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifoneVx510le</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifoneVx520DcDialCtlsE2ee</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifoneVx520DcDialE2ee</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifoneVx520DcIp1</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifoneVx520DcIp2</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifoneVx520DcIpCtls</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifoneVx520DcIpCtlsE2ee</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifoneVx520DcSslCtlsE2ee</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifoneVx520DcSslE2ee</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifoneVx520DialOnly</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifoneVx570Dial</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifoneVx570Ip</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifoneVx570Ssl</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>verifoneVx6803gGprs</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vicoSoftware</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>virtualTerminal</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vistaEntertainment</c> - <b>''</b></description></item>
///   <item><description><c>vitalcheck</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vmcAddOnAndroidByodQmd</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vmcAddOnAndroidByodStandard</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vmcAddOnBundleByodQms</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vmcAddOnBundleByodStandard</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vmcAddOnBundleCellularQmd</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vmcAddOnBundleCellularStandard</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vmcAddOnBundleWifiQmd</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vmcAddOnBundleWifiStandard</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vmcFieldBundleByodQmd</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vmcFieldBundleByodStandard</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vmcFieldBundleCellularQms</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vmcFieldBundleCellularStandard</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vmcStoreAndroidByodQms</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vmcStoreAndroidByodStandard</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vmcStoreBundleByodQms</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vmcStoreBundleByodStandard</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vmcStoreBundleCellularQms</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vmcStoreBundleCellularStandard</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vmcStoreBundleWifiQms</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vmcStoreBundleWifiStandard</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vPlus</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vsb</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vsbGreenbeanRecycle</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vsbKaizen</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vsbOrderbridge</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vsbPhonixManagedNetwork</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vsbSamurai</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vsbVisat</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vsbWiretrust</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>vsbXgateway</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>wandGift</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>waySystemsMtt5000</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>wendysCom</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>whirl</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>winn610s</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>xpaySoftware</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>xpient610</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>xpientSolutions</c> - <b>''</b></description></item>
/// </list>
/// <para>
///  &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TerminalType1>))]
public sealed record TerminalType1 : OpenStringEnum<TerminalType1>
{
    private TerminalType1(string value) : base(value)
    {
    }

    public static readonly TerminalType1 _125158Llc = new("125158LLC");

    public static readonly TerminalType1 _3Delta = new("3Delta");

    public static readonly TerminalType1 _3DeltaPws = new("3DeltaPws");

    public static readonly TerminalType1 _911SoftwareCreditline = new("911SoftwareCreditline");

    public static readonly TerminalType1 AbcLiquors = new("abcLiquors");

    public static readonly TerminalType1 Abc610Se = new("abc610SE");

    public static readonly TerminalType1 AchDirect = new("achDirect");

    public static readonly TerminalType1 AciRcsSwitch = new("aciRcsSwitch");

    public static readonly TerminalType1 AcoSoftware = new("acoSoftware");

    public static readonly TerminalType1 ActivantFalcon = new("activantFalcon");

    public static readonly TerminalType1 AdsGilbarco = new("adsGilbarco");

    public static readonly TerminalType1 AdvancedMobilePayment = new("advancedMobilePayment");

    public static readonly TerminalType1 Adyen = new("adyen");

    public static readonly TerminalType1 Ahcc = new("ahcc");

    public static readonly TerminalType1 Ajb = new("ajb");

    public static readonly TerminalType1 AjbFipayDirectTandem = new("ajbFipayDirectTandem");

    public static readonly TerminalType1 AjbIcip610 = new("ajbIcip610");

    public static readonly TerminalType1 AjbRtsIbm = new("ajbRtsIbm");

    public static readonly TerminalType1 AjbRtsTandem = new("ajbRtsTandem");

    public static readonly TerminalType1 AjbBevn = new("ajbBevn");

    public static readonly TerminalType1 AjbRue21 = new("ajbRue21");

    public static readonly TerminalType1 AjbSpoch = new("ajbSpoch");

    public static readonly TerminalType1 AllureGlobal = new("allureGlobal");

    public static readonly TerminalType1 AlohaEnhanced610 = new("alohaEnhanced610");

    public static readonly TerminalType1 AlohaTerm = new("alohaTerm");

    public static readonly TerminalType1 AprivaGateway = new("aprivaGateway");

    public static readonly TerminalType1 AprivaIwl255 = new("aprivaIwl255");

    public static readonly TerminalType1 Apriva610 = new("apriva610");

    public static readonly TerminalType1 AprivapayAtt = new("aprivapayAtt");

    public static readonly TerminalType1 AprivapayMobile = new("aprivapayMobile");

    public static readonly TerminalType1 AptosEpicorRetail = new("aptosEpicorRetail");

    public static readonly TerminalType1 Ascom = new("ascom");

    public static readonly TerminalType1 Asig = new("asig");

    public static readonly TerminalType1 Aurus = new("aurus");

    public static readonly TerminalType1 AuthorizeNet = new("authorizeNet");

    public static readonly TerminalType1 AutomatedCashSystems = new("automatedCashSystems");

    public static readonly TerminalType1 B2KSystems = new("b2kSystems");

    public static readonly TerminalType1 BevnSoftware = new("bevnSoftware");

    public static readonly TerminalType1 Billabong = new("billabong");

    public static readonly TerminalType1 Bncb = new("bncb");

    public static readonly TerminalType1 BobEvans610 = new("bobEvans610");

    public static readonly TerminalType1 BookstoreManager = new("bookstoreManager");

    public static readonly TerminalType1 Boost2Delta = new("boost2Delta");

    public static readonly TerminalType1 BoostBoraPayer = new("boostBoraPayer");

    public static readonly TerminalType1 BoostDirectInsite = new("boostDirectInsite");

    public static readonly TerminalType1 BoostMpg = new("boostMpg");

    public static readonly TerminalType1 BreakawayVisionPos = new("breakawayVisionPos");

    public static readonly TerminalType1 Bridgepay = new("bridgepay");

    public static readonly TerminalType1 BrinkSoftware = new("brinkSoftware");

    public static readonly TerminalType1 BuyAtab = new("buyAtab");

    public static readonly TerminalType1 CaclGift = new("caclGift");

    public static readonly TerminalType1 CardinalHealth610 = new("cardinalHealth610");

    public static readonly TerminalType1 Cayan = new("cayan");

    public static readonly TerminalType1 CcciWebsite = new("ccciWebsite");

    public static readonly TerminalType1 CdsGlobalPaydq = new("cdsGlobalPaydq");

    public static readonly TerminalType1 CenposHostCapture = new("cenposHostCapture");

    public static readonly TerminalType1 CenposIsoEmd = new("cenposIsoEmd");

    public static readonly TerminalType1 Cfre610 = new("cfre610");

    public static readonly TerminalType1 ChargePayments = new("chargePayments");

    public static readonly TerminalType1 ChargesmartPaywareConnect = new("chargesmartPaywareConnect");

    public static readonly TerminalType1 Chrb610 = new("chrb610");

    public static readonly TerminalType1 Chsp = new("chsp");

    public static readonly TerminalType1 CkfrIntrixSupercharge = new("ckfrIntrixSupercharge");

    public static readonly TerminalType1 Clre610Salepoint = new("clre610Salepoint");

    public static readonly TerminalType1 ComdataSmartdesq = new("comdataSmartdesq");

    public static readonly TerminalType1 Commerciant = new("commerciant");

    public static readonly TerminalType1 CrackerBarrel = new("crackerBarrel");

    public static readonly TerminalType1 CrainAtlanta = new("crainAtlanta");

    public static readonly TerminalType1 CraneVendingServices = new("craneVendingServices");

    public static readonly TerminalType1 CreditCall = new("creditCall");

    public static readonly TerminalType1 CtrSystems = new("ctrSystems");

    public static readonly TerminalType1 CubicPaymentApplication = new("cubicPaymentApplication");

    public static readonly TerminalType1 CyberSource = new("cyberSource");

    public static readonly TerminalType1 CyberSourceVsntConversion = new("cyberSourceVsntConversion");

    public static readonly TerminalType1 CyberSourceVsntResellerBasic = new("cyberSourceVsntResellerBasic");

    public static readonly TerminalType1 CyberSourceVsntResellerPremier = new("cyberSourceVsntResellerPremier");

    public static readonly TerminalType1 DataBusnessSystems = new("dataBusnessSystems");

    public static readonly TerminalType1 DataCap = new("dataCap");

    public static readonly TerminalType1 DataCapDialTran = new("dataCapDialTran");

    public static readonly TerminalType1 DataCapEpayRepro = new("dataCapEpayRepro");

    public static readonly TerminalType1 DataCapGiftEpay = new("dataCapGiftEpay");

    public static readonly TerminalType1 DataCapIpTran = new("dataCapIpTran");

    public static readonly TerminalType1 DataCapIpTranLt = new("dataCapIpTranLt");

    public static readonly TerminalType1 DataCapIpTranLtMoble = new("dataCapIpTranLtMoble");

    public static readonly TerminalType1 DataCapNetEpay = new("dataCapNetEpay");

    public static readonly TerminalType1 DataCapTranRepro = new("dataCapTranRepro");

    public static readonly TerminalType1 DataCapTwinTran = new("dataCapTwinTran");

    public static readonly TerminalType1 DataCapTwinTxnServer = new("dataCapTwinTxnServer");

    public static readonly TerminalType1 DataVantage = new("dataVantage");

    public static readonly TerminalType1 DataVantageFnln610 = new("dataVantageFnln610");

    public static readonly TerminalType1 DbsTplusEnHanced = new("dbsTplusEnHanced");

    public static readonly TerminalType1 DbsTransactionPlus = new("dbsTransactionPlus");

    public static readonly TerminalType1 DealBird = new("dealBird");

    public static readonly TerminalType1 Dejavoo = new("dejavoo");

    public static readonly TerminalType1 Delego = new("delego");

    public static readonly TerminalType1 Digicom = new("digicom");

    public static readonly TerminalType1 DirectInsite = new("directInsite");

    public static readonly TerminalType1 DiscGoTech = new("discGoTech");

    public static readonly TerminalType1 Dl610Snt = new("dl610Snt");

    public static readonly TerminalType1 DlglVarSoftware = new("dlglVarSoftware");

    public static readonly TerminalType1 Dlgl610S = new("dlgl610s");

    public static readonly TerminalType1 DominosAci = new("dominosAci");

    public static readonly TerminalType1 EcommercePlus = new("ecommercePlus");

    public static readonly TerminalType1 Edgil = new("edgil");

    public static readonly TerminalType1 EesCompanies = new("eesCompanies");

    public static readonly TerminalType1 ElavonEnConcert610 = new("elavonEnConcert610");

    public static readonly TerminalType1 ElavonFuseboxGateway = new("elavonFuseboxGateway");

    public static readonly TerminalType1 ElavonProtobase = new("elavonProtobase");

    public static readonly TerminalType1 ElavonPayments = new("elavonPayments");

    public static readonly TerminalType1 Elpl610R = new("elpl610r");

    public static readonly TerminalType1 EpayHealthcareMonetra = new("epayHealthcareMonetra");

    public static readonly TerminalType1 Equinox = new("equinox");

    public static readonly TerminalType1 EsdCard = new("esdCard");

    public static readonly TerminalType1 Eatouch = new("eatouch");

    public static readonly TerminalType1 ExatouchVsb = new("exatouchVsb");

    public static readonly TerminalType1 Exit41 = new("exit41");

    public static readonly TerminalType1 ExpressTriPos = new("expressTriPos");

    public static readonly TerminalType1 EzDine = new("ezDine");

    public static readonly TerminalType1 EzRetail = new("ezRetail");

    public static readonly TerminalType1 Fandango = new("fandango");

    public static readonly TerminalType1 FirstGlobalBillingSapwalletVsb = new("firstGlobalBillingSapwalletVsb");

    public static readonly TerminalType1 Fitb610S = new("fitb610s");

    public static readonly TerminalType1 Fredmeyr610 = new("fredmeyr610");

    public static readonly TerminalType1 FreedomPay = new("freedomPay");

    public static readonly TerminalType1 FtniGatewayEtran = new("ftniGatewayEtran");

    public static readonly TerminalType1 FuturePosVsb = new("futurePosVsb");

    public static readonly TerminalType1 GambleidTsevo = new("GambleidTsevo");

    public static readonly TerminalType1 Giftango = new("Giftango");

    public static readonly TerminalType1 Givex = new("Givex");

    public static readonly TerminalType1 GmsPaymentGateway = new("gmsPaymentGateway");

    public static readonly TerminalType1 GmsPajb = new("gmsPajb");

    public static readonly TerminalType1 GnctSoftware = new("gnctSoftware");

    public static readonly TerminalType1 GoEMerchant = new("goEMerchant");

    public static readonly TerminalType1 Govolution = new("govolution");

    public static readonly TerminalType1 GrantStreet = new("grantStreet");

    public static readonly TerminalType1 GreatLakesScrip = new("greatLakesScrip");

    public static readonly TerminalType1 GreatLakesScripVar = new("greatLakesScripVar");

    public static readonly TerminalType1 GsiCommerce = new("gsiCommerce");

    public static readonly TerminalType1 Handpoint = new("handpoint");

    public static readonly TerminalType1 HarleyOwnersGroup = new("harleyOwnersGroup");

    public static readonly TerminalType1 Highradius = new("highradius");

    public static readonly TerminalType1 Hp = new("hp");

    public static readonly TerminalType1 Hypercom5500M = new("hypercom5500m");

    public static readonly TerminalType1 HypercomPaymentServer = new("hypercomPaymentServer");

    public static readonly TerminalType1 HypercomT4205 = new("hypercomT4205");

    public static readonly TerminalType1 HypercomT4205E2E = new("hypercomT4205E2e");

    public static readonly TerminalType1 HypercomT4210 = new("hypercomT4210");

    public static readonly TerminalType1 HypercomT4210E2E = new("hypercomT4210E2e");

    public static readonly TerminalType1 Hypercom4220Dial = new("hypercom4220Dial");

    public static readonly TerminalType1 Hypercom4220DialE2E = new("hypercom4220DialE2e");

    public static readonly TerminalType1 Hypercom4220Ssl = new("hypercom4220Ssl");

    public static readonly TerminalType1 Hypercom4220SslE2E = new("hypercom4220SslE2e");

    public static readonly TerminalType1 I2CVsb = new("i2cVsb");

    public static readonly TerminalType1 Ibmace = new("ibmace");

    public static readonly TerminalType1 IcVerify = new("icVerify");

    public static readonly TerminalType1 IncentPay = new("incentPay");

    public static readonly TerminalType1 Index = new("index");

    public static readonly TerminalType1 Ingenico610 = new("ingenico610");

    public static readonly TerminalType1 Ingenico720 = new("ingenico720");

    public static readonly TerminalType1 IngenicoIct2203XDial = new("ingenicoIct2203xDial");

    public static readonly TerminalType1 IngenicoIct2203XDialE2Ee = new("ingenicoIct2203xDialE2ee");

    public static readonly TerminalType1 IngenicoIct2203XDialPilot = new("ingenicoIct2203xDialPilot");

    public static readonly TerminalType1 IngenicoIct2203XSsl = new("ingenicoIct2203xSsl");

    public static readonly TerminalType1 IngenicoIct2203XSslE2Ee = new("ingenicoIct2203xSslE2ee");

    public static readonly TerminalType1 IngenicoIct2203XSslPilot = new("ingenicoIct2203xSSLPilot");

    public static readonly TerminalType1 IngenicoIct220Ctls3XDial = new("ingenicoIct220Ctls3xDial");

    public static readonly TerminalType1 IngenicoIct220Ctls3XDialEe2E = new("ingenicoIct220Ctls3xDialEe2e");

    public static readonly TerminalType1 IngenicoIct220Ctls3XSsl = new("ingenicoIct220Ctls3xSsl");

    public static readonly TerminalType1 IngenicoIct220Ctls3XSslE2Ee = new("ingenicoIct220Ctls3xSslE2ee");

    public static readonly TerminalType1 IngenicoIct2503XDial = new("ingenicoIct2503xDial");

    public static readonly TerminalType1 IngenicoIct2503XDialE2Ee = new("ingenicoIct2503xDialE2ee");

    public static readonly TerminalType1 IngenicoIct2503XSsl = new("ingenicoIct2503xSsl");

    public static readonly TerminalType1 IngenicoIct2503XSsle2Ee = new("ingenicoIct2503xSSLE2ee");

    public static readonly TerminalType1 IngenicoIwl222BtDial = new("ingenicoIwl222BtDial");

    public static readonly TerminalType1 IngenicoIwl222BtDialE2Ee = new("ingenicoIwl222BtDialE2ee");

    public static readonly TerminalType1 IngenicoIwl222BtSsl = new("ingenicoIwl222BtSsl");

    public static readonly TerminalType1 IngenicoIwl222BtSSlE2Ee = new("ingenicoIwl222BtSSlE2ee");

    public static readonly TerminalType1 IngenicoIwl252BtDial = new("ingenicoIwl252BtDial");

    public static readonly TerminalType1 IngenicoIw252BtDialE2Ee = new("ingenicoIw252BtDialE2ee");

    public static readonly TerminalType1 IngenicoIw252BtSsl = new("ingenicoIw252BtSsl");

    public static readonly TerminalType1 IngenicoIw252BtSslE2Ee = new("ingenicoIw252BtSslE2ee");

    public static readonly TerminalType1 IngenicoIw2553G = new("ingenicoIw2553g");

    public static readonly TerminalType1 IngenicoIw2553GE2Ee = new("ingenicoIw2553gE2ee");

    public static readonly TerminalType1 IngenicoSiEnterprise = new("ingenicoSiEnterprise");

    public static readonly TerminalType1 Instamed = new("instamed");

    public static readonly TerminalType1 IpayGateway = new("ipayGateway");

    public static readonly TerminalType1 Isd = new("isd");

    public static readonly TerminalType1 IslandPacific = new("islandPacific");

    public static readonly TerminalType1 IsvOpenmotionVsb = new("isvOpenmotionVsb");

    public static readonly TerminalType1 Isv510 = new("isv510");

    public static readonly TerminalType1 Isv600 = new("isv600");

    public static readonly TerminalType1 Isv610 = new("isv610");

    public static readonly TerminalType1 IsvVsk = new("isvVsk");

    public static readonly TerminalType1 Itransact = new("itransact");

    public static readonly TerminalType1 JewlSoftware = new("jewlSoftware");

    public static readonly TerminalType1 JockeyEcomm = new("jockeyEcomm");

    public static readonly TerminalType1 JockeyRetail = new("jockeyRetail");

    public static readonly TerminalType1 Kachyng = new("kachyng");

    public static readonly TerminalType1 Klik = new("klik");

    public static readonly TerminalType1 KmartGift = new("kmartGift");

    public static readonly TerminalType1 Kubra = new("kubra");

    public static readonly TerminalType1 LightYear = new("lightYear");

    public static readonly TerminalType1 Linked2Pay = new("linked2Pay");

    public static readonly TerminalType1 LongRangeSystemsLrs = new("longRangeSystemsLrs");

    public static readonly TerminalType1 LumberVisaK = new("lumberVisaK");

    public static readonly TerminalType1 LumgPos = new("lumgPos");

    public static readonly TerminalType1 MagicWrighter = new("magicWrighter");

    public static readonly TerminalType1 MagnetCardServices = new("magnetCardServices");

    public static readonly TerminalType1 MainstreetMonetra510 = new("mainstreetMonetra510");

    public static readonly TerminalType1 MainstreetMonetra610 = new("mainstreetMonetra610");

    public static readonly TerminalType1 MastercardOpenapi = new("mastercardOpenapi");

    public static readonly TerminalType1 MastercardPaymentGateway = new("mastercardPaymentGateway");

    public static readonly TerminalType1 MeiApriva = new("meiApriva");

    public static readonly TerminalType1 MenusoftDigitalDining = new("menusoftDigitalDining");

    public static readonly TerminalType1 MerchantLinkCdg = new("merchantLinkCDG");

    public static readonly TerminalType1 MerchantLinkCredit = new("merchantLinkCredit");

    public static readonly TerminalType1 MeritSolar = new("meritSolar");

    public static readonly TerminalType1 MicrosSymphony = new("microsSymphony");

    public static readonly TerminalType1 MicrosalePos = new("microsalePos");

    public static readonly TerminalType1 MidniteExpressSlipstream = new("midniteExpressSlipstream");

    public static readonly TerminalType1 MightyTicket = new("mightyTicket");

    public static readonly TerminalType1 MilleniumRetailSolutions = new("milleniumRetailSolutions");

    public static readonly TerminalType1 MobileAccept = new("mobileAccept");

    public static readonly TerminalType1 MobileAcceptFlatRate = new("mobileAcceptFlatRate");

    public static readonly TerminalType1 MobileCheckoutQms = new("mobileCheckoutQms");

    public static readonly TerminalType1 MobileCheckoutStandard = new("mobileCheckoutStandard");

    public static readonly TerminalType1 MonetraAuth = new("monetraAuth");

    public static readonly TerminalType1 MonroMuffler = new("monroMuffler");

    public static readonly TerminalType1 MpayGateway = new("mpayGateway");

    public static readonly TerminalType1 MtxepsWineps = new("mtxepsWineps");

    public static readonly TerminalType1 Mvsp = new("mvsp");

    public static readonly TerminalType1 NcrAdvancedRestaurant = new("ncrAdvancedRestaurant");

    public static readonly TerminalType1 NcrCinema = new("ncrCinema");

    public static readonly TerminalType1 NcrCounterpoint510 = new("ncrCounterpoint510");

    public static readonly TerminalType1 NcrCounterpoint610 = new("ncrCounterpoint610");

    public static readonly TerminalType1 NcrRetalixConnectedPayments = new("ncrRetalixConnectedPayments");

    public static readonly TerminalType1 NcrSilver = new("ncrSilver");

    public static readonly TerminalType1 NcrSilverPro = new("ncrSilverPro");

    public static readonly TerminalType1 NcrSilverProQms = new("ncrSilverProQms");

    public static readonly TerminalType1 NeoGames610 = new("neoGames610");

    public static readonly TerminalType1 NetworkMerchants = new("networkMerchants");

    public static readonly TerminalType1 NsbEps = new("nsbEps");

    public static readonly TerminalType1 NourdersOdp = new("nourdersOdp");

    public static readonly TerminalType1 Nurit2159 = new("nurit2159");

    public static readonly TerminalType1 Nurit8400EDial = new("nurit8400EDial");

    public static readonly TerminalType1 OCharleys = new("oCharleys");

    public static readonly TerminalType1 Olo = new("olo");

    public static readonly TerminalType1 OpConnect = new("opConnect");

    public static readonly TerminalType1 OptimalPaymentsGateway = new("optimalPaymentsGateway");

    public static readonly TerminalType1 OrccCollectPay = new("orccCollectPay");

    public static readonly TerminalType1 OrccAciWorldwide = new("orccAciWorldwide");

    public static readonly TerminalType1 OrderTalk = new("orderTalk");

    public static readonly TerminalType1 PaVitalcheck = new("paVitalcheck");

    public static readonly TerminalType1 PaFidelityExpress = new("paFidelityExpress");

    public static readonly TerminalType1 PaGrantStreet = new("paGrantStreet");

    public static readonly TerminalType1 Parkmobile = new("parkmobile");

    public static readonly TerminalType1 PaxSp30Casio = new("paxSp30Casio");

    public static readonly TerminalType1 PayGov = new("payGov");

    public static readonly TerminalType1 PaydiantSj = new("paydiantSj");

    public static readonly TerminalType1 PayFirstEdcVpos = new("payFirstEdcVpos");

    public static readonly TerminalType1 PaypalPayflowLink = new("paypalPayflowLink");

    public static readonly TerminalType1 PaypalPayflowLinkReseller = new("paypalPayflowLinkReseller");

    public static readonly TerminalType1 PaypalPayflowPro = new("paypalPayflowPro");

    public static readonly TerminalType1 PaypalPayflowProReseller = new("paypalPayflowProReseller");

    public static readonly TerminalType1 Payright = new("payright");

    public static readonly TerminalType1 PaytechVsb = new("paytechVsb");

    public static readonly TerminalType1 PcAmerica = new("pcAmerica");

    public static readonly TerminalType1 Plstq610 = new("PLSTQ610");

    public static readonly TerminalType1 PlugNPlay = new("plugNPlay");

    public static readonly TerminalType1 Poynt = new("poynt");

    public static readonly TerminalType1 Precida = new("precida");

    public static readonly TerminalType1 PricetonCardConnect = new("pricetonCardConnect");

    public static readonly TerminalType1 PrincetonEcommCollectpay = new("princetonEcommCollectpay");

    public static readonly TerminalType1 PrincetonPayments = new("princetonPayments");

    public static readonly TerminalType1 PrincetonPayware = new("princetonPayware");

    public static readonly TerminalType1 PropSoftware = new("propSoftware");

    public static readonly TerminalType1 PurecommerceVsb = new("purecommerceVsb");

    public static readonly TerminalType1 PxpSolutionsRetail = new("pxpSolutionsRetail");

    public static readonly TerminalType1 RediantRposLighthouse = new("rediantRposLighthouse");

    public static readonly TerminalType1 RainbowApparel = new("rainbowApparel");

    public static readonly TerminalType1 Rdyc610S = new("rdyc610s");

    public static readonly TerminalType1 RedOakPs = new("redOakPs");

    public static readonly TerminalType1 RedfinNetwork = new("redfinNetwork");

    public static readonly TerminalType1 RemcoSoftware = new("remcoSoftware");

    public static readonly TerminalType1 RentACenter = new("rentACenter");

    public static readonly TerminalType1 ReproOnlyIngIct220Dial = new("reproOnlyIngIct220Dial");

    public static readonly TerminalType1 ReproOnlyIngIct220DialE2Ee = new("reproOnlyIngIct220DialE2ee");

    public static readonly TerminalType1 ReproOnlyIngIct220SslE2Ee = new("reproOnlyIngIct220SslE2ee");

    public static readonly TerminalType1 ReproOnlyIngIct250Dial = new("reproOnlyIngIct250Dial");

    public static readonly TerminalType1 ReproOnlyIngIct250DialE2Ee = new("reproOnlyIngIct250DialE2ee");

    public static readonly TerminalType1 ReproOnlyIngIct250Ssl = new("reproOnlyIngIct250Ssl");

    public static readonly TerminalType1 ReproOnlyIngIct250SslE2Ee = new("reproOnlyIngIct250SslE2ee");

    public static readonly TerminalType1 ReproOnlyVerifoneVx520DcDial = new("reproOnlyVerifoneVx520DcDial");

    public static readonly TerminalType1 ReproOnlyVerifoneVx520DcSsl = new("reproOnlyVerifoneVx520DcSsl");

    public static readonly TerminalType1 ReproOnlyVerifoneVx520DialCtls = new("reproOnlyVerifoneVx520DialCtls");

    public static readonly TerminalType1 ReproOnlyVerifoneVx520SslCtls = new("reproOnlyVerifoneVx520SslCtls");

    public static readonly TerminalType1 RetrieverSoftware = new("retrieverSoftware");

    public static readonly TerminalType1 RevlinkCollect = new("revlinkCollect");

    public static readonly TerminalType1 Revtrak = new("revtrak");

    public static readonly TerminalType1 ReamMobile = new("reamMobile");

    public static readonly TerminalType1 RoamMobileTest = new("roamMobileTest");

    public static readonly TerminalType1 RoamData = new("roamData");

    public static readonly TerminalType1 Salepoint = new("salepoint");

    public static readonly TerminalType1 SalepointClaires = new("salepointClaires");

    public static readonly TerminalType1 SbcSolutions = new("sbcSolutions");

    public static readonly TerminalType1 SecureTrading = new("secureTrading");

    public static readonly TerminalType1 SequoiaRetialSystems = new("sequoiaRetialSystems");

    public static readonly TerminalType1 Shci610 = new("shci610");

    public static readonly TerminalType1 Shift4OnTheNet = new("shift4OnTheNet");

    public static readonly TerminalType1 SightlinePayments = new("sightlinePayments");

    public static readonly TerminalType1 SlimCdEntNonReseller = new("slimCdEntNonReseller");

    public static readonly TerminalType1 SlimCdEnterprise = new("slimCdEnterprise");

    public static readonly TerminalType1 SlimCdPro = new("slimCdPro");

    public static readonly TerminalType1 SlimCdProNonReseller = new("slimCdProNonReseller");

    public static readonly TerminalType1 Snlh610 = new("snlh610");

    public static readonly TerminalType1 SouthernDataComm = new("southernDataComm");

    public static readonly TerminalType1 SpsEzpay = new("spsEzpay");

    public static readonly TerminalType1 SquirrelSystems = new("squirrelSystems");

    public static readonly TerminalType1 Ster610 = new("ster610");

    public static readonly TerminalType1 StorisVision9 = new("storisVision9");

    public static readonly TerminalType1 StstSoftware = new("ststSoftware");

    public static readonly TerminalType1 Talbots = new("talbots");

    public static readonly TerminalType1 TangiblePayments = new("tangiblePayments");

    public static readonly TerminalType1 TapToPayIphone = new("tapToPayIphone");

    public static readonly TerminalType1 TenderRetail = new("tenderRetail");

    public static readonly TerminalType1 Tillster = new("tillster");

    public static readonly TerminalType1 TnspayGateway = new("tnspayGateway");

    public static readonly TerminalType1 Toast = new("toast");

    public static readonly TerminalType1 ToyzPos = new("toyzPos");

    public static readonly TerminalType1 TransactionWirelessSvs = new("transactionWirelessSvs");

    public static readonly TerminalType1 Transax = new("transax");

    public static readonly TerminalType1 Tranzgate = new("tranzgate");

    public static readonly TerminalType1 Trem610 = new("trem610");

    public static readonly TerminalType1 Triversity = new("triversity");

    public static readonly TerminalType1 TriversityPos = new("triversityPos");

    public static readonly TerminalType1 TrustcommVault610 = new("trustcommVault610");

    public static readonly TerminalType1 TrustcommVault600 = new("trustcommVault600");

    public static readonly TerminalType1 Trustcommerce2011 = new("trustcommerce2011");

    public static readonly TerminalType1 TsysAmexPipPcSoftware = new("tsysAmexPipPcSoftware");

    public static readonly TerminalType1 TsysAmexPipTerminal = new("tsysAmexPipTerminal");

    public static readonly TerminalType1 TsysDialPay = new("tsysDialPay");

    public static readonly TerminalType1 TsysPosPort = new("tsysPosPort");

    public static readonly TerminalType1 Twitpay = new("twitpay");

    public static readonly TerminalType1 Uhaul = new("uhaul");

    public static readonly TerminalType1 UicBezel8 = new("uicBezel8");

    public static readonly TerminalType1 UpSolution610 = new("upSolution610");

    public static readonly TerminalType1 UsaEpay = new("usaEpay");

    public static readonly TerminalType1 Usfs = new("usfs");

    public static readonly TerminalType1 Ventek = new("ventek");

    public static readonly TerminalType1 Verifone = new("verifone");

    public static readonly TerminalType1 Verifone510Terminal = new("verifone510Terminal");

    public static readonly TerminalType1 Verifone600Terminal = new("verifone600Terminal");

    public static readonly TerminalType1 Verifone610 = new("verifone610");

    public static readonly TerminalType1 VerifoneOmni3200 = new("verifoneOmni3200");

    public static readonly TerminalType1 VerifonePaywareConnect = new("verifonePaywareConnect");

    public static readonly TerminalType1 VerifonePaywareMobile = new("verifonePaywareMobile");

    public static readonly TerminalType1 VerifonePaywarePc = new("verifonePaywarePc");

    public static readonly TerminalType1 VerifonePaywareTranactRita = new("verifonePaywareTranactRita");

    public static readonly TerminalType1 VerifonePcChargeGoSoftware = new("verifonePcChargeGoSoftware");

    public static readonly TerminalType1 VerifonePoint = new("verifonePoint");

    public static readonly TerminalType1 VerifonePointEntMx = new("verifonePointEntMx");

    public static readonly TerminalType1 VerifonePointEntVx = new("verifonePointEntVx");

    public static readonly TerminalType1 VerifoneRuby = new("verifoneRuby");

    public static readonly TerminalType1 VerifoneVx510 = new("verifoneVx510");

    public static readonly TerminalType1 VerifoneVx510DcDial = new("verifoneVx510DcDial");

    public static readonly TerminalType1 VerifoneVx510DcIp = new("verifoneVx510DcIp");

    public static readonly TerminalType1 VerifoneVx510DcSsl = new("verifoneVx510DcSsl");

    public static readonly TerminalType1 VerifoneVx510Le = new("verifoneVx510le");

    public static readonly TerminalType1 VerifoneVx520DcDialCtlsE2Ee = new("verifoneVx520DcDialCtlsE2ee");

    public static readonly TerminalType1 VerifoneVx520DcDialE2Ee = new("verifoneVx520DcDialE2ee");

    public static readonly TerminalType1 VerifoneVx520DcIp1 = new("verifoneVx520DcIp1");

    public static readonly TerminalType1 VerifoneVx520DcIp2 = new("verifoneVx520DcIp2");

    public static readonly TerminalType1 VerifoneVx520DcIpCtls = new("verifoneVx520DcIpCtls");

    public static readonly TerminalType1 VerifoneVx520DcIpCtlsE2Ee = new("verifoneVx520DcIpCtlsE2ee");

    public static readonly TerminalType1 VerifoneVx520DcSslCtlsE2Ee = new("verifoneVx520DcSslCtlsE2ee");

    public static readonly TerminalType1 VerifoneVx520DcSslE2Ee = new("verifoneVx520DcSslE2ee");

    public static readonly TerminalType1 VerifoneVx520DialOnly = new("verifoneVx520DialOnly");

    public static readonly TerminalType1 VerifoneVx570Dial = new("verifoneVx570Dial");

    public static readonly TerminalType1 VerifoneVx570Ip = new("verifoneVx570Ip");

    public static readonly TerminalType1 VerifoneVx570Ssl = new("verifoneVx570Ssl");

    public static readonly TerminalType1 VerifoneVx6803GGprs = new("verifoneVx6803gGprs");

    public static readonly TerminalType1 VicoSoftware = new("vicoSoftware");

    public static readonly TerminalType1 VirtualTerminal = new("virtualTerminal");

    public static readonly TerminalType1 VistaEntertainment = new("vistaEntertainment");

    public static readonly TerminalType1 Vitalcheck = new("vitalcheck");

    public static readonly TerminalType1 VmcAddOnAndroidByodQmd = new("vmcAddOnAndroidByodQmd");

    public static readonly TerminalType1 VmcAddOnAndroidByodStandard = new("vmcAddOnAndroidByodStandard");

    public static readonly TerminalType1 VmcAddOnBundleByodQms = new("vmcAddOnBundleByodQms");

    public static readonly TerminalType1 VmcAddOnBundleByodStandard = new("vmcAddOnBundleByodStandard");

    public static readonly TerminalType1 VmcAddOnBundleCellularQmd = new("vmcAddOnBundleCellularQmd");

    public static readonly TerminalType1 VmcAddOnBundleCellularStandard = new("vmcAddOnBundleCellularStandard");

    public static readonly TerminalType1 VmcAddOnBundleWifiQmd = new("vmcAddOnBundleWifiQmd");

    public static readonly TerminalType1 VmcAddOnBundleWifiStandard = new("vmcAddOnBundleWifiStandard");

    public static readonly TerminalType1 VmcFieldBundleByodQmd = new("vmcFieldBundleByodQmd");

    public static readonly TerminalType1 VmcFieldBundleByodStandard = new("vmcFieldBundleByodStandard");

    public static readonly TerminalType1 VmcFieldBundleCellularQms = new("vmcFieldBundleCellularQms");

    public static readonly TerminalType1 VmcFieldBundleCellularStandard = new("vmcFieldBundleCellularStandard");

    public static readonly TerminalType1 VmcStoreAndroidByodQms = new("vmcStoreAndroidByodQms");

    public static readonly TerminalType1 VmcStoreAndroidByodStandard = new("vmcStoreAndroidByodStandard");

    public static readonly TerminalType1 VmcStoreBundleByodQms = new("vmcStoreBundleByodQms");

    public static readonly TerminalType1 VmcStoreBundleByodStandard = new("vmcStoreBundleByodStandard");

    public static readonly TerminalType1 VmcStoreBundleCellularQms = new("vmcStoreBundleCellularQms");

    public static readonly TerminalType1 VmcStoreBundleCellularStandard = new("vmcStoreBundleCellularStandard");

    public static readonly TerminalType1 VmcStoreBundleWifiQms = new("vmcStoreBundleWifiQms");

    public static readonly TerminalType1 VmcStoreBundleWifiStandard = new("vmcStoreBundleWifiStandard");

    public static readonly TerminalType1 VPlus = new("vPlus");

    public static readonly TerminalType1 Vsb = new("vsb");

    public static readonly TerminalType1 VsbGreenbeanRecycle = new("vsbGreenbeanRecycle");

    public static readonly TerminalType1 VsbKaizen = new("vsbKaizen");

    public static readonly TerminalType1 VsbOrderbridge = new("vsbOrderbridge");

    public static readonly TerminalType1 VsbPhonixManagedNetwork = new("vsbPhonixManagedNetwork");

    public static readonly TerminalType1 VsbSamurai = new("vsbSamurai");

    public static readonly TerminalType1 VsbVisat = new("vsbVisat");

    public static readonly TerminalType1 VsbWiretrust = new("vsbWiretrust");

    public static readonly TerminalType1 VsbXgateway = new("vsbXgateway");

    public static readonly TerminalType1 WandGift = new("wandGift");

    public static readonly TerminalType1 WaySystemsMtt5000 = new("waySystemsMtt5000");

    public static readonly TerminalType1 WendysCom = new("wendysCom");

    public static readonly TerminalType1 Whirl = new("whirl");

    public static readonly TerminalType1 Winn610S = new("winn610s");

    public static readonly TerminalType1 XpaySoftware = new("xpaySoftware");

    public static readonly TerminalType1 Xpient610 = new("xpient610");

    public static readonly TerminalType1 XpientSolutions = new("xpientSolutions");

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
