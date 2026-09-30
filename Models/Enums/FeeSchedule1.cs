using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The schedule that determines when this Fee is triggered to be charged.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <para>
///  <c>1</c> - <b>Days.</b> The Fee is charged every day.
/// </para>
/// <para>
///  <c>2</c> - <b>Weeks.</b> The Fee is charged every week.
/// </para>
/// <para>
///  <c>3</c> - <b>Months.</b> The Fee is charged every month.
/// </para>
/// <para>
///  <c>4</c> - <b>Years.</b> The Fee is charged every year.
/// </para>
/// <para>
///  <c>5</c> - <b>Single.</b> The Fee is a one-off charge.
/// </para>
/// <para>
///  <c>6</c> - <b>Auth.</b> The Fee is triggered at the time of authorization of a transaction.
/// </para>
/// <para>
///  <c>7</c> - <b>Capture.</b> The Fee triggers at the capture time of a Transaction.
/// </para>
/// <para>
///  <c>8</c> - <b>Refund.</b> The Fee triggers when a refund transaction is processed.
/// </para>
/// <para>
///  <c>9</c> - <b>Board.</b> The Fee triggers when the Merchant is boarded.
/// </para>
/// <para>
///  <c>10</c> - <b>Payout.</b> The Fee triggers when a payout is processed.
/// </para>
/// <para>
///  <c>11</c> - <b>Chargeback.</b> The Fee triggers when a card chargeback occurs.
/// </para>
/// <para>
///  <c>12</c> - <b>Overdraft.</b> The Fee triggers when an overdraft usage charge from a bank is levied.
/// </para>
/// <para>
///  <c>13</c> - <b>Interchange.</b> The Fee triggers when interchange default are assessed for the Transactions of this Merchant.
/// </para>
/// <para>
///  <c>14</c> - <b>Processor.</b> The Fee triggers when the Transactions of this Merchant are processed by a payment processor.
/// </para>
/// <para>
///  <c>15</c> - <b>ACH failure.</b> The Fee triggers when an automated clearing house failure occurs.
/// </para>
/// <para>
///  <c>16</c> - <b>Account.</b> The Fee triggers when a bank account is verified.
/// </para>
/// <para>
///  <c>17</c> - <b>Sift.</b> The Fee triggers when a txn uses SIFT for fraud checking.
/// </para>
/// <para>
///  <c>18</c> - <b>Adjustment.</b> The Fee triggers when an adjustment is created.
/// </para>
/// <para>
///  <c>19</c> - <b>Retrieval.</b> The Fee triggers when a chargeback retrieval is processed.
/// </para>
/// <para>
///  <c>20</c> - <b>Arbitration.</b> The Fee triggers when a chargeback arbitration is processed.
/// </para>
/// <para>
///  <c>21</c> - <b>eCheck Sale.</b> The Fee triggers when an eCheck sale is processed.
/// </para>
/// <para>
///  <c>22</c> - <b>eCheck Refund.</b> The Fee triggers when an eCheck refund is processed.
/// </para>
/// <para>
///  <c>23</c> - <b>eCheck Return.</b> The Fee triggers when an eCheck txn is returned because of a failure while processing.
/// </para>
/// <para>
///  <c>24</c> - <b>Settlement.</b> The Fee triggers when a txn is settled.
/// </para>
/// <para>
///  <c>25</c> - <b>Misuse.</b> The Fee triggers when a txn authorization is misused.
/// </para>
/// <para>
///  <c>26</c> - <b>Profit share.</b> The Fee triggers when a profit share is executed.
/// </para>
/// <para>
///  <c>27</c> - <b>Unauth.</b> The Fee triggers when an auth reversal is created.
/// </para>
/// <para>
///  <c>28</c> - <b>Disbursement NOC.</b> The Fee triggers on Notice Of Change events for Disbursements.
/// </para>
/// <para>
///  <c>29</c> - <b>Transaction NOC.</b> The Fee triggers on Notice Of Change events for Transactions.
/// </para>
/// <para>
///  <c>30</c> - <b>eCheck failure return.</b> The Fee triggers when an eCheck txn is returned due to customer rejection or incorrect account information.
/// </para>
/// <para>
///  <c>31</c> - <b>eCheck NSF return.</b> The Fee triggers when an eCheck txn is returned due to insufficient funds.
/// </para>
/// <para>
///  <c>32</c> - <b>Currency conversion.</b> The Fee triggers when there is a currency conversion on a transaction.
/// </para>
/// <para>
///  <c>33</c> - <b>Terminal transaction.</b> The Fee triggers when there is a transaction processed via a terminal.
/// </para>
/// <para>
///  <c>34</c> - <b>Reverse payout.</b> The Fee triggers when a payout is reversed.
/// </para>
/// <para>
///  <c>35</c> - <b>Partial reverse payout.</b> The Fee triggers when a payout is partially reversed.
/// </para>
/// <para>
///  <c>43</c> - <b>Payment check.</b> The Fee triggers on a payment check.
/// </para>
/// <para>
///  <c>44</c> - <b>Payment update.</b> The Fee triggers when a payment is updated.
/// </para>
/// <para>
///  <c>45</c> - <b>Payment group check.</b> The Fee triggers on a payment group check.
/// </para>
/// <para>
///  <c>46</c> - <b>Payment group update.</b> The Fee triggers on a payment group update.
/// </para>
/// <para>
///  <c>47</c> - <b>Entry refund.</b> The Fee triggers when an entry is refunded.
/// </para>
/// <para>
///  <c>51</c> - <b>Statement Payment.</b> A statement bill was paid.
/// </para>
/// <para>
///  <c>52</c> - <b>Merchant Created.</b> A new Merchant entity has been created, but not boarded.
/// </para>
/// <para>
///  <c>53</c> - <b>Realtime Business Search.</b> Real-time Business Entity OFAC Search from Bridger by LexisNexis.
/// </para>
/// <para>
///  <c>54</c> - <b>Realtime Member Search.</b> Real-time Business Entity Managing Member Personal OFAC Search from Bridger by LexisNexis.
/// </para>
/// <para>
///  <c>55</c> - <b>MasterCard MATCH.</b> Merchant History Check from Mastercard Alert To Control High-risk Merchants (MATCH) program.
/// </para>
/// <para>
///  <c>56</c> - <b>Business Instant ID.</b> KYB Verification from LexisNexis.
/// </para>
/// <para>
///  <c>57</c> - <b>Consumer Instance ID.</b> KYC Verification from LexisNexis.
/// </para>
/// <para>
///  <c>58</c> - <b>ThreatMetrix.</b> Not for partner/referrer use.
/// </para>
/// <para>
///  <c>59</c> - <b>LegitScript Registration.</b> Merchant Compliance and Risk Rating Checks.
/// </para>
/// <para>
///  <c>60</c> - <b>Equifax Consumer Report.</b> Business owner's consumer credit report from Equifax.
/// </para>
/// <para>
///  <c>61</c> - <b>CharityCheck.</b> Business entity nonprofit eligibility verification from GuideStar.
/// </para>
/// <para>
///  <c>62</c> - <b>Internal Decision V2.</b> Payrix Risk services decision.
/// </para>
/// <para>
///  <c>63</c> - <b>TIN Check.</b> Tax Identification Number matching service for tax identity management from Sovos.
/// </para>
/// <para>
///  <c>64</c> - <b>Equifax Commercial Report.</b> Entity's commercial credit report from Equifax.
/// </para>
/// <para>
///  <c>65</c> - <b>LegitScript Merchant Check.</b> Merchant Compliance and Risk Rating Checks.
/// </para>
/// <para>
///  <c>66</c> - <b>Plaid.</b> Bank account link, info update and verification services.
/// </para>
/// <para>
///  <c>67</c> - <b>Statement Reversal.</b> A statement eCheck payment was reversed.
/// </para>
/// <para>
///  <c>68</c> - <b>GIACT eCheck Verification.</b> Real-time account status check for consumer and business bank accounts from gVerify by GIACT.
/// </para>
/// <para>
///  <c>69</c> - <b>GIACT Account Verification.</b> Real-time Business Entity Owner identity &amp; authorized signer status verification from gAuthenticate by GIACT.
/// </para>
/// <para>
///  <c>70</c> - <b>Boarding Decision.</b> Merchant boarding decision made by the platform via risk checks.
/// </para>
/// <para>
///  <c>71</c> - <b>Transaction Risk Decision.</b> Transaction decision made by the platform via risk checks.
/// </para>
/// <para>
///  <c>72</c> - <b>FANF.</b> Fixed Acquirer Network Fee from Visa for Merchants processing card-present and card-not-present transactions.
/// </para>
/// <para>
///  <c>73</c> - <b>MCLocation.</b> Merchant Location Fee from Mastercard for Merchants processing card-present and card-not-present transactions.
/// </para>
/// <para>
///  <c>74</c> - <b>VisaIntegrity.</b> Transaction Integrity Fee from Visa.
/// </para>
/// <para>
///  <c>75</c> - <b>SaferPayments: Basic.</b> PCI DSS Compliance Portal from WorldPay for Partner and Facilitator Merchant portfolios.
/// </para>
/// <para>
///  <c>76</c> - <b>SaferPayments: Managed.</b> PCI DSS Compliance Managed Services from WorldPay for Merchants in Partner and Facilitator portfolios.
/// </para>
/// <para>
///  <c>77</c> - <b>SaferPayments - PCI Non-Validation.</b> PCI DSS Compliance Portal and/or services were provided but the Merchant failed to meet PCI DSS Compliance.
/// </para>
/// <para>
///  <c>78</c> - <b>OMNITOKENS_VOLUME.</b> Omni-Channel payment tokenization from WorldPay.
/// </para>
/// <para>
///  <c>79</c> - <b>Payout Return.</b> A Payout Disbursement was returned when attempted.
/// </para>
/// <para>
///  <c>80</c> - <b>Payout Partial Return.</b> A Payout Disbursement was partially returned when attempted.
/// </para>
/// <para>
///  <c>81</c> - <b>Revenue Share.</b> A configuration of multiple entities dividing revenue.
/// </para>
/// <para>
///  <c>82</c> - <b>Card Settlement.</b> The funds from a card payment captured and authorized in a transaction have been settled.
/// </para>
/// <para>
///  <c>83</c> - <b>eCheck Settlement.</b> The funds from an ACH/eCheck payment used in a transaction have been settled.
/// </para>
/// <para>
///  <c>84</c> - <b>Revenue Share from Card.</b> Funds have been captured in a Revenue Share configuration from a card payment transaction.
/// </para>
/// <para>
///  <c>85</c> - <b>Revenue Share from eCheck.</b> Funds have been captured in a Revenue Share configuration from an ACH / eCheck payment transaction.
/// </para>
/// <para>
///  <c>86</c> - <b>Revenue Share Payout.</b> Funds from a Revenue Share capture have been settled and disbursed to the applicable entities.
///
///  <c>88</c> - <b>PLAID_IDENTITY_MACH</b>
///
///  <c>89</c> - <b>TXN_PLAID_IDENTITY_MACH</b>
///
///  <c>90</c> - <b>PLAID_GET_IDENTITY</b>
///
///  <c>91</c> - <b>TXN_PLAID_GET_IDENTITY</b>
///
///  <c>92</c> - <b>PLAID_GET_AUTH</b>
///
///  <c>93</c> - <b>TXN_PLAID_GET_AUTH</b>
///
///  <c>96</c> - <b>OMNITOKENS_MONTHLY</b> Omnitokens Monthly Fee.
///
///  <c>200</c> - <b>VALUTEC_ESSENTIAL_GIFT. External Fees</b>
/// </para>
/// <para>
///  <c>201</c> - <b>VALUTEC_ESSENTIAL_MONTHLY_TXN. External Fees</b>
/// </para>
/// <para>
///  <c>202</c> - <b>VALUTEC_DIGITAL_GIFT_PLUS_PACKAGE. External Fees</b>
/// </para>
/// <para>
///  <c>203</c> - <b>VALUTEC_DIGITAL_GIFT_PLUS_PACKAGE_TXN. External Fees</b>
/// </para>
/// <para>
///  <c>204</c> - <b>VALUTEC_LOYALTY_PLUS_PACKAGE. External Fees</b>
/// </para>
/// <para>
///  <c>205</c> - <b>VALUTEC_LOYALTY_PLUS_PACKAGE_TXN. External Fees</b>
/// </para>
/// <para>
///  <c>206</c> - <b>VALUTEC_TRANSACTION_FEE. External Fees</b>
/// </para>
/// <para>
///  <c>207</c> - <b>VALUTEC_SETUP_FEE. External Fees</b>
/// </para>
/// <para>
///  <c>208</c> - <b>VALUTEC_GIFT_ACH_POOLING. External Fees</b>
/// </para>
/// <para>
///  <c>209</c> - <b>VALUTEC_JUMP_START_KIT. External Fees</b>
/// </para>
/// <para>
///  <c>210</c> - <b>VALUTEC_LAUNCH_BOX_KIT. External Fees</b>
/// </para>
/// <para>
///  <c>211</c> - <b>VALUTEC_500_CUSTOM_CARDS. External Fees</b>
/// </para>
/// <para>
///  <c>212</c> - <b>VALUTEC_MAINTENANCE_FEE. External Fees</b>
/// </para>
/// <para>
///  <c>213</c> - <b>VALUTEC_DIGITAL_GIFT_PLUS_PACKAGE_ME. External Fees</b>
/// </para>
/// <para>
///  <c>214</c> - <b>EFE_MWC_RESIDUAL_ATELIO</b>
/// </para>
/// <para>
///  <c>215</c> - <b>EFE_MWC_RESIDUAL_PARAFIN</b>
/// </para>
/// <para>
///  <c>216</c> - <b>EFE_MWC_BILLING</b>
/// </para>
/// <para>
///  <c>217</c> - <b>FRAUDSIGHT_CNP_DECISION</b>
/// </para>
/// <para>
///  <c>218</c> - <b>FRAUDSIGHT_CP_DECISION</b>
/// </para>
/// <para>
///  <c>230</c> - <b>VALUTEC_OVERAGE_TRANSACTION_FEE. External Fees</b>
/// </para>
/// <para>
///  <c>231</c> - <b>VALUTEC_STANDARD_MOBILE_PASS_MONTHLY_APPLE. External Fees</b>
/// </para>
/// <para>
///  <c>232</c> - <b>VALUTEC_NFC_MOBILE_PASS_MONTHLY. External Fees</b>
/// </para>
/// <para>
///  <c>233</c> - <b>VALUTEC_STANDARD_MOBILE_PASS_MONTHLY_GOOGLE. External Fees</b>
/// </para>
/// <para>
///  <c>234</c> - <b>VALUTEC_ONLINE_GIFT_WEBSITE_MONTHLY. External Fees</b>
/// </para>
/// <para>
///  <c>235</c> - <b>VALUTEC_MARKETING_360_MONTHLY. External Fees</b>
/// </para>
/// <para>
///  <c>236</c> - <b>VALUTEC_ONLINE_GIFT_CARD_VOLUME_FEE. External Fees</b>
/// </para>
/// <para>
///  <c>237</c> - <b>VALUTEC_SOCIAL_SHARING_MONTHLY. External Fees</b>
/// </para>
/// <para>
///  <c>238</c> - <b>VALUTEC_DIGICARD_MONTHLY. External Fees</b>
/// </para>
/// <para>
///  <c>239</c> - <b>VALUTEC_LOYALTY_STANDARD_MONTHLY. External Fees</b>
/// </para>
/// <para>
///  <c>240</c> - <b>VALUTEC_AUTO_REWARDS_LPR_MONTHLY. External Fees</b>
/// </para>
/// <para>
///  <c>241</c> - <b>VALUTEC_ONECARD_SETUP_FEE. External Fees</b>
/// </para>
/// <para>
///  <c>242</c> - <b>VALUTEC_ONECARD_MONTHLY_FEE. External Fees</b>
/// </para>
/// <para>
///  <c>243</c> - <b>VALUTEC_MONTHLY_FEE_CHOICE. External Fees</b>
/// </para>
/// <para>
///  <c>244</c> - <b>VALUTEC_SYSTEM_ACCESS. External Fees</b>
/// </para>
/// <para>
///  <c>245</c> - <b>VALUTEC_TRANSACTION. External Fees</b>
/// </para>
/// <para>
///  <c>246</c> - <b>VALUTEC_MONTHLY_FEE_LAUNCHBOX. External Fees</b>
/// </para>
/// <para>
///  <c>247</c> - <b>VALUTEC_MONTHLY_FEE_JUMPSTART</b>
/// </para>
/// <para>
///  <c>248</c> - <b>VALUTEC_ONECARD_PHYSICAL_FULFILLMENT_FEE. External Fees</b>
/// </para>
/// <para>
///  <c>249</c> - <b>VALUTEC_ONECARD_VIRTUAL_FULFILLMENT_FEE. External Fees</b>
/// </para>
/// <para>
///  <c>250</c> - <b>VALUTEC_CUSTOMIZED_REPORTING. External Fees</b>
/// </para>
/// <para>
///  <c>251</c> - <b>VALUTEC_TRANSACTION_FILE_FEED. External Fees</b>
/// </para>
/// <para>
///  <c>252</c> - <b>VALUTEC_250_CUSTOM_CARDS. External Fees</b>
/// </para>
/// <para>
///  <c>253</c> - <b>VALUTEC_1000_CUSTOM_CARDS. External Fees</b>
/// </para>
/// <para>
///  <c>254</c> - <b>VALUTEC_2500_CUSTOM_CARDS. External Fees</b>
/// </para>
/// <para>
///  <c>255</c> - <b>VALUTEC_5000_CUSTOM_CARDS. External Fees</b>
/// </para>
/// <para>
///  <c>256</c> - <b>VALUTEC_10000_CUSTOM_CARDS. External Fees</b>
///
///  <c>257</c> - <b>VALUTEC_15000_CUSTOM_CARDS. External Fees</b>
///
///  <c>258</c> - <b>VALUTEC_20000_CUSTOM_CARDS. External Fees</b>
///
///  <c>259</c> - <b>VALUTEC_25000_CUSTOM_CARDS. External Fees</b>
///
///  <c>260</c> - <b>VALUTEC_250_EXPRESS_CARDS. External Fees</b>
/// </para>
/// <para>
///  <c>261</c> - <b>VALUTEC_500_EXPRESS_CARDS. External Fees</b>
/// </para>
/// <para>
///  <c>262</c> - <b>VALUTEC_1000_EXPRESS_CARD. External FeesS</b>
///
///  <c>263</c> - <b>VALUTEC_2500_EXPRESS_CARDS. External Fees</b>
///
///  <c>264</c> - <b>VALUTEC_5000_EXPRESS_CARDS. External Fees</b>
///
///  <c>265</c> - <b>VALUTEC_10000_EXPRESS_CARDS. External Fees</b>
/// </para>
/// <para>
///  <c>266</c> - <b>VALUTEC_SPECIALTY_CARDS. External Fees</b>
/// </para>
/// <para>
///  <c>267</c> - <b>VALUTEC_KEYTAGS. External Fees</b>
/// </para>
/// <para>
///  <c>268</c> - <b>VALUTEC_SLEEVES_CARRIERS_HANGERS. External Fees</b>
/// </para>
/// <para>
///  <c>269</c> - <b>VALUTEC_SIGNATURE_PANEL. External Fees</b>
/// </para>
/// <para>
///  <c>270</c> - <b>VALUTEC_4_4_PRINTING. External Fees</b>
///
///  <c>271</c> - <b>VALUTEC_SPECIALTY_FINISH. External Fees</b>
/// </para>
/// <para>
///  <c>272</c> - <b>VALUTEC_PANTONE. External Fees</b>
/// </para>
/// <para>
///  <c>273</c> - <b>VALUTEC_PIN_SCRATCH. External Fees</b>
/// </para>
/// <para>
///  <c>274</c> - <b>VALUTEC_MERCHANDISE. External Fees</b>
/// </para>
/// <para>
///  <c>275</c> - <b>VALUTEC_GIFT_CARD_DESIGN_SETUP_FEE. External Fees</b>
/// </para>
/// <para>
///  <c>276</c> - <b>VALUTEC_SHIPPING_HANDLING. External Fees</b>
/// </para>
/// <para>
///  <c>277</c> - <b>VALUTEC_RUSH_FEES. External Fees</b>
/// </para>
/// <para>
///  <c>278</c> - <b>VALUTEC_SEQUENCING. External Fees</b>
/// </para>
/// <para>
///  <c>279</c> - <b>VALUTEC_WHOLESALE_FULFILLMENT_FEE. External Fees</b>
/// </para>
/// <para>
///  <c>280</c> - <b>VALUTEC_MISCELLANEOUS_FEES. External Fees</b>
/// </para>
/// <para>
///  <c>281</c> - <b>VALUTEC_HOSTING_FEE. External Fees</b>
/// </para>
/// <para>
///  <c>282</c> - <b>VALUTEC_STORECARD_MONTHLY_FEE. External Fees</b>
/// </para>
/// <para>
///  <c>283</c> - <b>VALUTEC_GIFT_ACH_FEE_MONTHLY. External Fees</b>
/// </para>
/// <para>
///  <c>284</c> - <b>VALUTEC_ONECARD_MONTHLY_FEE_STORECARD. External Fees</b>
/// </para>
/// <para>
///  <c>400</c> - <b>REVBOOST_EMBEDDED_TMS_MONTHLY</b>
/// </para>
/// <para>
///  <c>401</c> - <b>REVBOOST_EMBEDDED_TMS_PPT</b>
/// </para>
/// <para>
///  <c>402</c> - <b>TXN_THREAT_METRIX. External Fees</b>
/// </para>
/// <para>
///  <c>403</c> - <b>THREAT_METRIX_EMAILAGE. External Fees</b>
/// </para>
/// <para>
///  <c>404</c> - <b>THREAT_METRIX_FRAUD_POINT. External Fees</b>
/// </para>
/// <para>
///  <c>405</c> - <b>GIACT_INQUIRY. External Fees</b>
/// </para>
/// <para>
///  <c>406</c> - <b>GIACT_TXN_GAUTHENTICATE. External Fees</b>
/// </para>
/// <para>
///  <c>407</c> - <b>TRULIOO_IDV. External Fees</b>
/// </para>
/// <para>
///  <c>408</c> - <b>TRULIOO_AMLLDV. External Fees</b>
/// </para>
/// <para>
///  <c>409</c> - <b>TRULIOO_BUSINESS_VERIFICATION. External Fees</b>
/// </para>
/// <para>
///  <c>410</c> - <b>THREAT_METRIX_PHONE_FINDER. External Fees</b>
/// </para>
/// <para>
///  <c>601</c> - <b>TIER_NON_QUALIFIED_COUNT</b>
/// </para>
/// <para>
///  <c>602</c> - <b>TIER_QUALIFIED_COUNT</b>
/// </para>
/// <para>
///  <c>603</c> - <b>TIER_MID_QUALIFIED_COUNT</b>
/// </para>
/// <para>
///  <c>604</c> - <b>TIER_HIGH_RISK_COUNT</b>
/// </para>
/// <para>
///  <c>605</c> - <b>TIER_NON_QUALIFIED_VOLUME</b>
/// </para>
/// <para>
///  <c>606</c> - <b>TIER_QUALIFIED_VOLUME</b>
/// </para>
/// <para>
///  <c>607</c> - <b>TIER_MID_QUALIFIED_VOLUME</b>
/// </para>
/// <para>
///  <c>608</c> - <b>TIER_HIGH_RISK_VOLUME</b>
/// </para>
/// <para>
///  <c>701</c> - <b>NYCE_ANNUAL_FEE</b>
/// </para>
/// <para>
///  <c>702</c> - <b>PULSE_ANNUAL_FEE</b>
/// </para>
/// <para>
///  <c>703</c> - <b>CU24_ANNUAL_FEE</b>
/// </para>
/// <para>
///  <c>704</c> - <b>STAR_ANNUAL_FEE</b>
/// </para>
/// <para>
///  <c>705</c> - <b>ACCEL_ANNUAL_FEE</b>
/// </para>
/// <para>
///  <c>801</c> - <b>INGENICO_LINK_2500</b>, Canada (inactive)
/// </para>
/// <para>
///  <c>802</c> - <b>INGENICO_LANE_3600_STD</b>, Canada
/// </para>
/// <para>
///  <c>803</c> - <b>INGENICO_LANE_3600_DLX</b>, Canada (inactive)
/// </para>
/// <para>
///  <c>804</c> - <b>INGENICO_LANE_7000_STD</b>, Canada
/// </para>
/// <para>
///  <c>805</c> - <b>INGENICO_LANE_7000_DLX</b>, Canada (inactive)
/// </para>
/// <para>
///  <c>806</c> - <b>INGENICO_MOVE_5000</b>, Canada (inactive)
/// </para>
/// <para>
///  <c>807</c> - <b>PAYRIX_EQUIPMENT_SETUP_FEE</b>
/// </para>
/// <para>
///  &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<FeeSchedule1>))]
public sealed record FeeSchedule1 : OpenIntEnum<FeeSchedule1>
{
    private FeeSchedule1(long value) : base(value)
    {
    }

