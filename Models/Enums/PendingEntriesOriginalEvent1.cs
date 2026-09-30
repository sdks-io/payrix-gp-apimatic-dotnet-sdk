using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The event that originally triggered the entry.
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// - <c>1</c> - <b>DAYS</b> The PendingEntry for an Entry that triggers every day.
/// - <c>2</c> - <b>WEEKS</b> The PendingEntry for an Entry that triggers every week.
/// - <c>3</c> - <b>MONTHS</b> The PendingEntry for an Entry that triggers every month.
/// - <c>4</c> - <b>YEARS</b> The PendingEntry for an Entry that triggers every year.
/// - <c>5</c> - <b>SINGLE</b> The PendingEntry for an Entry related to a one-off event.
/// - <c>6</c> - <b>AUTH</b> The PendingEntry for an Entry related to the time of authorization of a transaction.
/// - <c>7</c> - <b>CAPTURE</b> The PendingEntry for an Entry related to the capture time of a Transaction.
/// - <c>8</c> - <b>REFUND</b> The PendingEntry for an Entry related to when a refund transaction is processed.
/// - <c>9</c> - <b>BOARD</b> The PendingEntry for an Entry related to when the Merchant is boarded.
/// - <c>10</c> - <b>PAYOUT</b> The PendingEntry for an Entry related to when a payout is processed.
/// - <c>11</c> - <b>CHARGEBACK</b> The PendingEntry for an Entry related to when a card chargeback occurs.
/// - <c>12</c> - <b>OVERDRAFT</b> The PendingEntry for an Entry related to when an overdraft usage charge from a bank is levied.
/// - <c>13</c> - <b>INTERCHANGE</b> The PendingEntry for an Entry related to when interchange Fees are assessed for the Transactions of this Merchant.
/// - <c>14</c> - <b>PROCESSOR</b> The PendingEntry for an Entry related to when the Transactions of this Merchant are processed by a payment processor.
/// - <c>15</c> - <b>ACHFAIL</b> The PendingEntry for an Entry related to when an automated clearing house failure occurs.
/// - <c>16</c> - <b>ACCOUNT</b> The PendingEntry for an Entry related to when a bank account is verified.
/// - <c>17</c> - <b>SIFT</b> The PendingEntry for an Entry related to Transaction fraud score.
/// - <c>18</c> - <b>ADJUSTMENT</b> The PendingEntry for an Entry related to adjusted funds.
/// - <c>19</c> - <b>RETRIEVAL</b> The PendingEntry for an Entry related to Retrieval Request Chargeback.
/// - <c>20</c> - <b>ARBITRATION</b> The PendingEntry for an Entry related to Arbitration Chargeback.
/// - <c>21</c> - <b>ECSALE</b> The PendingEntry for an Entry related to an eCheck Sale.
/// - <c>22</c> - <b>ECREFUND</b> The PendingEntry for an Entry related to an eCheck Refund.
/// - <c>23</c> - <b>ECRETURN</b> The PendingEntry for an Entry related to an eCheck Return.
/// - <c>24</c> - <b>SETTLEMENT</b> The PendingEntry for an Entry related to transaction settlement.
/// - <c>25</c> - <b>MISUSE</b> The PendingEntry for an Entry related to Misuse of authorization.
/// - <c>26</c> - <b>PROFIT_SHARE</b> The PendingEntry for an Entry related to a profit sharing entry.
/// - <c>27</c> - <b>UNAUTH</b> The PendingEntry for an Entry related to an unauthorized entry.
/// - <c>28</c> - <b>ACHNOC</b> The PendingEntry for an Entry related to an ACH Notification of Change.
/// - <c>29</c> - <b>ECNOC</b> The PendingEntry for an Entry related to an eCheck Notifications of Change.
/// - <c>30</c> - <b>ECFAIL</b> The PendingEntry for an Entry related to an eCheck Fail.
/// - <c>31</c> - <b>ECNSF</b> The PendingEntry for an Entry related to an eCheck Non-Sufficient Funds.
/// - <c>32</c> - <b>CURRENCY_CONVERSION</b> The PendingEntry for an Entry related to a currency conversion.
/// - <c>33</c> - <b>TERMINAL_TXN</b> The PendingEntry for an Entry related to a terminal transaction.
/// - <c>34</c> - <b>REVERSE_PAYOUT</b> The PendingEntry for an Entry related to a payout that's been reversed.
/// - <c>35</c> - <b>PARTIAL_REVERSE_PAYOUT</b> The PendingEntry for an Entry related to a payout that's been partially reversed.
/// - <c>43</c> - <b>PAYMENT_CHECK</b> Single payment check (deprecated).
/// - <c>44</c> - <b>PAYMENT_UPDATE</b> Single payment update.
/// - <c>45</c> - <b>PAYMENT_GROUP_CHECK</b> Group payment check (deprecated).
/// - <c>46</c> - <b>PAYMENT_GROUP_UPDATE</b> Group payment update.
/// - <c>47</c> - <b>ENTRY_REFUND</b> Entry refunds.
/// - <c>51</c> - <b>STATEMENT</b> Payment of statement.
/// - <c>52</c> - <b>MERCHANT_CREATION</b> Merchant fee upon creation.
/// - <c>53</c> - <b>REALTIME_BUSINESS_SEARCH</b> Real-time business search.
/// - <c>54</c> - <b>REALTIME_MEMBER_SEARCH</b> Real-time member search.
/// - <c>55</c> - <b>MASTER_CARD_MATCH</b> Mastercard match.
/// - <c>56</c> - <b>BUSINESS_INSTANT_ID</b> Business instant ID.
/// - <c>57</c> - <b>CONSUMER_INSTANT_ID</b> Consumer instant ID.
/// - <c>58</c> - <b>THREAT_METRIX</b> Threat metrix.
/// - <c>59</c> - <b>LEGIT_SCRIPT_REGISTER</b> Legit script register.
/// - <c>60</c> - <b>EQUIFAX_CONSUMER_REPORT</b> Equifax consumer report.
/// - <c>61</c> - <b>GUIDE_STAR</b> Guidestar.
/// - <c>62</c> - <b>PAYLOAD_ATTRIBUTE</b> Internal Decision V2.
/// - <c>63</c> - <b>TIN_CHECK</b> Tin check.
/// - <c>64</c> - <b>EQUIFAX_COMMERCIAL_REPORT</b> Equifax commercial report.
/// - <c>65</c> - <b>LEGIT_SCRIPT_CHECK_MERCHANT</b> Legit script check merchant.
/// - <c>66</c> - <b>PLAID</b> Plaid.
/// - <c>67</c> - <b>STATEMENT_REVERSAL</b> Reversal of statement.
/// - <c>68</c> - <b>GIACT_ECHECK</b> GIACT call made to verify creator Echeck bank Account.
/// - <c>69</c> - <b>GIACT_BANK_ACCOUNT</b> Giact calls to verify merchant settlement account on sign-up or post-boarding account.
/// - <c>70</c> - <b>BOARD_DECISION</b> Process decision fee after board.
/// - <c>71</c> - <b>TXN_RISK_DECISION</b> Txn going through a risk decision.
/// - <c>72</c> - <b>FANF</b> External Fees.
/// - <c>73</c> - <b>MCLOCATION</b> External Fees.
/// - <c>74</c> - <b>VISAINTEGRITY</b> External Fees.
/// - <c>75</c> - <b>SAFERPAYMENTS_BASIC</b> External Fees.
/// - <c>76</c> - <b>SAFERPAYMENTS_MANAGED</b> External Fees.
/// - <c>77</c> - <b>SAFERPAYMENTS_PCI_NONVALIDATION</b> External Fees.
/// - <c>78</c> - <b>OMNITOKENS_VOLUME</b> External Fees.
/// - <c>79</c> - <b>PAYOUT_RETURN</b> Payout Return.
/// - <c>80</c> - <b>PAYOUT_PARTIAL_RETURN</b> Payout Partial Return.
/// - <c>81</c> - <b>REV_SHARE</b> Rev share.
/// - <c>82</c> - <b>CARD_SETTLEMENT</b> Txns card settlement.
/// - <c>83</c> - <b>ECHECK_SETTLEMENT</b> Txns e-check settlement.
/// - <c>84</c> - <b>REV_SHARE_CARD</b> Rev Share Schedules.
/// - <c>85</c> - <b>REV_SHARE_ECHECK</b> Rev Share Schedules.
/// - <c>86</c> - <b>REV_SHARE_DBM</b> Rev Share Schedules.
/// - <c>87</c> - <b>PREARBITRATION</b> Chargeback PreArbitration.
/// - <c>88</c> - <b>PLAID_IDENTITY_MACH</b> Plaid.
/// - <c>89</c> - <b>TXN_PLAID_IDENTITY_MACH</b> Txns Plaid.
/// - <c>90</c> - <b>PLAID_GET_IDENTITY</b> Plaid.
/// - <c>91</c> - <b>TXN_PLAID_GET_IDENTITY</b> Txns Plaid.
/// - <c>92</c> - <b>PLAID_GET_AUTH</b> Plaid.
/// - <c>93</c> - <b>TXN_PLAID_GET_AUTH</b> Txns Plaid.
/// - <c>94</c> - <b>REVERSAL</b> Chargeback Reversal.
/// - <c>95</c> - <b>REPRESENTMENT</b> Chargeback Representment.
/// - <c>96</c> - <b>OMNITOKENS_MONTHLY</b> Omnitokens Monthly Fee.
/// - <c>101</c> - <b>IC_RETAIN_PASSTHRU_REFUND</b> Interchange retain pass on refund.
/// - <c>200</c> - <b>VALUTEC_ESSENTIAL_GIFT</b> External Fees.
/// - <c>201</c> - <b>VALUTEC_ESSENTIAL_MONTHLY_TXN</b> External Fees.
/// - <c>202</c> - <b>VALUTEC_DIGITAL_GIFT_PLUS_PACKAGE</b> External Fees.
/// - <c>203</c> - <b>VALUTEC_DIGITAL_GIFT_PLUS_PACKAGE_TXN</b> External Fees.
/// - <c>204</c> - <b>VALUTEC_LOYALTY_PLUS_PACKAGE</b> External Fees.
/// - <c>205</c> - <b>VALUTEC_LOYALTY_PLUS_PACKAGE_TXN</b> External Fees.
/// - <c>206</c> - <b>VALUTEC_TRANSACTION_FEE</b> External Fees.
/// - <c>207</c> - <b>VALUTEC_SETUP_FEE</b> External Fees.
/// - <c>208</c> - <b>VALUTEC_GIFT_ACH_POOLING</b> External Fees.
/// - <c>209</c> - <b>VALUTEC_JUMP_START_KIT</b> External Fees.
/// - <c>210</c> - <b>VALUTEC_LAUNCH_BOX_KIT</b> External Fees.
/// - <c>211</c> - <b>VALUTEC_500_CUSTOM_CARDS</b> External Fees.
/// - <c>212</c> - <b>VALUTEC_MAINTENANCE_FEE</b> External Fees.
/// - <c>213</c> - <b>VALUTEC_DIGITAL_GIFT_PLUS_PACKAGE_ME</b> External Fees.
/// - <c>214</c> - <b>EFE_MWC_RESIDUAL_ATELIO</b> EFE External Fees.
/// - <c>215</c> - <b>EFE_MWC_RESIDUAL_PARAFIN</b> EFE External Fees.
/// - <c>216</c> - <b>EFE_MWC_BILLING</b> EFE External Fees.
/// - <c>217</c> - <b>FRAUDSIGHT_CNP_DECISION</b> External Fees.
/// - <c>218</c> - <b>FRAUDSIGHT_CP_DECISION</b> External Fees.
/// - <c>400</c> - <b>REVBOOST_EMBEDDED_TMS_MONTHLY</b> External Fees.
/// - <c>401</c> - <b>REVBOOST_EMBEDDED_TMS_PPT</b> External Fees.
/// - <c>402</c> - <b>TXN_THREAT_METRIX</b> External Fees.
/// - <c>403</c> - <b>THREAT_METRIX_EMAILAGE</b> External Fees.
/// - <c>404</c> - <b>THREAT_METRIX_FRAUD_POINT</b> External Fees.
/// - <c>405</c> - <b>GIACT_INQUIRY</b> External Fees.
/// - <c>406</c> - <b>GIACT_TXN_GAUTHENTICATE</b> External Fees.
/// - <c>407</c> - <b>TRULIOO_IDV</b> External Fees.
/// - <c>408</c> - <b>TRULIOO_AMLLDV</b> External Fees.
/// - <c>409</c> - <b>TRULIOO_BUSINESS_VERIFICATION</b> External Fees.
/// - <c>410</c> - <b>THREAT_METRIX_PHONE_FINDER</b> External Fees.
/// - <c>601</c> - <b>TIER_NON_QUALIFIED_COUNT</b> Risk Based Tier Fees.
/// - <c>602</c> - <b>TIER_QUALIFIED_COUNT</b> Risk Based Tier Fees.
/// - <c>603</c> - <b>TIER_MID_QUALIFIED_COUNT</b> Risk Based Tier Fees.
/// - <c>604</c> - <b>TIER_HIGH_RISK_COUNT</b> Risk Based Tier Fees.
/// - <c>605</c> - <b>TIER_NON_QUALIFIED_VOLUME</b> Risk Based Tier Fees.
/// - <c>606</c> - <b>TIER_QUALIFIED_VOLUME</b> Risk Based Tier Fees.
/// - <c>607</c> - <b>TIER_MID_QUALIFIED_VOLUME</b> Risk Based Tier Fees.
/// - <c>608</c> - <b>TIER_HIGH_RISK_VOLUME</b> Risk Based Tier Fees
/// &lt;/details&gt;
/// </summary>
[JsonConverter(typeof(IntEnumConverter<PendingEntriesOriginalEvent1>))]
public sealed record PendingEntriesOriginalEvent1 : OpenIntEnum<PendingEntriesOriginalEvent1>
{
    private PendingEntriesOriginalEvent1(long value) : base(value)
    {
    }

