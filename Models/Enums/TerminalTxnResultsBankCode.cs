using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TerminalTxnResultsBankCode>))]
public sealed record TerminalTxnResultsBankCode : OpenStringEnum<TerminalTxnResultsBankCode>
{
    private TerminalTxnResultsBankCode(string value) : base(value)
    {
    }

    public static readonly TerminalTxnResultsBankCode AcceptedButNotYetProcessed = new(
        "accepted_but_not_yet_processed");

    public static readonly TerminalTxnResultsBankCode AccountBlocked = new("account_blocked");

    public static readonly TerminalTxnResultsBankCode AccountIsPurged = new("account_is_purged");

    public static readonly TerminalTxnResultsBankCode AccountLocked = new("account_locked");

    public static readonly TerminalTxnResultsBankCode AccountOnHoldOrNotActive = new("account_on_hold_or_not_active");

    public static readonly TerminalTxnResultsBankCode AccountNotActivated = new("account_not_activated");

    public static readonly TerminalTxnResultsBankCode AccountReloadsExceeded = new("account_reloads_exceeded");

    public static readonly TerminalTxnResultsBankCode AccountRowLocked = new("account_row_locked");

    public static readonly TerminalTxnResultsBankCode AccountStatusIsVoidLock = new("account_status_is_void_lock");

    public static readonly TerminalTxnResultsBankCode AchPaymentNotAccepted = new("ach_payment_not_accepted");

    public static readonly TerminalTxnResultsBankCode AcquirerChannelUnavailable = new("acquirer_channel_unavailable");

    public static readonly TerminalTxnResultsBankCode ActivationFailed = new("activation_failed");

    public static readonly TerminalTxnResultsBankCode AdditiveLimitExceeded = new("additive_limit_exceeded");

    public static readonly TerminalTxnResultsBankCode ZipMatchAddressMismatch = new("zip_match_address_mismatch");

    public static readonly TerminalTxnResultsBankCode ZipMatchAddressNotVerified = new(
        "zip_match_address_not_verified");

    public static readonly TerminalTxnResultsBankCode AlreadyRedeemed = new("already_redeemed");

    public static readonly TerminalTxnResultsBankCode AlreadyReversed = new("already_reversed");

    public static readonly TerminalTxnResultsBankCode AmountLimitExceeded = new("amount_limit_exceeded");

    public static readonly TerminalTxnResultsBankCode AmountTooLarge = new("amount_too_large");

    public static readonly TerminalTxnResultsBankCode ApproveWithId = new("approve_with_id");

    public static readonly TerminalTxnResultsBankCode Approved = new("approved");

    public static readonly TerminalTxnResultsBankCode ApprovedEmvKeyLoad = new("approved_emv_key_load");

    public static readonly TerminalTxnResultsBankCode ApprovedWithNoCash = new("approved_with_no_cash");

    public static readonly TerminalTxnResultsBankCode ApprovedWithOverdraft = new("approved_with_overdraft");

    public static readonly TerminalTxnResultsBankCode AuthorizationIdNeeded = new("authorization_id_needed");

    public static readonly TerminalTxnResultsBankCode BadAccount = new("bad_account");

    public static readonly TerminalTxnResultsBankCode BadChecksum = new("bad_checksum");

    public static readonly TerminalTxnResultsBankCode BadClose = new("bad_close");

    public static readonly TerminalTxnResultsBankCode BadMagStripe = new("bad_mag_stripe");

    public static readonly TerminalTxnResultsBankCode BadPostDate = new("bad_post_date");

    public static readonly TerminalTxnResultsBankCode BadRepayDate = new("bad_repay_date");

    public static readonly TerminalTxnResultsBankCode BalanceNotAvailable = new("balance_not_available");

    public static readonly TerminalTxnResultsBankCode BillToShipToMismatch = new("bill_to_ship_to_mismatch");

    public static readonly TerminalTxnResultsBankCode BinBlocked = new("bin_blocked");

    public static readonly TerminalTxnResultsBankCode BlockedByCardholder = new("blocked_by_cardholder");

    public static readonly TerminalTxnResultsBankCode BulkActivationError = new("bulk_activation_error");

    public static readonly TerminalTxnResultsBankCode BulkActivationPackageAmountError = new(
        "bulk_activation_package_amount_error");

    public static readonly TerminalTxnResultsBankCode CallAcquirer = new("call_acquirer");

    public static readonly TerminalTxnResultsBankCode CallForAuthorization = new("call_for_authorization");

    public static readonly TerminalTxnResultsBankCode CallIssuer = new("call_issuer");

    public static readonly TerminalTxnResultsBankCode CallTelecheck = new("call_telecheck");

    public static readonly TerminalTxnResultsBankCode CannotFindNetwork = new("cannot_find_network");

    public static readonly TerminalTxnResultsBankCode CardAlreadyActive = new("card_already_active");

    public static readonly TerminalTxnResultsBankCode CardAlreadyClosed = new("card_already_closed");

    public static readonly TerminalTxnResultsBankCode CardNotActive = new("card_not_active");

    public static readonly TerminalTxnResultsBankCode CardNotSupported = new("card_not_supported");

    public static readonly TerminalTxnResultsBankCode CardVelocityAmountExceeded = new("card_velocity_amount_exceeded");

    public static readonly TerminalTxnResultsBankCode CardVelocityCountExceeded = new("card_velocity_count_exceeded");

    public static readonly TerminalTxnResultsBankCode CardVelocityExceeded = new("card_velocity_exceeded");

    public static readonly TerminalTxnResultsBankCode CashbackGreaterThanTransactionAmount = new(
        "cashback_greater_than_transaction_amount");

    public static readonly TerminalTxnResultsBankCode CashLimitExceeded = new("cash_limit_exceeded");

    public static readonly TerminalTxnResultsBankCode CenterClosed = new("center_closed");

    public static readonly TerminalTxnResultsBankCode CheckerManagerNotFound = new("checker/manager_not_found");

    public static readonly TerminalTxnResultsBankCode ChipFailure = new("chip_failure");

    public static readonly TerminalTxnResultsBankCode CloseUnavailable = new("close_unavailable");

    public static readonly TerminalTxnResultsBankCode CloseNotValid = new("close_not_valid");

    public static readonly TerminalTxnResultsBankCode ClosedAccount = new("closed_account");

    public static readonly TerminalTxnResultsBankCode CountExceedsLimit = new("count_exceeds_limit");

    public static readonly TerminalTxnResultsBankCode CounterfeitCard = new("counterfeit_card");

    public static readonly TerminalTxnResultsBankCode CounterOfferToSupplyPersonalGuaranty = new(
        "counter_offer_to_supply_personal_guaranty");

    public static readonly TerminalTxnResultsBankCode CryptogramDecryptionError = new("cryptogram_decryption_error");

    public static readonly TerminalTxnResultsBankCode CryptoBoxIsOffline = new("crypto_box_is_offline");

    public static readonly TerminalTxnResultsBankCode CurrencyConversionComplete = new("currency_conversion_complete");

    public static readonly TerminalTxnResultsBankCode CurrencyConversionError = new("currency_conversion_error");

    public static readonly TerminalTxnResultsBankCode CurrencyNotSupported = new("currency_not_supported");

    public static readonly TerminalTxnResultsBankCode CustomerCancellation = new("customer_cancellation");

    public static readonly TerminalTxnResultsBankCode CustomerOptOut = new("customer_opt_out");

    public static readonly TerminalTxnResultsBankCode CutTimeCloseTo1400 = new("cut_time_close_to_1400");

    public static readonly TerminalTxnResultsBankCode CvvDeclined = new("cvv_declined");

    public static readonly TerminalTxnResultsBankCode CvvFailed = new("cvv_failed");

    public static readonly TerminalTxnResultsBankCode DailyLimitExceeded = new("daily_limit_exceeded");

    public static readonly TerminalTxnResultsBankCode DateOfBirthError = new("date_of_birth_error");

    public static readonly TerminalTxnResultsBankCode DebitGatewayUnavailable = new("debit_gateway_unavailable");

    public static readonly TerminalTxnResultsBankCode Declined = new("declined");

    public static readonly TerminalTxnResultsBankCode DeclinedDueToStandInRules = new("declined_due_to_stand_in_rules");

    public static readonly TerminalTxnResultsBankCode DeconvertedBin = new("deconverted_bin");

    public static readonly TerminalTxnResultsBankCode DoNotHonor = new("do_not_honor");

    public static readonly TerminalTxnResultsBankCode DoNotTryAgain = new("do_not_try_again");

    public static readonly TerminalTxnResultsBankCode DoNotTryAgainSubsequentMayContinue = new(
        "do_not_try_again_subsequent_may_continue");

    public static readonly TerminalTxnResultsBankCode DriversLicenseOrIdRequired = new(
        "drivers_license_or_id_required");

    public static readonly TerminalTxnResultsBankCode DuplicateCapture = new("duplicate_capture");

    public static readonly TerminalTxnResultsBankCode DuplicateReturn = new("duplicate_return");

    public static readonly TerminalTxnResultsBankCode DuplicateReversal = new("duplicate_reversal");

    public static readonly TerminalTxnResultsBankCode DuplicateTransaction = new("duplicate_transaction");

    public static readonly TerminalTxnResultsBankCode EditHonor = new("edit_honor");

    public static readonly TerminalTxnResultsBankCode EmailNoMatch = new("email_no_match");

    public static readonly TerminalTxnResultsBankCode EmailUnavailable = new("email_unavailable");

    public static readonly TerminalTxnResultsBankCode EmvKeyDownloadError = new("emv_key_download_error");

    public static readonly TerminalTxnResultsBankCode EnterLesserAmount = new("enter_lesser_amount");

    public static readonly TerminalTxnResultsBankCode ErrorProcessingPinBlock = new("error_processing_pin_block");

    public static readonly TerminalTxnResultsBankCode ExceedsGlobalAmountForPeriodPayInside = new(
        "exceeds_global_amount_for_period_pay_inside");

    public static readonly TerminalTxnResultsBankCode ExceedsGlobalCountForPeriodPayInside = new(
        "exceeds_global_count_for_period_pay_inside");

    public static readonly TerminalTxnResultsBankCode ExceedsGlobalLimitsForPeriodPayInside = new(
        "exceeds_global_limits_for_period_pay_inside");

    public static readonly TerminalTxnResultsBankCode ExceedsLimit = new("exceeds_limit");

    public static readonly TerminalTxnResultsBankCode ExceedsMerchantAmountForPeriodPayInside = new(
        "exceeds_merchant_amount_for_period_pay_inside");

    public static readonly TerminalTxnResultsBankCode ExceedsMerchantCountForPeriodPayInside = new(
        "exceeds_merchant_count_for_period_pay_inside");

    public static readonly TerminalTxnResultsBankCode ExceedsMerchantLimitsForPeriodPayInside = new(
        "exceeds_merchant_limits_for_period_pay_inside");

    public static readonly TerminalTxnResultsBankCode ExceedsStateAmountForPeriodPayInside = new(
        "exceeds_state_amount_for_period_pay_inside");

    public static readonly TerminalTxnResultsBankCode ExceedsStateCountForPeriodPayInside = new(
        "exceeds_state_count_for_period_pay_inside");

    public static readonly TerminalTxnResultsBankCode ExceedsStateLimitsForPeriodPayInside = new(
        "exceeds_state_limits_for_period_pay_inside");

    public static readonly TerminalTxnResultsBankCode ExceedsTransactionCountOrAmountLimitIn24Hours = new(
        "exceeds_transaction_count_or_amount_limit_in_24_hours");

    public static readonly TerminalTxnResultsBankCode ExceedsTransactionCountOrAmountLimitIn7Days = new(
        "exceeds_transaction_count_or_amount_limit_in_7_days");

    public static readonly TerminalTxnResultsBankCode ExceedsTransactionCountOrAmountLimitIn30Days = new(
        "exceeds_transaction_count_or_amount_limit_in_30_days");

    public static readonly TerminalTxnResultsBankCode ExceedsZipCodeAmountForPeriodPayInside = new(
        "exceeds_zip_code_amount_for_period_pay_inside");

    public static readonly TerminalTxnResultsBankCode ExceedsZipCodeCountForPeriodPayInside = new(
        "exceeds_zip_code_count_for_period_pay_inside");

    public static readonly TerminalTxnResultsBankCode ExceedsZipCodeLimitsForPeriodPayInside = new(
        "exceeds_zip_code_limits_for_period_pay_inside");

    public static readonly TerminalTxnResultsBankCode ExpiredCard = new("expired_card");

    public static readonly TerminalTxnResultsBankCode ExpiredLock = new("expired_lock");

    public static readonly TerminalTxnResultsBankCode Fraudulent = new("fraudulent");

    public static readonly TerminalTxnResultsBankCode FileTemporarilyUnavailable = new("file_temporarily_unavailable");

    public static readonly TerminalTxnResultsBankCode FileUpdateError = new("file_update_error");

    public static readonly TerminalTxnResultsBankCode FileUpdateUnavailable = new("file_update_unavailable");

    public static readonly TerminalTxnResultsBankCode FormatError = new("format_error");

    public static readonly TerminalTxnResultsBankCode ForwardToIssuer = new("forward_to_issuer");

    public static readonly TerminalTxnResultsBankCode FuelLimitExceeded = new("fuel_limit_exceeded");

    public static readonly TerminalTxnResultsBankCode FuelOnly = new("fuel_only");

    public static readonly TerminalTxnResultsBankCode FuelPriceError = new("fuel_price_error");

    public static readonly TerminalTxnResultsBankCode FullSsnRequired = new("full_ssn_required");

    public static readonly TerminalTxnResultsBankCode FunctionNotSupported = new("function_not_supported");

    public static readonly TerminalTxnResultsBankCode FundsOnHold = new("funds_on_hold");

    public static readonly TerminalTxnResultsBankCode General = new("general");

    public static readonly TerminalTxnResultsBankCode GeneralError = new("general_error");

    public static readonly TerminalTxnResultsBankCode GenericDecline = new("generic_decline");

    public static readonly TerminalTxnResultsBankCode HardCapturePickupCard = new("hard_capture_pickup_card");

    public static readonly TerminalTxnResultsBankCode HardNegativeInfoOnFile = new("hard_negative_info_on_file");

    public static readonly TerminalTxnResultsBankCode HighRisk = new("high_risk");

    public static readonly TerminalTxnResultsBankCode HoldShippingFor24H = new("hold_shipping_for_24h");

    public static readonly TerminalTxnResultsBankCode HonorWithAuthentication = new("honor_with_authentication");

    public static readonly TerminalTxnResultsBankCode IllegalTransaction = new("illegal_transaction");

    public static readonly TerminalTxnResultsBankCode ImprintCard = new("imprint_card");

    public static readonly TerminalTxnResultsBankCode IncorrectCvv = new("incorrect_cvv");

    public static readonly TerminalTxnResultsBankCode IncorrectNumber = new("incorrect_number");

    public static readonly TerminalTxnResultsBankCode IncorrectPin = new("incorrect_pin");

    public static readonly TerminalTxnResultsBankCode IncorrectMerchantLocation = new("incorrect_merchant_location");

    public static readonly TerminalTxnResultsBankCode IncorrectTransactionVersion = new(
        "incorrect_transaction_version");

    public static readonly TerminalTxnResultsBankCode InquiryDeclined = new("inquiry_declined");

    public static readonly TerminalTxnResultsBankCode InsufficientData = new("insufficient_data");

    public static readonly TerminalTxnResultsBankCode InsufficientFunds = new("insufficient_funds");

    public static readonly TerminalTxnResultsBankCode InsufficientSecurity = new("insufficient_security");

    public static readonly TerminalTxnResultsBankCode InternetAccessDisabled = new("internet_access_disabled");

    public static readonly TerminalTxnResultsBankCode Invalid3DPassword = new("invalid_3d_password");

    public static readonly TerminalTxnResultsBankCode InvalidAccount = new("invalid_account");

    public static readonly TerminalTxnResultsBankCode InvalidAccountDate = new("invalid_account/date");

    public static readonly TerminalTxnResultsBankCode InvalidAccountType = new("invalid_account_type");

    public static readonly TerminalTxnResultsBankCode InvalidActivate = new("invalid_activate");

    public static readonly TerminalTxnResultsBankCode InvalidAmount = new("invalid_amount");

    public static readonly TerminalTxnResultsBankCode InvalidAuthorizationCode = new("invalid_authorization_code");

    public static readonly TerminalTxnResultsBankCode InvalidBatchNumberId = new("invalid_batch_number/id");

    public static readonly TerminalTxnResultsBankCode InvalidCashback = new("invalid_cashback");

    public static readonly TerminalTxnResultsBankCode InvalidCheckingAccount = new("invalid_checking_account");

    public static readonly TerminalTxnResultsBankCode InvalidCheckingAccountNumber = new(
        "invalid_checking_account_number");

    public static readonly TerminalTxnResultsBankCode InvalidCreditAccount = new("invalid_credit_account");

    public static readonly TerminalTxnResultsBankCode InvalidClerk = new("invalid_clerk");

    public static readonly TerminalTxnResultsBankCode InvalidCurrency = new("invalid_currency");