    public static readonly FeeSchedule1 Value1 = new(1L);

    public static readonly FeeSchedule1 Value2 = new(2L);

    public static readonly FeeSchedule1 Value3 = new(3L);

    public static readonly FeeSchedule1 Value4 = new(4L);

    public static readonly FeeSchedule1 Value5 = new(5L);

    public static readonly FeeSchedule1 Value6 = new(6L);

    public static readonly FeeSchedule1 Value7 = new(7L);

    public static readonly FeeSchedule1 Value8 = new(8L);

    public static readonly FeeSchedule1 Value9 = new(9L);

    public static readonly FeeSchedule1 Value10 = new(10L);

    public static readonly FeeSchedule1 Value11 = new(11L);

    public static readonly FeeSchedule1 Value12 = new(12L);

    public static readonly FeeSchedule1 Value13 = new(13L);

    public static readonly FeeSchedule1 Value14 = new(14L);

    public static readonly FeeSchedule1 Value15 = new(15L);

    public static readonly FeeSchedule1 Value16 = new(16L);

    public static readonly FeeSchedule1 Value17 = new(17L);

    public static readonly FeeSchedule1 Value18 = new(18L);

    public static readonly FeeSchedule1 Value19 = new(19L);

    public static readonly FeeSchedule1 Value20 = new(20L);