    public static readonly PendingEntriesOriginalEvent1 Value1 = new(1L);

    public static readonly PendingEntriesOriginalEvent1 Value2 = new(2L);

    public static readonly PendingEntriesOriginalEvent1 Value3 = new(3L);

    public static readonly PendingEntriesOriginalEvent1 Value4 = new(4L);

    public static readonly PendingEntriesOriginalEvent1 Value5 = new(5L);

    public static readonly PendingEntriesOriginalEvent1 Value6 = new(6L);

    public static readonly PendingEntriesOriginalEvent1 Value7 = new(7L);

    public static readonly PendingEntriesOriginalEvent1 Value8 = new(8L);

    public static readonly PendingEntriesOriginalEvent1 Value9 = new(9L);

    public static readonly PendingEntriesOriginalEvent1 Value10 = new(10L);

    public static readonly PendingEntriesOriginalEvent1 Value11 = new(11L);

    public static readonly PendingEntriesOriginalEvent1 Value12 = new(12L);

    public static readonly PendingEntriesOriginalEvent1 Value13 = new(13L);

    public static readonly PendingEntriesOriginalEvent1 Value14 = new(14L);

    public static readonly PendingEntriesOriginalEvent1 Value15 = new(15L);

    public static readonly PendingEntriesOriginalEvent1 Value16 = new(16L);