    public static readonly TerminalTxnResultsBankCode InvalidCvv = new("invalid_cvv");

    public static readonly TerminalTxnResultsBankCode InvalidDateOrTime = new("invalid_date_or_time");

    public static readonly TerminalTxnResultsBankCode InvalidDriver = new("invalid_driver");

    public static readonly TerminalTxnResultsBankCode InvalidEanOrScv = new("invalid_ean_or_scv");

    public static readonly TerminalTxnResultsBankCode InvalidEffectiveDate = new("invalid_effective_date");

    public static readonly TerminalTxnResultsBankCode InvalidEmailAddress = new("invalid_email_address");

    public static readonly TerminalTxnResultsBankCode InvalidEntry = new("invalid_entry");

    public static readonly TerminalTxnResultsBankCode InvalidExpiryDate = new("invalid_expiry_date");

    public static readonly TerminalTxnResultsBankCode InvalidExpiryYear = new("invalid_expiry_year");

    public static readonly TerminalTxnResultsBankCode InvalidHost = new("invalid_host");

    public static readonly TerminalTxnResultsBankCode InvalidLocation = new("invalid_location");

    public static readonly TerminalTxnResultsBankCode InvalidMaidenName = new("invalid_maiden_name");

    public static readonly TerminalTxnResultsBankCode InvalidMcc = new("invalid_mcc");

    public static readonly TerminalTxnResultsBankCode InvalidMerchant = new("invalid_merchant");

    public static readonly TerminalTxnResultsBankCode InvalidMerchantId = new("invalid_merchant_id");

    public static readonly TerminalTxnResultsBankCode InvalidMerchantIdSe = new("invalid_merchant_id/se");

    public static readonly TerminalTxnResultsBankCode InvalidMerchantSetup = new("invalid_merchant_setup");

    public static readonly TerminalTxnResultsBankCode InvalidMicrData = new("invalid_micr_data");

    public static readonly TerminalTxnResultsBankCode InvalidNewPassword = new("invalid_new_password");

    public static readonly TerminalTxnResultsBankCode InvalidNotPresent = new("invalid_not_present");

    public static readonly TerminalTxnResultsBankCode InvalidNumber = new("invalid_number");

    public static readonly TerminalTxnResultsBankCode InvalidOdometer = new("invalid_odometer");

    public static readonly TerminalTxnResultsBankCode InvalidPassword = new("invalid_password");

    public static readonly TerminalTxnResultsBankCode InvalidPin = new("invalid_pin");

    public static readonly TerminalTxnResultsBankCode InvalidPos = new("invalid_pos");

    public static readonly TerminalTxnResultsBankCode InvalidPreapprovalNumber = new("invalid_preapproval_number");

    public static readonly TerminalTxnResultsBankCode InvalidPrefix = new("invalid_prefix");

    public static readonly TerminalTxnResultsBankCode InvalidProduct = new("invalid_product");

    public static readonly TerminalTxnResultsBankCode InvalidPromptEntry = new("invalid_prompt_entry");

    public static readonly TerminalTxnResultsBankCode InvalidRequest = new("invalid_request");

    public static readonly TerminalTxnResultsBankCode InvalidResponse = new("invalid_response");

    public static readonly TerminalTxnResultsBankCode InvalidResponseDate = new("invalid_response_date");

    public static readonly TerminalTxnResultsBankCode InvalidRestrictionCode = new("invalid_restriction_code");

    public static readonly TerminalTxnResultsBankCode InvalidSavingsAccount = new("invalid_savings_account");

    public static readonly TerminalTxnResultsBankCode InvalidSecurePaymentData = new("invalid_secure_payment_data");

    public static readonly TerminalTxnResultsBankCode InvalidSku = new("invalid_sku");

    public static readonly TerminalTxnResultsBankCode InvalidSsn = new("invalid_ssn");

    public static readonly TerminalTxnResultsBankCode InvalidStateCode = new("invalid_state_code");

    public static readonly TerminalTxnResultsBankCode InvalidStatusChange = new("invalid_status_change");

    public static readonly TerminalTxnResultsBankCode InvalidTerminal = new("invalid_terminal");

    public static readonly TerminalTxnResultsBankCode InvalidTgnCic = new("invalid_tgn_cic");

    public static readonly TerminalTxnResultsBankCode InvalidTimezone = new("invalid_timezone");

    public static readonly TerminalTxnResultsBankCode InvalidTppid = new("invalid_tppid");

    public static readonly TerminalTxnResultsBankCode InvalidTrackData = new("invalid_track_data");

    public static readonly TerminalTxnResultsBankCode InvalidTransaction = new("invalid_transaction");

    public static readonly TerminalTxnResultsBankCode InvalidTransarmorTransaction = new(
        "invalid_transarmor_transaction");

    public static readonly TerminalTxnResultsBankCode InvalidUser = new("invalid_user");

    public static readonly TerminalTxnResultsBankCode InvalidValueInTheField = new("invalid_value_in_the_field");

    public static readonly TerminalTxnResultsBankCode InvalidVehicle = new("invalid_vehicle");

    public static readonly TerminalTxnResultsBankCode InvalidVoidOfActivation = new("invalid_void_of_activation");

    public static readonly TerminalTxnResultsBankCode InvalidZipCode = new("invalid_zip_code");

    public static readonly TerminalTxnResultsBankCode IssuanceUnderMinimumAmount = new("issuance_under_minimum_amount");

    public static readonly TerminalTxnResultsBankCode IssuerNotAvailable = new("issuer_not_available");

    public static readonly TerminalTxnResultsBankCode IssuerProcessorOrSwitchNotAvailable = new(
        "issuer_processor_or_switch_not_available");

    public static readonly TerminalTxnResultsBankCode IssuerSpecialConditions = new("issuer_special_conditions");

    public static readonly TerminalTxnResultsBankCode IssuerVelocityAmountExceeded = new(
        "issuer_velocity_amount_exceeded");

    public static readonly TerminalTxnResultsBankCode IssuerVelocityCountExceeded = new(
        "issuer_velocity_count_exceeded");

    public static readonly TerminalTxnResultsBankCode LateReversal = new("late_reversal");

    public static readonly TerminalTxnResultsBankCode LawViolation = new("law_violation");

    public static readonly TerminalTxnResultsBankCode LimitCheckFailed = new("limit_check_failed");

    public static readonly TerminalTxnResultsBankCode LostCard = new("lost_card");

    public static readonly TerminalTxnResultsBankCode MaidenNameUnavailable = new("maiden_name_unavailable");

    public static readonly TerminalTxnResultsBankCode ManualTriesExceeded = new("manual_tries_exceeded");

    public static readonly TerminalTxnResultsBankCode MatchMember = new("match");

    public static readonly TerminalTxnResultsBankCode MaxBalanceExceeded = new("max_balance_exceeded");

    public static readonly TerminalTxnResultsBankCode MerchantDepleted = new("merchant_depleted");

    public static readonly TerminalTxnResultsBankCode MerchantHasMailPending = new("merchant_has_mail_pending");

    public static readonly TerminalTxnResultsBankCode MessageFormatError = new("message_format_error");

    public static readonly TerminalTxnResultsBankCode Minus2Debit = new("minus2_debit");

    public static readonly TerminalTxnResultsBankCode MissingConditionalData = new("missing_conditional_data");

    public static readonly TerminalTxnResultsBankCode MissingCustomerServicePhone = new(
        "missing_customer_service_phone");

    public static readonly TerminalTxnResultsBankCode MissingFromAccount = new("missing_from_account");

    public static readonly TerminalTxnResultsBankCode MissingToAccount = new("missing_to_account");

    public static readonly TerminalTxnResultsBankCode MultiCurrencyDccFail = new("multi_currency_dcc_fail");

    public static readonly TerminalTxnResultsBankCode MultiCurrencyInvertFail = new("multi_currency_invert_fail");

    public static readonly TerminalTxnResultsBankCode MultipleAccountsForType = new("multiple_accounts_for_type");

    public static readonly TerminalTxnResultsBankCode NameEmailNoMatch = new("name_email_no_match");

    public static readonly TerminalTxnResultsBankCode NameEmailUnavailable = new("name_email_unavailable");

    public static readonly TerminalTxnResultsBankCode NameNoMatch = new("name_no_match");

    public static readonly TerminalTxnResultsBankCode NamePhoneNoMatch = new("name_phone_no_match");

    public static readonly TerminalTxnResultsBankCode NamePhoneUnavailable = new("name_phone_unavailable");

    public static readonly TerminalTxnResultsBankCode NameUnavailable = new("name_unavailable");

    public static readonly TerminalTxnResultsBankCode NegativeFileException = new("negative_file_exception");

    public static readonly TerminalTxnResultsBankCode NewAccountInformationAvailable = new(
        "new_account_information_available");

    public static readonly TerminalTxnResultsBankCode NewCardIssued = new("new_card_issued");

    public static readonly TerminalTxnResultsBankCode NewPasswordRequired = new("new_password_required");

    public static readonly TerminalTxnResultsBankCode NoAccountLink = new("no_account_link");

    public static readonly TerminalTxnResultsBankCode NoActionTaken = new("no_action_taken");

    public static readonly TerminalTxnResultsBankCode NoCardRecord = new("no_card_record");

    public static readonly TerminalTxnResultsBankCode NoChainId = new("no_chain_id");

    public static readonly TerminalTxnResultsBankCode NoCheckingAccount = new("no_checking_account");

    public static readonly TerminalTxnResultsBankCode Mismatch = new("mismatch");

    public static readonly TerminalTxnResultsBankCode NoMessagesPending = new("no_messages_pending");

    public static readonly TerminalTxnResultsBankCode NoOpenBatch = new("no_open_batch");

    public static readonly TerminalTxnResultsBankCode NoPhoneService = new("no_phone_service");

    public static readonly TerminalTxnResultsBankCode NoPreviousTransaction = new("no_previous_transaction");

    public static readonly TerminalTxnResultsBankCode NoReasonToDecline = new("no_reason_to_decline");

    public static readonly TerminalTxnResultsBankCode NoSavingsAccount = new("no_savings_account");

    public static readonly TerminalTxnResultsBankCode NoSuchIssuer = new("no_such_issuer");

    public static readonly TerminalTxnResultsBankCode NoToAccount = new("no_to_account");

    public static readonly TerminalTxnResultsBankCode NoTransactionsAvailable = new("no_transactions_available");

    public static readonly TerminalTxnResultsBankCode NoTransactionSecurityRecord = new(
        "no_transaction_security_record");

    public static readonly TerminalTxnResultsBankCode NotAccepted = new("not_accepted");

    public static readonly TerminalTxnResultsBankCode NotActive = new("not_active");

    public static readonly TerminalTxnResultsBankCode NotLostOrStolen = new("not_lost_or_stolen");

    public static readonly TerminalTxnResultsBankCode NotOnFile = new("not_on_file");

    public static readonly TerminalTxnResultsBankCode NotPermitted = new("not_permitted");

    public static readonly TerminalTxnResultsBankCode NotPerformed = new("not_performed");

    public static readonly TerminalTxnResultsBankCode NotProcessed = new("not_processed");

    public static readonly TerminalTxnResultsBankCode NotSupported = new("not_supported");

    public static readonly TerminalTxnResultsBankCode Nsf = new("nsf");

    public static readonly TerminalTxnResultsBankCode OneTimeStopPayment = new("one_time_stop_payment");

    public static readonly TerminalTxnResultsBankCode OriginalAuthorizationMismatch = new(
        "original_authorization_mismatch");

    public static readonly TerminalTxnResultsBankCode OriginalAuthorizationNotFound = new(
        "original_authorization_not_found");

    public static readonly TerminalTxnResultsBankCode OriginalRepeated = new("original_repeated");

    public static readonly TerminalTxnResultsBankCode OriginalTransactionNotApproved = new(
        "original_transaction_not_approved");

    public static readonly TerminalTxnResultsBankCode OverChainDailyVelocityAmount = new(
        "over_chain_daily_velocity_amount");

    public static readonly TerminalTxnResultsBankCode OverChainDailyVelocityCount = new(
        "over_chain_daily_velocity_count");

    public static readonly TerminalTxnResultsBankCode OverChainDailyVelocityLimits = new(
        "over_chain_daily_velocity_limits");

    public static readonly TerminalTxnResultsBankCode OverChainProductVelocityAmount = new(
        "over_chain_product_velocity_amount");

    public static readonly TerminalTxnResultsBankCode OverChainProductVelocityCount = new(
        "over_chain_product_velocity_count");

    public static readonly TerminalTxnResultsBankCode OverChainProductVelocityLimits = new(
        "over_chain_product_velocity_limits");

    public static readonly TerminalTxnResultsBankCode OverMaxBalance = new("over_max_balance");

    public static readonly TerminalTxnResultsBankCode OverMerchandiseLimit = new("over_merchandise_limit");

    public static readonly TerminalTxnResultsBankCode OverMerchantDailyVelocityAmount = new(
        "over_merchant_daily_velocity_amount");

    public static readonly TerminalTxnResultsBankCode OverMerchantDailyVelocityCount = new(
        "over_merchant_daily_velocity_count");

    public static readonly TerminalTxnResultsBankCode OverMerchantDailyVelocityLimits = new(
        "over_merchant_daily_velocity_limits");

    public static readonly TerminalTxnResultsBankCode OverMerchantProductVelocityAmount = new(
        "over_merchant_product_velocity_amount");

    public static readonly TerminalTxnResultsBankCode OverMerchantProductVelocityCount = new(
        "over_merchant_product_velocity_count");

    public static readonly TerminalTxnResultsBankCode OverMerchantProductVelocityLimits = new(
        "over_merchant_product_velocity_limits");

    public static readonly TerminalTxnResultsBankCode OverMonthlyLimit = new("over_monthly_limit");

    public static readonly TerminalTxnResultsBankCode OverNonFuelLimit = new("over_non_fuel_limit");

    public static readonly TerminalTxnResultsBankCode PanTransError = new("pan_trans_error");

    public static readonly TerminalTxnResultsBankCode PartialAuthNotAllowed = new("partial_auth_not_allowed");

    public static readonly TerminalTxnResultsBankCode PartialReversal = new("partial_reversal");

    public static readonly TerminalTxnResultsBankCode PartiallyApproved = new("partially_approved");

    public static readonly TerminalTxnResultsBankCode PasswordRetriesExceeded = new("password_retries_exceeded");

    public static readonly TerminalTxnResultsBankCode PayAtPumpNotAllowed = new("pay_at_pump_not_allowed");

    public static readonly TerminalTxnResultsBankCode PhoneEmailNoMatch = new("phone_email_no_match");

    public static readonly TerminalTxnResultsBankCode PhoneEmailUnavailable = new("phone_email_unavailable");

    public static readonly TerminalTxnResultsBankCode PhoneNoMatch = new("phone_no_match");

    public static readonly TerminalTxnResultsBankCode PhoneUnavailable = new("phone_unavailable");

    public static readonly TerminalTxnResultsBankCode PickupCard = new("pickup_card");

    public static readonly TerminalTxnResultsBankCode PinAlreadyExists = new("pin_already_exists");

    public static readonly TerminalTxnResultsBankCode PinKeyError = new("pin_key_error");

    public static readonly TerminalTxnResultsBankCode PinKeySychronizationError = new("pin_key_sychronization_error");

    public static readonly TerminalTxnResultsBankCode PinTryExceeded = new("pin_try_exceeded");

    public static readonly TerminalTxnResultsBankCode PleaseRetry = new("please_retry");

    public static readonly TerminalTxnResultsBankCode ProcessAsDebit = new("process_as_debit");

    public static readonly TerminalTxnResultsBankCode ProcessingError = new("processing_error");

    public static readonly TerminalTxnResultsBankCode ProductCodeRestricted = new("product_code_restricted");

    public static readonly TerminalTxnResultsBankCode PromoLocationRestricted = new("promo_location_restricted");

    public static readonly TerminalTxnResultsBankCode QuantityExceeded = new("quantity_exceeded");

    public static readonly TerminalTxnResultsBankCode ReauthorizationTimeframeExpired = new(
        "reauthorization_timeframe_expired");

    public static readonly TerminalTxnResultsBankCode RechargeAmountExceeded = new("recharge_amount_exceeded");

    public static readonly TerminalTxnResultsBankCode RechargeCountExceeded = new("recharge_count_exceeded");

    public static readonly TerminalTxnResultsBankCode ReenterTransaction = new("reenter_transaction");

    public static readonly TerminalTxnResultsBankCode Referral = new("referral");

    public static readonly TerminalTxnResultsBankCode RejectMessage = new("reject_message");

    public static readonly TerminalTxnResultsBankCode RejectedLostStolenChecks = new("rejected_lost/stolen_checks");

    public static readonly TerminalTxnResultsBankCode RepairLimitExceeded = new("repair_limit_exceeded");

    public static readonly TerminalTxnResultsBankCode RequestInProgress = new("request_in_progress");

    public static readonly TerminalTxnResultsBankCode ResponseReceivedLate = new("response_received_late");

    public static readonly TerminalTxnResultsBankCode RestrictedCard = new("restricted_card");