    public static readonly FeeSchedule1 Value21 = new(21L);

    public static readonly FeeSchedule1 Value22 = new(22L);

    public static readonly FeeSchedule1 Value23 = new(23L);

    public static readonly FeeSchedule1 Value24 = new(24L);

    public static readonly FeeSchedule1 Value25 = new(25L);

    public static readonly FeeSchedule1 Value26 = new(26L);

    public static readonly FeeSchedule1 Value27 = new(27L);

    public static readonly FeeSchedule1 Value28 = new(28L);

    public static readonly FeeSchedule1 Value29 = new(29L);

    public static readonly FeeSchedule1 Value30 = new(30L);

    public static readonly FeeSchedule1 Value31 = new(31L);

    public static readonly FeeSchedule1 Value32 = new(32L);

    public static readonly FeeSchedule1 Value33 = new(33L);

    public static readonly FeeSchedule1 Value34 = new(34L);

    public static readonly FeeSchedule1 Value35 = new(35L);

    public static readonly FeeSchedule1 Value43 = new(43L);

    public static readonly FeeSchedule1 Value44 = new(44L);

    public static readonly FeeSchedule1 Value45 = new(45L);

    public static readonly FeeSchedule1 Value46 = new(46L);

    public static readonly FeeSchedule1 Value47 = new(47L);