    public static readonly PendingEntriesOriginalEvent1 Value17 = new(17L);

    public static readonly PendingEntriesOriginalEvent1 Value18 = new(18L);

    public static readonly PendingEntriesOriginalEvent1 Value19 = new(19L);

    public static readonly PendingEntriesOriginalEvent1 Value20 = new(20L);

    public static readonly PendingEntriesOriginalEvent1 Value21 = new(21L);

    public static readonly PendingEntriesOriginalEvent1 Value22 = new(22L);

    public static readonly PendingEntriesOriginalEvent1 Value23 = new(23L);

    public static readonly PendingEntriesOriginalEvent1 Value24 = new(24L);

    public static readonly PendingEntriesOriginalEvent1 Value25 = new(25L);

    public static readonly PendingEntriesOriginalEvent1 Value26 = new(26L);

    public static readonly PendingEntriesOriginalEvent1 Value27 = new(27L);

    public static readonly PendingEntriesOriginalEvent1 Value28 = new(28L);

    public static readonly PendingEntriesOriginalEvent1 Value29 = new(29L);

    public static readonly PendingEntriesOriginalEvent1 Value30 = new(30L);

    public static readonly PendingEntriesOriginalEvent1 Value31 = new(31L);

    public static readonly PendingEntriesOriginalEvent1 Value32 = new(32L);