    public static readonly TerminalTxnResultsBankCode ResubmissionViolatesNetworkFrequency = new(
        "resubmission_violates_network_frequency");

    public static readonly TerminalTxnResultsBankCode RetainCard = new("retain_card");

    public static readonly TerminalTxnResultsBankCode Reversal = new("reversal");

    public static readonly TerminalTxnResultsBankCode ReversalNoMatch = new("reversal_no_match");

    public static readonly TerminalTxnResultsBankCode ReversalUnsuccessful = new("reversal_unsuccessful");

    public static readonly TerminalTxnResultsBankCode RevocationOfAllAuthorizations = new(
        "revocation_of_all_authorizations");

    public static readonly TerminalTxnResultsBankCode RevocationOfAuthorization = new("revocation_of_authorization");

    public static readonly TerminalTxnResultsBankCode SecureCodeNotEnabled = new("secure_code_not_enabled");

    public static readonly TerminalTxnResultsBankCode SecurityError = new("security_error");

    public static readonly TerminalTxnResultsBankCode SecurityErrorTryAgain = new("security_error_try_again");

    public static readonly TerminalTxnResultsBankCode SecurityViolation = new("security_violation");

    public static readonly TerminalTxnResultsBankCode SeeAttendant = new("see_attendant");

    public static readonly TerminalTxnResultsBankCode SeeExhibitForError = new("see_exhibit_for_error");

    public static readonly TerminalTxnResultsBankCode ServiceNotAllowed = new("service_not_allowed");

    public static readonly TerminalTxnResultsBankCode SignatureRequired = new("signature_required");

    public static readonly TerminalTxnResultsBankCode SkipTraceInfo = new("skip_trace_info");

    public static readonly TerminalTxnResultsBankCode SoftDescriptorNotEnabled = new("soft_descriptor_not_enabled");

    public static readonly TerminalTxnResultsBankCode SsnNotAvailable = new("ssn_not_available");

    public static readonly TerminalTxnResultsBankCode StolenCard = new("stolen_card");

    public static readonly TerminalTxnResultsBankCode StopPaymentOrder = new("stop_payment_order");

    public static readonly TerminalTxnResultsBankCode StopRecurringPaymentRequests = new(
        "stop_recurring_payment_requests");

    public static readonly TerminalTxnResultsBankCode StoreLocationZeroNotAllowed = new(
        "store_location_zero_not_allowed");

    public static readonly TerminalTxnResultsBankCode SubsystemUnavailable = new("subsystem_unavailable");

    public static readonly TerminalTxnResultsBankCode SurchargeLimitExceeded = new("surcharge_limit_exceeded");

    public static readonly TerminalTxnResultsBankCode SystemError = new("system_error");

    public static readonly TerminalTxnResultsBankCode TargetCardAndTransactionCountMismatch = new(
        "target_card_and_transaction_count_mismatch");

    public static readonly TerminalTxnResultsBankCode TerminalTransactionNumberMismatch = new(
        "terminal_transaction_number_mismatch");

    public static readonly TerminalTxnResultsBankCode TestmodeDecline = new("testmode_decline");

    public static readonly TerminalTxnResultsBankCode TicketLimitExceeded = new("ticket_limit_exceeded");

    public static readonly TerminalTxnResultsBankCode Timeout = new("timeout");

    public static readonly TerminalTxnResultsBankCode TimeoutReversalNotSupported = new(
        "timeout_reversal_not_supported");

    public static readonly TerminalTxnResultsBankCode TooManyTransactionsRequested = new(
        "too_many_transactions_requested");

    public static readonly TerminalTxnResultsBankCode TotalsUnavailable = new("totals_unavailable");

    public static readonly TerminalTxnResultsBankCode TransactionCountOrWithdrawalLimitExceeded = new(
        "transaction_count_or_withdrawal_limit_exceeded");

    public static readonly TerminalTxnResultsBankCode TransactionDestinationNotFoundForRouting = new(
        "transaction_destination_not_found_for_routing");

    public static readonly TerminalTxnResultsBankCode TransactionHistoryUnavailable = new(
        "transaction_history_unavailable");

    public static readonly TerminalTxnResultsBankCode TransactionNotAllowed = new("transaction_not_allowed");

    public static readonly TerminalTxnResultsBankCode TransactionNotPermitted = new("transaction_not_permitted");

    public static readonly TerminalTxnResultsBankCode TransactionNotSupported = new("transaction_not_supported");

    public static readonly TerminalTxnResultsBankCode TransactionTotalLimitPerProductClassExceeded = new(
        "transaction_total_limit_per_product_class_exceeded");

    public static readonly TerminalTxnResultsBankCode TransarmorInvalidTokenOrAccountNumber = new(
        "transarmor_invalid_token_or_account_number");

    public static readonly TerminalTxnResultsBankCode TransarmorKeyError = new("transarmor_key_error");

    public static readonly TerminalTxnResultsBankCode TransarmorServiceUnavailable = new(
        "transarmor_service_unavailable");

    public static readonly TerminalTxnResultsBankCode TryAgainLater = new("try_again_later");

    public static readonly TerminalTxnResultsBankCode UnableToLocatePreviousMessage = new(
        "unable_to_locate_previous_message");

    public static readonly TerminalTxnResultsBankCode UnableToLocateRecord = new("unable_to_locate_record");

    public static readonly TerminalTxnResultsBankCode UnableToProcess = new("unable_to_process");

    public static readonly TerminalTxnResultsBankCode UnableToVerifyPin = new("unable_to_verify_pin");

    public static readonly TerminalTxnResultsBankCode Unauthorized = new("unauthorized");

    public static readonly TerminalTxnResultsBankCode Unavailable = new("unavailable");

    public static readonly TerminalTxnResultsBankCode UndefinedCard = new("undefined_card");

    public static readonly TerminalTxnResultsBankCode UnderageCustomer = new("underage_customer");

    public static readonly TerminalTxnResultsBankCode UnknownVelocityErrorPayInside = new(
        "unknown_velocity_error_pay_inside");

    public static readonly TerminalTxnResultsBankCode Unsuccessful = new("unsuccessful");

    public static readonly TerminalTxnResultsBankCode UnsupportedMessage = new("unsupported_message");

    public static readonly TerminalTxnResultsBankCode ValidationError = new("validation_error");

    public static readonly TerminalTxnResultsBankCode VelocityErrorPayInside = new("velocity_error_pay_inside");

    public static readonly TerminalTxnResultsBankCode VerificationTransaction = new("verification_transaction");

    public static readonly TerminalTxnResultsBankCode ViolationOfBusinessArrangement = new(
        "violation_of_business_arrangement");

    public static readonly TerminalTxnResultsBankCode VisaOctMastercardMoneysendTransactionsBlocked = new(
        "visa_oct/mastercard_moneysend_transactions_blocked");

    public static readonly TerminalTxnResultsBankCode VoidCapturedItem = new("void_captured_item");

    public static readonly TerminalTxnResultsBankCode VoyagerIdProblem = new("voyager_id_problem");

    public static readonly TerminalTxnResultsBankCode YOrNRequired = new("y_or_n_required");

    public static readonly TerminalTxnResultsBankCode Wait2PmEastern = new("wait_2_pm_eastern");

    public static readonly TerminalTxnResultsBankCode WithdrawalCountLimitExceeded = new(
        "withdrawal_count_limit_exceeded");

    public static readonly TerminalTxnResultsBankCode WithdrawalLimitExceeded = new("withdrawal_limit_exceeded");

    public static readonly TerminalTxnResultsBankCode ZipAddressNotVerified = new("zip_address_not_verified");

    public static readonly TerminalTxnResultsBankCode ZipAndAddressNotVerified = new("zip_and_address_not_verified");

    public static readonly TerminalTxnResultsBankCode ZipNoMatch = new("zip_no_match");

    public static readonly TerminalTxnResultsBankCode AddressMatchZipMismatch = new("address_match_zip_mismatch");

    public static readonly TerminalTxnResultsBankCode ZipNotVerified = new("zip_not_verified");

    public static readonly TerminalTxnResultsBankCode _3DsAuthenticationSuccessful = new(
        "3ds_authentication_successful");

    public static readonly TerminalTxnResultsBankCode _3DsAuthenticationInvalid = new("3ds_authentication_invalid");

    public static readonly TerminalTxnResultsBankCode _3DsAuthenticationFailed = new("3ds_authentication_failed");

    public static readonly TerminalTxnResultsBankCode _3DsAuthenticationNotValidated = new(
        "3ds_authentication_not_validated");

    public static readonly TerminalTxnResultsBankCode _3DsAuthenticationSuccessfulWithoutLiabilityShift = new(
        "3ds_authentication_successful_without_liability_shift");