    public static readonly FeeSchedule1 Value51 = new(51L);

    public static readonly FeeSchedule1 Value52 = new(52L);

    public static readonly FeeSchedule1 Value53 = new(53L);

    public static readonly FeeSchedule1 Value54 = new(54L);

    public static readonly FeeSchedule1 Value55 = new(55L);

    public static readonly FeeSchedule1 Value56 = new(56L);

    public static readonly FeeSchedule1 Value57 = new(57L);

    public static readonly FeeSchedule1 Value58 = new(58L);

    public static readonly FeeSchedule1 Value59 = new(59L);

    public static readonly FeeSchedule1 Value60 = new(60L);

    public static readonly FeeSchedule1 Value61 = new(61L);

    public static readonly FeeSchedule1 Value62 = new(62L);

    public static readonly FeeSchedule1 Value63 = new(63L);

    public static readonly FeeSchedule1 Value64 = new(64L);

    public static readonly FeeSchedule1 Value65 = new(65L);

    public static readonly FeeSchedule1 Value66 = new(66L);

    public static readonly FeeSchedule1 Value67 = new(67L);

    public static readonly FeeSchedule1 Value68 = new(68L);

    public static readonly FeeSchedule1 Value69 = new(69L);

    public static readonly FeeSchedule1 Value70 = new(70L);