    public static readonly PendingEntriesOriginalEvent1 Value33 = new(33L);

    public static readonly PendingEntriesOriginalEvent1 Value34 = new(34L);

    public static readonly PendingEntriesOriginalEvent1 Value35 = new(35L);

    public static readonly PendingEntriesOriginalEvent1 Value43 = new(43L);

    public static readonly PendingEntriesOriginalEvent1 Value44 = new(44L);

    public static readonly PendingEntriesOriginalEvent1 Value45 = new(45L);

    public static readonly PendingEntriesOriginalEvent1 Value46 = new(46L);

    public static readonly PendingEntriesOriginalEvent1 Value47 = new(47L);

    public static readonly PendingEntriesOriginalEvent1 Value51 = new(51L);

    public static readonly PendingEntriesOriginalEvent1 Value52 = new(52L);

    public static readonly PendingEntriesOriginalEvent1 Value53 = new(53L);

    public static readonly PendingEntriesOriginalEvent1 Value54 = new(54L);

    public static readonly PendingEntriesOriginalEvent1 Value55 = new(55L);

    public static readonly PendingEntriesOriginalEvent1 Value56 = new(56L);

    public static readonly PendingEntriesOriginalEvent1 Value57 = new(57L);

    public static readonly PendingEntriesOriginalEvent1 Value58 = new(58L);

    public static readonly PendingEntriesOriginalEvent1 Value59 = new(59L);

    public static readonly PendingEntriesOriginalEvent1 Value60 = new(60L);

    public static readonly PendingEntriesOriginalEvent1 Value61 = new(61L);

    public static readonly PendingEntriesOriginalEvent1 Value62 = new(62L);

    public static readonly PendingEntriesOriginalEvent1 Value63 = new(63L);

    public static readonly PendingEntriesOriginalEvent1 Value64 = new(64L);

    public static readonly PendingEntriesOriginalEvent1 Value65 = new(65L);

    public static readonly PendingEntriesOriginalEvent1 Value66 = new(66L);

    public static readonly PendingEntriesOriginalEvent1 Value67 = new(67L);

    public static readonly PendingEntriesOriginalEvent1 Value68 = new(68L);

    public static readonly PendingEntriesOriginalEvent1 Value69 = new(69L);

    public static readonly PendingEntriesOriginalEvent1 Value70 = new(70L);

    public static readonly PendingEntriesOriginalEvent1 Value71 = new(71L);

    public static readonly PendingEntriesOriginalEvent1 Value72 = new(72L);

    public static readonly PendingEntriesOriginalEvent1 Value73 = new(73L);

    public static readonly PendingEntriesOriginalEvent1 Value74 = new(74L);

    public static readonly PendingEntriesOriginalEvent1 Value75 = new(75L);

    public static readonly PendingEntriesOriginalEvent1 Value76 = new(76L);

    public static readonly PendingEntriesOriginalEvent1 Value77 = new(77L);

    public static readonly PendingEntriesOriginalEvent1 Value78 = new(78L);

    public static readonly PendingEntriesOriginalEvent1 Value79 = new(79L);

    public static readonly PendingEntriesOriginalEvent1 Value80 = new(80L);

    public static readonly PendingEntriesOriginalEvent1 Value81 = new(81L);

    public static readonly PendingEntriesOriginalEvent1 Value82 = new(82L);

    public static readonly PendingEntriesOriginalEvent1 Value83 = new(83L);

    public static readonly PendingEntriesOriginalEvent1 Value84 = new(84L);

    public static readonly PendingEntriesOriginalEvent1 Value85 = new(85L);

    public static readonly PendingEntriesOriginalEvent1 Value86 = new(86L);

    public static readonly PendingEntriesOriginalEvent1 Value87 = new(87L);

    public static readonly PendingEntriesOriginalEvent1 Value88 = new(88L);

    public static readonly PendingEntriesOriginalEvent1 Value89 = new(89L);

    public static readonly PendingEntriesOriginalEvent1 Value90 = new(90L);

    public static readonly PendingEntriesOriginalEvent1 Value91 = new(91L);

    public static readonly PendingEntriesOriginalEvent1 Value92 = new(92L);

    public static readonly PendingEntriesOriginalEvent1 Value93 = new(93L);

    public static readonly PendingEntriesOriginalEvent1 Value94 = new(94L);