    public TResult Match<TResult>(Func<TResult> onAcceptedButNotYetProcessed,
        Func<TResult> onAccountBlocked,
        Func<TResult> onAccountIsPurged,
        Func<TResult> onAccountLocked,
        Func<TResult> onAccountOnHoldOrNotActive,
        Func<TResult> onAccountNotActivated,
        Func<TResult> onAccountReloadsExceeded,
        Func<TResult> onAccountRowLocked,
        Func<TResult> onAccountStatusIsVoidLock,
        Func<TResult> onAchPaymentNotAccepted,
        Func<TResult> onAcquirerChannelUnavailable,
        Func<TResult> onActivationFailed,
        Func<TResult> onAdditiveLimitExceeded,
        Func<TResult> onZipMatchAddressMismatch,
        Func<TResult> onZipMatchAddressNotVerified,
        Func<TResult> onAlreadyRedeemed,
        Func<TResult> onAlreadyReversed,
        Func<TResult> onAmountLimitExceeded,
        Func<TResult> onAmountTooLarge,
        Func<TResult> onApproveWithId,
        Func<TResult> onApproved,
        Func<TResult> onApprovedEmvKeyLoad,
        Func<TResult> onApprovedWithNoCash,
        Func<TResult> onApprovedWithOverdraft,
        Func<TResult> onAuthorizationIdNeeded,
        Func<TResult> onBadAccount,
        Func<TResult> onBadChecksum,
        Func<TResult> onBadClose,
        Func<TResult> onBadMagStripe,
        Func<TResult> onBadPostDate,
        Func<TResult> onBadRepayDate,
        Func<TResult> onBalanceNotAvailable,
        Func<TResult> onBillToShipToMismatch,
        Func<TResult> onBinBlocked,
        Func<TResult> onBlockedByCardholder,
        Func<TResult> onBulkActivationError,
        Func<TResult> onBulkActivationPackageAmountError,
        Func<TResult> onCallAcquirer,
        Func<TResult> onCallForAuthorization,
        Func<TResult> onCallIssuer,
        Func<TResult> onCallTelecheck,
        Func<TResult> onCannotFindNetwork,
        Func<TResult> onCardAlreadyActive,
        Func<TResult> onCardAlreadyClosed,
        Func<TResult> onCardNotActive,
        Func<TResult> onCardNotSupported,
        Func<TResult> onCardVelocityAmountExceeded,
        Func<TResult> onCardVelocityCountExceeded,
        Func<TResult> onCardVelocityExceeded,
        Func<TResult> onCashbackGreaterThanTransactionAmount,
        Func<TResult> onCashLimitExceeded,
        Func<TResult> onCenterClosed,
        Func<TResult> onCheckerManagerNotFound,
        Func<TResult> onChipFailure,
        Func<TResult> onCloseUnavailable,
        Func<TResult> onCloseNotValid,
        Func<TResult> onClosedAccount,
        Func<TResult> onCountExceedsLimit,
        Func<TResult> onCounterfeitCard,
        Func<TResult> onCounterOfferToSupplyPersonalGuaranty,
        Func<TResult> onCryptogramDecryptionError,
        Func<TResult> onCryptoBoxIsOffline,
        Func<TResult> onCurrencyConversionComplete,
        Func<TResult> onCurrencyConversionError,
        Func<TResult> onCurrencyNotSupported,
        Func<TResult> onCustomerCancellation,
        Func<TResult> onCustomerOptOut,
        Func<TResult> onCutTimeCloseTo1400,
        Func<TResult> onCvvDeclined,
        Func<TResult> onCvvFailed,
        Func<TResult> onDailyLimitExceeded,
        Func<TResult> onDateOfBirthError,
        Func<TResult> onDebitGatewayUnavailable,
        Func<TResult> onDeclined,
        Func<TResult> onDeclinedDueToStandInRules,
        Func<TResult> onDeconvertedBin,
        Func<TResult> onDoNotHonor,
        Func<TResult> onDoNotTryAgain,
        Func<TResult> onDoNotTryAgainSubsequentMayContinue,
        Func<TResult> onDriversLicenseOrIdRequired,
        Func<TResult> onDuplicateCapture,
        Func<TResult> onDuplicateReturn,
        Func<TResult> onDuplicateReversal,
        Func<TResult> onDuplicateTransaction,
        Func<TResult> onEditHonor,
        Func<TResult> onEmailNoMatch,
        Func<TResult> onEmailUnavailable,
        Func<TResult> onEmvKeyDownloadError,
        Func<TResult> onEnterLesserAmount,
        Func<TResult> onErrorProcessingPinBlock,
        Func<TResult> onExceedsGlobalAmountForPeriodPayInside,
        Func<TResult> onExceedsGlobalCountForPeriodPayInside,
        Func<TResult> onExceedsGlobalLimitsForPeriodPayInside,
        Func<TResult> onExceedsLimit,
        Func<TResult> onExceedsMerchantAmountForPeriodPayInside,
        Func<TResult> onExceedsMerchantCountForPeriodPayInside,
        Func<TResult> onExceedsMerchantLimitsForPeriodPayInside,
        Func<TResult> onExceedsStateAmountForPeriodPayInside,
        Func<TResult> onExceedsStateCountForPeriodPayInside,
        Func<TResult> onExceedsStateLimitsForPeriodPayInside,
        Func<TResult> onExceedsTransactionCountOrAmountLimitIn24Hours,
        Func<TResult> onExceedsTransactionCountOrAmountLimitIn7Days,
        Func<TResult> onExceedsTransactionCountOrAmountLimitIn30Days,
        Func<TResult> onExceedsZipCodeAmountForPeriodPayInside,
        Func<TResult> onExceedsZipCodeCountForPeriodPayInside,
        Func<TResult> onExceedsZipCodeLimitsForPeriodPayInside,
        Func<TResult> onExpiredCard,
        Func<TResult> onExpiredLock,
        Func<TResult> onFraudulent,
        Func<TResult> onFileTemporarilyUnavailable,
        Func<TResult> onFileUpdateError,
        Func<TResult> onFileUpdateUnavailable,
        Func<TResult> onFormatError,
        Func<TResult> onForwardToIssuer,
        Func<TResult> onFuelLimitExceeded,
        Func<TResult> onFuelOnly,
        Func<TResult> onFuelPriceError,
        Func<TResult> onFullSsnRequired,
        Func<TResult> onFunctionNotSupported,
        Func<TResult> onFundsOnHold,
        Func<TResult> onGeneral,
        Func<TResult> onGeneralError,
        Func<TResult> onGenericDecline,
        Func<TResult> onHardCapturePickupCard,
        Func<TResult> onHardNegativeInfoOnFile,
        Func<TResult> onHighRisk,
        Func<TResult> onHoldShippingFor24H,
        Func<TResult> onHonorWithAuthentication,
        Func<TResult> onIllegalTransaction,
        Func<TResult> onImprintCard,
        Func<TResult> onIncorrectCvv,
        Func<TResult> onIncorrectNumber,
        Func<TResult> onIncorrectPin,
        Func<TResult> onIncorrectMerchantLocation,
        Func<TResult> onIncorrectTransactionVersion,
        Func<TResult> onInquiryDeclined,
        Func<TResult> onInsufficientData,
        Func<TResult> onInsufficientFunds,
        Func<TResult> onInsufficientSecurity,
        Func<TResult> onInternetAccessDisabled,
        Func<TResult> onInvalid3DPassword,
        Func<TResult> onInvalidAccount,
        Func<TResult> onInvalidAccountDate,
        Func<TResult> onInvalidAccountType,
        Func<TResult> onInvalidActivate,
        Func<TResult> onInvalidAmount,
        Func<TResult> onInvalidAuthorizationCode,
        Func<TResult> onInvalidBatchNumberId,
        Func<TResult> onInvalidCashback,
        Func<TResult> onInvalidCheckingAccount,
        Func<TResult> onInvalidCheckingAccountNumber,
        Func<TResult> onInvalidCreditAccount,
        Func<TResult> onInvalidClerk,
        Func<TResult> onInvalidCurrency,
        Func<TResult> onInvalidCvv,
        Func<TResult> onInvalidDateOrTime,
        Func<TResult> onInvalidDriver,
        Func<TResult> onInvalidEanOrScv,
        Func<TResult> onInvalidEffectiveDate,
        Func<TResult> onInvalidEmailAddress,
        Func<TResult> onInvalidEntry,
        Func<TResult> onInvalidExpiryDate,
        Func<TResult> onInvalidExpiryYear,
        Func<TResult> onInvalidHost,
        Func<TResult> onInvalidLocation,
        Func<TResult> onInvalidMaidenName,
        Func<TResult> onInvalidMcc,
        Func<TResult> onInvalidMerchant,
        Func<TResult> onInvalidMerchantId,
        Func<TResult> onInvalidMerchantIdSe,
        Func<TResult> onInvalidMerchantSetup,
        Func<TResult> onInvalidMicrData,
        Func<TResult> onInvalidNewPassword,
        Func<TResult> onInvalidNotPresent,
        Func<TResult> onInvalidNumber,
        Func<TResult> onInvalidOdometer,
        Func<TResult> onInvalidPassword,
        Func<TResult> onInvalidPin,
        Func<TResult> onInvalidPos,
        Func<TResult> onInvalidPreapprovalNumber,
        Func<TResult> onInvalidPrefix,
        Func<TResult> onInvalidProduct,
        Func<TResult> onInvalidPromptEntry,
        Func<TResult> onInvalidRequest,
        Func<TResult> onInvalidResponse,
        Func<TResult> onInvalidResponseDate,
        Func<TResult> onInvalidRestrictionCode,
        Func<TResult> onInvalidSavingsAccount,
        Func<TResult> onInvalidSecurePaymentData,
        Func<TResult> onInvalidSku,
        Func<TResult> onInvalidSsn,
        Func<TResult> onInvalidStateCode,
        Func<TResult> onInvalidStatusChange,
        Func<TResult> onInvalidTerminal,
        Func<TResult> onInvalidTgnCic,
        Func<TResult> onInvalidTimezone,
        Func<TResult> onInvalidTppid,
        Func<TResult> onInvalidTrackData,
        Func<TResult> onInvalidTransaction,
        Func<TResult> onInvalidTransarmorTransaction,
        Func<TResult> onInvalidUser,
        Func<TResult> onInvalidValueInTheField,
        Func<TResult> onInvalidVehicle,
        Func<TResult> onInvalidVoidOfActivation,
        Func<TResult> onInvalidZipCode,
        Func<TResult> onIssuanceUnderMinimumAmount,
        Func<TResult> onIssuerNotAvailable,
        Func<TResult> onIssuerProcessorOrSwitchNotAvailable,
        Func<TResult> onIssuerSpecialConditions,
        Func<TResult> onIssuerVelocityAmountExceeded,
        Func<TResult> onIssuerVelocityCountExceeded,
        Func<TResult> onLateReversal,
        Func<TResult> onLawViolation,
        Func<TResult> onLimitCheckFailed,
        Func<TResult> onLostCard,
        Func<TResult> onMaidenNameUnavailable,
        Func<TResult> onManualTriesExceeded,
        Func<TResult> onMatchMember,
        Func<TResult> onMaxBalanceExceeded,
        Func<TResult> onMerchantDepleted,
        Func<TResult> onMerchantHasMailPending,
        Func<TResult> onMessageFormatError,
        Func<TResult> onMinus2Debit,
        Func<TResult> onMissingConditionalData,
        Func<TResult> onMissingCustomerServicePhone,
        Func<TResult> onMissingFromAccount,
        Func<TResult> onMissingToAccount,
        Func<TResult> onMultiCurrencyDccFail,
        Func<TResult> onMultiCurrencyInvertFail,
        Func<TResult> onMultipleAccountsForType,
        Func<TResult> onNameEmailNoMatch,
        Func<TResult> onNameEmailUnavailable,
        Func<TResult> onNameNoMatch,
        Func<TResult> onNamePhoneNoMatch,
        Func<TResult> onNamePhoneUnavailable,
        Func<TResult> onNameUnavailable,
        Func<TResult> onNegativeFileException,
        Func<TResult> onNewAccountInformationAvailable,
        Func<TResult> onNewCardIssued,
        Func<TResult> onNewPasswordRequired,
        Func<TResult> onNoAccountLink,
        Func<TResult> onNoActionTaken,
        Func<TResult> onNoCardRecord,
        Func<TResult> onNoChainId,
        Func<TResult> onNoCheckingAccount,
        Func<TResult> onMismatch,
        Func<TResult> onNoMessagesPending,
        Func<TResult> onNoOpenBatch,
        Func<TResult> onNoPhoneService,
        Func<TResult> onNoPreviousTransaction,
        Func<TResult> onNoReasonToDecline,
        Func<TResult> onNoSavingsAccount,
        Func<TResult> onNoSuchIssuer,
        Func<TResult> onNoToAccount,
        Func<TResult> onNoTransactionsAvailable,
        Func<TResult> onNoTransactionSecurityRecord,
        Func<TResult> onNotAccepted,
        Func<TResult> onNotActive,
        Func<TResult> onNotLostOrStolen,
        Func<TResult> onNotOnFile,
        Func<TResult> onNotPermitted,
        Func<TResult> onNotPerformed,
        Func<TResult> onNotProcessed,
        Func<TResult> onNotSupported,
        Func<TResult> onNsf,
        Func<TResult> onOneTimeStopPayment,
        Func<TResult> onOriginalAuthorizationMismatch,
        Func<TResult> onOriginalAuthorizationNotFound,
        Func<TResult> onOriginalRepeated,
        Func<TResult> onOriginalTransactionNotApproved,
        Func<TResult> onOverChainDailyVelocityAmount,
        Func<TResult> onOverChainDailyVelocityCount,
        Func<TResult> onOverChainDailyVelocityLimits,
        Func<TResult> onOverChainProductVelocityAmount,
        Func<TResult> onOverChainProductVelocityCount,
        Func<TResult> onOverChainProductVelocityLimits,
        Func<TResult> onOverMaxBalance,
        Func<TResult> onOverMerchandiseLimit,
        Func<TResult> onOverMerchantDailyVelocityAmount,
        Func<TResult> onOverMerchantDailyVelocityCount,
        Func<TResult> onOverMerchantDailyVelocityLimits,
        Func<TResult> onOverMerchantProductVelocityAmount,
        Func<TResult> onOverMerchantProductVelocityCount,
        Func<TResult> onOverMerchantProductVelocityLimits,
        Func<TResult> onOverMonthlyLimit,
        Func<TResult> onOverNonFuelLimit,
        Func<TResult> onPanTransError,
        Func<TResult> onPartialAuthNotAllowed,
        Func<TResult> onPartialReversal,
        Func<TResult> onPartiallyApproved,
        Func<TResult> onPasswordRetriesExceeded,
        Func<TResult> onPayAtPumpNotAllowed,
        Func<TResult> onPhoneEmailNoMatch,
        Func<TResult> onPhoneEmailUnavailable,
        Func<TResult> onPhoneNoMatch,
        Func<TResult> onPhoneUnavailable,
        Func<TResult> onPickupCard,
        Func<TResult> onPinAlreadyExists,
        Func<TResult> onPinKeyError,
        Func<TResult> onPinKeySychronizationError,
        Func<TResult> onPinTryExceeded,
        Func<TResult> onPleaseRetry,
        Func<TResult> onProcessAsDebit,
        Func<TResult> onProcessingError,
        Func<TResult> onProductCodeRestricted,
        Func<TResult> onPromoLocationRestricted,
        Func<TResult> onQuantityExceeded,
        Func<TResult> onReauthorizationTimeframeExpired,
        Func<TResult> onRechargeAmountExceeded,
        Func<TResult> onRechargeCountExceeded,
        Func<TResult> onReenterTransaction,
        Func<TResult> onReferral,
        Func<TResult> onRejectMessage,
        Func<TResult> onRejectedLostStolenChecks,
        Func<TResult> onRepairLimitExceeded,
        Func<TResult> onRequestInProgress,
        Func<TResult> onResponseReceivedLate,
        Func<TResult> onRestrictedCard,
        Func<TResult> onResubmissionViolatesNetworkFrequency,
        Func<TResult> onRetainCard,
        Func<TResult> onReversal,
        Func<TResult> onReversalNoMatch,
        Func<TResult> onReversalUnsuccessful,
        Func<TResult> onRevocationOfAllAuthorizations,
        Func<TResult> onRevocationOfAuthorization,
        Func<TResult> onSecureCodeNotEnabled,
        Func<TResult> onSecurityError,
        Func<TResult> onSecurityErrorTryAgain,
        Func<TResult> onSecurityViolation,
        Func<TResult> onSeeAttendant,
        Func<TResult> onSeeExhibitForError,
        Func<TResult> onServiceNotAllowed,
        Func<TResult> onSignatureRequired,
        Func<TResult> onSkipTraceInfo,
        Func<TResult> onSoftDescriptorNotEnabled,
        Func<TResult> onSsnNotAvailable,
        Func<TResult> onStolenCard,
        Func<TResult> onStopPaymentOrder,
        Func<TResult> onStopRecurringPaymentRequests,
        Func<TResult> onStoreLocationZeroNotAllowed,
        Func<TResult> onSubsystemUnavailable,
        Func<TResult> onSurchargeLimitExceeded,
        Func<TResult> onSystemError,
        Func<TResult> onTargetCardAndTransactionCountMismatch,
        Func<TResult> onTerminalTransactionNumberMismatch,
        Func<TResult> onTestmodeDecline,
        Func<TResult> onTicketLimitExceeded,
        Func<TResult> onTimeout,
        Func<TResult> onTimeoutReversalNotSupported,
        Func<TResult> onTooManyTransactionsRequested,
        Func<TResult> onTotalsUnavailable,
        Func<TResult> onTransactionCountOrWithdrawalLimitExceeded,
        Func<TResult> onTransactionDestinationNotFoundForRouting,
        Func<TResult> onTransactionHistoryUnavailable,
        Func<TResult> onTransactionNotAllowed,
        Func<TResult> onTransactionNotPermitted,
        Func<TResult> onTransactionNotSupported,
        Func<TResult> onTransactionTotalLimitPerProductClassExceeded,
        Func<TResult> onTransarmorInvalidTokenOrAccountNumber,
        Func<TResult> onTransarmorKeyError,
        Func<TResult> onTransarmorServiceUnavailable,
        Func<TResult> onTryAgainLater,
        Func<TResult> onUnableToLocatePreviousMessage,
        Func<TResult> onUnableToLocateRecord,
        Func<TResult> onUnableToProcess,
        Func<TResult> onUnableToVerifyPin,
        Func<TResult> onUnauthorized,
        Func<TResult> onUnavailable,
        Func<TResult> onUndefinedCard,
        Func<TResult> onUnderageCustomer,
        Func<TResult> onUnknownVelocityErrorPayInside,
        Func<TResult> onUnsuccessful,
        Func<TResult> onUnsupportedMessage,
        Func<TResult> onValidationError,
        Func<TResult> onVelocityErrorPayInside,
        Func<TResult> onVerificationTransaction,
        Func<TResult> onViolationOfBusinessArrangement,
        Func<TResult> onVisaOctMastercardMoneysendTransactionsBlocked,
        Func<TResult> onVoidCapturedItem,
        Func<TResult> onVoyagerIdProblem,
        Func<TResult> onYOrNRequired,
        Func<TResult> onWait2PmEastern,
        Func<TResult> onWithdrawalCountLimitExceeded,
        Func<TResult> onWithdrawalLimitExceeded,
        Func<TResult> onZipAddressNotVerified,
        Func<TResult> onZipAndAddressNotVerified,
        Func<TResult> onZipNoMatch,
        Func<TResult> onAddressMatchZipMismatch,
        Func<TResult> onZipNotVerified,
        Func<TResult> on_3DsAuthenticationSuccessful,
        Func<TResult> on_3DsAuthenticationInvalid,
        Func<TResult> on_3DsAuthenticationFailed,
        Func<TResult> on_3DsAuthenticationNotValidated,
        Func<TResult> on_3DsAuthenticationSuccessfulWithoutLiabilityShift,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AcceptedButNotYetProcessed => onAcceptedButNotYetProcessed(),
            _ when this == AccountBlocked => onAccountBlocked(),
            _ when this == AccountIsPurged => onAccountIsPurged(),
            _ when this == AccountLocked => onAccountLocked(),
            _ when this == AccountOnHoldOrNotActive => onAccountOnHoldOrNotActive(),
            _ when this == AccountNotActivated => onAccountNotActivated(),
            _ when this == AccountReloadsExceeded => onAccountReloadsExceeded(),
            _ when this == AccountRowLocked => onAccountRowLocked(),
            _ when this == AccountStatusIsVoidLock => onAccountStatusIsVoidLock(),
            _ when this == AchPaymentNotAccepted => onAchPaymentNotAccepted(),
            _ when this == AcquirerChannelUnavailable => onAcquirerChannelUnavailable(),
            _ when this == ActivationFailed => onActivationFailed(),
            _ when this == AdditiveLimitExceeded => onAdditiveLimitExceeded(),
            _ when this == ZipMatchAddressMismatch => onZipMatchAddressMismatch(),
            _ when this == ZipMatchAddressNotVerified => onZipMatchAddressNotVerified(),
            _ when this == AlreadyRedeemed => onAlreadyRedeemed(),
            _ when this == AlreadyReversed => onAlreadyReversed(),
            _ when this == AmountLimitExceeded => onAmountLimitExceeded(),
            _ when this == AmountTooLarge => onAmountTooLarge(),
            _ when this == ApproveWithId => onApproveWithId(),
            _ when this == Approved => onApproved(),
            _ when this == ApprovedEmvKeyLoad => onApprovedEmvKeyLoad(),
            _ when this == ApprovedWithNoCash => onApprovedWithNoCash(),
            _ when this == ApprovedWithOverdraft => onApprovedWithOverdraft(),
            _ when this == AuthorizationIdNeeded => onAuthorizationIdNeeded(),
            _ when this == BadAccount => onBadAccount(),
            _ when this == BadChecksum => onBadChecksum(),
            _ when this == BadClose => onBadClose(),
            _ when this == BadMagStripe => onBadMagStripe(),
            _ when this == BadPostDate => onBadPostDate(),
            _ when this == BadRepayDate => onBadRepayDate(),
            _ when this == BalanceNotAvailable => onBalanceNotAvailable(),
            _ when this == BillToShipToMismatch => onBillToShipToMismatch(),
            _ when this == BinBlocked => onBinBlocked(),
            _ when this == BlockedByCardholder => onBlockedByCardholder(),
            _ when this == BulkActivationError => onBulkActivationError(),
            _ when this == BulkActivationPackageAmountError => onBulkActivationPackageAmountError(),
            _ when this == CallAcquirer => onCallAcquirer(),
            _ when this == CallForAuthorization => onCallForAuthorization(),
            _ when this == CallIssuer => onCallIssuer(),
            _ when this == CallTelecheck => onCallTelecheck(),
            _ when this == CannotFindNetwork => onCannotFindNetwork(),
            _ when this == CardAlreadyActive => onCardAlreadyActive(),
            _ when this == CardAlreadyClosed => onCardAlreadyClosed(),
            _ when this == CardNotActive => onCardNotActive(),
            _ when this == CardNotSupported => onCardNotSupported(),
            _ when this == CardVelocityAmountExceeded => onCardVelocityAmountExceeded(),
            _ when this == CardVelocityCountExceeded => onCardVelocityCountExceeded(),
            _ when this == CardVelocityExceeded => onCardVelocityExceeded(),
            _ when this == CashbackGreaterThanTransactionAmount => onCashbackGreaterThanTransactionAmount(),
            _ when this == CashLimitExceeded => onCashLimitExceeded(),
            _ when this == CenterClosed => onCenterClosed(),
            _ when this == CheckerManagerNotFound => onCheckerManagerNotFound(),
            _ when this == ChipFailure => onChipFailure(),
            _ when this == CloseUnavailable => onCloseUnavailable(),
            _ when this == CloseNotValid => onCloseNotValid(),
            _ when this == ClosedAccount => onClosedAccount(),
            _ when this == CountExceedsLimit => onCountExceedsLimit(),
            _ when this == CounterfeitCard => onCounterfeitCard(),
            _ when this == CounterOfferToSupplyPersonalGuaranty => onCounterOfferToSupplyPersonalGuaranty(),
            _ when this == CryptogramDecryptionError => onCryptogramDecryptionError(),
            _ when this == CryptoBoxIsOffline => onCryptoBoxIsOffline(),
            _ when this == CurrencyConversionComplete => onCurrencyConversionComplete(),
            _ when this == CurrencyConversionError => onCurrencyConversionError(),
            _ when this == CurrencyNotSupported => onCurrencyNotSupported(),
            _ when this == CustomerCancellation => onCustomerCancellation(),
            _ when this == CustomerOptOut => onCustomerOptOut(),
            _ when this == CutTimeCloseTo1400 => onCutTimeCloseTo1400(),
            _ when this == CvvDeclined => onCvvDeclined(),
            _ when this == CvvFailed => onCvvFailed(),
            _ when this == DailyLimitExceeded => onDailyLimitExceeded(),
            _ when this == DateOfBirthError => onDateOfBirthError(),
            _ when this == DebitGatewayUnavailable => onDebitGatewayUnavailable(),
            _ when this == Declined => onDeclined(),
            _ when this == DeclinedDueToStandInRules => onDeclinedDueToStandInRules(),
            _ when this == DeconvertedBin => onDeconvertedBin(),
            _ when this == DoNotHonor => onDoNotHonor(),
            _ when this == DoNotTryAgain => onDoNotTryAgain(),
            _ when this == DoNotTryAgainSubsequentMayContinue => onDoNotTryAgainSubsequentMayContinue(),
            _ when this == DriversLicenseOrIdRequired => onDriversLicenseOrIdRequired(),
            _ when this == DuplicateCapture => onDuplicateCapture(),
            _ when this == DuplicateReturn => onDuplicateReturn(),
            _ when this == DuplicateReversal => onDuplicateReversal(),
            _ when this == DuplicateTransaction => onDuplicateTransaction(),
            _ when this == EditHonor => onEditHonor(),
            _ when this == EmailNoMatch => onEmailNoMatch(),
            _ when this == EmailUnavailable => onEmailUnavailable(),
            _ when this == EmvKeyDownloadError => onEmvKeyDownloadError(),
            _ when this == EnterLesserAmount => onEnterLesserAmount(),
            _ when this == ErrorProcessingPinBlock => onErrorProcessingPinBlock(),
            _ when this == ExceedsGlobalAmountForPeriodPayInside => onExceedsGlobalAmountForPeriodPayInside(),
            _ when this == ExceedsGlobalCountForPeriodPayInside => onExceedsGlobalCountForPeriodPayInside(),
            _ when this == ExceedsGlobalLimitsForPeriodPayInside => onExceedsGlobalLimitsForPeriodPayInside(),
            _ when this == ExceedsLimit => onExceedsLimit(),
            _ when this == ExceedsMerchantAmountForPeriodPayInside => onExceedsMerchantAmountForPeriodPayInside(),
            _ when this == ExceedsMerchantCountForPeriodPayInside => onExceedsMerchantCountForPeriodPayInside(),
            _ when this == ExceedsMerchantLimitsForPeriodPayInside => onExceedsMerchantLimitsForPeriodPayInside(),
            _ when this == ExceedsStateAmountForPeriodPayInside => onExceedsStateAmountForPeriodPayInside(),
            _ when this == ExceedsStateCountForPeriodPayInside => onExceedsStateCountForPeriodPayInside(),
            _ when this == ExceedsStateLimitsForPeriodPayInside => onExceedsStateLimitsForPeriodPayInside(),
            _ when this ==
                ExceedsTransactionCountOrAmountLimitIn24Hours => onExceedsTransactionCountOrAmountLimitIn24Hours(),
            _ when this ==
                ExceedsTransactionCountOrAmountLimitIn7Days => onExceedsTransactionCountOrAmountLimitIn7Days(),
            _ when this ==
                ExceedsTransactionCountOrAmountLimitIn30Days => onExceedsTransactionCountOrAmountLimitIn30Days(),
            _ when this == ExceedsZipCodeAmountForPeriodPayInside => onExceedsZipCodeAmountForPeriodPayInside(),
            _ when this == ExceedsZipCodeCountForPeriodPayInside => onExceedsZipCodeCountForPeriodPayInside(),
            _ when this == ExceedsZipCodeLimitsForPeriodPayInside => onExceedsZipCodeLimitsForPeriodPayInside(),
            _ when this == ExpiredCard => onExpiredCard(),
            _ when this == ExpiredLock => onExpiredLock(),
            _ when this == Fraudulent => onFraudulent(),
            _ when this == FileTemporarilyUnavailable => onFileTemporarilyUnavailable(),
            _ when this == FileUpdateError => onFileUpdateError(),
            _ when this == FileUpdateUnavailable => onFileUpdateUnavailable(),
            _ when this == FormatError => onFormatError(),
            _ when this == ForwardToIssuer => onForwardToIssuer(),
            _ when this == FuelLimitExceeded => onFuelLimitExceeded(),
            _ when this == FuelOnly => onFuelOnly(),
            _ when this == FuelPriceError => onFuelPriceError(),
            _ when this == FullSsnRequired => onFullSsnRequired(),
            _ when this == FunctionNotSupported => onFunctionNotSupported(),
            _ when this == FundsOnHold => onFundsOnHold(),
            _ when this == General => onGeneral(),
            _ when this == GeneralError => onGeneralError(),
            _ when this == GenericDecline => onGenericDecline(),
            _ when this == HardCapturePickupCard => onHardCapturePickupCard(),
            _ when this == HardNegativeInfoOnFile => onHardNegativeInfoOnFile(),
            _ when this == HighRisk => onHighRisk(),
            _ when this == HoldShippingFor24H => onHoldShippingFor24H(),
            _ when this == HonorWithAuthentication => onHonorWithAuthentication(),
            _ when this == IllegalTransaction => onIllegalTransaction(),
            _ when this == ImprintCard => onImprintCard(),
            _ when this == IncorrectCvv => onIncorrectCvv(),
            _ when this == IncorrectNumber => onIncorrectNumber(),
            _ when this == IncorrectPin => onIncorrectPin(),
            _ when this == IncorrectMerchantLocation => onIncorrectMerchantLocation(),
            _ when this == IncorrectTransactionVersion => onIncorrectTransactionVersion(),
            _ when this == InquiryDeclined => onInquiryDeclined(),
            _ when this == InsufficientData => onInsufficientData(),
            _ when this == InsufficientFunds => onInsufficientFunds(),
            _ when this == InsufficientSecurity => onInsufficientSecurity(),
            _ when this == InternetAccessDisabled => onInternetAccessDisabled(),
            _ when this == Invalid3DPassword => onInvalid3DPassword(),
            _ when this == InvalidAccount => onInvalidAccount(),
            _ when this == InvalidAccountDate => onInvalidAccountDate(),
            _ when this == InvalidAccountType => onInvalidAccountType(),
            _ when this == InvalidActivate => onInvalidActivate(),
            _ when this == InvalidAmount => onInvalidAmount(),
            _ when this == InvalidAuthorizationCode => onInvalidAuthorizationCode(),
            _ when this == InvalidBatchNumberId => onInvalidBatchNumberId(),
            _ when this == InvalidCashback => onInvalidCashback(),
            _ when this == InvalidCheckingAccount => onInvalidCheckingAccount(),
            _ when this == InvalidCheckingAccountNumber => onInvalidCheckingAccountNumber(),
            _ when this == InvalidCreditAccount => onInvalidCreditAccount(),
            _ when this == InvalidClerk => onInvalidClerk(),
            _ when this == InvalidCurrency => onInvalidCurrency(),
            _ when this == InvalidCvv => onInvalidCvv(),
            _ when this == InvalidDateOrTime => onInvalidDateOrTime(),
            _ when this == InvalidDriver => onInvalidDriver(),
            _ when this == InvalidEanOrScv => onInvalidEanOrScv(),
            _ when this == InvalidEffectiveDate => onInvalidEffectiveDate(),
            _ when this == InvalidEmailAddress => onInvalidEmailAddress(),
            _ when this == InvalidEntry => onInvalidEntry(),
            _ when this == InvalidExpiryDate => onInvalidExpiryDate(),
            _ when this == InvalidExpiryYear => onInvalidExpiryYear(),
            _ when this == InvalidHost => onInvalidHost(),
            _ when this == InvalidLocation => onInvalidLocation(),
            _ when this == InvalidMaidenName => onInvalidMaidenName(),
            _ when this == InvalidMcc => onInvalidMcc(),
            _ when this == InvalidMerchant => onInvalidMerchant(),
            _ when this == InvalidMerchantId => onInvalidMerchantId(),
            _ when this == InvalidMerchantIdSe => onInvalidMerchantIdSe(),
            _ when this == InvalidMerchantSetup => onInvalidMerchantSetup(),
            _ when this == InvalidMicrData => onInvalidMicrData(),
            _ when this == InvalidNewPassword => onInvalidNewPassword(),
            _ when this == InvalidNotPresent => onInvalidNotPresent(),
            _ when this == InvalidNumber => onInvalidNumber(),
            _ when this == InvalidOdometer => onInvalidOdometer(),
            _ when this == InvalidPassword => onInvalidPassword(),
            _ when this == InvalidPin => onInvalidPin(),
            _ when this == InvalidPos => onInvalidPos(),
            _ when this == InvalidPreapprovalNumber => onInvalidPreapprovalNumber(),
            _ when this == InvalidPrefix => onInvalidPrefix(),
            _ when this == InvalidProduct => onInvalidProduct(),
            _ when this == InvalidPromptEntry => onInvalidPromptEntry(),
            _ when this == InvalidRequest => onInvalidRequest(),
            _ when this == InvalidResponse => onInvalidResponse(),
            _ when this == InvalidResponseDate => onInvalidResponseDate(),
            _ when this == InvalidRestrictionCode => onInvalidRestrictionCode(),
            _ when this == InvalidSavingsAccount => onInvalidSavingsAccount(),
            _ when this == InvalidSecurePaymentData => onInvalidSecurePaymentData(),
            _ when this == InvalidSku => onInvalidSku(),
            _ when this == InvalidSsn => onInvalidSsn(),
            _ when this == InvalidStateCode => onInvalidStateCode(),
            _ when this == InvalidStatusChange => onInvalidStatusChange(),
            _ when this == InvalidTerminal => onInvalidTerminal(),
            _ when this == InvalidTgnCic => onInvalidTgnCic(),
            _ when this == InvalidTimezone => onInvalidTimezone(),
            _ when this == InvalidTppid => onInvalidTppid(),
            _ when this == InvalidTrackData => onInvalidTrackData(),
            _ when this == InvalidTransaction => onInvalidTransaction(),
            _ when this == InvalidTransarmorTransaction => onInvalidTransarmorTransaction(),
            _ when this == InvalidUser => onInvalidUser(),
            _ when this == InvalidValueInTheField => onInvalidValueInTheField(),
            _ when this == InvalidVehicle => onInvalidVehicle(),
            _ when this == InvalidVoidOfActivation => onInvalidVoidOfActivation(),
            _ when this == InvalidZipCode => onInvalidZipCode(),
            _ when this == IssuanceUnderMinimumAmount => onIssuanceUnderMinimumAmount(),
            _ when this == IssuerNotAvailable => onIssuerNotAvailable(),
            _ when this == IssuerProcessorOrSwitchNotAvailable => onIssuerProcessorOrSwitchNotAvailable(),
            _ when this == IssuerSpecialConditions => onIssuerSpecialConditions(),
            _ when this == IssuerVelocityAmountExceeded => onIssuerVelocityAmountExceeded(),
            _ when this == IssuerVelocityCountExceeded => onIssuerVelocityCountExceeded(),
            _ when this == LateReversal => onLateReversal(),
            _ when this == LawViolation => onLawViolation(),
            _ when this == LimitCheckFailed => onLimitCheckFailed(),
            _ when this == LostCard => onLostCard(),
            _ when this == MaidenNameUnavailable => onMaidenNameUnavailable(),
            _ when this == ManualTriesExceeded => onManualTriesExceeded(),
            _ when this == MatchMember => onMatchMember(),
            _ when this == MaxBalanceExceeded => onMaxBalanceExceeded(),
            _ when this == MerchantDepleted => onMerchantDepleted(),
            _ when this == MerchantHasMailPending => onMerchantHasMailPending(),
            _ when this == MessageFormatError => onMessageFormatError(),
            _ when this == Minus2Debit => onMinus2Debit(),
            _ when this == MissingConditionalData => onMissingConditionalData(),
            _ when this == MissingCustomerServicePhone => onMissingCustomerServicePhone(),
            _ when this == MissingFromAccount => onMissingFromAccount(),
            _ when this == MissingToAccount => onMissingToAccount(),
            _ when this == MultiCurrencyDccFail => onMultiCurrencyDccFail(),
            _ when this == MultiCurrencyInvertFail => onMultiCurrencyInvertFail(),
            _ when this == MultipleAccountsForType => onMultipleAccountsForType(),
            _ when this == NameEmailNoMatch => onNameEmailNoMatch(),
            _ when this == NameEmailUnavailable => onNameEmailUnavailable(),
            _ when this == NameNoMatch => onNameNoMatch(),
            _ when this == NamePhoneNoMatch => onNamePhoneNoMatch(),
            _ when this == NamePhoneUnavailable => onNamePhoneUnavailable(),
            _ when this == NameUnavailable => onNameUnavailable(),
            _ when this == NegativeFileException => onNegativeFileException(),
            _ when this == NewAccountInformationAvailable => onNewAccountInformationAvailable(),
            _ when this == NewCardIssued => onNewCardIssued(),
            _ when this == NewPasswordRequired => onNewPasswordRequired(),
            _ when this == NoAccountLink => onNoAccountLink(),
            _ when this == NoActionTaken => onNoActionTaken(),
            _ when this == NoCardRecord => onNoCardRecord(),
            _ when this == NoChainId => onNoChainId(),
            _ when this == NoCheckingAccount => onNoCheckingAccount(),
            _ when this == Mismatch => onMismatch(),
            _ when this == NoMessagesPending => onNoMessagesPending(),
            _ when this == NoOpenBatch => onNoOpenBatch(),
            _ when this == NoPhoneService => onNoPhoneService(),
            _ when this == NoPreviousTransaction => onNoPreviousTransaction(),
            _ when this == NoReasonToDecline => onNoReasonToDecline(),
            _ when this == NoSavingsAccount => onNoSavingsAccount(),
            _ when this == NoSuchIssuer => onNoSuchIssuer(),
            _ when this == NoToAccount => onNoToAccount(),
            _ when this == NoTransactionsAvailable => onNoTransactionsAvailable(),
            _ when this == NoTransactionSecurityRecord => onNoTransactionSecurityRecord(),
            _ when this == NotAccepted => onNotAccepted(),
            _ when this == NotActive => onNotActive(),
            _ when this == NotLostOrStolen => onNotLostOrStolen(),
            _ when this == NotOnFile => onNotOnFile(),
            _ when this == NotPermitted => onNotPermitted(),
            _ when this == NotPerformed => onNotPerformed(),
            _ when this == NotProcessed => onNotProcessed(),
            _ when this == NotSupported => onNotSupported(),
            _ when this == Nsf => onNsf(),
            _ when this == OneTimeStopPayment => onOneTimeStopPayment(),
            _ when this == OriginalAuthorizationMismatch => onOriginalAuthorizationMismatch(),
            _ when this == OriginalAuthorizationNotFound => onOriginalAuthorizationNotFound(),
            _ when this == OriginalRepeated => onOriginalRepeated(),
            _ when this == OriginalTransactionNotApproved => onOriginalTransactionNotApproved(),
            _ when this == OverChainDailyVelocityAmount => onOverChainDailyVelocityAmount(),
            _ when this == OverChainDailyVelocityCount => onOverChainDailyVelocityCount(),
            _ when this == OverChainDailyVelocityLimits => onOverChainDailyVelocityLimits(),
            _ when this == OverChainProductVelocityAmount => onOverChainProductVelocityAmount(),
            _ when this == OverChainProductVelocityCount => onOverChainProductVelocityCount(),
            _ when this == OverChainProductVelocityLimits => onOverChainProductVelocityLimits(),
            _ when this == OverMaxBalance => onOverMaxBalance(),
            _ when this == OverMerchandiseLimit => onOverMerchandiseLimit(),
            _ when this == OverMerchantDailyVelocityAmount => onOverMerchantDailyVelocityAmount(),
            _ when this == OverMerchantDailyVelocityCount => onOverMerchantDailyVelocityCount(),
            _ when this == OverMerchantDailyVelocityLimits => onOverMerchantDailyVelocityLimits(),
            _ when this == OverMerchantProductVelocityAmount => onOverMerchantProductVelocityAmount(),
            _ when this == OverMerchantProductVelocityCount => onOverMerchantProductVelocityCount(),
            _ when this == OverMerchantProductVelocityLimits => onOverMerchantProductVelocityLimits(),
            _ when this == OverMonthlyLimit => onOverMonthlyLimit(),
            _ when this == OverNonFuelLimit => onOverNonFuelLimit(),
            _ when this == PanTransError => onPanTransError(),
            _ when this == PartialAuthNotAllowed => onPartialAuthNotAllowed(),
            _ when this == PartialReversal => onPartialReversal(),
            _ when this == PartiallyApproved => onPartiallyApproved(),
            _ when this == PasswordRetriesExceeded => onPasswordRetriesExceeded(),
            _ when this == PayAtPumpNotAllowed => onPayAtPumpNotAllowed(),
            _ when this == PhoneEmailNoMatch => onPhoneEmailNoMatch(),
            _ when this == PhoneEmailUnavailable => onPhoneEmailUnavailable(),
            _ when this == PhoneNoMatch => onPhoneNoMatch(),
            _ when this == PhoneUnavailable => onPhoneUnavailable(),
            _ when this == PickupCard => onPickupCard(),
            _ when this == PinAlreadyExists => onPinAlreadyExists(),
            _ when this == PinKeyError => onPinKeyError(),
            _ when this == PinKeySychronizationError => onPinKeySychronizationError(),
            _ when this == PinTryExceeded => onPinTryExceeded(),
            _ when this == PleaseRetry => onPleaseRetry(),
            _ when this == ProcessAsDebit => onProcessAsDebit(),
            _ when this == ProcessingError => onProcessingError(),
            _ when this == ProductCodeRestricted => onProductCodeRestricted(),
            _ when this == PromoLocationRestricted => onPromoLocationRestricted(),
            _ when this == QuantityExceeded => onQuantityExceeded(),
            _ when this == ReauthorizationTimeframeExpired => onReauthorizationTimeframeExpired(),
            _ when this == RechargeAmountExceeded => onRechargeAmountExceeded(),
            _ when this == RechargeCountExceeded => onRechargeCountExceeded(),
            _ when this == ReenterTransaction => onReenterTransaction(),
            _ when this == Referral => onReferral(),
            _ when this == RejectMessage => onRejectMessage(),
            _ when this == RejectedLostStolenChecks => onRejectedLostStolenChecks(),
            _ when this == RepairLimitExceeded => onRepairLimitExceeded(),
            _ when this == RequestInProgress => onRequestInProgress(),
            _ when this == ResponseReceivedLate => onResponseReceivedLate(),
            _ when this == RestrictedCard => onRestrictedCard(),
            _ when this == ResubmissionViolatesNetworkFrequency => onResubmissionViolatesNetworkFrequency(),
            _ when this == RetainCard => onRetainCard(),
            _ when this == Reversal => onReversal(),
            _ when this == ReversalNoMatch => onReversalNoMatch(),
            _ when this == ReversalUnsuccessful => onReversalUnsuccessful(),
            _ when this == RevocationOfAllAuthorizations => onRevocationOfAllAuthorizations(),
            _ when this == RevocationOfAuthorization => onRevocationOfAuthorization(),
            _ when this == SecureCodeNotEnabled => onSecureCodeNotEnabled(),
            _ when this == SecurityError => onSecurityError(),
            _ when this == SecurityErrorTryAgain => onSecurityErrorTryAgain(),
            _ when this == SecurityViolation => onSecurityViolation(),
            _ when this == SeeAttendant => onSeeAttendant(),
            _ when this == SeeExhibitForError => onSeeExhibitForError(),
            _ when this == ServiceNotAllowed => onServiceNotAllowed(),
            _ when this == SignatureRequired => onSignatureRequired(),
            _ when this == SkipTraceInfo => onSkipTraceInfo(),
            _ when this == SoftDescriptorNotEnabled => onSoftDescriptorNotEnabled(),
            _ when this == SsnNotAvailable => onSsnNotAvailable(),
            _ when this == StolenCard => onStolenCard(),
            _ when this == StopPaymentOrder => onStopPaymentOrder(),
            _ when this == StopRecurringPaymentRequests => onStopRecurringPaymentRequests(),
            _ when this == StoreLocationZeroNotAllowed => onStoreLocationZeroNotAllowed(),
            _ when this == SubsystemUnavailable => onSubsystemUnavailable(),
            _ when this == SurchargeLimitExceeded => onSurchargeLimitExceeded(),
            _ when this == SystemError => onSystemError(),
            _ when this == TargetCardAndTransactionCountMismatch => onTargetCardAndTransactionCountMismatch(),
            _ when this == TerminalTransactionNumberMismatch => onTerminalTransactionNumberMismatch(),
            _ when this == TestmodeDecline => onTestmodeDecline(),
            _ when this == TicketLimitExceeded => onTicketLimitExceeded(),
            _ when this == Timeout => onTimeout(),
            _ when this == TimeoutReversalNotSupported => onTimeoutReversalNotSupported(),
            _ when this == TooManyTransactionsRequested => onTooManyTransactionsRequested(),
            _ when this == TotalsUnavailable => onTotalsUnavailable(),
            _ when this == TransactionCountOrWithdrawalLimitExceeded => onTransactionCountOrWithdrawalLimitExceeded(),
            _ when this == TransactionDestinationNotFoundForRouting => onTransactionDestinationNotFoundForRouting(),
            _ when this == TransactionHistoryUnavailable => onTransactionHistoryUnavailable(),
            _ when this == TransactionNotAllowed => onTransactionNotAllowed(),
            _ when this == TransactionNotPermitted => onTransactionNotPermitted(),
            _ when this == TransactionNotSupported => onTransactionNotSupported(),
            _ when this ==
                TransactionTotalLimitPerProductClassExceeded => onTransactionTotalLimitPerProductClassExceeded(),
            _ when this == TransarmorInvalidTokenOrAccountNumber => onTransarmorInvalidTokenOrAccountNumber(),
            _ when this == TransarmorKeyError => onTransarmorKeyError(),
            _ when this == TransarmorServiceUnavailable => onTransarmorServiceUnavailable(),
            _ when this == TryAgainLater => onTryAgainLater(),
            _ when this == UnableToLocatePreviousMessage => onUnableToLocatePreviousMessage(),
            _ when this == UnableToLocateRecord => onUnableToLocateRecord(),
            _ when this == UnableToProcess => onUnableToProcess(),
            _ when this == UnableToVerifyPin => onUnableToVerifyPin(),
            _ when this == Unauthorized => onUnauthorized(),
            _ when this == Unavailable => onUnavailable(),
            _ when this == UndefinedCard => onUndefinedCard(),
            _ when this == UnderageCustomer => onUnderageCustomer(),
            _ when this == UnknownVelocityErrorPayInside => onUnknownVelocityErrorPayInside(),
            _ when this == Unsuccessful => onUnsuccessful(),
            _ when this == UnsupportedMessage => onUnsupportedMessage(),
            _ when this == ValidationError => onValidationError(),
            _ when this == VelocityErrorPayInside => onVelocityErrorPayInside(),
            _ when this == VerificationTransaction => onVerificationTransaction(),
            _ when this == ViolationOfBusinessArrangement => onViolationOfBusinessArrangement(),
            _ when this ==
                VisaOctMastercardMoneysendTransactionsBlocked => onVisaOctMastercardMoneysendTransactionsBlocked(),
            _ when this == VoidCapturedItem => onVoidCapturedItem(),
            _ when this == VoyagerIdProblem => onVoyagerIdProblem(),
            _ when this == YOrNRequired => onYOrNRequired(),
            _ when this == Wait2PmEastern => onWait2PmEastern(),
            _ when this == WithdrawalCountLimitExceeded => onWithdrawalCountLimitExceeded(),
            _ when this == WithdrawalLimitExceeded => onWithdrawalLimitExceeded(),
            _ when this == ZipAddressNotVerified => onZipAddressNotVerified(),
            _ when this == ZipAndAddressNotVerified => onZipAndAddressNotVerified(),
            _ when this == ZipNoMatch => onZipNoMatch(),
            _ when this == AddressMatchZipMismatch => onAddressMatchZipMismatch(),
            _ when this == ZipNotVerified => onZipNotVerified(),
            _ when this == _3DsAuthenticationSuccessful => on_3DsAuthenticationSuccessful(),
            _ when this == _3DsAuthenticationInvalid => on_3DsAuthenticationInvalid(),
            _ when this == _3DsAuthenticationFailed => on_3DsAuthenticationFailed(),
            _ when this == _3DsAuthenticationNotValidated => on_3DsAuthenticationNotValidated(),
            _ when this ==
                _3DsAuthenticationSuccessfulWithoutLiabilityShift => on_3DsAuthenticationSuccessfulWithoutLiabilityShift(),
            _ => otherwise(Value)
        };