    public static readonly FeeSchedule1 Value71 = new(71L);

    public static readonly FeeSchedule1 Value72 = new(72L);

    public static readonly FeeSchedule1 Value73 = new(73L);

    public static readonly FeeSchedule1 Value74 = new(74L);

    public static readonly FeeSchedule1 Value75 = new(75L);

    public static readonly FeeSchedule1 Value76 = new(76L);

    public static readonly FeeSchedule1 Value77 = new(77L);

    public static readonly FeeSchedule1 Value78 = new(78L);

    public static readonly FeeSchedule1 Value79 = new(79L);

    public static readonly FeeSchedule1 Value80 = new(80L);

    public static readonly FeeSchedule1 Value81 = new(81L);

    public static readonly FeeSchedule1 Value82 = new(82L);

    public static readonly FeeSchedule1 Value83 = new(83L);

    public static readonly FeeSchedule1 Value84 = new(84L);

    public static readonly FeeSchedule1 Value85 = new(85L);

    public static readonly FeeSchedule1 Value86 = new(86L);

    public static readonly FeeSchedule1 Value88 = new(88L);

    public static readonly FeeSchedule1 Value89 = new(89L);

    public static readonly FeeSchedule1 Value90 = new(90L);

    public static readonly FeeSchedule1 Value91 = new(91L);