    public static readonly PendingEntriesOriginalEvent1 Value95 = new(95L);

    public static readonly PendingEntriesOriginalEvent1 Value96 = new(96L);

    public static readonly PendingEntriesOriginalEvent1 Value101 = new(101L);

    public static readonly PendingEntriesOriginalEvent1 Value200 = new(200L);

    public static readonly PendingEntriesOriginalEvent1 Value201 = new(201L);

    public static readonly PendingEntriesOriginalEvent1 Value202 = new(202L);

    public static readonly PendingEntriesOriginalEvent1 Value203 = new(203L);

    public static readonly PendingEntriesOriginalEvent1 Value204 = new(204L);

    public static readonly PendingEntriesOriginalEvent1 Value205 = new(205L);

    public static readonly PendingEntriesOriginalEvent1 Value206 = new(206L);

    public static readonly PendingEntriesOriginalEvent1 Value207 = new(207L);

    public static readonly PendingEntriesOriginalEvent1 Value208 = new(208L);

    public static readonly PendingEntriesOriginalEvent1 Value209 = new(209L);

    public static readonly PendingEntriesOriginalEvent1 Value210 = new(210L);

    public static readonly PendingEntriesOriginalEvent1 Value211 = new(211L);

    public static readonly PendingEntriesOriginalEvent1 Value212 = new(212L);

    public static readonly PendingEntriesOriginalEvent1 Value213 = new(213L);

    public static readonly PendingEntriesOriginalEvent1 Value214 = new(214L);

    public static readonly PendingEntriesOriginalEvent1 Value215 = new(215L);

    public static readonly PendingEntriesOriginalEvent1 Value216 = new(216L);

    public static readonly PendingEntriesOriginalEvent1 Value217 = new(217L);

    public static readonly PendingEntriesOriginalEvent1 Value218 = new(218L);

    public static readonly PendingEntriesOriginalEvent1 Value400 = new(400L);

    public static readonly PendingEntriesOriginalEvent1 Value401 = new(401L);

    public static readonly PendingEntriesOriginalEvent1 Value402 = new(402L);

    public static readonly PendingEntriesOriginalEvent1 Value403 = new(403L);

    public static readonly PendingEntriesOriginalEvent1 Value404 = new(404L);

    public static readonly PendingEntriesOriginalEvent1 Value405 = new(405L);

    public static readonly PendingEntriesOriginalEvent1 Value406 = new(406L);

    public static readonly PendingEntriesOriginalEvent1 Value407 = new(407L);

    public static readonly PendingEntriesOriginalEvent1 Value408 = new(408L);

    public static readonly PendingEntriesOriginalEvent1 Value409 = new(409L);

    public static readonly PendingEntriesOriginalEvent1 Value410 = new(410L);

    public static readonly PendingEntriesOriginalEvent1 Value601 = new(601L);

    public static readonly PendingEntriesOriginalEvent1 Value602 = new(602L);

    public static readonly PendingEntriesOriginalEvent1 Value603 = new(603L);

    public static readonly PendingEntriesOriginalEvent1 Value604 = new(604L);

    public static readonly PendingEntriesOriginalEvent1 Value605 = new(605L);

    public static readonly PendingEntriesOriginalEvent1 Value606 = new(606L);

    public static readonly PendingEntriesOriginalEvent1 Value607 = new(607L);

    public static readonly PendingEntriesOriginalEvent1 Value608 = new(608L);