    public void Match(Action onAcceptedButNotYetProcessed,
        Action onAccountBlocked,
        Action onAccountIsPurged,
        Action onAccountLocked,
        Action onAccountOnHoldOrNotActive,
        Action onAccountNotActivated,
        Action onAccountReloadsExceeded,
        Action onAccountRowLocked,
        Action onAccountStatusIsVoidLock,
        Action onAchPaymentNotAccepted,
        Action onAcquirerChannelUnavailable,
        Action onActivationFailed,
        Action onAdditiveLimitExceeded,
        Action onZipMatchAddressMismatch,
        Action onZipMatchAddressNotVerified,
        Action onAlreadyRedeemed,
        Action onAlreadyReversed,
        Action onAmountLimitExceeded,
        Action onAmountTooLarge,
        Action onApproveWithId,
        Action onApproved,
        Action onApprovedEmvKeyLoad,
        Action onApprovedWithNoCash,
        Action onApprovedWithOverdraft,
        Action onAuthorizationIdNeeded,
        Action onBadAccount,
        Action onBadChecksum,
        Action onBadClose,
        Action onBadMagStripe,
        Action onBadPostDate,
        Action onBadRepayDate,
        Action onBalanceNotAvailable,
        Action onBillToShipToMismatch,
        Action onBinBlocked,
        Action onBlockedByCardholder,
        Action onBulkActivationError,
        Action onBulkActivationPackageAmountError,
        Action onCallAcquirer,
        Action onCallForAuthorization,
        Action onCallIssuer,
        Action onCallTelecheck,
        Action onCannotFindNetwork,
        Action onCardAlreadyActive,
        Action onCardAlreadyClosed,
        Action onCardNotActive,
        Action onCardNotSupported,
        Action onCardVelocityAmountExceeded,
        Action onCardVelocityCountExceeded,
        Action onCardVelocityExceeded,
        Action onCashbackGreaterThanTransactionAmount,
        Action onCashLimitExceeded,
        Action onCenterClosed,
        Action onCheckerManagerNotFound,
        Action onChipFailure,
        Action onCloseUnavailable,
        Action onCloseNotValid,
        Action onClosedAccount,
        Action onCountExceedsLimit,
        Action onCounterfeitCard,
        Action onCounterOfferToSupplyPersonalGuaranty,
        Action onCryptogramDecryptionError,
        Action onCryptoBoxIsOffline,
        Action onCurrencyConversionComplete,
        Action onCurrencyConversionError,
        Action onCurrencyNotSupported,
        Action onCustomerCancellation,
        Action onCustomerOptOut,
        Action onCutTimeCloseTo1400,
        Action onCvvDeclined,
        Action onCvvFailed,
        Action onDailyLimitExceeded,
        Action onDateOfBirthError,
        Action onDebitGatewayUnavailable,
        Action onDeclined,
        Action onDeclinedDueToStandInRules,
        Action onDeconvertedBin,
        Action onDoNotHonor,
        Action onDoNotTryAgain,
        Action onDoNotTryAgainSubsequentMayContinue,
        Action onDriversLicenseOrIdRequired,
        Action onDuplicateCapture,
        Action onDuplicateReturn,
        Action onDuplicateReversal,
        Action onDuplicateTransaction,
        Action onEditHonor,
        Action onEmailNoMatch,
        Action onEmailUnavailable,
        Action onEmvKeyDownloadError,
        Action onEnterLesserAmount,
        Action onErrorProcessingPinBlock,
        Action onExceedsGlobalAmountForPeriodPayInside,
        Action onExceedsGlobalCountForPeriodPayInside,
        Action onExceedsGlobalLimitsForPeriodPayInside,
        Action onExceedsLimit,
        Action onExceedsMerchantAmountForPeriodPayInside,
        Action onExceedsMerchantCountForPeriodPayInside,
        Action onExceedsMerchantLimitsForPeriodPayInside,
        Action onExceedsStateAmountForPeriodPayInside,
        Action onExceedsStateCountForPeriodPayInside,
        Action onExceedsStateLimitsForPeriodPayInside,
        Action onExceedsTransactionCountOrAmountLimitIn24Hours,
        Action onExceedsTransactionCountOrAmountLimitIn7Days,
        Action onExceedsTransactionCountOrAmountLimitIn30Days,
        Action onExceedsZipCodeAmountForPeriodPayInside,
        Action onExceedsZipCodeCountForPeriodPayInside,
        Action onExceedsZipCodeLimitsForPeriodPayInside,
        Action onExpiredCard,
        Action onExpiredLock,
        Action onFraudulent,
        Action onFileTemporarilyUnavailable,
        Action onFileUpdateError,
        Action onFileUpdateUnavailable,
        Action onFormatError,
        Action onForwardToIssuer,
        Action onFuelLimitExceeded,
        Action onFuelOnly,
        Action onFuelPriceError,
        Action onFullSsnRequired,
        Action onFunctionNotSupported,
        Action onFundsOnHold,
        Action onGeneral,
        Action onGeneralError,
        Action onGenericDecline,
        Action onHardCapturePickupCard,
        Action onHardNegativeInfoOnFile,
        Action onHighRisk,
        Action onHoldShippingFor24H,
        Action onHonorWithAuthentication,
        Action onIllegalTransaction,
        Action onImprintCard,
        Action onIncorrectCvv,
        Action onIncorrectNumber,
        Action onIncorrectPin,
        Action onIncorrectMerchantLocation,
        Action onIncorrectTransactionVersion,
        Action onInquiryDeclined,
        Action onInsufficientData,
        Action onInsufficientFunds,
        Action onInsufficientSecurity,
        Action onInternetAccessDisabled,
        Action onInvalid3DPassword,
        Action onInvalidAccount,
        Action onInvalidAccountDate,
        Action onInvalidAccountType,
        Action onInvalidActivate,
        Action onInvalidAmount,
        Action onInvalidAuthorizationCode,
        Action onInvalidBatchNumberId,
        Action onInvalidCashback,
        Action onInvalidCheckingAccount,
        Action onInvalidCheckingAccountNumber,
        Action onInvalidCreditAccount,
        Action onInvalidClerk,
        Action onInvalidCurrency,
        Action onInvalidCvv,
        Action onInvalidDateOrTime,
        Action onInvalidDriver,
        Action onInvalidEanOrScv,
        Action onInvalidEffectiveDate,
        Action onInvalidEmailAddress,
        Action onInvalidEntry,
        Action onInvalidExpiryDate,
        Action onInvalidExpiryYear,
        Action onInvalidHost,
        Action onInvalidLocation,
        Action onInvalidMaidenName,
        Action onInvalidMcc,
        Action onInvalidMerchant,
        Action onInvalidMerchantId,
        Action onInvalidMerchantIdSe,
        Action onInvalidMerchantSetup,
        Action onInvalidMicrData,
        Action onInvalidNewPassword,
        Action onInvalidNotPresent,
        Action onInvalidNumber,
        Action onInvalidOdometer,
        Action onInvalidPassword,
        Action onInvalidPin,
        Action onInvalidPos,
        Action onInvalidPreapprovalNumber,
        Action onInvalidPrefix,
        Action onInvalidProduct,
        Action onInvalidPromptEntry,
        Action onInvalidRequest,
        Action onInvalidResponse,
        Action onInvalidResponseDate,
        Action onInvalidRestrictionCode,
        Action onInvalidSavingsAccount,
        Action onInvalidSecurePaymentData,
        Action onInvalidSku,
        Action onInvalidSsn,
        Action onInvalidStateCode,
        Action onInvalidStatusChange,
        Action onInvalidTerminal,
        Action onInvalidTgnCic,
        Action onInvalidTimezone,
        Action onInvalidTppid,
        Action onInvalidTrackData,
        Action onInvalidTransaction,
        Action onInvalidTransarmorTransaction,
        Action onInvalidUser,
        Action onInvalidValueInTheField,
        Action onInvalidVehicle,
        Action onInvalidVoidOfActivation,
        Action onInvalidZipCode,
        Action onIssuanceUnderMinimumAmount,
        Action onIssuerNotAvailable,
        Action onIssuerProcessorOrSwitchNotAvailable,
        Action onIssuerSpecialConditions,
        Action onIssuerVelocityAmountExceeded,
        Action onIssuerVelocityCountExceeded,
        Action onLateReversal,
        Action onLawViolation,
        Action onLimitCheckFailed,
        Action onLostCard,
        Action onMaidenNameUnavailable,
        Action onManualTriesExceeded,
        Action onMatchMember,
        Action onMaxBalanceExceeded,
        Action onMerchantDepleted,
        Action onMerchantHasMailPending,
        Action onMessageFormatError,
        Action onMinus2Debit,
        Action onMissingConditionalData,
        Action onMissingCustomerServicePhone,
        Action onMissingFromAccount,
        Action onMissingToAccount,
        Action onMultiCurrencyDccFail,
        Action onMultiCurrencyInvertFail,
        Action onMultipleAccountsForType,
        Action onNameEmailNoMatch,
        Action onNameEmailUnavailable,
        Action onNameNoMatch,
        Action onNamePhoneNoMatch,
        Action onNamePhoneUnavailable,
        Action onNameUnavailable,
        Action onNegativeFileException,
        Action onNewAccountInformationAvailable,
        Action onNewCardIssued,
        Action onNewPasswordRequired,
        Action onNoAccountLink,
        Action onNoActionTaken,
        Action onNoCardRecord,
        Action onNoChainId,
        Action onNoCheckingAccount,
        Action onMismatch,
        Action onNoMessagesPending,
        Action onNoOpenBatch,
        Action onNoPhoneService,
        Action onNoPreviousTransaction,
        Action onNoReasonToDecline,
        Action onNoSavingsAccount,
        Action onNoSuchIssuer,
        Action onNoToAccount,
        Action onNoTransactionsAvailable,
        Action onNoTransactionSecurityRecord,
        Action onNotAccepted,
        Action onNotActive,
        Action onNotLostOrStolen,
        Action onNotOnFile,
        Action onNotPermitted,
        Action onNotPerformed,
        Action onNotProcessed,
        Action onNotSupported,
        Action onNsf,
        Action onOneTimeStopPayment,
        Action onOriginalAuthorizationMismatch,
        Action onOriginalAuthorizationNotFound,
        Action onOriginalRepeated,
        Action onOriginalTransactionNotApproved,
        Action onOverChainDailyVelocityAmount,
        Action onOverChainDailyVelocityCount,
        Action onOverChainDailyVelocityLimits,
        Action onOverChainProductVelocityAmount,
        Action onOverChainProductVelocityCount,
        Action onOverChainProductVelocityLimits,
        Action onOverMaxBalance,
        Action onOverMerchandiseLimit,
        Action onOverMerchantDailyVelocityAmount,
        Action onOverMerchantDailyVelocityCount,
        Action onOverMerchantDailyVelocityLimits,
        Action onOverMerchantProductVelocityAmount,
        Action onOverMerchantProductVelocityCount,
        Action onOverMerchantProductVelocityLimits,
        Action onOverMonthlyLimit,
        Action onOverNonFuelLimit,
        Action onPanTransError,
        Action onPartialAuthNotAllowed,
        Action onPartialReversal,
        Action onPartiallyApproved,
        Action onPasswordRetriesExceeded,
        Action onPayAtPumpNotAllowed,
        Action onPhoneEmailNoMatch,
        Action onPhoneEmailUnavailable,
        Action onPhoneNoMatch,
        Action onPhoneUnavailable,
        Action onPickupCard,
        Action onPinAlreadyExists,
        Action onPinKeyError,
        Action onPinKeySychronizationError,
        Action onPinTryExceeded,
        Action onPleaseRetry,
        Action onProcessAsDebit,
        Action onProcessingError,
        Action onProductCodeRestricted,
        Action onPromoLocationRestricted,
        Action onQuantityExceeded,
        Action onReauthorizationTimeframeExpired,
        Action onRechargeAmountExceeded,
        Action onRechargeCountExceeded,
        Action onReenterTransaction,
        Action onReferral,
        Action onRejectMessage,
        Action onRejectedLostStolenChecks,
        Action onRepairLimitExceeded,
        Action onRequestInProgress,
        Action onResponseReceivedLate,
        Action onRestrictedCard,
        Action onResubmissionViolatesNetworkFrequency,
        Action onRetainCard,
        Action onReversal,
        Action onReversalNoMatch,
        Action onReversalUnsuccessful,
        Action onRevocationOfAllAuthorizations,
        Action onRevocationOfAuthorization,
        Action onSecureCodeNotEnabled,
        Action onSecurityError,
        Action onSecurityErrorTryAgain,
        Action onSecurityViolation,
        Action onSeeAttendant,
        Action onSeeExhibitForError,
        Action onServiceNotAllowed,
        Action onSignatureRequired,
        Action onSkipTraceInfo,
        Action onSoftDescriptorNotEnabled,
        Action onSsnNotAvailable,
        Action onStolenCard,
        Action onStopPaymentOrder,
        Action onStopRecurringPaymentRequests,
        Action onStoreLocationZeroNotAllowed,
        Action onSubsystemUnavailable,
        Action onSurchargeLimitExceeded,
        Action onSystemError,
        Action onTargetCardAndTransactionCountMismatch,
        Action onTerminalTransactionNumberMismatch,
        Action onTestmodeDecline,
        Action onTicketLimitExceeded,
        Action onTimeout,
        Action onTimeoutReversalNotSupported,
        Action onTooManyTransactionsRequested,
        Action onTotalsUnavailable,
        Action onTransactionCountOrWithdrawalLimitExceeded,
        Action onTransactionDestinationNotFoundForRouting,
        Action onTransactionHistoryUnavailable,
        Action onTransactionNotAllowed,
        Action onTransactionNotPermitted,
        Action onTransactionNotSupported,
        Action onTransactionTotalLimitPerProductClassExceeded,
        Action onTransarmorInvalidTokenOrAccountNumber,
        Action onTransarmorKeyError,
        Action onTransarmorServiceUnavailable,
        Action onTryAgainLater,
        Action onUnableToLocatePreviousMessage,
        Action onUnableToLocateRecord,
        Action onUnableToProcess,
        Action onUnableToVerifyPin,
        Action onUnauthorized,
        Action onUnavailable,
        Action onUndefinedCard,
        Action onUnderageCustomer,
        Action onUnknownVelocityErrorPayInside,
        Action onUnsuccessful,
        Action onUnsupportedMessage,
        Action onValidationError,
        Action onVelocityErrorPayInside,
        Action onVerificationTransaction,
        Action onViolationOfBusinessArrangement,
        Action onVisaOctMastercardMoneysendTransactionsBlocked,
        Action onVoidCapturedItem,
        Action onVoyagerIdProblem,
        Action onYOrNRequired,
        Action onWait2PmEastern,
        Action onWithdrawalCountLimitExceeded,
        Action onWithdrawalLimitExceeded,
        Action onZipAddressNotVerified,
        Action onZipAndAddressNotVerified,
        Action onZipNoMatch,
        Action onAddressMatchZipMismatch,
        Action onZipNotVerified,
        Action on_3DsAuthenticationSuccessful,
        Action on_3DsAuthenticationInvalid,
        Action on_3DsAuthenticationFailed,
        Action on_3DsAuthenticationNotValidated,
        Action on_3DsAuthenticationSuccessfulWithoutLiabilityShift,
        Action<string> otherwise)
    {
        if (this == AcceptedButNotYetProcessed) onAcceptedButNotYetProcessed();
        else if (this == AccountBlocked) onAccountBlocked();
        else if (this == AccountIsPurged) onAccountIsPurged();
        else if (this == AccountLocked) onAccountLocked();
        else if (this == AccountOnHoldOrNotActive) onAccountOnHoldOrNotActive();
        else if (this == AccountNotActivated) onAccountNotActivated();
        else if (this == AccountReloadsExceeded) onAccountReloadsExceeded();
        else if (this == AccountRowLocked) onAccountRowLocked();
        else if (this == AccountStatusIsVoidLock) onAccountStatusIsVoidLock();
        else if (this == AchPaymentNotAccepted) onAchPaymentNotAccepted();
        else if (this == AcquirerChannelUnavailable) onAcquirerChannelUnavailable();
        else if (this == ActivationFailed) onActivationFailed();
        else if (this == AdditiveLimitExceeded) onAdditiveLimitExceeded();
        else if (this == ZipMatchAddressMismatch) onZipMatchAddressMismatch();
        else if (this == ZipMatchAddressNotVerified) onZipMatchAddressNotVerified();
        else if (this == AlreadyRedeemed) onAlreadyRedeemed();
        else if (this == AlreadyReversed) onAlreadyReversed();
        else if (this == AmountLimitExceeded) onAmountLimitExceeded();
        else if (this == AmountTooLarge) onAmountTooLarge();
        else if (this == ApproveWithId) onApproveWithId();
        else if (this == Approved) onApproved();
        else if (this == ApprovedEmvKeyLoad) onApprovedEmvKeyLoad();
        else if (this == ApprovedWithNoCash) onApprovedWithNoCash();
        else if (this == ApprovedWithOverdraft) onApprovedWithOverdraft();
        else if (this == AuthorizationIdNeeded) onAuthorizationIdNeeded();
        else if (this == BadAccount) onBadAccount();
        else if (this == BadChecksum) onBadChecksum();
        else if (this == BadClose) onBadClose();
        else if (this == BadMagStripe) onBadMagStripe();
        else if (this == BadPostDate) onBadPostDate();
        else if (this == BadRepayDate) onBadRepayDate();
        else if (this == BalanceNotAvailable) onBalanceNotAvailable();
        else if (this == BillToShipToMismatch) onBillToShipToMismatch();
        else if (this == BinBlocked) onBinBlocked();
        else if (this == BlockedByCardholder) onBlockedByCardholder();
        else if (this == BulkActivationError) onBulkActivationError();
        else if (this == BulkActivationPackageAmountError) onBulkActivationPackageAmountError();
        else if (this == CallAcquirer) onCallAcquirer();
        else if (this == CallForAuthorization) onCallForAuthorization();
        else if (this == CallIssuer) onCallIssuer();
        else if (this == CallTelecheck) onCallTelecheck();
        else if (this == CannotFindNetwork) onCannotFindNetwork();
        else if (this == CardAlreadyActive) onCardAlreadyActive();
        else if (this == CardAlreadyClosed) onCardAlreadyClosed();
        else if (this == CardNotActive) onCardNotActive();
        else if (this == CardNotSupported) onCardNotSupported();
        else if (this == CardVelocityAmountExceeded) onCardVelocityAmountExceeded();
        else if (this == CardVelocityCountExceeded) onCardVelocityCountExceeded();
        else if (this == CardVelocityExceeded) onCardVelocityExceeded();
        else if (this == CashbackGreaterThanTransactionAmount) onCashbackGreaterThanTransactionAmount();
        else if (this == CashLimitExceeded) onCashLimitExceeded();
        else if (this == CenterClosed) onCenterClosed();
        else if (this == CheckerManagerNotFound) onCheckerManagerNotFound();
        else if (this == ChipFailure) onChipFailure();
        else if (this == CloseUnavailable) onCloseUnavailable();
        else if (this == CloseNotValid) onCloseNotValid();
        else if (this == ClosedAccount) onClosedAccount();
        else if (this == CountExceedsLimit) onCountExceedsLimit();
        else if (this == CounterfeitCard) onCounterfeitCard();
        else if (this == CounterOfferToSupplyPersonalGuaranty) onCounterOfferToSupplyPersonalGuaranty();
        else if (this == CryptogramDecryptionError) onCryptogramDecryptionError();
        else if (this == CryptoBoxIsOffline) onCryptoBoxIsOffline();
        else if (this == CurrencyConversionComplete) onCurrencyConversionComplete();
        else if (this == CurrencyConversionError) onCurrencyConversionError();
        else if (this == CurrencyNotSupported) onCurrencyNotSupported();
        else if (this == CustomerCancellation) onCustomerCancellation();
        else if (this == CustomerOptOut) onCustomerOptOut();
        else if (this == CutTimeCloseTo1400) onCutTimeCloseTo1400();
        else if (this == CvvDeclined) onCvvDeclined();
        else if (this == CvvFailed) onCvvFailed();
        else if (this == DailyLimitExceeded) onDailyLimitExceeded();
        else if (this == DateOfBirthError) onDateOfBirthError();
        else if (this == DebitGatewayUnavailable) onDebitGatewayUnavailable();
        else if (this == Declined) onDeclined();
        else if (this == DeclinedDueToStandInRules) onDeclinedDueToStandInRules();
        else if (this == DeconvertedBin) onDeconvertedBin();
        else if (this == DoNotHonor) onDoNotHonor();
        else if (this == DoNotTryAgain) onDoNotTryAgain();
        else if (this == DoNotTryAgainSubsequentMayContinue) onDoNotTryAgainSubsequentMayContinue();
        else if (this == DriversLicenseOrIdRequired) onDriversLicenseOrIdRequired();
        else if (this == DuplicateCapture) onDuplicateCapture();
        else if (this == DuplicateReturn) onDuplicateReturn();
        else if (this == DuplicateReversal) onDuplicateReversal();
        else if (this == DuplicateTransaction) onDuplicateTransaction();
        else if (this == EditHonor) onEditHonor();
        else if (this == EmailNoMatch) onEmailNoMatch();
        else if (this == EmailUnavailable) onEmailUnavailable();
        else if (this == EmvKeyDownloadError) onEmvKeyDownloadError();
        else if (this == EnterLesserAmount) onEnterLesserAmount();
        else if (this == ErrorProcessingPinBlock) onErrorProcessingPinBlock();
        else if (this == ExceedsGlobalAmountForPeriodPayInside) onExceedsGlobalAmountForPeriodPayInside();
        else if (this == ExceedsGlobalCountForPeriodPayInside) onExceedsGlobalCountForPeriodPayInside();
        else if (this == ExceedsGlobalLimitsForPeriodPayInside) onExceedsGlobalLimitsForPeriodPayInside();
        else if (this == ExceedsLimit) onExceedsLimit();
        else if (this == ExceedsMerchantAmountForPeriodPayInside) onExceedsMerchantAmountForPeriodPayInside();
        else if (this == ExceedsMerchantCountForPeriodPayInside) onExceedsMerchantCountForPeriodPayInside();
        else if (this == ExceedsMerchantLimitsForPeriodPayInside) onExceedsMerchantLimitsForPeriodPayInside();
        else if (this == ExceedsStateAmountForPeriodPayInside) onExceedsStateAmountForPeriodPayInside();
        else if (this == ExceedsStateCountForPeriodPayInside) onExceedsStateCountForPeriodPayInside();
        else if (this == ExceedsStateLimitsForPeriodPayInside) onExceedsStateLimitsForPeriodPayInside();
        else if (this ==
            ExceedsTransactionCountOrAmountLimitIn24Hours) onExceedsTransactionCountOrAmountLimitIn24Hours();
        else if (this == ExceedsTransactionCountOrAmountLimitIn7Days) onExceedsTransactionCountOrAmountLimitIn7Days();
        else if (this == ExceedsTransactionCountOrAmountLimitIn30Days) onExceedsTransactionCountOrAmountLimitIn30Days();
        else if (this == ExceedsZipCodeAmountForPeriodPayInside) onExceedsZipCodeAmountForPeriodPayInside();
        else if (this == ExceedsZipCodeCountForPeriodPayInside) onExceedsZipCodeCountForPeriodPayInside();
        else if (this == ExceedsZipCodeLimitsForPeriodPayInside) onExceedsZipCodeLimitsForPeriodPayInside();
        else if (this == ExpiredCard) onExpiredCard();
        else if (this == ExpiredLock) onExpiredLock();
        else if (this == Fraudulent) onFraudulent();
        else if (this == FileTemporarilyUnavailable) onFileTemporarilyUnavailable();
        else if (this == FileUpdateError) onFileUpdateError();
        else if (this == FileUpdateUnavailable) onFileUpdateUnavailable();
        else if (this == FormatError) onFormatError();
        else if (this == ForwardToIssuer) onForwardToIssuer();
        else if (this == FuelLimitExceeded) onFuelLimitExceeded();
        else if (this == FuelOnly) onFuelOnly();
        else if (this == FuelPriceError) onFuelPriceError();
        else if (this == FullSsnRequired) onFullSsnRequired();
        else if (this == FunctionNotSupported) onFunctionNotSupported();
        else if (this == FundsOnHold) onFundsOnHold();
        else if (this == General) onGeneral();
        else if (this == GeneralError) onGeneralError();
        else if (this == GenericDecline) onGenericDecline();
        else if (this == HardCapturePickupCard) onHardCapturePickupCard();
        else if (this == HardNegativeInfoOnFile) onHardNegativeInfoOnFile();
        else if (this == HighRisk) onHighRisk();
        else if (this == HoldShippingFor24H) onHoldShippingFor24H();
        else if (this == HonorWithAuthentication) onHonorWithAuthentication();
        else if (this == IllegalTransaction) onIllegalTransaction();
        else if (this == ImprintCard) onImprintCard();
        else if (this == IncorrectCvv) onIncorrectCvv();
        else if (this == IncorrectNumber) onIncorrectNumber();
        else if (this == IncorrectPin) onIncorrectPin();
        else if (this == IncorrectMerchantLocation) onIncorrectMerchantLocation();
        else if (this == IncorrectTransactionVersion) onIncorrectTransactionVersion();
        else if (this == InquiryDeclined) onInquiryDeclined();
        else if (this == InsufficientData) onInsufficientData();
        else if (this == InsufficientFunds) onInsufficientFunds();
        else if (this == InsufficientSecurity) onInsufficientSecurity();
        else if (this == InternetAccessDisabled) onInternetAccessDisabled();
        else if (this == Invalid3DPassword) onInvalid3DPassword();
        else if (this == InvalidAccount) onInvalidAccount();
        else if (this == InvalidAccountDate) onInvalidAccountDate();
        else if (this == InvalidAccountType) onInvalidAccountType();
        else if (this == InvalidActivate) onInvalidActivate();
        else if (this == InvalidAmount) onInvalidAmount();
        else if (this == InvalidAuthorizationCode) onInvalidAuthorizationCode();
        else if (this == InvalidBatchNumberId) onInvalidBatchNumberId();
        else if (this == InvalidCashback) onInvalidCashback();
        else if (this == InvalidCheckingAccount) onInvalidCheckingAccount();
        else if (this == InvalidCheckingAccountNumber) onInvalidCheckingAccountNumber();
        else if (this == InvalidCreditAccount) onInvalidCreditAccount();
        else if (this == InvalidClerk) onInvalidClerk();
        else if (this == InvalidCurrency) onInvalidCurrency();
        else if (this == InvalidCvv) onInvalidCvv();
        else if (this == InvalidDateOrTime) onInvalidDateOrTime();
        else if (this == InvalidDriver) onInvalidDriver();
        else if (this == InvalidEanOrScv) onInvalidEanOrScv();
        else if (this == InvalidEffectiveDate) onInvalidEffectiveDate();
        else if (this == InvalidEmailAddress) onInvalidEmailAddress();
        else if (this == InvalidEntry) onInvalidEntry();
        else if (this == InvalidExpiryDate) onInvalidExpiryDate();
        else if (this == InvalidExpiryYear) onInvalidExpiryYear();
        else if (this == InvalidHost) onInvalidHost();
        else if (this == InvalidLocation) onInvalidLocation();
        else if (this == InvalidMaidenName) onInvalidMaidenName();
        else if (this == InvalidMcc) onInvalidMcc();
        else if (this == InvalidMerchant) onInvalidMerchant();
        else if (this == InvalidMerchantId) onInvalidMerchantId();
        else if (this == InvalidMerchantIdSe) onInvalidMerchantIdSe();
        else if (this == InvalidMerchantSetup) onInvalidMerchantSetup();
        else if (this == InvalidMicrData) onInvalidMicrData();
        else if (this == InvalidNewPassword) onInvalidNewPassword();
        else if (this == InvalidNotPresent) onInvalidNotPresent();
        else if (this == InvalidNumber) onInvalidNumber();
        else if (this == InvalidOdometer) onInvalidOdometer();
        else if (this == InvalidPassword) onInvalidPassword();
        else if (this == InvalidPin) onInvalidPin();
        else if (this == InvalidPos) onInvalidPos();
        else if (this == InvalidPreapprovalNumber) onInvalidPreapprovalNumber();
        else if (this == InvalidPrefix) onInvalidPrefix();
        else if (this == InvalidProduct) onInvalidProduct();
        else if (this == InvalidPromptEntry) onInvalidPromptEntry();
        else if (this == InvalidRequest) onInvalidRequest();
        else if (this == InvalidResponse) onInvalidResponse();
        else if (this == InvalidResponseDate) onInvalidResponseDate();
        else if (this == InvalidRestrictionCode) onInvalidRestrictionCode();
        else if (this == InvalidSavingsAccount) onInvalidSavingsAccount();
        else if (this == InvalidSecurePaymentData) onInvalidSecurePaymentData();
        else if (this == InvalidSku) onInvalidSku();
        else if (this == InvalidSsn) onInvalidSsn();
        else if (this == InvalidStateCode) onInvalidStateCode();
        else if (this == InvalidStatusChange) onInvalidStatusChange();
        else if (this == InvalidTerminal) onInvalidTerminal();
        else if (this == InvalidTgnCic) onInvalidTgnCic();
        else if (this == InvalidTimezone) onInvalidTimezone();
        else if (this == InvalidTppid) onInvalidTppid();
        else if (this == InvalidTrackData) onInvalidTrackData();
        else if (this == InvalidTransaction) onInvalidTransaction();
        else if (this == InvalidTransarmorTransaction) onInvalidTransarmorTransaction();
        else if (this == InvalidUser) onInvalidUser();
        else if (this == InvalidValueInTheField) onInvalidValueInTheField();
        else if (this == InvalidVehicle) onInvalidVehicle();
        else if (this == InvalidVoidOfActivation) onInvalidVoidOfActivation();
        else if (this == InvalidZipCode) onInvalidZipCode();
        else if (this == IssuanceUnderMinimumAmount) onIssuanceUnderMinimumAmount();
        else if (this == IssuerNotAvailable) onIssuerNotAvailable();
        else if (this == IssuerProcessorOrSwitchNotAvailable) onIssuerProcessorOrSwitchNotAvailable();
        else if (this == IssuerSpecialConditions) onIssuerSpecialConditions();
        else if (this == IssuerVelocityAmountExceeded) onIssuerVelocityAmountExceeded();
        else if (this == IssuerVelocityCountExceeded) onIssuerVelocityCountExceeded();
        else if (this == LateReversal) onLateReversal();
        else if (this == LawViolation) onLawViolation();
        else if (this == LimitCheckFailed) onLimitCheckFailed();
        else if (this == LostCard) onLostCard();
        else if (this == MaidenNameUnavailable) onMaidenNameUnavailable();
        else if (this == ManualTriesExceeded) onManualTriesExceeded();
        else if (this == MatchMember) onMatchMember();
        else if (this == MaxBalanceExceeded) onMaxBalanceExceeded();
        else if (this == MerchantDepleted) onMerchantDepleted();
        else if (this == MerchantHasMailPending) onMerchantHasMailPending();
        else if (this == MessageFormatError) onMessageFormatError();
        else if (this == Minus2Debit) onMinus2Debit();
        else if (this == MissingConditionalData) onMissingConditionalData();
        else if (this == MissingCustomerServicePhone) onMissingCustomerServicePhone();
        else if (this == MissingFromAccount) onMissingFromAccount();
        else if (this == MissingToAccount) onMissingToAccount();
        else if (this == MultiCurrencyDccFail) onMultiCurrencyDccFail();
        else if (this == MultiCurrencyInvertFail) onMultiCurrencyInvertFail();
        else if (this == MultipleAccountsForType) onMultipleAccountsForType();
        else if (this == NameEmailNoMatch) onNameEmailNoMatch();
        else if (this == NameEmailUnavailable) onNameEmailUnavailable();
        else if (this == NameNoMatch) onNameNoMatch();
        else if (this == NamePhoneNoMatch) onNamePhoneNoMatch();
        else if (this == NamePhoneUnavailable) onNamePhoneUnavailable();
        else if (this == NameUnavailable) onNameUnavailable();
        else if (this == NegativeFileException) onNegativeFileException();
        else if (this == NewAccountInformationAvailable) onNewAccountInformationAvailable();
        else if (this == NewCardIssued) onNewCardIssued();
        else if (this == NewPasswordRequired) onNewPasswordRequired();
        else if (this == NoAccountLink) onNoAccountLink();
        else if (this == NoActionTaken) onNoActionTaken();
        else if (this == NoCardRecord) onNoCardRecord();
        else if (this == NoChainId) onNoChainId();
        else if (this == NoCheckingAccount) onNoCheckingAccount();
        else if (this == Mismatch) onMismatch();
        else if (this == NoMessagesPending) onNoMessagesPending();
        else if (this == NoOpenBatch) onNoOpenBatch();
        else if (this == NoPhoneService) onNoPhoneService();
        else if (this == NoPreviousTransaction) onNoPreviousTransaction();
        else if (this == NoReasonToDecline) onNoReasonToDecline();
        else if (this == NoSavingsAccount) onNoSavingsAccount();
        else if (this == NoSuchIssuer) onNoSuchIssuer();
        else if (this == NoToAccount) onNoToAccount();
        else if (this == NoTransactionsAvailable) onNoTransactionsAvailable();
        else if (this == NoTransactionSecurityRecord) onNoTransactionSecurityRecord();
        else if (this == NotAccepted) onNotAccepted();
        else if (this == NotActive) onNotActive();
        else if (this == NotLostOrStolen) onNotLostOrStolen();
        else if (this == NotOnFile) onNotOnFile();
        else if (this == NotPermitted) onNotPermitted();
        else if (this == NotPerformed) onNotPerformed();
        else if (this == NotProcessed) onNotProcessed();
        else if (this == NotSupported) onNotSupported();
        else if (this == Nsf) onNsf();
        else if (this == OneTimeStopPayment) onOneTimeStopPayment();
        else if (this == OriginalAuthorizationMismatch) onOriginalAuthorizationMismatch();
        else if (this == OriginalAuthorizationNotFound) onOriginalAuthorizationNotFound();
        else if (this == OriginalRepeated) onOriginalRepeated();
        else if (this == OriginalTransactionNotApproved) onOriginalTransactionNotApproved();
        else if (this == OverChainDailyVelocityAmount) onOverChainDailyVelocityAmount();
        else if (this == OverChainDailyVelocityCount) onOverChainDailyVelocityCount();
        else if (this == OverChainDailyVelocityLimits) onOverChainDailyVelocityLimits();
        else if (this == OverChainProductVelocityAmount) onOverChainProductVelocityAmount();
        else if (this == OverChainProductVelocityCount) onOverChainProductVelocityCount();
        else if (this == OverChainProductVelocityLimits) onOverChainProductVelocityLimits();
        else if (this == OverMaxBalance) onOverMaxBalance();
        else if (this == OverMerchandiseLimit) onOverMerchandiseLimit();
        else if (this == OverMerchantDailyVelocityAmount) onOverMerchantDailyVelocityAmount();
        else if (this == OverMerchantDailyVelocityCount) onOverMerchantDailyVelocityCount();
        else if (this == OverMerchantDailyVelocityLimits) onOverMerchantDailyVelocityLimits();
        else if (this == OverMerchantProductVelocityAmount) onOverMerchantProductVelocityAmount();
        else if (this == OverMerchantProductVelocityCount) onOverMerchantProductVelocityCount();
        else if (this == OverMerchantProductVelocityLimits) onOverMerchantProductVelocityLimits();
        else if (this == OverMonthlyLimit) onOverMonthlyLimit();
        else if (this == OverNonFuelLimit) onOverNonFuelLimit();
        else if (this == PanTransError) onPanTransError();
        else if (this == PartialAuthNotAllowed) onPartialAuthNotAllowed();
        else if (this == PartialReversal) onPartialReversal();
        else if (this == PartiallyApproved) onPartiallyApproved();
        else if (this == PasswordRetriesExceeded) onPasswordRetriesExceeded();
        else if (this == PayAtPumpNotAllowed) onPayAtPumpNotAllowed();
        else if (this == PhoneEmailNoMatch) onPhoneEmailNoMatch();
        else if (this == PhoneEmailUnavailable) onPhoneEmailUnavailable();
        else if (this == PhoneNoMatch) onPhoneNoMatch();
        else if (this == PhoneUnavailable) onPhoneUnavailable();
        else if (this == PickupCard) onPickupCard();
        else if (this == PinAlreadyExists) onPinAlreadyExists();
        else if (this == PinKeyError) onPinKeyError();
        else if (this == PinKeySychronizationError) onPinKeySychronizationError();
        else if (this == PinTryExceeded) onPinTryExceeded();
        else if (this == PleaseRetry) onPleaseRetry();
        else if (this == ProcessAsDebit) onProcessAsDebit();
        else if (this == ProcessingError) onProcessingError();
        else if (this == ProductCodeRestricted) onProductCodeRestricted();
        else if (this == PromoLocationRestricted) onPromoLocationRestricted();
        else if (this == QuantityExceeded) onQuantityExceeded();
        else if (this == ReauthorizationTimeframeExpired) onReauthorizationTimeframeExpired();
        else if (this == RechargeAmountExceeded) onRechargeAmountExceeded();
        else if (this == RechargeCountExceeded) onRechargeCountExceeded();
        else if (this == ReenterTransaction) onReenterTransaction();
        else if (this == Referral) onReferral();
        else if (this == RejectMessage) onRejectMessage();
        else if (this == RejectedLostStolenChecks) onRejectedLostStolenChecks();
        else if (this == RepairLimitExceeded) onRepairLimitExceeded();
        else if (this == RequestInProgress) onRequestInProgress();
        else if (this == ResponseReceivedLate) onResponseReceivedLate();
        else if (this == RestrictedCard) onRestrictedCard();
        else if (this == ResubmissionViolatesNetworkFrequency) onResubmissionViolatesNetworkFrequency();
        else if (this == RetainCard) onRetainCard();
        else if (this == Reversal) onReversal();
        else if (this == ReversalNoMatch) onReversalNoMatch();
        else if (this == ReversalUnsuccessful) onReversalUnsuccessful();
        else if (this == RevocationOfAllAuthorizations) onRevocationOfAllAuthorizations();
        else if (this == RevocationOfAuthorization) onRevocationOfAuthorization();
        else if (this == SecureCodeNotEnabled) onSecureCodeNotEnabled();
        else if (this == SecurityError) onSecurityError();
        else if (this == SecurityErrorTryAgain) onSecurityErrorTryAgain();
        else if (this == SecurityViolation) onSecurityViolation();
        else if (this == SeeAttendant) onSeeAttendant();
        else if (this == SeeExhibitForError) onSeeExhibitForError();
        else if (this == ServiceNotAllowed) onServiceNotAllowed();
        else if (this == SignatureRequired) onSignatureRequired();
        else if (this == SkipTraceInfo) onSkipTraceInfo();
        else if (this == SoftDescriptorNotEnabled) onSoftDescriptorNotEnabled();
        else if (this == SsnNotAvailable) onSsnNotAvailable();
        else if (this == StolenCard) onStolenCard();
        else if (this == StopPaymentOrder) onStopPaymentOrder();
        else if (this == StopRecurringPaymentRequests) onStopRecurringPaymentRequests();
        else if (this == StoreLocationZeroNotAllowed) onStoreLocationZeroNotAllowed();
        else if (this == SubsystemUnavailable) onSubsystemUnavailable();
        else if (this == SurchargeLimitExceeded) onSurchargeLimitExceeded();
        else if (this == SystemError) onSystemError();
        else if (this == TargetCardAndTransactionCountMismatch) onTargetCardAndTransactionCountMismatch();
        else if (this == TerminalTransactionNumberMismatch) onTerminalTransactionNumberMismatch();
        else if (this == TestmodeDecline) onTestmodeDecline();
        else if (this == TicketLimitExceeded) onTicketLimitExceeded();
        else if (this == Timeout) onTimeout();
        else if (this == TimeoutReversalNotSupported) onTimeoutReversalNotSupported();
        else if (this == TooManyTransactionsRequested) onTooManyTransactionsRequested();
        else if (this == TotalsUnavailable) onTotalsUnavailable();
        else if (this == TransactionCountOrWithdrawalLimitExceeded) onTransactionCountOrWithdrawalLimitExceeded();
        else if (this == TransactionDestinationNotFoundForRouting) onTransactionDestinationNotFoundForRouting();
        else if (this == TransactionHistoryUnavailable) onTransactionHistoryUnavailable();
        else if (this == TransactionNotAllowed) onTransactionNotAllowed();
        else if (this == TransactionNotPermitted) onTransactionNotPermitted();
        else if (this == TransactionNotSupported) onTransactionNotSupported();
        else if (this == TransactionTotalLimitPerProductClassExceeded) onTransactionTotalLimitPerProductClassExceeded();
        else if (this == TransarmorInvalidTokenOrAccountNumber) onTransarmorInvalidTokenOrAccountNumber();
        else if (this == TransarmorKeyError) onTransarmorKeyError();
        else if (this == TransarmorServiceUnavailable) onTransarmorServiceUnavailable();
        else if (this == TryAgainLater) onTryAgainLater();
        else if (this == UnableToLocatePreviousMessage) onUnableToLocatePreviousMessage();
        else if (this == UnableToLocateRecord) onUnableToLocateRecord();
        else if (this == UnableToProcess) onUnableToProcess();
        else if (this == UnableToVerifyPin) onUnableToVerifyPin();
        else if (this == Unauthorized) onUnauthorized();
        else if (this == Unavailable) onUnavailable();
        else if (this == UndefinedCard) onUndefinedCard();
        else if (this == UnderageCustomer) onUnderageCustomer();
        else if (this == UnknownVelocityErrorPayInside) onUnknownVelocityErrorPayInside();
        else if (this == Unsuccessful) onUnsuccessful();
        else if (this == UnsupportedMessage) onUnsupportedMessage();
        else if (this == ValidationError) onValidationError();
        else if (this == VelocityErrorPayInside) onVelocityErrorPayInside();
        else if (this == VerificationTransaction) onVerificationTransaction();
        else if (this == ViolationOfBusinessArrangement) onViolationOfBusinessArrangement();
        else if (this ==
            VisaOctMastercardMoneysendTransactionsBlocked) onVisaOctMastercardMoneysendTransactionsBlocked();
        else if (this == VoidCapturedItem) onVoidCapturedItem();
        else if (this == VoyagerIdProblem) onVoyagerIdProblem();
        else if (this == YOrNRequired) onYOrNRequired();
        else if (this == Wait2PmEastern) onWait2PmEastern();
        else if (this == WithdrawalCountLimitExceeded) onWithdrawalCountLimitExceeded();
        else if (this == WithdrawalLimitExceeded) onWithdrawalLimitExceeded();
        else if (this == ZipAddressNotVerified) onZipAddressNotVerified();
        else if (this == ZipAndAddressNotVerified) onZipAndAddressNotVerified();
        else if (this == ZipNoMatch) onZipNoMatch();
        else if (this == AddressMatchZipMismatch) onAddressMatchZipMismatch();
        else if (this == ZipNotVerified) onZipNotVerified();
        else if (this == _3DsAuthenticationSuccessful) on_3DsAuthenticationSuccessful();
        else if (this == _3DsAuthenticationInvalid) on_3DsAuthenticationInvalid();
        else if (this == _3DsAuthenticationFailed) on_3DsAuthenticationFailed();
        else if (this == _3DsAuthenticationNotValidated) on_3DsAuthenticationNotValidated();
        else if (this ==
            _3DsAuthenticationSuccessfulWithoutLiabilityShift) on_3DsAuthenticationSuccessfulWithoutLiabilityShift();
        else otherwise(Value);
    }
}