    public static readonly FeeSchedule1 Value92 = new(92L);

    public static readonly FeeSchedule1 Value93 = new(93L);

    public static readonly FeeSchedule1 Value96 = new(96L);

    public static readonly FeeSchedule1 Value200 = new(200L);

    public static readonly FeeSchedule1 Value201 = new(201L);

    public static readonly FeeSchedule1 Value202 = new(202L);

    public static readonly FeeSchedule1 Value203 = new(203L);

    public static readonly FeeSchedule1 Value204 = new(204L);

    public static readonly FeeSchedule1 Value205 = new(205L);

    public static readonly FeeSchedule1 Value206 = new(206L);

    public static readonly FeeSchedule1 Value207 = new(207L);

    public static readonly FeeSchedule1 Value208 = new(208L);

    public static readonly FeeSchedule1 Value209 = new(209L);

    public static readonly FeeSchedule1 Value210 = new(210L);

    public static readonly FeeSchedule1 Value211 = new(211L);

    public static readonly FeeSchedule1 Value212 = new(212L);

    public static readonly FeeSchedule1 Value213 = new(213L);

    public static readonly FeeSchedule1 Value214 = new(214L);

    public static readonly FeeSchedule1 Value215 = new(215L);

    public static readonly FeeSchedule1 Value216 = new(216L);

    public static readonly FeeSchedule1 Value217 = new(217L);

    public static readonly FeeSchedule1 Value218 = new(218L);

    public static readonly FeeSchedule1 Value230 = new(230L);

    public static readonly FeeSchedule1 Value231 = new(231L);

    public static readonly FeeSchedule1 Value232 = new(232L);

    public static readonly FeeSchedule1 Value233 = new(233L);

    public static readonly FeeSchedule1 Value234 = new(234L);

    public static readonly FeeSchedule1 Value235 = new(235L);

    public static readonly FeeSchedule1 Value236 = new(236L);

    public static readonly FeeSchedule1 Value237 = new(237L);

    public static readonly FeeSchedule1 Value238 = new(238L);

    public static readonly FeeSchedule1 Value239 = new(239L);

    public static readonly FeeSchedule1 Value240 = new(240L);

    public static readonly FeeSchedule1 Value241 = new(241L);

    public static readonly FeeSchedule1 Value242 = new(242L);

    public static readonly FeeSchedule1 Value243 = new(243L);

    public static readonly FeeSchedule1 Value244 = new(244L);

    public static readonly FeeSchedule1 Value245 = new(245L);

    public static readonly FeeSchedule1 Value246 = new(246L);

    public static readonly FeeSchedule1 Value247 = new(247L);

    public static readonly FeeSchedule1 Value248 = new(248L);

    public static readonly FeeSchedule1 Value249 = new(249L);

    public static readonly FeeSchedule1 Value250 = new(250L);

    public static readonly FeeSchedule1 Value251 = new(251L);

    public static readonly FeeSchedule1 Value252 = new(252L);

    public static readonly FeeSchedule1 Value253 = new(253L);

    public static readonly FeeSchedule1 Value254 = new(254L);

    public static readonly FeeSchedule1 Value255 = new(255L);

    public static readonly FeeSchedule1 Value256 = new(256L);

    public static readonly FeeSchedule1 Value257 = new(257L);

    public static readonly FeeSchedule1 Value258 = new(258L);

    public static readonly FeeSchedule1 Value259 = new(259L);

    public static readonly FeeSchedule1 Value260 = new(260L);

    public static readonly FeeSchedule1 Value261 = new(261L);

    public static readonly FeeSchedule1 Value262 = new(262L);

    public static readonly FeeSchedule1 Value263 = new(263L);

    public static readonly FeeSchedule1 Value264 = new(264L);

    public static readonly FeeSchedule1 Value265 = new(265L);

    public static readonly FeeSchedule1 Value266 = new(266L);

    public static readonly FeeSchedule1 Value267 = new(267L);

    public static readonly FeeSchedule1 Value268 = new(268L);

    public static readonly FeeSchedule1 Value269 = new(269L);

    public static readonly FeeSchedule1 Value270 = new(270L);

    public static readonly FeeSchedule1 Value271 = new(271L);

    public static readonly FeeSchedule1 Value272 = new(272L);

    public static readonly FeeSchedule1 Value273 = new(273L);

    public static readonly FeeSchedule1 Value274 = new(274L);

    public static readonly FeeSchedule1 Value275 = new(275L);

    public static readonly FeeSchedule1 Value276 = new(276L);

    public static readonly FeeSchedule1 Value277 = new(277L);

    public static readonly FeeSchedule1 Value278 = new(278L);

    public static readonly FeeSchedule1 Value279 = new(279L);

    public static readonly FeeSchedule1 Value280 = new(280L);

    public static readonly FeeSchedule1 Value281 = new(281L);

    public static readonly FeeSchedule1 Value282 = new(282L);

    public static readonly FeeSchedule1 Value283 = new(283L);

    public static readonly FeeSchedule1 Value284 = new(284L);

    public static readonly FeeSchedule1 Value400 = new(400L);

    public static readonly FeeSchedule1 Value401 = new(401L);

    public static readonly FeeSchedule1 Value402 = new(402L);

    public static readonly FeeSchedule1 Value403 = new(403L);

    public static readonly FeeSchedule1 Value404 = new(404L);

    public static readonly FeeSchedule1 Value405 = new(405L);

    public static readonly FeeSchedule1 Value406 = new(406L);

    public static readonly FeeSchedule1 Value407 = new(407L);