    public TResult Match<TResult>(Func<TResult> onValue1,
        Func<TResult> onValue2,
        Func<TResult> onValue3,
        Func<TResult> onValue4,
        Func<TResult> onValue5,
        Func<TResult> onValue6,
        Func<TResult> onValue7,
        Func<TResult> onValue8,
        Func<TResult> onValue9,
        Func<TResult> onValue10,
        Func<TResult> onValue11,
        Func<TResult> onValue12,
        Func<TResult> onValue13,
        Func<TResult> onValue14,
        Func<TResult> onValue15,
        Func<TResult> onValue16,
        Func<TResult> onValue17,
        Func<TResult> onValue18,
        Func<TResult> onValue19,
        Func<TResult> onValue20,
        Func<TResult> onValue21,
        Func<TResult> onValue22,
        Func<TResult> onValue23,
        Func<TResult> onValue24,
        Func<TResult> onValue25,
        Func<TResult> onValue26,
        Func<TResult> onValue27,
        Func<TResult> onValue28,
        Func<TResult> onValue29,
        Func<TResult> onValue30,
        Func<TResult> onValue31,
        Func<TResult> onValue32,
        Func<TResult> onValue33,
        Func<TResult> onValue34,
        Func<TResult> onValue35,
        Func<TResult> onValue43,
        Func<TResult> onValue44,
        Func<TResult> onValue45,
        Func<TResult> onValue46,
        Func<TResult> onValue47,
        Func<TResult> onValue51,
        Func<TResult> onValue52,
        Func<TResult> onValue53,
        Func<TResult> onValue54,
        Func<TResult> onValue55,
        Func<TResult> onValue56,
        Func<TResult> onValue57,
        Func<TResult> onValue58,
        Func<TResult> onValue59,
        Func<TResult> onValue60,
        Func<TResult> onValue61,
        Func<TResult> onValue62,
        Func<TResult> onValue63,
        Func<TResult> onValue64,
        Func<TResult> onValue65,
        Func<TResult> onValue66,
        Func<TResult> onValue67,
        Func<TResult> onValue68,
        Func<TResult> onValue69,
        Func<TResult> onValue70,
        Func<TResult> onValue71,
        Func<TResult> onValue72,
        Func<TResult> onValue73,
        Func<TResult> onValue74,
        Func<TResult> onValue75,
        Func<TResult> onValue76,
        Func<TResult> onValue77,
        Func<TResult> onValue78,
        Func<TResult> onValue79,
        Func<TResult> onValue80,
        Func<TResult> onValue81,
        Func<TResult> onValue82,
        Func<TResult> onValue83,
        Func<TResult> onValue84,
        Func<TResult> onValue85,
        Func<TResult> onValue86,
        Func<TResult> onValue87,
        Func<TResult> onValue88,
        Func<TResult> onValue89,
        Func<TResult> onValue90,
        Func<TResult> onValue91,
        Func<TResult> onValue92,
        Func<TResult> onValue93,
        Func<TResult> onValue94,
        Func<TResult> onValue95,
        Func<TResult> onValue96,
        Func<TResult> onValue101,
        Func<TResult> onValue200,
        Func<TResult> onValue201,
        Func<TResult> onValue202,
        Func<TResult> onValue203,
        Func<TResult> onValue204,
        Func<TResult> onValue205,
        Func<TResult> onValue206,
        Func<TResult> onValue207,
        Func<TResult> onValue208,
        Func<TResult> onValue209,
        Func<TResult> onValue210,
        Func<TResult> onValue211,
        Func<TResult> onValue212,
        Func<TResult> onValue213,
        Func<TResult> onValue214,
        Func<TResult> onValue215,
        Func<TResult> onValue216,
        Func<TResult> onValue217,
        Func<TResult> onValue218,
        Func<TResult> onValue400,
        Func<TResult> onValue401,
        Func<TResult> onValue402,
        Func<TResult> onValue403,
        Func<TResult> onValue404,
        Func<TResult> onValue405,
        Func<TResult> onValue406,
        Func<TResult> onValue407,
        Func<TResult> onValue408,
        Func<TResult> onValue409,
        Func<TResult> onValue410,
        Func<TResult> onValue601,
        Func<TResult> onValue602,
        Func<TResult> onValue603,
        Func<TResult> onValue604,
        Func<TResult> onValue605,
        Func<TResult> onValue606,
        Func<TResult> onValue607,
        Func<TResult> onValue608,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value1 => onValue1(),
            _ when this == Value2 => onValue2(),
            _ when this == Value3 => onValue3(),
            _ when this == Value4 => onValue4(),
            _ when this == Value5 => onValue5(),
            _ when this == Value6 => onValue6(),
            _ when this == Value7 => onValue7(),
            _ when this == Value8 => onValue8(),
            _ when this == Value9 => onValue9(),
            _ when this == Value10 => onValue10(),
            _ when this == Value11 => onValue11(),
            _ when this == Value12 => onValue12(),
            _ when this == Value13 => onValue13(),
            _ when this == Value14 => onValue14(),
            _ when this == Value15 => onValue15(),
            _ when this == Value16 => onValue16(),
            _ when this == Value17 => onValue17(),
            _ when this == Value18 => onValue18(),
            _ when this == Value19 => onValue19(),
            _ when this == Value20 => onValue20(),
            _ when this == Value21 => onValue21(),
            _ when this == Value22 => onValue22(),
            _ when this == Value23 => onValue23(),
            _ when this == Value24 => onValue24(),
            _ when this == Value25 => onValue25(),
            _ when this == Value26 => onValue26(),
            _ when this == Value27 => onValue27(),
            _ when this == Value28 => onValue28(),
            _ when this == Value29 => onValue29(),
            _ when this == Value30 => onValue30(),
            _ when this == Value31 => onValue31(),
            _ when this == Value32 => onValue32(),
            _ when this == Value33 => onValue33(),
            _ when this == Value34 => onValue34(),
            _ when this == Value35 => onValue35(),
            _ when this == Value43 => onValue43(),
            _ when this == Value44 => onValue44(),
            _ when this == Value45 => onValue45(),
            _ when this == Value46 => onValue46(),
            _ when this == Value47 => onValue47(),
            _ when this == Value51 => onValue51(),
            _ when this == Value52 => onValue52(),
            _ when this == Value53 => onValue53(),
            _ when this == Value54 => onValue54(),
            _ when this == Value55 => onValue55(),
            _ when this == Value56 => onValue56(),
            _ when this == Value57 => onValue57(),
            _ when this == Value58 => onValue58(),
            _ when this == Value59 => onValue59(),
            _ when this == Value60 => onValue60(),
            _ when this == Value61 => onValue61(),
            _ when this == Value62 => onValue62(),
            _ when this == Value63 => onValue63(),
            _ when this == Value64 => onValue64(),
            _ when this == Value65 => onValue65(),
            _ when this == Value66 => onValue66(),
            _ when this == Value67 => onValue67(),
            _ when this == Value68 => onValue68(),
            _ when this == Value69 => onValue69(),
            _ when this == Value70 => onValue70(),
            _ when this == Value71 => onValue71(),
            _ when this == Value72 => onValue72(),
            _ when this == Value73 => onValue73(),
            _ when this == Value74 => onValue74(),
            _ when this == Value75 => onValue75(),
            _ when this == Value76 => onValue76(),
            _ when this == Value77 => onValue77(),
            _ when this == Value78 => onValue78(),
            _ when this == Value79 => onValue79(),
            _ when this == Value80 => onValue80(),
            _ when this == Value81 => onValue81(),
            _ when this == Value82 => onValue82(),
            _ when this == Value83 => onValue83(),
            _ when this == Value84 => onValue84(),
            _ when this == Value85 => onValue85(),
            _ when this == Value86 => onValue86(),
            _ when this == Value87 => onValue87(),
            _ when this == Value88 => onValue88(),
            _ when this == Value89 => onValue89(),
            _ when this == Value90 => onValue90(),
            _ when this == Value91 => onValue91(),
            _ when this == Value92 => onValue92(),
            _ when this == Value93 => onValue93(),
            _ when this == Value94 => onValue94(),
            _ when this == Value95 => onValue95(),
            _ when this == Value96 => onValue96(),
            _ when this == Value101 => onValue101(),
            _ when this == Value200 => onValue200(),
            _ when this == Value201 => onValue201(),
            _ when this == Value202 => onValue202(),
            _ when this == Value203 => onValue203(),
            _ when this == Value204 => onValue204(),
            _ when this == Value205 => onValue205(),
            _ when this == Value206 => onValue206(),
            _ when this == Value207 => onValue207(),
            _ when this == Value208 => onValue208(),
            _ when this == Value209 => onValue209(),
            _ when this == Value210 => onValue210(),
            _ when this == Value211 => onValue211(),
            _ when this == Value212 => onValue212(),
            _ when this == Value213 => onValue213(),
            _ when this == Value214 => onValue214(),
            _ when this == Value215 => onValue215(),
            _ when this == Value216 => onValue216(),
            _ when this == Value217 => onValue217(),
            _ when this == Value218 => onValue218(),
            _ when this == Value400 => onValue400(),
            _ when this == Value401 => onValue401(),
            _ when this == Value402 => onValue402(),
            _ when this == Value403 => onValue403(),
            _ when this == Value404 => onValue404(),
            _ when this == Value405 => onValue405(),
            _ when this == Value406 => onValue406(),
            _ when this == Value407 => onValue407(),
            _ when this == Value408 => onValue408(),
            _ when this == Value409 => onValue409(),
            _ when this == Value410 => onValue410(),
            _ when this == Value601 => onValue601(),
            _ when this == Value602 => onValue602(),
            _ when this == Value603 => onValue603(),
            _ when this == Value604 => onValue604(),
            _ when this == Value605 => onValue605(),
            _ when this == Value606 => onValue606(),
            _ when this == Value607 => onValue607(),
            _ when this == Value608 => onValue608(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue1,
        Action onValue2,
        Action onValue3,
        Action onValue4,
        Action onValue5,
        Action onValue6,
        Action onValue7,
        Action onValue8,
        Action onValue9,
        Action onValue10,
        Action onValue11,
        Action onValue12,
        Action onValue13,
        Action onValue14,
        Action onValue15,
        Action onValue16,
        Action onValue17,
        Action onValue18,
        Action onValue19,
        Action onValue20,
        Action onValue21,
        Action onValue22,
        Action onValue23,
        Action onValue24,
        Action onValue25,
        Action onValue26,
        Action onValue27,
        Action onValue28,
        Action onValue29,
        Action onValue30,
        Action onValue31,
        Action onValue32,
        Action onValue33,
        Action onValue34,
        Action onValue35,
        Action onValue43,
        Action onValue44,
        Action onValue45,
        Action onValue46,
        Action onValue47,
        Action onValue51,
        Action onValue52,
        Action onValue53,
        Action onValue54,
        Action onValue55,
        Action onValue56,
        Action onValue57,
        Action onValue58,
        Action onValue59,
        Action onValue60,
        Action onValue61,
        Action onValue62,
        Action onValue63,
        Action onValue64,
        Action onValue65,
        Action onValue66,
        Action onValue67,
        Action onValue68,
        Action onValue69,
        Action onValue70,
        Action onValue71,
        Action onValue72,
        Action onValue73,
        Action onValue74,
        Action onValue75,
        Action onValue76,
        Action onValue77,
        Action onValue78,
        Action onValue79,
        Action onValue80,
        Action onValue81,
        Action onValue82,
        Action onValue83,
        Action onValue84,
        Action onValue85,
        Action onValue86,
        Action onValue87,
        Action onValue88,
        Action onValue89,
        Action onValue90,
        Action onValue91,
        Action onValue92,
        Action onValue93,
        Action onValue94,
        Action onValue95,
        Action onValue96,
        Action onValue101,
        Action onValue200,
        Action onValue201,
        Action onValue202,
        Action onValue203,
        Action onValue204,
        Action onValue205,
        Action onValue206,
        Action onValue207,
        Action onValue208,
        Action onValue209,
        Action onValue210,
        Action onValue211,
        Action onValue212,
        Action onValue213,
        Action onValue214,
        Action onValue215,
        Action onValue216,
        Action onValue217,
        Action onValue218,
        Action onValue400,
        Action onValue401,
        Action onValue402,
        Action onValue403,
        Action onValue404,
        Action onValue405,
        Action onValue406,
        Action onValue407,
        Action onValue408,
        Action onValue409,
        Action onValue410,
        Action onValue601,
        Action onValue602,
        Action onValue603,
        Action onValue604,
        Action onValue605,
        Action onValue606,
        Action onValue607,
        Action onValue608,
        Action<long> otherwise)
    {
        if (this == Value1) onValue1();
        else if (this == Value2) onValue2();
        else if (this == Value3) onValue3();
        else if (this == Value4) onValue4();
        else if (this == Value5) onValue5();
        else if (this == Value6) onValue6();
        else if (this == Value7) onValue7();
        else if (this == Value8) onValue8();
        else if (this == Value9) onValue9();
        else if (this == Value10) onValue10();
        else if (this == Value11) onValue11();
        else if (this == Value12) onValue12();
        else if (this == Value13) onValue13();
        else if (this == Value14) onValue14();
        else if (this == Value15) onValue15();
        else if (this == Value16) onValue16();
        else if (this == Value17) onValue17();
        else if (this == Value18) onValue18();
        else if (this == Value19) onValue19();
        else if (this == Value20) onValue20();
        else if (this == Value21) onValue21();
        else if (this == Value22) onValue22();
        else if (this == Value23) onValue23();
        else if (this == Value24) onValue24();
        else if (this == Value25) onValue25();
        else if (this == Value26) onValue26();
        else if (this == Value27) onValue27();
        else if (this == Value28) onValue28();
        else if (this == Value29) onValue29();
        else if (this == Value30) onValue30();
        else if (this == Value31) onValue31();
        else if (this == Value32) onValue32();
        else if (this == Value33) onValue33();
        else if (this == Value34) onValue34();
        else if (this == Value35) onValue35();
        else if (this == Value43) onValue43();
        else if (this == Value44) onValue44();
        else if (this == Value45) onValue45();
        else if (this == Value46) onValue46();
        else if (this == Value47) onValue47();
        else if (this == Value51) onValue51();
        else if (this == Value52) onValue52();
        else if (this == Value53) onValue53();
        else if (this == Value54) onValue54();
        else if (this == Value55) onValue55();
        else if (this == Value56) onValue56();
        else if (this == Value57) onValue57();
        else if (this == Value58) onValue58();
        else if (this == Value59) onValue59();
        else if (this == Value60) onValue60();
        else if (this == Value61) onValue61();
        else if (this == Value62) onValue62();
        else if (this == Value63) onValue63();
        else if (this == Value64) onValue64();
        else if (this == Value65) onValue65();
        else if (this == Value66) onValue66();
        else if (this == Value67) onValue67();
        else if (this == Value68) onValue68();
        else if (this == Value69) onValue69();
        else if (this == Value70) onValue70();
        else if (this == Value71) onValue71();
        else if (this == Value72) onValue72();
        else if (this == Value73) onValue73();
        else if (this == Value74) onValue74();
        else if (this == Value75) onValue75();
        else if (this == Value76) onValue76();
        else if (this == Value77) onValue77();
        else if (this == Value78) onValue78();
        else if (this == Value79) onValue79();
        else if (this == Value80) onValue80();
        else if (this == Value81) onValue81();
        else if (this == Value82) onValue82();
        else if (this == Value83) onValue83();
        else if (this == Value84) onValue84();
        else if (this == Value85) onValue85();
        else if (this == Value86) onValue86();
        else if (this == Value87) onValue87();
        else if (this == Value88) onValue88();
        else if (this == Value89) onValue89();
        else if (this == Value90) onValue90();
        else if (this == Value91) onValue91();
        else if (this == Value92) onValue92();
        else if (this == Value93) onValue93();
        else if (this == Value94) onValue94();
        else if (this == Value95) onValue95();
        else if (this == Value96) onValue96();
        else if (this == Value101) onValue101();
        else if (this == Value200) onValue200();
        else if (this == Value201) onValue201();
        else if (this == Value202) onValue202();
        else if (this == Value203) onValue203();
        else if (this == Value204) onValue204();
        else if (this == Value205) onValue205();
        else if (this == Value206) onValue206();
        else if (this == Value207) onValue207();
        else if (this == Value208) onValue208();
        else if (this == Value209) onValue209();
        else if (this == Value210) onValue210();
        else if (this == Value211) onValue211();
        else if (this == Value212) onValue212();
        else if (this == Value213) onValue213();
        else if (this == Value214) onValue214();
        else if (this == Value215) onValue215();
        else if (this == Value216) onValue216();
        else if (this == Value217) onValue217();
        else if (this == Value218) onValue218();
        else if (this == Value400) onValue400();
        else if (this == Value401) onValue401();
        else if (this == Value402) onValue402();
        else if (this == Value403) onValue403();
        else if (this == Value404) onValue404();
        else if (this == Value405) onValue405();
        else if (this == Value406) onValue406();
        else if (this == Value407) onValue407();
        else if (this == Value408) onValue408();
        else if (this == Value409) onValue409();
        else if (this == Value410) onValue410();
        else if (this == Value601) onValue601();
        else if (this == Value602) onValue602();
        else if (this == Value603) onValue603();
        else if (this == Value604) onValue604();
        else if (this == Value605) onValue605();
        else if (this == Value606) onValue606();
        else if (this == Value607) onValue607();
        else if (this == Value608) onValue608();
        else otherwise(Value);
    }
}