    public static readonly FeeSchedule1 Value408 = new(408L);

    public static readonly FeeSchedule1 Value409 = new(409L);

    public static readonly FeeSchedule1 Value410 = new(410L);

    public static readonly FeeSchedule1 Value601 = new(601L);

    public static readonly FeeSchedule1 Value602 = new(602L);

    public static readonly FeeSchedule1 Value603 = new(603L);

    public static readonly FeeSchedule1 Value604 = new(604L);

    public static readonly FeeSchedule1 Value605 = new(605L);

    public static readonly FeeSchedule1 Value606 = new(606L);

    public static readonly FeeSchedule1 Value607 = new(607L);

    public static readonly FeeSchedule1 Value608 = new(608L);

    public static readonly FeeSchedule1 Value701 = new(701L);

    public static readonly FeeSchedule1 Value702 = new(702L);

    public static readonly FeeSchedule1 Value703 = new(703L);

    public static readonly FeeSchedule1 Value704 = new(704L);

    public static readonly FeeSchedule1 Value705 = new(705L);

    public static readonly FeeSchedule1 Value801 = new(801L);

    public static readonly FeeSchedule1 Value802 = new(802L);

    public static readonly FeeSchedule1 Value803 = new(803L);

    public static readonly FeeSchedule1 Value804 = new(804L);

    public static readonly FeeSchedule1 Value805 = new(805L);

    public static readonly FeeSchedule1 Value806 = new(806L);

    public static readonly FeeSchedule1 Value807 = new(807L);

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
        Func<TResult> onValue88,
        Func<TResult> onValue89,
        Func<TResult> onValue90,
        Func<TResult> onValue91,
        Func<TResult> onValue92,
        Func<TResult> onValue93,
        Func<TResult> onValue96,
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
        Func<TResult> onValue230,
        Func<TResult> onValue231,
        Func<TResult> onValue232,
        Func<TResult> onValue233,
        Func<TResult> onValue234,
        Func<TResult> onValue235,
        Func<TResult> onValue236,
        Func<TResult> onValue237,
        Func<TResult> onValue238,
        Func<TResult> onValue239,
        Func<TResult> onValue240,
        Func<TResult> onValue241,
        Func<TResult> onValue242,
        Func<TResult> onValue243,
        Func<TResult> onValue244,
        Func<TResult> onValue245,
        Func<TResult> onValue246,
        Func<TResult> onValue247,
        Func<TResult> onValue248,
        Func<TResult> onValue249,
        Func<TResult> onValue250,
        Func<TResult> onValue251,
        Func<TResult> onValue252,
        Func<TResult> onValue253,
        Func<TResult> onValue254,
        Func<TResult> onValue255,
        Func<TResult> onValue256,
        Func<TResult> onValue257,
        Func<TResult> onValue258,
        Func<TResult> onValue259,
        Func<TResult> onValue260,
        Func<TResult> onValue261,
        Func<TResult> onValue262,
        Func<TResult> onValue263,
        Func<TResult> onValue264,
        Func<TResult> onValue265,
        Func<TResult> onValue266,
        Func<TResult> onValue267,
        Func<TResult> onValue268,
        Func<TResult> onValue269,
        Func<TResult> onValue270,
        Func<TResult> onValue271,
        Func<TResult> onValue272,
        Func<TResult> onValue273,
        Func<TResult> onValue274,
        Func<TResult> onValue275,
        Func<TResult> onValue276,
        Func<TResult> onValue277,
        Func<TResult> onValue278,
        Func<TResult> onValue279,
        Func<TResult> onValue280,
        Func<TResult> onValue281,
        Func<TResult> onValue282,
        Func<TResult> onValue283,
        Func<TResult> onValue284,
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
        Func<TResult> onValue701,
        Func<TResult> onValue702,
        Func<TResult> onValue703,
        Func<TResult> onValue704,
        Func<TResult> onValue705,
        Func<TResult> onValue801,
        Func<TResult> onValue802,
        Func<TResult> onValue803,
        Func<TResult> onValue804,
        Func<TResult> onValue805,
        Func<TResult> onValue806,
        Func<TResult> onValue807,
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
            _ when this == Value88 => onValue88(),
            _ when this == Value89 => onValue89(),
            _ when this == Value90 => onValue90(),
            _ when this == Value91 => onValue91(),
            _ when this == Value92 => onValue92(),
            _ when this == Value93 => onValue93(),
            _ when this == Value96 => onValue96(),
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
            _ when this == Value230 => onValue230(),
            _ when this == Value231 => onValue231(),
            _ when this == Value232 => onValue232(),
            _ when this == Value233 => onValue233(),
            _ when this == Value234 => onValue234(),
            _ when this == Value235 => onValue235(),
            _ when this == Value236 => onValue236(),
            _ when this == Value237 => onValue237(),
            _ when this == Value238 => onValue238(),
            _ when this == Value239 => onValue239(),
            _ when this == Value240 => onValue240(),
            _ when this == Value241 => onValue241(),
            _ when this == Value242 => onValue242(),
            _ when this == Value243 => onValue243(),
            _ when this == Value244 => onValue244(),
            _ when this == Value245 => onValue245(),
            _ when this == Value246 => onValue246(),
            _ when this == Value247 => onValue247(),
            _ when this == Value248 => onValue248(),
            _ when this == Value249 => onValue249(),
            _ when this == Value250 => onValue250(),
            _ when this == Value251 => onValue251(),
            _ when this == Value252 => onValue252(),
            _ when this == Value253 => onValue253(),
            _ when this == Value254 => onValue254(),
            _ when this == Value255 => onValue255(),
            _ when this == Value256 => onValue256(),
            _ when this == Value257 => onValue257(),
            _ when this == Value258 => onValue258(),
            _ when this == Value259 => onValue259(),
            _ when this == Value260 => onValue260(),
            _ when this == Value261 => onValue261(),
            _ when this == Value262 => onValue262(),
            _ when this == Value263 => onValue263(),
            _ when this == Value264 => onValue264(),
            _ when this == Value265 => onValue265(),
            _ when this == Value266 => onValue266(),
            _ when this == Value267 => onValue267(),
            _ when this == Value268 => onValue268(),
            _ when this == Value269 => onValue269(),
            _ when this == Value270 => onValue270(),
            _ when this == Value271 => onValue271(),
            _ when this == Value272 => onValue272(),
            _ when this == Value273 => onValue273(),
            _ when this == Value274 => onValue274(),
            _ when this == Value275 => onValue275(),
            _ when this == Value276 => onValue276(),
            _ when this == Value277 => onValue277(),
            _ when this == Value278 => onValue278(),
            _ when this == Value279 => onValue279(),
            _ when this == Value280 => onValue280(),
            _ when this == Value281 => onValue281(),
            _ when this == Value282 => onValue282(),
            _ when this == Value283 => onValue283(),
            _ when this == Value284 => onValue284(),
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
            _ when this == Value701 => onValue701(),
            _ when this == Value702 => onValue702(),
            _ when this == Value703 => onValue703(),
            _ when this == Value704 => onValue704(),
            _ when this == Value705 => onValue705(),
            _ when this == Value801 => onValue801(),
            _ when this == Value802 => onValue802(),
            _ when this == Value803 => onValue803(),
            _ when this == Value804 => onValue804(),
            _ when this == Value805 => onValue805(),
            _ when this == Value806 => onValue806(),
            _ when this == Value807 => onValue807(),
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
        Action onValue88,
        Action onValue89,
        Action onValue90,
        Action onValue91,
        Action onValue92,
        Action onValue93,
        Action onValue96,
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
        Action onValue230,
        Action onValue231,
        Action onValue232,
        Action onValue233,
        Action onValue234,
        Action onValue235,
        Action onValue236,
        Action onValue237,
        Action onValue238,
        Action onValue239,
        Action onValue240,
        Action onValue241,
        Action onValue242,
        Action onValue243,
        Action onValue244,
        Action onValue245,
        Action onValue246,
        Action onValue247,
        Action onValue248,
        Action onValue249,
        Action onValue250,
        Action onValue251,
        Action onValue252,
        Action onValue253,
        Action onValue254,
        Action onValue255,
        Action onValue256,
        Action onValue257,
        Action onValue258,
        Action onValue259,
        Action onValue260,
        Action onValue261,
        Action onValue262,
        Action onValue263,
        Action onValue264,
        Action onValue265,
        Action onValue266,
        Action onValue267,
        Action onValue268,
        Action onValue269,
        Action onValue270,
        Action onValue271,
        Action onValue272,
        Action onValue273,
        Action onValue274,
        Action onValue275,
        Action onValue276,
        Action onValue277,
        Action onValue278,
        Action onValue279,
        Action onValue280,
        Action onValue281,
        Action onValue282,
        Action onValue283,
        Action onValue284,
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
        Action onValue701,
        Action onValue702,
        Action onValue703,
        Action onValue704,
        Action onValue705,
        Action onValue801,
        Action onValue802,
        Action onValue803,
        Action onValue804,
        Action onValue805,
        Action onValue806,
        Action onValue807,
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
        else if (this == Value88) onValue88();
        else if (this == Value89) onValue89();
        else if (this == Value90) onValue90();
        else if (this == Value91) onValue91();
        else if (this == Value92) onValue92();
        else if (this == Value93) onValue93();
        else if (this == Value96) onValue96();
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
        else if (this == Value230) onValue230();
        else if (this == Value231) onValue231();
        else if (this == Value232) onValue232();
        else if (this == Value233) onValue233();
        else if (this == Value234) onValue234();
        else if (this == Value235) onValue235();
        else if (this == Value236) onValue236();
        else if (this == Value237) onValue237();
        else if (this == Value238) onValue238();
        else if (this == Value239) onValue239();
        else if (this == Value240) onValue240();
        else if (this == Value241) onValue241();
        else if (this == Value242) onValue242();
        else if (this == Value243) onValue243();
        else if (this == Value244) onValue244();
        else if (this == Value245) onValue245();
        else if (this == Value246) onValue246();
        else if (this == Value247) onValue247();
        else if (this == Value248) onValue248();
        else if (this == Value249) onValue249();
        else if (this == Value250) onValue250();
        else if (this == Value251) onValue251();
        else if (this == Value252) onValue252();
        else if (this == Value253) onValue253();
        else if (this == Value254) onValue254();
        else if (this == Value255) onValue255();
        else if (this == Value256) onValue256();
        else if (this == Value257) onValue257();
        else if (this == Value258) onValue258();
        else if (this == Value259) onValue259();
        else if (this == Value260) onValue260();
        else if (this == Value261) onValue261();
        else if (this == Value262) onValue262();
        else if (this == Value263) onValue263();
        else if (this == Value264) onValue264();
        else if (this == Value265) onValue265();
        else if (this == Value266) onValue266();
        else if (this == Value267) onValue267();
        else if (this == Value268) onValue268();
        else if (this == Value269) onValue269();
        else if (this == Value270) onValue270();
        else if (this == Value271) onValue271();
        else if (this == Value272) onValue272();
        else if (this == Value273) onValue273();
        else if (this == Value274) onValue274();
        else if (this == Value275) onValue275();
        else if (this == Value276) onValue276();
        else if (this == Value277) onValue277();
        else if (this == Value278) onValue278();
        else if (this == Value279) onValue279();
        else if (this == Value280) onValue280();
        else if (this == Value281) onValue281();
        else if (this == Value282) onValue282();
        else if (this == Value283) onValue283();
        else if (this == Value284) onValue284();
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
        else if (this == Value701) onValue701();
        else if (this == Value702) onValue702();
        else if (this == Value703) onValue703();
        else if (this == Value704) onValue704();
        else if (this == Value705) onValue705();
        else if (this == Value801) onValue801();
        else if (this == Value802) onValue802();
        else if (this == Value803) onValue803();
        else if (this == Value804) onValue804();
        else if (this == Value805) onValue805();
        else if (this == Value806) onValue806();
        else if (this == Value807) onValue807();
        else otherwise(Value);
    }
}
