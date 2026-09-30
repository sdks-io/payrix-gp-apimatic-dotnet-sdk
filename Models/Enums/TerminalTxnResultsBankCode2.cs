using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Exact message code as received from the activation integration or
/// from the processor for the resulting transaction.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>ACCEPTED_BUT_NOT_YET_PROCESSED</c> - <b>accepted_but_not_yet_processed</b></description></item>
///   <item><description><c>ACCOUNT_BLOCKED</c> - <b>account_blocked</b></description></item>
///   <item><description><c>ACCOUNT_IS_PURGED</c> - <b>account_is_purged</b></description></item>
///   <item><description><c>ACCOUNT_LOCKED</c> - <b>account_locked</b></description></item>
///   <item><description><c>ACCOUNT_ON_HOLD_OR_NOT_ACTIVE</c> - <b>account_on_hold_or_not_active</b></description></item>
///   <item><description><c>ACCOUNT_NOT_ACTIVATED</c> - <b>account_not_activated</b></description></item>
///   <item><description><c>ACCOUNT_RELOADS_EXCEEDED</c> - <b>account_reloads_exceeded</b></description></item>
///   <item><description><c>ACCOUNT_ROW_LOCKED</c> - <b>account_row_locked</b></description></item>
///   <item><description><c>ACCOUNT_STATUS_IS_VOID_LOCK</c> - <b>account_status_is_void_lock</b></description></item>
///   <item><description><c>ACH_PAYMENT_NOT_ACCEPTED</c> - <b>ach_payment_not_accepted</b></description></item>
///   <item><description><c>ACQUIRER_CHANNEL_UNAVAILABLE</c> - <b>acquirer_channel_unavailable</b></description></item>
///   <item><description><c>ACTIVATION_FAILED</c> - <b>activation_failed</b></description></item>
///   <item><description><c>ADDITIVE_LIMIT_EXCEEDED</c> - <b>additive_limit_exceeded</b></description></item>
///   <item><description><c>ADDRESS_NO_MATCH</c> - <b>zip_match_address_mismatch</b></description></item>
///   <item><description><c>ADDRESS_NOT_VERIFIED</c> - <b>zip_match_address_not_verified</b></description></item>
///   <item><description><c>ALREADY_REDEEMED</c> - <b>already_redeemed</b></description></item>
///   <item><description><c>ALREADY_REVERSED</c> - <b>already_reversed</b></description></item>
///   <item><description><c>AMOUNT_LIMIT_EXCEEDED</c> - <b>amount_limit_exceeded</b></description></item>
///   <item><description><c>AMOUNT_TOO_LARGE</c> - <b>amount_too_large</b></description></item>
///   <item><description><c>APPROVE_WITH_ID</c> - <b>approve_with_id</b></description></item>
///   <item><description><c>APPROVED</c> - <b>approved</b></description></item>
///   <item><description><c>APPROVED_EMV_KEY_LOAD</c> - <b>approved_emv_key_load</b></description></item>
///   <item><description><c>APPROVED_WITH_NO_CASH</c> - <b>approved_with_no_cash</b></description></item>
///   <item><description><c>APPROVED_WITH_OVERDRAFT</c> - <b>approved_with_overdraft</b></description></item>
///   <item><description><c>AUTHORIZATION_ID_NEEDED</c> - <b>authorization_id_needed</b></description></item>
///   <item><description><c>BAD_ACCOUNT</c> - <b>bad_account</b></description></item>
///   <item><description><c>BAD_CHECKSUM</c> - <b>bad_checksum</b></description></item>
///   <item><description><c>BAD_CLOSE</c> - <b>bad_close</b></description></item>
///   <item><description><c>BAD_MAG_STRIPE</c> - <b>bad_mag_stripe</b></description></item>
///   <item><description><c>BAD_POST_DATE</c> - <b>bad_post_date</b></description></item>
///   <item><description><c>BAD_REPAY_DATE</c> - <b>bad_repay_date</b></description></item>
///   <item><description><c>BALANCE_NOT_AVAILABLE</c> - <b>balance_not_available</b></description></item>
///   <item><description><c>BILL_TO_SHIP_TO_MISMATCH</c> - <b>bill_to_ship_to_mismatch</b></description></item>
///   <item><description><c>BIN_BLOCKED</c> - <b>bin_blocked</b></description></item>
///   <item><description><c>BLOCKED_BY_CARDHOLDER</c> - <b>blocked_by_cardholder</b></description></item>
///   <item><description><c>BULK_ACTIVATION_ERROR</c> - <b>bulk_activation_error</b></description></item>
///   <item><description><c>BULK_ACTIVATION_PACKAGE_AMOUNT_ERROR</c> - <b>bulk_activation_package_amount_error</b></description></item>
///   <item><description><c>CALL_ACQUIRER</c> - <b>call_acquirer</b></description></item>
///   <item><description><c>CALL_FOR_AUTHORIZATION</c> - <b>call_for_authorization</b></description></item>
///   <item><description><c>CALL_ISSUER</c> - <b>call_issuer</b></description></item>
///   <item><description><c>CALL_TELECHECK</c> - <b>call_telecheck</b></description></item>
///   <item><description><c>CANNOT_FIND_NETWORK</c> - <b>cannot_find_network</b></description></item>
///   <item><description><c>CARD_ALREADY_ACTIVE</c> - <b>card_already_active</b></description></item>
///   <item><description><c>CARD_ALREADY_CLOSED</c> - <b>card_already_closed</b></description></item>
///   <item><description><c>CARD_NOT_ACTIVE</c> - <b>card_not_active</b></description></item>
///   <item><description><c>CARD_NOT_SUPPORTED</c> - <b>card_not_supported</b></description></item>
///   <item><description><c>CARD_VELOCITY_AMOUNT_EXCEEDED</c> - <b>card_velocity_amount_exceeded</b></description></item>
///   <item><description><c>CARD_VELOCITY_COUNT_EXCEEDED</c> - <b>card_velocity_count_exceeded</b></description></item>
///   <item><description><c>CARD_VELOCITY_EXCEEDED</c> - <b>card_velocity_exceeded</b></description></item>
///   <item><description><c>CASHBACK_GREATER_THAN_TRANSACTION_AMOUNT</c> - <b>cashback_greater_than_transaction_amount</b></description></item>
///   <item><description><c>CASH_LIMIT_EXCEEDED</c> - <b>cash_limit_exceeded</b></description></item>
///   <item><description><c>CENTER_CLOSED</c> - <b>center_closed</b></description></item>
///   <item><description><c>CHECKER/MANAGER_NOT_FOUND</c> - <b>checker/manager_not_found</b></description></item>
///   <item><description><c>CHIP_FAILURE</c> - <b>chip_failure</b></description></item>
///   <item><description><c>CLOSE_UNAVAILABLE</c> - <b>close_unavailable</b></description></item>
///   <item><description><c>CLOSE_NOT_VALID</c> - <b>close_not_valid</b></description></item>
///   <item><description><c>CLOSED_ACCOUNT</c> - <b>closed_account</b></description></item>
///   <item><description><c>COUNT_EXCEEDS_LIMIT</c> - <b>count_exceeds_limit</b></description></item>
///   <item><description><c>COUNTERFEIT_CARD</c> - <b>counterfeit_card</b></description></item>
///   <item><description><c>COUNTER_OFFER_TO_SUPPLY_PERSONAL_GUARANTY</c> - <b>counter_offer_to_supply_personal_guaranty</b></description></item>
///   <item><description><c>CRYPTOGRAM_DECRYPTION_ERROR</c> - <b>cryptogram_decryption_error</b></description></item>
///   <item><description><c>CRYPTO_BOX_IS_OFFLINE</c> - <b>crypto_box_is_offline</b></description></item>
///   <item><description><c>CURRENCY_CONVERSION_COMPLETE</c> - <b>currency_conversion_complete</b></description></item>
///   <item><description><c>CURRENCY_CONVERSION_ERROR</c> - <b>currency_conversion_error</b></description></item>
///   <item><description><c>CURRENCY_NOT_SUPPORTED</c> - <b>currency_not_supported</b></description></item>
///   <item><description><c>CUSTOMER_CANCELLATION</c> - <b>customer_cancellation</b></description></item>
///   <item><description><c>CUSTOMER_OPT_OUT</c> - <b>customer_opt_out</b></description></item>
///   <item><description><c>CUT_TIME_CLOSE_TO_1400</c> - <b>cut_time_close_to_1400</b></description></item>
///   <item><description><c>CVV_DECLINED</c> - <b>cvv_declined</b></description></item>
///   <item><description><c>CVV_FAILED</c> - <b>cvv_failed</b></description></item>
///   <item><description><c>DAILY_LIMIT_EXCEEDED</c> - <b>daily_limit_exceeded</b></description></item>
///   <item><description><c>DATE_OF_BIRTH_ERROR</c> - <b>date_of_birth_error</b></description></item>
///   <item><description><c>DEBIT_GATEWAY_UNAVAILABLE</c> - <b>debit_gateway_unavailable</b></description></item>
///   <item><description><c>DECLINED</c> - <b>declined</b></description></item>
///   <item><description><c>DECLINED_DUE_TO_STAND_IN_RULES</c> - <b>declined_due_to_stand_in_rules</b></description></item>
///   <item><description><c>DECONVERTED_BIN</c> - <b>deconverted_bin</b></description></item>
///   <item><description><c>DO_NOT_HONOR</c> - <b>do_not_honor</b></description></item>
///   <item><description><c>DO_NOT_TRY_AGAIN</c> - <b>do_not_try_again</b></description></item>
///   <item><description><c>DO_NOT_TRY_AGAIN_SUBSEQUENT_MAY_CONTINUE</c> - <b>do_not_try_again_subsequent_may_continue</b></description></item>
///   <item><description><c>DRIVERS_LICENSE_OR_ID_REQUIRED</c> - <b>drivers_license_or_id_required</b></description></item>
///   <item><description><c>DUPLICATE_CAPTURE</c> - <b>duplicate_capture</b></description></item>
///   <item><description><c>DUPLICATE_RETURN</c> - <b>duplicate_return</b></description></item>
///   <item><description><c>DUPLICATE_REVERSAL</c> - <b>duplicate_reversal</b></description></item>
///   <item><description><c>DUPLICATE_TRANSACTION</c> - <b>duplicate_transaction</b></description></item>
///   <item><description><c>EDIT_HONOR</c> - <b>edit_honor</b></description></item>
///   <item><description><c>EMAIL_NO_MATCH</c> - <b>email_no_match</b></description></item>
///   <item><description><c>EMAIL_UNAVAILABLE</c> - <b>email_unavailable</b></description></item>
///   <item><description><c>EMV_KEY_DOWNLOAD_ERROR</c> - <b>emv_key_download_error</b></description></item>
///   <item><description><c>ENTER_LESSER_AMOUNT</c> - <b>enter_lesser_amount</b></description></item>
///   <item><description><c>ERROR_PROCESSING_PIN_BLOCK</c> - <b>error_processing_pin_block</b></description></item>
///   <item><description><c>EXCEEDS_GLOBAL_AMOUNT_FOR_PERIOD_PAY_INSIDE</c> - <b>exceeds_global_amount_for_period_pay_inside</b></description></item>
///   <item><description><c>EXCEEDS_GLOBAL_COUNT_FOR_PERIOD_PAY_INSIDE</c> - <b>exceeds_global_count_for_period_pay_inside</b></description></item>
///   <item><description><c>EXCEEDS_GLOBAL_LIMITS_FOR_PERIOD_PAY_INSIDE</c> - <b>exceeds_global_limits_for_period_pay_inside</b></description></item>
///   <item><description><c>EXCEEDS_LIMIT</c> - <b>exceeds_limit</b></description></item>
///   <item><description><c>EXCEEDS_MERCHANT_AMOUNT_FOR_PERIOD_PAY_INSIDE</c> - <b>exceeds_merchant_amount_for_period_pay_inside</b></description></item>
///   <item><description><c>EXCEEDS_MERCHANT_COUNT_FOR_PERIOD_PAY_INSIDE</c> - <b>exceeds_merchant_count_for_period_pay_inside</b></description></item>
///   <item><description><c>EXCEEDS_MERCHANT_LIMITS_FOR_PERIOD_PAY_INSIDE</c> - <b>exceeds_merchant_limits_for_period_pay_inside</b></description></item>
///   <item><description><c>EXCEEDS_STATE_AMOUNT_FOR_PERIOD_PAY_INSIDE</c> - <b>exceeds_state_amount_for_period_pay_inside</b></description></item>
///   <item><description><c>EXCEEDS_STATE_COUNT_FOR_PERIOD_PAY_INSIDE</c> - <b>exceeds_state_count_for_period_pay_inside</b></description></item>
///   <item><description><c>EXCEEDS_STATE_LIMITS_FOR_PERIOD_PAY_INSIDE</c> - <b>exceeds_state_limits_for_period_pay_inside</b></description></item>
///   <item><description><c>EXCEEDS_TRANSACTION_COUNT_OR_AMOUNT_LIMIT_IN_24_HOURS</c> - <b>exceeds_transaction_count_or_amount_limit_in_24_hours</b></description></item>
///   <item><description><c>EXCEEDS_TRANSACTION_COUNT_OR_AMOUNT_LIMIT_IN_7_DAYS</c> - <b>exceeds_transaction_count_or_amount_limit_in_7_days</b></description></item>
///   <item><description><c>EXCEEDS_TRANSACTION_COUNT_OR_AMOUNT_LIMIT_IN_30_DAYS</c> - <b>exceeds_transaction_count_or_amount_limit_in_30_days</b></description></item>
///   <item><description><c>EXCEEDS_ZIP_CODE_AMOUNT_FOR_PERIOD_PAY_INSIDE</c> - <b>exceeds_zip_code_amount_for_period_pay_inside</b></description></item>
///   <item><description><c>EXCEEDS_ZIP_CODE_COUNT_FOR_PERIOD_PAY_INSIDE</c> - <b>exceeds_zip_code_count_for_period_pay_inside</b></description></item>
///   <item><description><c>EXCEEDS_ZIP_CODE_LIMITS_FOR_PERIOD_PAY_INSIDE</c> - <b>exceeds_zip_code_limits_for_period_pay_inside</b></description></item>
///   <item><description><c>EXPIRED_CARD</c> - <b>expired_card</b></description></item>
///   <item><description><c>EXPIRED_LOCK</c> - <b>expired_lock</b></description></item>
///   <item><description><c>FRAUDULENT</c> - <b>fraudulent</b></description></item>
///   <item><description><c>FILE_TEMPORARILY_UNAVAILABLE</c> - <b>file_temporarily_unavailable</b></description></item>
///   <item><description><c>FILE_UPDATE_ERROR</c> - <b>file_update_error</b></description></item>
///   <item><description><c>FILE_UPDATE_UNAVAILABLE</c> - <b>file_update_unavailable</b></description></item>
///   <item><description><c>FORMAT_ERROR</c> - <b>format_error</b></description></item>
///   <item><description><c>FORWARD_TO_ISSUER</c> - <b>forward_to_issuer</b></description></item>
///   <item><description><c>FUEL_LIMIT_EXCEEDED</c> - <b>fuel_limit_exceeded</b></description></item>
///   <item><description><c>FUEL_ONLY</c> - <b>fuel_only</b></description></item>
///   <item><description><c>FUEL_PRICE_ERROR</c> - <b>fuel_price_error</b></description></item>
///   <item><description><c>FULL_SSN_REQUIRED</c> - <b>full_ssn_required</b></description></item>
///   <item><description><c>FUNCTION_NOT_SUPPORTED</c> - <b>function_not_supported</b></description></item>
///   <item><description><c>FUNDS_ON_HOLD</c> - <b>funds_on_hold</b></description></item>
///   <item><description><c>GENERAL</c> - <b>general</b></description></item>
///   <item><description><c>GENERAL_ERROR</c> - <b>general_error</b></description></item>
///   <item><description><c>GENERIC_DECLINE</c> - <b>generic_decline</b></description></item>
///   <item><description><c>HARD_CAPTURE_PICKUP_CARD</c> - <b>hard_capture_pickup_card</b></description></item>
///   <item><description><c>HARD_NEGATIVE_INFO_ON_FILE</c> - <b>hard_negative_info_on_file</b></description></item>
///   <item><description><c>HIGH_RISK</c> - <b>high_risk</b></description></item>
///   <item><description><c>HOLD_SHIPPING_FOR_24H</c> - <b>hold_shipping_for_24h</b></description></item>
///   <item><description><c>HONOR_WITH_AUTHENTICATION</c> - <b>honor_with_authentication</b></description></item>
///   <item><description><c>ILLEGAL_TRANSACTION</c> - <b>illegal_transaction</b></description></item>
///   <item><description><c>IMPRINT_CARD</c> - <b>imprint_card</b></description></item>
///   <item><description><c>INCORRECT_CVV</c> - <b>incorrect_cvv</b></description></item>
///   <item><description><c>INCORRECT_NUMBER</c> - <b>incorrect_number</b></description></item>
///   <item><description><c>INCORRECT_PIN</c> - <b>incorrect_pin</b></description></item>
///   <item><description><c>INCORRECT_MERCHANT_LOCATION</c> - <b>incorrect_merchant_location</b></description></item>
///   <item><description><c>INCORRECT_TRANSACTION_VERSION</c> - <b>incorrect_transaction_version</b></description></item>
///   <item><description><c>INQUIRY_DECLINED</c> - <b>inquiry_declined</b></description></item>
///   <item><description><c>INSUFFICIENT_DATA</c> - <b>insufficient_data</b></description></item>
///   <item><description><c>INSUFFICIENT_FUNDS</c> - <b>insufficient_funds</b></description></item>
///   <item><description><c>INSUFFICIENT_SECURITY</c> - <b>insufficient_security</b></description></item>
///   <item><description><c>INTERNET_ACCESS_DISABLED</c> - <b>internet_access_disabled</b></description></item>
///   <item><description><c>INVALID_3D_PASSWORD</c> - <b>invalid_3d_password</b></description></item>
///   <item><description><c>INVALID_ACCOUNT</c> - <b>invalid_account</b></description></item>
///   <item><description><c>INVALID_ACCOUNT/DATE</c> - <b>invalid_account/date</b></description></item>
///   <item><description><c>INVALID_ACCOUNT_TYPE</c> - <b>invalid_account_type</b></description></item>
///   <item><description><c>INVALID_ACTIVATE</c> - <b>invalid_activate</b></description></item>
///   <item><description><c>INVALID_AMOUNT</c> - <b>invalid_amount</b></description></item>
///   <item><description><c>INVALID_AUTHORIZATION_CODE</c> - <b>invalid_authorization_code</b></description></item>
///   <item><description><c>INVALID_BATCH_NUMBER/ID</c> - <b>invalid_batch_number/id</b></description></item>
///   <item><description><c>INVALID_CASHBACK</c> - <b>invalid_cashback</b></description></item>
///   <item><description><c>INVALID_CHECKING_ACCOUNT</c> - <b>invalid_checking_account</b></description></item>
///   <item><description><c>INVALID_CHECKING_ACCOUNT_NUMBER</c> - <b>invalid_checking_account_number</b></description></item>
///   <item><description><c>INVALID_CLERK</c> - <b>invalid_clerk</b></description></item>
///   <item><description><c>INVALID_CREDIT_ACCOUNT</c> - <b>invalid_credit_account</b></description></item>
///   <item><description><c>INVALID_CURRENCY</c> - <b>invalid_currency</b></description></item>
///   <item><description><c>INVALID_CVV</c> - <b>invalid_cvv</b></description></item>
///   <item><description><c>INVALID_DATE_OR_TIME</c> - <b>invalid_date_or_time</b></description></item>
///   <item><description><c>INVALID_DRIVER</c> - <b>invalid_driver</b></description></item>
///   <item><description><c>INVALID_EAN_OR_SCV</c> - <b>invalid_ean_or_scv</b></description></item>
///   <item><description><c>INVALID_EFFECTIVE_DATE</c> - <b>invalid_effective_date</b></description></item>
///   <item><description><c>INVALID_EMAIL_ADDRESS</c> - <b>invalid_email_address</b></description></item>
///   <item><description><c>INVALID_ENTRY</c> - <b>invalid_entry</b></description></item>
///   <item><description><c>INVALID_EXPIRY_DATE</c> - <b>invalid_expiry_date</b></description></item>
///   <item><description><c>INVALID_EXPIRY_YEAR</c> - <b>invalid_expiry_year</b></description></item>
///   <item><description><c>INVALID_HOST</c> - <b>invalid_host</b></description></item>
///   <item><description><c>INVALID_LOCATION</c> - <b>invalid_location</b></description></item>
///   <item><description><c>INVALID_MAIDEN_NAME</c> - <b>invalid_maiden_name</b></description></item>
///   <item><description><c>INVALID_MCC</c> - <b>invalid_mcc</b></description></item>
///   <item><description><c>INVALID_MERCHANT</c> - <b>invalid_merchant</b></description></item>
///   <item><description><c>INVALID_MERCHANT_ID</c> - <b>invalid_merchant_id</b></description></item>
///   <item><description><c>INVALID_MERCHANT_ID/SE</c> - <b>invalid_merchant_id/se</b></description></item>
///   <item><description><c>INVALID_MERCHANT_SETUP</c> - <b>invalid_merchant_setup</b></description></item>
///   <item><description><c>INVALID_MICR_DATA</c> - <b>invalid_micr_data</b></description></item>
///   <item><description><c>INVALID_NEW_PASSWORD</c> - <b>invalid_new_password</b></description></item>
///   <item><description><c>INVALID_NOT_PRESENT</c> - <b>invalid_not_present</b></description></item>
///   <item><description><c>INVALID_NUMBER</c> - <b>invalid_number</b></description></item>
///   <item><description><c>INVALID_ODOMETER</c> - <b>invalid_odometer</b></description></item>
///   <item><description><c>INVALID_PASSWORD</c> - <b>invalid_password</b></description></item>
///   <item><description><c>INVALID_PIN</c> - <b>invalid_pin</b></description></item>
///   <item><description><c>INVALID_POS</c> - <b>invalid_pos</b></description></item>
///   <item><description><c>INVALID_PREAPPROVAL_NUMBER</c> - <b>invalid_preapproval_number</b></description></item>
///   <item><description><c>INVALID_PREFIX</c> - <b>invalid_prefix</b></description></item>
///   <item><description><c>INVALID_PRODUCT</c> - <b>invalid_product</b></description></item>
///   <item><description><c>INVALID_PROMPT_ENTRY</c> - <b>invalid_prompt_entry</b></description></item>
///   <item><description><c>INVALID_REQUEST</c> - <b>invalid_request</b></description></item>
///   <item><description><c>INVALID_RESPONSE</c> - <b>invalid_response</b></description></item>
///   <item><description><c>INVALID_RESPONSE_DATE</c> - <b>invalid_response_date</b></description></item>
///   <item><description><c>INVALID_RESTRICTION_CODE</c> - <b>invalid_restriction_code</b></description></item>
///   <item><description><c>INVALID_SAVINGS_ACCOUNT</c> - <b>invalid_savings_account</b></description></item>
///   <item><description><c>INVALID_SECURE_PAYMENT_DATA</c> - <b>invalid_secure_payment_data</b></description></item>
///   <item><description><c>INVALID_SKU</c> - <b>invalid_sku</b></description></item>
///   <item><description><c>INVALID_SSN</c> - <b>invalid_ssn</b></description></item>
///   <item><description><c>INVALID_STATE_CODE</c> - <b>invalid_state_code</b></description></item>
///   <item><description><c>INVALID_STATUS_CHANGE</c> - <b>invalid_status_change</b></description></item>
///   <item><description><c>INVALID_TERMINAL</c> - <b>invalid_terminal</b></description></item>
///   <item><description><c>INVALID_TGN_CIC</c> - <b>invalid_tgn_cic</b></description></item>
///   <item><description><c>INVALID_TIMEZONE</c> - <b>invalid_timezone</b></description></item>
///   <item><description><c>INVALID_TPPID</c> - <b>invalid_tppid</b></description></item>
///   <item><description><c>INVALID_TRACK_DATA</c> - <b>invalid_track_data</b></description></item>
///   <item><description><c>INVALID_TRANSACTION</c> - <b>invalid_transaction</b></description></item>
///   <item><description><c>INVALID_TRANSARMOR_TRANSACTION</c> - <b>invalid_transarmor_transaction</b></description></item>
///   <item><description><c>INVALID_USER</c> - <b>invalid_user</b></description></item>
///   <item><description><c>INVALID_VALUE_IN_THE_FIELD</c> - <b>invalid_value_in_the_field</b></description></item>
///   <item><description><c>INVALID_VEHICLE</c> - <b>invalid_vehicle</b></description></item>
///   <item><description><c>INVALID_VOID_OF_ACTIVATION</c> - <b>invalid_void_of_activation</b></description></item>
///   <item><description><c>INVALID_ZIP_CODE</c> - <b>invalid_zip_code</b></description></item>
///   <item><description><c>ISSUANCE_UNDER_MINIMUM_AMOUNT</c> - <b>issuance_under_minimum_amount</b></description></item>
///   <item><description><c>ISSUER_NOT_AVAILABLE</c> - <b>issuer_not_available</b></description></item>
///   <item><description><c>ISSUER_PROCESSOR_OR_SWITCH_NOT_AVAILABLE</c> - <b>issuer_processor_or_switch_not_available</b></description></item>
///   <item><description><c>ISSUER_SPECIAL_CONDITIONS</c> - <b>issuer_special_conditions</b></description></item>
///   <item><description><c>ISSUER_VELOCITY_AMOUNT_EXCEEDED</c> - <b>issuer_velocity_amount_exceeded</b></description></item>
///   <item><description><c>ISSUER_VELOCITY_COUNT_EXCEEDED</c> - <b>issuer_velocity_count_exceeded</b></description></item>
///   <item><description><c>LATE_REVERSAL</c> - <b>late_reversal</b></description></item>
///   <item><description><c>LAW_VIOLATION</c> - <b>law_violation</b></description></item>
///   <item><description><c>LIMIT_CHECK_FAILED</c> - <b>limit_check_failed</b></description></item>
///   <item><description><c>LOST_CARD</c> - <b>lost_card</b></description></item>
///   <item><description><c>MAIDEN_NAME_UNAVAILABLE</c> - <b>maiden_name_unavailable</b></description></item>
///   <item><description><c>MANUAL_TRIES_EXCEEDED</c> - <b>manual_tries_exceeded</b></description></item>
///   <item><description><c>MATCH</c> - <b>match</b></description></item>
///   <item><description><c>MAX_BALANCE_EXCEEDED</c> - <b>max_balance_exceeded</b></description></item>
///   <item><description><c>MERCHANT_DEPLETED</c> - <b>merchant_depleted</b></description></item>
///   <item><description><c>MERCHANT_HAS_MAIL_PENDING</c> - <b>merchant_has_mail_pending</b></description></item>
///   <item><description><c>MESSAGE_FORMAT_ERROR</c> - <b>message_format_error</b></description></item>
///   <item><description><c>MINUS2_DEBIT</c> - <b>minus2_debit</b></description></item>
///   <item><description><c>MISSING_CONDITIONAL_DATA</c> - <b>missing_conditional_data</b></description></item>
///   <item><description><c>MISSING_CUSTOMER_SERVICE_PHONE</c> - <b>missing_customer_service_phone</b></description></item>
///   <item><description><c>MISSING_FROM_ACCOUNT</c> - <b>missing_from_account</b></description></item>
///   <item><description><c>MISSING_TO_ACCOUNT</c> - <b>missing_to_account</b></description></item>
///   <item><description><c>MULTI_CURRENCY_DCC_FAIL</c> - <b>multi_currency_dcc_fail</b></description></item>
///   <item><description><c>MULTI_CURRENCY_INVERT_FAIL</c> - <b>multi_currency_invert_fail</b></description></item>
///   <item><description><c>MULTIPLE_ACCOUNTS_FOR_TYPE</c> - <b>multiple_accounts_for_type</b></description></item>
///   <item><description><c>NAME_EMAIL_NO_MATCH</c> - <b>name_email_no_match</b></description></item>
///   <item><description><c>NAME_EMAIL_UNAVAILABLE</c> - <b>name_email_unavailable</b></description></item>
///   <item><description><c>NAME_NO_MATCH</c> - <b>name_no_match</b></description></item>
///   <item><description><c>NAME_PHONE_NO_MATCH</c> - <b>name_phone_no_match</b></description></item>
///   <item><description><c>NAME_PHONE_UNAVAILABLE</c> - <b>name_phone_unavailable</b></description></item>
///   <item><description><c>NAME_UNAVAILABLE</c> - <b>name_unavailable</b></description></item>
///   <item><description><c>NEGATIVE_FILE_EXCEPTION</c> - <b>negative_file_exception</b></description></item>
///   <item><description><c>NEW_ACCOUNT_INFORMATION_AVAILABLE</c> - <b>new_account_information_available</b></description></item>
///   <item><description><c>NEW_CARD_ISSUED</c> - <b>new_card_issued</b></description></item>
///   <item><description><c>NEW_PASSWORD_REQUIRED</c> - <b>new_password_required</b></description></item>
///   <item><description><c>NO_ACCOUNT_LINK</c> - <b>no_account_link</b></description></item>
///   <item><description><c>NO_ACTION_TAKEN</c> - <b>no_action_taken</b></description></item>
///   <item><description><c>NO_CARD_RECORD</c> - <b>no_card_record</b></description></item>
///   <item><description><c>NO_CHAIN_ID</c> - <b>no_chain_id</b></description></item>
///   <item><description><c>NO_CHECKING_ACCOUNT</c> - <b>no_checking_account</b></description></item>
///   <item><description><c>NO_MATCH</c> - <b>mismatch</b></description></item>
///   <item><description><c>NO_MESSAGES_PENDING</c> - <b>no_messages_pending</b></description></item>
///   <item><description><c>NO_OPEN_BATCH</c> - <b>no_open_batch</b></description></item>
///   <item><description><c>NO_PHONE_SERVICE</c> - <b>no_phone_service</b></description></item>
///   <item><description><c>NO_PREVIOUS_TRANSACTION</c> - <b>no_previous_transaction</b></description></item>
///   <item><description><c>NO_REASON_TO_DECLINE</c> - <b>no_reason_to_decline</b></description></item>
///   <item><description><c>NO_SAVINGS_ACCOUNT</c> - <b>no_savings_account</b></description></item>
///   <item><description><c>NO_SUCH_ISSUER</c> - <b>no_such_issuer</b></description></item>
///   <item><description><c>NO_TO_ACCOUNT</c> - <b>no_to_account</b></description></item>
///   <item><description><c>NO_TRANSACTIONS_AVAILABLE</c> - <b>no_transactions_available</b></description></item>
///   <item><description><c>NO_TRANSACTION_SECURITY_RECORD</c> - <b>no_transaction_security_record</b></description></item>
///   <item><description><c>NOT_ACCEPTED</c> - <b> not_accepted</b></description></item>
///   <item><description><c>NOT_ACTIVE</c> - <b>not_active</b></description></item>
///   <item><description><c>NOT_LOST_OR_STOLEN</c> - <b>not_lost_or_stolen</b></description></item>
///   <item><description><c>NOT_ON_FILE</c> - <b>not_on_file</b></description></item>
///   <item><description><c>NOT_PERMITTED</c> - <b>not_permitted</b></description></item>
///   <item><description><c>NOT_PERFORMED</c> - <b>not_performed</b></description></item>
///   <item><description><c>NOT_PROCESSED</c> - <b>not_processed</b></description></item>
///   <item><description><c>NOT_SUPPORTED</c> - <b>not_supported</b></description></item>
///   <item><description><c>NSF</c> - <b>nsf</b></description></item>
///   <item><description><c>ONE_TIME_STOP_PAYMENT</c> - <b>one_time_stop_payment</b></description></item>
///   <item><description><c>ORIGINAL_AUTHORIZATION_MISMATCH</c> - <b>original_authorization_mismatch</b></description></item>
///   <item><description><c>ORIGINAL_AUTHORIZATION_NOT_FOUND</c> - <b>original_authorization_not_found</b></description></item>
///   <item><description><c>ORIGINAL_REPEATED</c> - <b>original_repeated</b></description></item>
///   <item><description><c>ORIGINAL_TRANSACTION_NOT_APPROVED</c> - <b>original_transaction_not_approved</b></description></item>
///   <item><description><c>OVER_CHAIN_DAILY_VELOCITY_AMOUNT</c> - <b>over_chain_daily_velocity_amount</b></description></item>
///   <item><description><c>OVER_CHAIN_DAILY_VELOCITY_COUNT</c> - <b>over_chain_daily_velocity_count</b></description></item>
///   <item><description><c>OVER_CHAIN_DAILY_VELOCITY_LIMITS</c> - <b>over_chain_daily_velocity_limits</b></description></item>
///   <item><description><c>OVER_CHAIN_PRODUCT_VELOCITY_AMOUNT</c> - <b>over_chain_product_velocity_amount</b></description></item>
///   <item><description><c>OVER_CHAIN_PRODUCT_VELOCITY_COUNT</c> - <b>over_chain_product_velocity_count</b></description></item>
///   <item><description><c>OVER_CHAIN_PRODUCT_VELOCITY_LIMITS</c> - <b>over_chain_product_velocity_limits</b></description></item>
///   <item><description><c>OVER_MAX_BALANCE</c> - <b>over_max_balance</b></description></item>
///   <item><description><c>OVER_MERCHANDISE_LIMIT</c> - <b>over_merchandise_limit</b></description></item>
///   <item><description><c>OVER_MERCHANT_DAILY_VELOCITY_AMOUNT</c> - <b>over_merchant_daily_velocity_amount</b></description></item>
///   <item><description><c>OVER_MERCHANT_DAILY_VELOCITY_COUNT</c> - <b>over_merchant_daily_velocity_count</b></description></item>
///   <item><description><c>OVER_MERCHANT_DAILY_VELOCITY_LIMITS</c> - <b>over_merchant_daily_velocity_limits</b></description></item>
///   <item><description><c>OVER_MERCHANT_PRODUCT_VELOCITY_AMOUNT</c> - <b>over_merchant_product_velocity_amount</b></description></item>
///   <item><description><c>OVER_MERCHANT_PRODUCT_VELOCITY_COUNT</c> - <b>over_merchant_product_velocity_count</b></description></item>
///   <item><description><c>OVER_MERCHANT_PRODUCT_VELOCITY_LIMITS</c> - <b>over_merchant_product_velocity_limits</b></description></item>
///   <item><description><c>OVER_MONTHLY_LIMIT</c> - <b>over_monthly_limit</b></description></item>
///   <item><description><c>OVER_NON_FUEL_LIMIT</c> - <b>over_non_fuel_limit</b></description></item>
///   <item><description><c>PAN_TRANS_ERROR</c> - <b>pan_trans_error</b></description></item>
///   <item><description><c>PARTIAL_AUTH_NOT_ALLOWED</c> - <b>partial_auth_not_allowed</b></description></item>
///   <item><description><c>PARTIAL_REVERSAL</c> - <b>partial_reversal</b></description></item>
///   <item><description><c>PARTIALLY_APPROVED</c> - <b>partially_approved</b></description></item>
///   <item><description><c>PASSWORD_RETRIES_EXCEEDED</c> - <b>password_retries_exceeded</b></description></item>
///   <item><description><c>PAY_AT_PUMP_NOT_ALLOWED</c> - <b>pay_at_pump_not_allowed</b></description></item>
///   <item><description><c>PHONE_EMAIL_NO_MATCH</c> - <b>phone_email_no_match</b></description></item>
///   <item><description><c>PHONE_EMAIL_UNAVAILABLE</c> - <b>phone_email_unavailable</b></description></item>
///   <item><description><c>PHONE_NO_MATCH</c> - <b>phone_no_match</b></description></item>
///   <item><description><c>PHONE_UNAVAILABLE</c> - <b>phone_unavailable</b></description></item>
///   <item><description><c>PICKUP_CARD</c> - <b>pickup_card</b></description></item>
///   <item><description><c>PIN_ALREADY_EXISTS</c> - <b>pin_already_exists</b></description></item>
///   <item><description><c>PIN_KEY_ERROR</c> - <b>pin_key_error</b></description></item>
///   <item><description><c>PIN_KEY_SYNCHRONIZATION_ERROR</c> - <b>pin_key_sychronization_error</b></description></item>
///   <item><description><c>PIN_TRY_EXCEEDED</c> - <b>pin_try_exceeded</b></description></item>
///   <item><description><c>PLEASE_RETRY</c> - <b>please_retry</b></description></item>
///   <item><description><c>PROCESS_AS_DEBIT</c> - <b>process_as_debit</b></description></item>
///   <item><description><c>PROCESSING_ERROR</c> - <b>processing_error</b></description></item>
///   <item><description><c>PRODUCT_CODE_RESTRICTED</c> - <b>product_code_restricted</b></description></item>
///   <item><description><c>PROMO_LOCATION_RESTRICTED</c> - <b>promo_location_restricted</b></description></item>
///   <item><description><c>QUANTITY_EXCEEDED</c> - <b>quantity_exceeded</b></description></item>
///   <item><description><c>REAUTHORIZATION_TIMEFRAME_EXPIRED</c> - <b>reauthorization_timeframe_expired</b></description></item>
///   <item><description><c>RECHARGE_AMOUNT_EXCEEDED</c> - <b>recharge_amount_exceeded</b></description></item>
///   <item><description><c>RECHARGE_COUNT_EXCEEDED</c> - <b>recharge_count_exceeded</b></description></item>
///   <item><description><c>REENTER_TRANSACTION</c> - <b>reenter_transaction</b></description></item>
///   <item><description><c>REFERRAL</c> - <b>referral</b></description></item>
///   <item><description><c>REJECT_MESSAGE</c> - <b>reject_message</b></description></item>
///   <item><description><c>REJECTED_LOST/STOLEN_CHECKS</c> - <b>rejected_lost/stolen_checks</b></description></item>
///   <item><description><c>REPAIR_LIMIT_EXCEEDED</c> - <b>repair_limit_exceeded</b></description></item>
///   <item><description><c>REQUEST_IN_PROGRESS</c> - <b>request_in_progress</b></description></item>
///   <item><description><c>RESPONSE_RECEIVED_LATE</c> - <b>response_received_late</b></description></item>
///   <item><description><c>RESTRICTED_CARD</c> - <b>restricted_card</b></description></item>
///   <item><description><c>RESUBMISSION_VIOLATES_NETWORK_FREQUENCY</c> - <b>resubmission_violates_network_frequency</b></description></item>
///   <item><description><c>RETAIN_CARD</c> - <b>retain_card</b></description></item>
///   <item><description><c>REVERSAL</c> - <b>reversal</b></description></item>
///   <item><description><c>REVERSAL_NO_MATCH</c> - <b>reversal_no_match</b></description></item>
///   <item><description><c>REVERSAL_UNSUCCESSFUL</c> - <b>reversal_unsuccessful</b></description></item>
///   <item><description><c>REVOCATION_OF_ALL_AUTHORIZATIONS</c> - <b>revocation_of_all_authorizations</b></description></item>
///   <item><description><c>REVOCATION_OF_AUTHORIZATION</c> - <b>revocation_of_authorization</b></description></item>
///   <item><description><c>SECURE_CODE_NOT_ENABLED</c> - <b>secure_code_not_enabled</b></description></item>
///   <item><description><c>SECURITY_ERROR</c> - <b>security_error</b></description></item>
///   <item><description><c>SECURITY_ERROR_TRY_AGAIN</c> - <b>security_error_try_again</b></description></item>
///   <item><description><c>SECURITY_VIOLATION</c> - <b>security_violation</b></description></item>
///   <item><description><c>SEE_ATTENDANT</c> - <b>see_attendant</b></description></item>
///   <item><description><c>SEE_EXHIBIT_FOR_ERROR</c> - <b>see_exhibit_for_error</b></description></item>
///   <item><description><c>SERVICE_NOT_ALLOWED</c> - <b>service_not_allowed</b></description></item>
///   <item><description><c>SIGNATURE_REQUIRED</c> - <b>signature_required</b></description></item>
///   <item><description><c>SKIP_TRACE_INFO</c> - <b>skip_trace_info</b></description></item>
///   <item><description><c>SOFT_DESCRIPTOR_NOT_ENABLED</c> - <b>soft_descriptor_not_enabled</b></description></item>
///   <item><description><c>SSN_NOT_AVAILABLE</c> - <b>ssn_not_available</b></description></item>
///   <item><description><c>STOLEN_CARD</c> - <b>stolen_card</b></description></item>
///   <item><description><c>STOP_PAYMENT_ORDER</c> - <b>stop_payment_order</b></description></item>
///   <item><description><c>STOP_RECURRING_PAYMENT_REQUESTS</c> - <b>stop_recurring_payment_requests</b></description></item>
///   <item><description><c>STORE_LOCATION_ZERO_NOT_ALLOWED</c> - <b>store_location_zero_not_allowed</b></description></item>
///   <item><description><c>SUBSYSTEM_UNAVAILABLE</c> - <b>subsystem_unavailable</b></description></item>
///   <item><description><c>SURCHARGE_LIMIT_EXCEEDED</c> - <b>surcharge_limit_exceeded</b></description></item>
///   <item><description><c>SYSTEM_ERROR</c> - <b>system_error</b></description></item>
///   <item><description><c>TARGET_CARD_AND_TRANSACTION_COUNT_MISMATCH</c> - <b>target_card_and_transaction_count_mismatch</b></description></item>
///   <item><description><c>TERMINAL_TRANSACTION_NUMBER_MISMATCH</c> - <b>terminal_transaction_number_mismatch</b></description></item>
///   <item><description><c>TESTMODE_DECLINE</c> - <b>testmode_decline</b></description></item>
///   <item><description><c>TICKET_LIMIT_EXCEEDED</c> - <b>ticket_limit_exceeded</b></description></item>
///   <item><description><c>TIMEOUT</c> - <b>timeout</b></description></item>
///   <item><description><c>TIMEOUT_REVERSAL_NOT_SUPPORTED</c> - <b>timeout_reversal_not_supported</b></description></item>
///   <item><description><c>TOO_MANY_TRANSACTIONS_REQUESTED</c> - <b>too_many_transactions_requested</b></description></item>
///   <item><description><c>TOTALS_UNAVAILABLE</c> - <b>totals_unavailable</b></description></item>
///   <item><description><c>TRANSACTION_COUNT_OR_WITHDRAWAL_LIMIT_EXCEEDED</c> - <b>transaction_count_or_withdrawal_limit_exceeded</b></description></item>
///   <item><description><c>TRANSACTION_DESTINATION_NOT_FOUND_FOR_ROUTING</c> - <b>transaction_destination_not_found_for_routing</b></description></item>
///   <item><description><c>TRANSACTION_HISTORY_UNAVAILABLE</c> - <b>transaction_history_unavailable</b></description></item>
///   <item><description><c>TRANSACTION_NOT_ALLOWED</c> - <b>transaction_not_allowed</b></description></item>
///   <item><description><c>TRANSACTION_NOT_PERMITTED</c> - <b>transaction_not_permitted</b></description></item>
///   <item><description><c>TRANSACTION_NOT_SUPPORTED</c> - <b>transaction_not_supported</b></description></item>
///   <item><description><c>TRANSACTION_TOTAL_LIMIT_PER_PRODUCT_CLASS_EXCEEDED</c> - <b>transaction_total_limit_per_product_class_exceeded</b></description></item>
///   <item><description><c>TRANSARMOR_INVALID_TOKEN_OR_ACCOUNT_NUMBER</c> - <b>transarmor_invalid_token_or_account_number</b></description></item>
///   <item><description><c>TRANSARMOR_KEY_ERROR</c> - <b>transarmor_key_error</b></description></item>
///   <item><description><c>TRANSARMOR_SERVICE_UNAVAILABLE</c> - <b>transarmor_service_unavailable</b></description></item>
///   <item><description><c>TRY_AGAIN_LATER</c> - <b>try_again_later</b></description></item>
///   <item><description><c>UNABLE_TO_LOCATE_PREVIOUS_MESSAGE</c> - <b>unable_to_locate_previous_message</b></description></item>
///   <item><description><c>UNABLE_TO_LOCATE_RECORD</c> - <b>unable_to_locate_record</b></description></item>
///   <item><description><c>UNABLE_TO_PROCESS</c> - <b>unable_to_process</b></description></item>
///   <item><description><c>UNABLE_TO_VERIFY_PIN</c> - <b>unable_to_verify_pin</b></description></item>
///   <item><description><c>UNAUTHORIZED</c> - <b>unauthorized</b></description></item>
///   <item><description><c>UNAVAILABLE</c> - <b>unavailable</b></description></item>
///   <item><description><c>UNDEFINED_CARD</c> - <b>undefined_card</b></description></item>
///   <item><description><c>UNDERAGE_CUSTOMER</c> - <b>underage_customer</b></description></item>
///   <item><description><c>UNKNOWN_VELOCITY_ERROR_PAY_INSIDE</c> - <b>unknown_velocity_error_pay_inside</b></description></item>
///   <item><description><c>UNSUCCESSFUL</c> - <b>unsuccessful</b></description></item>
///   <item><description><c>UNSUPPORTED_MESSAGE</c> - <b>unsupported_message</b></description></item>
///   <item><description><c>VALIDATION_ERROR</c> - <b>validation_error</b></description></item>
///   <item><description><c>VELOCITY_ERROR_PAY_INSIDE</c> - <b>velocity_error_pay_inside</b></description></item>
///   <item><description><c>VERIFICATION_TRANSACTION</c> - <b>verification_transaction</b></description></item>
///   <item><description><c>VIOLATION_OF_BUSINESS_ARRANGEMENT</c> - <b>violation_of_business_arrangement</b></description></item>
///   <item><description><c>VISA_OCT/MASTERCARD_MONEYSEND_TRANSACTIONS_BLOCKED</c> - <b>visa_oct/mastercard_moneysend_transactions_blocked</b></description></item>
///   <item><description><c>VOID_CAPTURED_ITEM</c> - <b>void_captured_item</b></description></item>
///   <item><description><c>VOYAGER_ID_PROBLEM</c> - <b>voyager_id_problem</b></description></item>
///   <item><description><c>Y_OR_N_REQUIRED</c> - <b>y_or_n_required</b></description></item>
///   <item><description><c>WAIT_2_PM_EASTERN</c> - <b>wait_2_pm_eastern</b></description></item>
///   <item><description><c>WITHDRAWAL_COUNT_LIMIT_EXCEEDED</c> - <b>withdrawal_count_limit_exceeded</b></description></item>
///   <item><description><c>WITHDRAWAL_LIMIT_EXCEEDED</c> - <b>withdrawal_limit_exceeded</b></description></item>
///   <item><description><c>ZIP_ADDRESS_NOT_VERIFIED</c> - <b>zip_and_address_not_verified</b></description></item>
///   <item><description><c>ZIP_NO_MATCH</c> - <b>address_match_zip_mismatch</b></description></item>
///   <item><description><c>ZIP_NOT_VERIFIED</c> - <b>zip_not_verified</b></description></item>
///   <item><description><c>3DS_AUTHENTICATION_SUCCESSFUL</c> - <b>3ds_authentication_successful</b></description></item>
///   <item><description><c>3DS_AUTHENTICATION_INVALID</c> - <b>3ds_authentication_invalid</b></description></item>
///   <item><description><c>3DS_AUTHENTICATION_FAILED</c> - <b>3ds_authentication_failed</b></description></item>
///   <item><description><c>3DS_AUTHENTICATION_NOT_VALIDATED</c> - <b>3ds_authentication_not_validated</b></description></item>
///   <item><description><c>3DS_AUTHENTICATION_SUCCESSFUL_WITHOUT_LIABILITY_SHIFT</c> - <b>3ds_authentication_successful_without_liability_shift</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TerminalTxnResultsBankCode2>))]
public sealed record TerminalTxnResultsBankCode2 : OpenStringEnum<TerminalTxnResultsBankCode2>
{
    private TerminalTxnResultsBankCode2(string value) : base(value)
    {
    }

    public static readonly TerminalTxnResultsBankCode2 AcceptedButNotYetProcessed = new(
        "accepted_but_not_yet_processed");

    public static readonly TerminalTxnResultsBankCode2 AccountBlocked = new("account_blocked");

    public static readonly TerminalTxnResultsBankCode2 AccountIsPurged = new("account_is_purged");

    public static readonly TerminalTxnResultsBankCode2 AccountLocked = new("account_locked");

    public static readonly TerminalTxnResultsBankCode2 AccountOnHoldOrNotActive = new("account_on_hold_or_not_active");

    public static readonly TerminalTxnResultsBankCode2 AccountNotActivated = new("account_not_activated");

    public static readonly TerminalTxnResultsBankCode2 AccountReloadsExceeded = new("account_reloads_exceeded");

    public static readonly TerminalTxnResultsBankCode2 AccountRowLocked = new("account_row_locked");

    public static readonly TerminalTxnResultsBankCode2 AccountStatusIsVoidLock = new("account_status_is_void_lock");

    public static readonly TerminalTxnResultsBankCode2 AchPaymentNotAccepted = new("ach_payment_not_accepted");

    public static readonly TerminalTxnResultsBankCode2 AcquirerChannelUnavailable = new("acquirer_channel_unavailable");

    public static readonly TerminalTxnResultsBankCode2 ActivationFailed = new("activation_failed");

    public static readonly TerminalTxnResultsBankCode2 AdditiveLimitExceeded = new("additive_limit_exceeded");

    public static readonly TerminalTxnResultsBankCode2 ZipMatchAddressMismatch = new("zip_match_address_mismatch");

    public static readonly TerminalTxnResultsBankCode2 ZipMatchAddressNotVerified = new(
        "zip_match_address_not_verified");

    public static readonly TerminalTxnResultsBankCode2 AlreadyRedeemed = new("already_redeemed");

    public static readonly TerminalTxnResultsBankCode2 AlreadyReversed = new("already_reversed");

    public static readonly TerminalTxnResultsBankCode2 AmountLimitExceeded = new("amount_limit_exceeded");

    public static readonly TerminalTxnResultsBankCode2 AmountTooLarge = new("amount_too_large");

    public static readonly TerminalTxnResultsBankCode2 ApproveWithId = new("approve_with_id");

    public static readonly TerminalTxnResultsBankCode2 Approved = new("approved");

    public static readonly TerminalTxnResultsBankCode2 ApprovedEmvKeyLoad = new("approved_emv_key_load");

    public static readonly TerminalTxnResultsBankCode2 ApprovedWithNoCash = new("approved_with_no_cash");

    public static readonly TerminalTxnResultsBankCode2 ApprovedWithOverdraft = new("approved_with_overdraft");

    public static readonly TerminalTxnResultsBankCode2 AuthorizationIdNeeded = new("authorization_id_needed");

    public static readonly TerminalTxnResultsBankCode2 BadAccount = new("bad_account");

    public static readonly TerminalTxnResultsBankCode2 BadChecksum = new("bad_checksum");

    public static readonly TerminalTxnResultsBankCode2 BadClose = new("bad_close");

    public static readonly TerminalTxnResultsBankCode2 BadMagStripe = new("bad_mag_stripe");

    public static readonly TerminalTxnResultsBankCode2 BadPostDate = new("bad_post_date");

    public static readonly TerminalTxnResultsBankCode2 BadRepayDate = new("bad_repay_date");

    public static readonly TerminalTxnResultsBankCode2 BalanceNotAvailable = new("balance_not_available");

    public static readonly TerminalTxnResultsBankCode2 BillToShipToMismatch = new("bill_to_ship_to_mismatch");

    public static readonly TerminalTxnResultsBankCode2 BinBlocked = new("bin_blocked");

    public static readonly TerminalTxnResultsBankCode2 BlockedByCardholder = new("blocked_by_cardholder");

    public static readonly TerminalTxnResultsBankCode2 BulkActivationError = new("bulk_activation_error");

    public static readonly TerminalTxnResultsBankCode2 BulkActivationPackageAmountError = new(
        "bulk_activation_package_amount_error");

    public static readonly TerminalTxnResultsBankCode2 CallAcquirer = new("call_acquirer");

    public static readonly TerminalTxnResultsBankCode2 CallForAuthorization = new("call_for_authorization");

    public static readonly TerminalTxnResultsBankCode2 CallIssuer = new("call_issuer");

    public static readonly TerminalTxnResultsBankCode2 CallTelecheck = new("call_telecheck");

    public static readonly TerminalTxnResultsBankCode2 CannotFindNetwork = new("cannot_find_network");

    public static readonly TerminalTxnResultsBankCode2 CardAlreadyActive = new("card_already_active");

    public static readonly TerminalTxnResultsBankCode2 CardAlreadyClosed = new("card_already_closed");

    public static readonly TerminalTxnResultsBankCode2 CardNotActive = new("card_not_active");

    public static readonly TerminalTxnResultsBankCode2 CardNotSupported = new("card_not_supported");

    public static readonly TerminalTxnResultsBankCode2 CardVelocityAmountExceeded = new(
        "card_velocity_amount_exceeded");

    public static readonly TerminalTxnResultsBankCode2 CardVelocityCountExceeded = new("card_velocity_count_exceeded");

    public static readonly TerminalTxnResultsBankCode2 CardVelocityExceeded = new("card_velocity_exceeded");

    public static readonly TerminalTxnResultsBankCode2 CashbackGreaterThanTransactionAmount = new(
        "cashback_greater_than_transaction_amount");

    public static readonly TerminalTxnResultsBankCode2 CashLimitExceeded = new("cash_limit_exceeded");

    public static readonly TerminalTxnResultsBankCode2 CenterClosed = new("center_closed");

    public static readonly TerminalTxnResultsBankCode2 CheckerManagerNotFound = new("checker/manager_not_found");

    public static readonly TerminalTxnResultsBankCode2 ChipFailure = new("chip_failure");

    public static readonly TerminalTxnResultsBankCode2 CloseUnavailable = new("close_unavailable");

    public static readonly TerminalTxnResultsBankCode2 CloseNotValid = new("close_not_valid");

    public static readonly TerminalTxnResultsBankCode2 ClosedAccount = new("closed_account");

    public static readonly TerminalTxnResultsBankCode2 CountExceedsLimit = new("count_exceeds_limit");

    public static readonly TerminalTxnResultsBankCode2 CounterfeitCard = new("counterfeit_card");

    public static readonly TerminalTxnResultsBankCode2 CounterOfferToSupplyPersonalGuaranty = new(
        "counter_offer_to_supply_personal_guaranty");

    public static readonly TerminalTxnResultsBankCode2 CryptogramDecryptionError = new("cryptogram_decryption_error");

    public static readonly TerminalTxnResultsBankCode2 CryptoBoxIsOffline = new("crypto_box_is_offline");

    public static readonly TerminalTxnResultsBankCode2 CurrencyConversionComplete = new("currency_conversion_complete");

    public static readonly TerminalTxnResultsBankCode2 CurrencyConversionError = new("currency_conversion_error");

    public static readonly TerminalTxnResultsBankCode2 CurrencyNotSupported = new("currency_not_supported");

    public static readonly TerminalTxnResultsBankCode2 CustomerCancellation = new("customer_cancellation");

    public static readonly TerminalTxnResultsBankCode2 CustomerOptOut = new("customer_opt_out");

    public static readonly TerminalTxnResultsBankCode2 CutTimeCloseTo1400 = new("cut_time_close_to_1400");

    public static readonly TerminalTxnResultsBankCode2 CvvDeclined = new("cvv_declined");

    public static readonly TerminalTxnResultsBankCode2 CvvFailed = new("cvv_failed");

    public static readonly TerminalTxnResultsBankCode2 DailyLimitExceeded = new("daily_limit_exceeded");

    public static readonly TerminalTxnResultsBankCode2 DateOfBirthError = new("date_of_birth_error");

    public static readonly TerminalTxnResultsBankCode2 DebitGatewayUnavailable = new("debit_gateway_unavailable");

    public static readonly TerminalTxnResultsBankCode2 Declined = new("declined");

    public static readonly TerminalTxnResultsBankCode2 DeclinedDueToStandInRules = new(
        "declined_due_to_stand_in_rules");

    public static readonly TerminalTxnResultsBankCode2 DeconvertedBin = new("deconverted_bin");

    public static readonly TerminalTxnResultsBankCode2 DoNotHonor = new("do_not_honor");

    public static readonly TerminalTxnResultsBankCode2 DoNotTryAgain = new("do_not_try_again");

    public static readonly TerminalTxnResultsBankCode2 DoNotTryAgainSubsequentMayContinue = new(
        "do_not_try_again_subsequent_may_continue");

    public static readonly TerminalTxnResultsBankCode2 DriversLicenseOrIdRequired = new(
        "drivers_license_or_id_required");

    public static readonly TerminalTxnResultsBankCode2 DuplicateCapture = new("duplicate_capture");

    public static readonly TerminalTxnResultsBankCode2 DuplicateReturn = new("duplicate_return");

    public static readonly TerminalTxnResultsBankCode2 DuplicateReversal = new("duplicate_reversal");

    public static readonly TerminalTxnResultsBankCode2 DuplicateTransaction = new("duplicate_transaction");

    public static readonly TerminalTxnResultsBankCode2 EditHonor = new("edit_honor");

    public static readonly TerminalTxnResultsBankCode2 EmailNoMatch = new("email_no_match");

    public static readonly TerminalTxnResultsBankCode2 EmailUnavailable = new("email_unavailable");

    public static readonly TerminalTxnResultsBankCode2 EmvKeyDownloadError = new("emv_key_download_error");

    public static readonly TerminalTxnResultsBankCode2 EnterLesserAmount = new("enter_lesser_amount");

    public static readonly TerminalTxnResultsBankCode2 ErrorProcessingPinBlock = new("error_processing_pin_block");

    public static readonly TerminalTxnResultsBankCode2 ExceedsGlobalAmountForPeriodPayInside = new(
        "exceeds_global_amount_for_period_pay_inside");

    public static readonly TerminalTxnResultsBankCode2 ExceedsGlobalCountForPeriodPayInside = new(
        "exceeds_global_count_for_period_pay_inside");

    public static readonly TerminalTxnResultsBankCode2 ExceedsGlobalLimitsForPeriodPayInside = new(
        "exceeds_global_limits_for_period_pay_inside");

    public static readonly TerminalTxnResultsBankCode2 ExceedsLimit = new("exceeds_limit");

    public static readonly TerminalTxnResultsBankCode2 ExceedsMerchantAmountForPeriodPayInside = new(
        "exceeds_merchant_amount_for_period_pay_inside");

    public static readonly TerminalTxnResultsBankCode2 ExceedsMerchantCountForPeriodPayInside = new(
        "exceeds_merchant_count_for_period_pay_inside");

    public static readonly TerminalTxnResultsBankCode2 ExceedsMerchantLimitsForPeriodPayInside = new(
        "exceeds_merchant_limits_for_period_pay_inside");

    public static readonly TerminalTxnResultsBankCode2 ExceedsStateAmountForPeriodPayInside = new(
        "exceeds_state_amount_for_period_pay_inside");

    public static readonly TerminalTxnResultsBankCode2 ExceedsStateCountForPeriodPayInside = new(
        "exceeds_state_count_for_period_pay_inside");

    public static readonly TerminalTxnResultsBankCode2 ExceedsStateLimitsForPeriodPayInside = new(
        "exceeds_state_limits_for_period_pay_inside");

    public static readonly TerminalTxnResultsBankCode2 ExceedsTransactionCountOrAmountLimitIn24Hours = new(
        "exceeds_transaction_count_or_amount_limit_in_24_hours");

    public static readonly TerminalTxnResultsBankCode2 ExceedsTransactionCountOrAmountLimitIn7Days = new(
        "exceeds_transaction_count_or_amount_limit_in_7_days");

    public static readonly TerminalTxnResultsBankCode2 ExceedsTransactionCountOrAmountLimitIn30Days = new(
        "exceeds_transaction_count_or_amount_limit_in_30_days");

    public static readonly TerminalTxnResultsBankCode2 ExceedsZipCodeAmountForPeriodPayInside = new(
        "exceeds_zip_code_amount_for_period_pay_inside");

    public static readonly TerminalTxnResultsBankCode2 ExceedsZipCodeCountForPeriodPayInside = new(
        "exceeds_zip_code_count_for_period_pay_inside");

    public static readonly TerminalTxnResultsBankCode2 ExceedsZipCodeLimitsForPeriodPayInside = new(
        "exceeds_zip_code_limits_for_period_pay_inside");

    public static readonly TerminalTxnResultsBankCode2 ExpiredCard = new("expired_card");

    public static readonly TerminalTxnResultsBankCode2 ExpiredLock = new("expired_lock");

    public static readonly TerminalTxnResultsBankCode2 Fraudulent = new("fraudulent");

    public static readonly TerminalTxnResultsBankCode2 FileTemporarilyUnavailable = new("file_temporarily_unavailable");

    public static readonly TerminalTxnResultsBankCode2 FileUpdateError = new("file_update_error");

    public static readonly TerminalTxnResultsBankCode2 FileUpdateUnavailable = new("file_update_unavailable");

    public static readonly TerminalTxnResultsBankCode2 FormatError = new("format_error");

    public static readonly TerminalTxnResultsBankCode2 ForwardToIssuer = new("forward_to_issuer");

    public static readonly TerminalTxnResultsBankCode2 FuelLimitExceeded = new("fuel_limit_exceeded");

    public static readonly TerminalTxnResultsBankCode2 FuelOnly = new("fuel_only");

    public static readonly TerminalTxnResultsBankCode2 FuelPriceError = new("fuel_price_error");

    public static readonly TerminalTxnResultsBankCode2 FullSsnRequired = new("full_ssn_required");

    public static readonly TerminalTxnResultsBankCode2 FunctionNotSupported = new("function_not_supported");

    public static readonly TerminalTxnResultsBankCode2 FundsOnHold = new("funds_on_hold");

    public static readonly TerminalTxnResultsBankCode2 General = new("general");

    public static readonly TerminalTxnResultsBankCode2 GeneralError = new("general_error");

    public static readonly TerminalTxnResultsBankCode2 GenericDecline = new("generic_decline");

    public static readonly TerminalTxnResultsBankCode2 HardCapturePickupCard = new("hard_capture_pickup_card");

    public static readonly TerminalTxnResultsBankCode2 HardNegativeInfoOnFile = new("hard_negative_info_on_file");

    public static readonly TerminalTxnResultsBankCode2 HighRisk = new("high_risk");

    public static readonly TerminalTxnResultsBankCode2 HoldShippingFor24H = new("hold_shipping_for_24h");

    public static readonly TerminalTxnResultsBankCode2 HonorWithAuthentication = new("honor_with_authentication");

    public static readonly TerminalTxnResultsBankCode2 IllegalTransaction = new("illegal_transaction");

    public static readonly TerminalTxnResultsBankCode2 ImprintCard = new("imprint_card");

    public static readonly TerminalTxnResultsBankCode2 IncorrectCvv = new("incorrect_cvv");

    public static readonly TerminalTxnResultsBankCode2 IncorrectNumber = new("incorrect_number");

    public static readonly TerminalTxnResultsBankCode2 IncorrectPin = new("incorrect_pin");

    public static readonly TerminalTxnResultsBankCode2 IncorrectMerchantLocation = new("incorrect_merchant_location");

    public static readonly TerminalTxnResultsBankCode2 IncorrectTransactionVersion = new(
        "incorrect_transaction_version");

    public static readonly TerminalTxnResultsBankCode2 InquiryDeclined = new("inquiry_declined");

    public static readonly TerminalTxnResultsBankCode2 InsufficientData = new("insufficient_data");

    public static readonly TerminalTxnResultsBankCode2 InsufficientFunds = new("insufficient_funds");

    public static readonly TerminalTxnResultsBankCode2 InsufficientSecurity = new("insufficient_security");

    public static readonly TerminalTxnResultsBankCode2 InternetAccessDisabled = new("internet_access_disabled");

    public static readonly TerminalTxnResultsBankCode2 Invalid3DPassword = new("invalid_3d_password");

    public static readonly TerminalTxnResultsBankCode2 InvalidAccount = new("invalid_account");

    public static readonly TerminalTxnResultsBankCode2 InvalidAccountDate = new("invalid_account/date");

    public static readonly TerminalTxnResultsBankCode2 InvalidAccountType = new("invalid_account_type");

    public static readonly TerminalTxnResultsBankCode2 InvalidActivate = new("invalid_activate");

    public static readonly TerminalTxnResultsBankCode2 InvalidAmount = new("invalid_amount");

    public static readonly TerminalTxnResultsBankCode2 InvalidAuthorizationCode = new("invalid_authorization_code");

    public static readonly TerminalTxnResultsBankCode2 InvalidBatchNumberId = new("invalid_batch_number/id");

    public static readonly TerminalTxnResultsBankCode2 InvalidCashback = new("invalid_cashback");

    public static readonly TerminalTxnResultsBankCode2 InvalidCheckingAccount = new("invalid_checking_account");

    public static readonly TerminalTxnResultsBankCode2 InvalidCheckingAccountNumber = new(
        "invalid_checking_account_number");

    public static readonly TerminalTxnResultsBankCode2 InvalidCreditAccount = new("invalid_credit_account");

    public static readonly TerminalTxnResultsBankCode2 InvalidClerk = new("invalid_clerk");

    public static readonly TerminalTxnResultsBankCode2 InvalidCurrency = new("invalid_currency");

    public static readonly TerminalTxnResultsBankCode2 InvalidCvv = new("invalid_cvv");

    public static readonly TerminalTxnResultsBankCode2 InvalidDateOrTime = new("invalid_date_or_time");

    public static readonly TerminalTxnResultsBankCode2 InvalidDriver = new("invalid_driver");

    public static readonly TerminalTxnResultsBankCode2 InvalidEanOrScv = new("invalid_ean_or_scv");

    public static readonly TerminalTxnResultsBankCode2 InvalidEffectiveDate = new("invalid_effective_date");

    public static readonly TerminalTxnResultsBankCode2 InvalidEmailAddress = new("invalid_email_address");

    public static readonly TerminalTxnResultsBankCode2 InvalidEntry = new("invalid_entry");

    public static readonly TerminalTxnResultsBankCode2 InvalidExpiryDate = new("invalid_expiry_date");

    public static readonly TerminalTxnResultsBankCode2 InvalidExpiryYear = new("invalid_expiry_year");

    public static readonly TerminalTxnResultsBankCode2 InvalidHost = new("invalid_host");

    public static readonly TerminalTxnResultsBankCode2 InvalidLocation = new("invalid_location");

    public static readonly TerminalTxnResultsBankCode2 InvalidMaidenName = new("invalid_maiden_name");

    public static readonly TerminalTxnResultsBankCode2 InvalidMcc = new("invalid_mcc");

    public static readonly TerminalTxnResultsBankCode2 InvalidMerchant = new("invalid_merchant");

    public static readonly TerminalTxnResultsBankCode2 InvalidMerchantId = new("invalid_merchant_id");

    public static readonly TerminalTxnResultsBankCode2 InvalidMerchantIdSe = new("invalid_merchant_id/se");

    public static readonly TerminalTxnResultsBankCode2 InvalidMerchantSetup = new("invalid_merchant_setup");

    public static readonly TerminalTxnResultsBankCode2 InvalidMicrData = new("invalid_micr_data");

    public static readonly TerminalTxnResultsBankCode2 InvalidNewPassword = new("invalid_new_password");

    public static readonly TerminalTxnResultsBankCode2 InvalidNotPresent = new("invalid_not_present");

    public static readonly TerminalTxnResultsBankCode2 InvalidNumber = new("invalid_number");

    public static readonly TerminalTxnResultsBankCode2 InvalidOdometer = new("invalid_odometer");

    public static readonly TerminalTxnResultsBankCode2 InvalidPassword = new("invalid_password");

    public static readonly TerminalTxnResultsBankCode2 InvalidPin = new("invalid_pin");

    public static readonly TerminalTxnResultsBankCode2 InvalidPos = new("invalid_pos");

    public static readonly TerminalTxnResultsBankCode2 InvalidPreapprovalNumber = new("invalid_preapproval_number");

    public static readonly TerminalTxnResultsBankCode2 InvalidPrefix = new("invalid_prefix");

    public static readonly TerminalTxnResultsBankCode2 InvalidProduct = new("invalid_product");

    public static readonly TerminalTxnResultsBankCode2 InvalidPromptEntry = new("invalid_prompt_entry");

    public static readonly TerminalTxnResultsBankCode2 InvalidRequest = new("invalid_request");

    public static readonly TerminalTxnResultsBankCode2 InvalidResponse = new("invalid_response");

    public static readonly TerminalTxnResultsBankCode2 InvalidResponseDate = new("invalid_response_date");

    public static readonly TerminalTxnResultsBankCode2 InvalidRestrictionCode = new("invalid_restriction_code");

    public static readonly TerminalTxnResultsBankCode2 InvalidSavingsAccount = new("invalid_savings_account");

    public static readonly TerminalTxnResultsBankCode2 InvalidSecurePaymentData = new("invalid_secure_payment_data");

    public static readonly TerminalTxnResultsBankCode2 InvalidSku = new("invalid_sku");

    public static readonly TerminalTxnResultsBankCode2 InvalidSsn = new("invalid_ssn");

    public static readonly TerminalTxnResultsBankCode2 InvalidStateCode = new("invalid_state_code");

    public static readonly TerminalTxnResultsBankCode2 InvalidStatusChange = new("invalid_status_change");

    public static readonly TerminalTxnResultsBankCode2 InvalidTerminal = new("invalid_terminal");

    public static readonly TerminalTxnResultsBankCode2 InvalidTgnCic = new("invalid_tgn_cic");

    public static readonly TerminalTxnResultsBankCode2 InvalidTimezone = new("invalid_timezone");

    public static readonly TerminalTxnResultsBankCode2 InvalidTppid = new("invalid_tppid");

    public static readonly TerminalTxnResultsBankCode2 InvalidTrackData = new("invalid_track_data");

    public static readonly TerminalTxnResultsBankCode2 InvalidTransaction = new("invalid_transaction");

    public static readonly TerminalTxnResultsBankCode2 InvalidTransarmorTransaction = new(
        "invalid_transarmor_transaction");

    public static readonly TerminalTxnResultsBankCode2 InvalidUser = new("invalid_user");

    public static readonly TerminalTxnResultsBankCode2 InvalidValueInTheField = new("invalid_value_in_the_field");

    public static readonly TerminalTxnResultsBankCode2 InvalidVehicle = new("invalid_vehicle");

    public static readonly TerminalTxnResultsBankCode2 InvalidVoidOfActivation = new("invalid_void_of_activation");

    public static readonly TerminalTxnResultsBankCode2 InvalidZipCode = new("invalid_zip_code");

    public static readonly TerminalTxnResultsBankCode2 IssuanceUnderMinimumAmount = new(
        "issuance_under_minimum_amount");

    public static readonly TerminalTxnResultsBankCode2 IssuerNotAvailable = new("issuer_not_available");

    public static readonly TerminalTxnResultsBankCode2 IssuerProcessorOrSwitchNotAvailable = new(
        "issuer_processor_or_switch_not_available");

    public static readonly TerminalTxnResultsBankCode2 IssuerSpecialConditions = new("issuer_special_conditions");

    public static readonly TerminalTxnResultsBankCode2 IssuerVelocityAmountExceeded = new(
        "issuer_velocity_amount_exceeded");

    public static readonly TerminalTxnResultsBankCode2 IssuerVelocityCountExceeded = new(
        "issuer_velocity_count_exceeded");

    public static readonly TerminalTxnResultsBankCode2 LateReversal = new("late_reversal");

    public static readonly TerminalTxnResultsBankCode2 LawViolation = new("law_violation");

    public static readonly TerminalTxnResultsBankCode2 LimitCheckFailed = new("limit_check_failed");

    public static readonly TerminalTxnResultsBankCode2 LostCard = new("lost_card");

    public static readonly TerminalTxnResultsBankCode2 MaidenNameUnavailable = new("maiden_name_unavailable");

    public static readonly TerminalTxnResultsBankCode2 ManualTriesExceeded = new("manual_tries_exceeded");

    public static readonly TerminalTxnResultsBankCode2 MatchMember = new("match");

    public static readonly TerminalTxnResultsBankCode2 MaxBalanceExceeded = new("max_balance_exceeded");

    public static readonly TerminalTxnResultsBankCode2 MerchantDepleted = new("merchant_depleted");

    public static readonly TerminalTxnResultsBankCode2 MerchantHasMailPending = new("merchant_has_mail_pending");

    public static readonly TerminalTxnResultsBankCode2 MessageFormatError = new("message_format_error");

    public static readonly TerminalTxnResultsBankCode2 Minus2Debit = new("minus2_debit");

    public static readonly TerminalTxnResultsBankCode2 MissingConditionalData = new("missing_conditional_data");

    public static readonly TerminalTxnResultsBankCode2 MissingCustomerServicePhone = new(
        "missing_customer_service_phone");

    public static readonly TerminalTxnResultsBankCode2 MissingFromAccount = new("missing_from_account");

    public static readonly TerminalTxnResultsBankCode2 MissingToAccount = new("missing_to_account");

    public static readonly TerminalTxnResultsBankCode2 MultiCurrencyDccFail = new("multi_currency_dcc_fail");

    public static readonly TerminalTxnResultsBankCode2 MultiCurrencyInvertFail = new("multi_currency_invert_fail");

    public static readonly TerminalTxnResultsBankCode2 MultipleAccountsForType = new("multiple_accounts_for_type");

    public static readonly TerminalTxnResultsBankCode2 NameEmailNoMatch = new("name_email_no_match");

    public static readonly TerminalTxnResultsBankCode2 NameEmailUnavailable = new("name_email_unavailable");

    public static readonly TerminalTxnResultsBankCode2 NameNoMatch = new("name_no_match");

    public static readonly TerminalTxnResultsBankCode2 NamePhoneNoMatch = new("name_phone_no_match");

    public static readonly TerminalTxnResultsBankCode2 NamePhoneUnavailable = new("name_phone_unavailable");

    public static readonly TerminalTxnResultsBankCode2 NameUnavailable = new("name_unavailable");

    public static readonly TerminalTxnResultsBankCode2 NegativeFileException = new("negative_file_exception");

    public static readonly TerminalTxnResultsBankCode2 NewAccountInformationAvailable = new(
        "new_account_information_available");

    public static readonly TerminalTxnResultsBankCode2 NewCardIssued = new("new_card_issued");

    public static readonly TerminalTxnResultsBankCode2 NewPasswordRequired = new("new_password_required");

    public static readonly TerminalTxnResultsBankCode2 NoAccountLink = new("no_account_link");

    public static readonly TerminalTxnResultsBankCode2 NoActionTaken = new("no_action_taken");

    public static readonly TerminalTxnResultsBankCode2 NoCardRecord = new("no_card_record");

    public static readonly TerminalTxnResultsBankCode2 NoChainId = new("no_chain_id");

    public static readonly TerminalTxnResultsBankCode2 NoCheckingAccount = new("no_checking_account");

    public static readonly TerminalTxnResultsBankCode2 Mismatch = new("mismatch");

    public static readonly TerminalTxnResultsBankCode2 NoMessagesPending = new("no_messages_pending");

    public static readonly TerminalTxnResultsBankCode2 NoOpenBatch = new("no_open_batch");

    public static readonly TerminalTxnResultsBankCode2 NoPhoneService = new("no_phone_service");

    public static readonly TerminalTxnResultsBankCode2 NoPreviousTransaction = new("no_previous_transaction");

    public static readonly TerminalTxnResultsBankCode2 NoReasonToDecline = new("no_reason_to_decline");

    public static readonly TerminalTxnResultsBankCode2 NoSavingsAccount = new("no_savings_account");

    public static readonly TerminalTxnResultsBankCode2 NoSuchIssuer = new("no_such_issuer");

    public static readonly TerminalTxnResultsBankCode2 NoToAccount = new("no_to_account");

    public static readonly TerminalTxnResultsBankCode2 NoTransactionsAvailable = new("no_transactions_available");

    public static readonly TerminalTxnResultsBankCode2 NoTransactionSecurityRecord = new(
        "no_transaction_security_record");

    public static readonly TerminalTxnResultsBankCode2 NotAccepted = new("not_accepted");

    public static readonly TerminalTxnResultsBankCode2 NotActive = new("not_active");

    public static readonly TerminalTxnResultsBankCode2 NotLostOrStolen = new("not_lost_or_stolen");

    public static readonly TerminalTxnResultsBankCode2 NotOnFile = new("not_on_file");

    public static readonly TerminalTxnResultsBankCode2 NotPermitted = new("not_permitted");

    public static readonly TerminalTxnResultsBankCode2 NotPerformed = new("not_performed");

    public static readonly TerminalTxnResultsBankCode2 NotProcessed = new("not_processed");

    public static readonly TerminalTxnResultsBankCode2 NotSupported = new("not_supported");

    public static readonly TerminalTxnResultsBankCode2 Nsf = new("nsf");

    public static readonly TerminalTxnResultsBankCode2 OneTimeStopPayment = new("one_time_stop_payment");

    public static readonly TerminalTxnResultsBankCode2 OriginalAuthorizationMismatch = new(
        "original_authorization_mismatch");

    public static readonly TerminalTxnResultsBankCode2 OriginalAuthorizationNotFound = new(
        "original_authorization_not_found");

    public static readonly TerminalTxnResultsBankCode2 OriginalRepeated = new("original_repeated");

    public static readonly TerminalTxnResultsBankCode2 OriginalTransactionNotApproved = new(
        "original_transaction_not_approved");

    public static readonly TerminalTxnResultsBankCode2 OverChainDailyVelocityAmount = new(
        "over_chain_daily_velocity_amount");

    public static readonly TerminalTxnResultsBankCode2 OverChainDailyVelocityCount = new(
        "over_chain_daily_velocity_count");

    public static readonly TerminalTxnResultsBankCode2 OverChainDailyVelocityLimits = new(
        "over_chain_daily_velocity_limits");

    public static readonly TerminalTxnResultsBankCode2 OverChainProductVelocityAmount = new(
        "over_chain_product_velocity_amount");

    public static readonly TerminalTxnResultsBankCode2 OverChainProductVelocityCount = new(
        "over_chain_product_velocity_count");

    public static readonly TerminalTxnResultsBankCode2 OverChainProductVelocityLimits = new(
        "over_chain_product_velocity_limits");

    public static readonly TerminalTxnResultsBankCode2 OverMaxBalance = new("over_max_balance");

    public static readonly TerminalTxnResultsBankCode2 OverMerchandiseLimit = new("over_merchandise_limit");

    public static readonly TerminalTxnResultsBankCode2 OverMerchantDailyVelocityAmount = new(
        "over_merchant_daily_velocity_amount");

    public static readonly TerminalTxnResultsBankCode2 OverMerchantDailyVelocityCount = new(
        "over_merchant_daily_velocity_count");

    public static readonly TerminalTxnResultsBankCode2 OverMerchantDailyVelocityLimits = new(
        "over_merchant_daily_velocity_limits");

    public static readonly TerminalTxnResultsBankCode2 OverMerchantProductVelocityAmount = new(
        "over_merchant_product_velocity_amount");

    public static readonly TerminalTxnResultsBankCode2 OverMerchantProductVelocityCount = new(
        "over_merchant_product_velocity_count");

    public static readonly TerminalTxnResultsBankCode2 OverMerchantProductVelocityLimits = new(
        "over_merchant_product_velocity_limits");

    public static readonly TerminalTxnResultsBankCode2 OverMonthlyLimit = new("over_monthly_limit");

    public static readonly TerminalTxnResultsBankCode2 OverNonFuelLimit = new("over_non_fuel_limit");

    public static readonly TerminalTxnResultsBankCode2 PanTransError = new("pan_trans_error");

    public static readonly TerminalTxnResultsBankCode2 PartialAuthNotAllowed = new("partial_auth_not_allowed");

    public static readonly TerminalTxnResultsBankCode2 PartialReversal = new("partial_reversal");

    public static readonly TerminalTxnResultsBankCode2 PartiallyApproved = new("partially_approved");

    public static readonly TerminalTxnResultsBankCode2 PasswordRetriesExceeded = new("password_retries_exceeded");

    public static readonly TerminalTxnResultsBankCode2 PayAtPumpNotAllowed = new("pay_at_pump_not_allowed");

    public static readonly TerminalTxnResultsBankCode2 PhoneEmailNoMatch = new("phone_email_no_match");

    public static readonly TerminalTxnResultsBankCode2 PhoneEmailUnavailable = new("phone_email_unavailable");

    public static readonly TerminalTxnResultsBankCode2 PhoneNoMatch = new("phone_no_match");

    public static readonly TerminalTxnResultsBankCode2 PhoneUnavailable = new("phone_unavailable");

    public static readonly TerminalTxnResultsBankCode2 PickupCard = new("pickup_card");

    public static readonly TerminalTxnResultsBankCode2 PinAlreadyExists = new("pin_already_exists");

    public static readonly TerminalTxnResultsBankCode2 PinKeyError = new("pin_key_error");

    public static readonly TerminalTxnResultsBankCode2 PinKeySychronizationError = new("pin_key_sychronization_error");

    public static readonly TerminalTxnResultsBankCode2 PinTryExceeded = new("pin_try_exceeded");

    public static readonly TerminalTxnResultsBankCode2 PleaseRetry = new("please_retry");

    public static readonly TerminalTxnResultsBankCode2 ProcessAsDebit = new("process_as_debit");

    public static readonly TerminalTxnResultsBankCode2 ProcessingError = new("processing_error");

    public static readonly TerminalTxnResultsBankCode2 ProductCodeRestricted = new("product_code_restricted");

    public static readonly TerminalTxnResultsBankCode2 PromoLocationRestricted = new("promo_location_restricted");

    public static readonly TerminalTxnResultsBankCode2 QuantityExceeded = new("quantity_exceeded");

    public static readonly TerminalTxnResultsBankCode2 ReauthorizationTimeframeExpired = new(
        "reauthorization_timeframe_expired");

    public static readonly TerminalTxnResultsBankCode2 RechargeAmountExceeded = new("recharge_amount_exceeded");

    public static readonly TerminalTxnResultsBankCode2 RechargeCountExceeded = new("recharge_count_exceeded");

    public static readonly TerminalTxnResultsBankCode2 ReenterTransaction = new("reenter_transaction");

    public static readonly TerminalTxnResultsBankCode2 Referral = new("referral");

    public static readonly TerminalTxnResultsBankCode2 RejectMessage = new("reject_message");

    public static readonly TerminalTxnResultsBankCode2 RejectedLostStolenChecks = new("rejected_lost/stolen_checks");

    public static readonly TerminalTxnResultsBankCode2 RepairLimitExceeded = new("repair_limit_exceeded");

    public static readonly TerminalTxnResultsBankCode2 RequestInProgress = new("request_in_progress");

    public static readonly TerminalTxnResultsBankCode2 ResponseReceivedLate = new("response_received_late");

    public static readonly TerminalTxnResultsBankCode2 RestrictedCard = new("restricted_card");

    public static readonly TerminalTxnResultsBankCode2 ResubmissionViolatesNetworkFrequency = new(
        "resubmission_violates_network_frequency");

    public static readonly TerminalTxnResultsBankCode2 RetainCard = new("retain_card");

    public static readonly TerminalTxnResultsBankCode2 Reversal = new("reversal");

    public static readonly TerminalTxnResultsBankCode2 ReversalNoMatch = new("reversal_no_match");

    public static readonly TerminalTxnResultsBankCode2 ReversalUnsuccessful = new("reversal_unsuccessful");

    public static readonly TerminalTxnResultsBankCode2 RevocationOfAllAuthorizations = new(
        "revocation_of_all_authorizations");

    public static readonly TerminalTxnResultsBankCode2 RevocationOfAuthorization = new("revocation_of_authorization");

    public static readonly TerminalTxnResultsBankCode2 SecureCodeNotEnabled = new("secure_code_not_enabled");

    public static readonly TerminalTxnResultsBankCode2 SecurityError = new("security_error");

    public static readonly TerminalTxnResultsBankCode2 SecurityErrorTryAgain = new("security_error_try_again");

    public static readonly TerminalTxnResultsBankCode2 SecurityViolation = new("security_violation");

    public static readonly TerminalTxnResultsBankCode2 SeeAttendant = new("see_attendant");

    public static readonly TerminalTxnResultsBankCode2 SeeExhibitForError = new("see_exhibit_for_error");

    public static readonly TerminalTxnResultsBankCode2 ServiceNotAllowed = new("service_not_allowed");

    public static readonly TerminalTxnResultsBankCode2 SignatureRequired = new("signature_required");

    public static readonly TerminalTxnResultsBankCode2 SkipTraceInfo = new("skip_trace_info");

    public static readonly TerminalTxnResultsBankCode2 SoftDescriptorNotEnabled = new("soft_descriptor_not_enabled");

    public static readonly TerminalTxnResultsBankCode2 SsnNotAvailable = new("ssn_not_available");

    public static readonly TerminalTxnResultsBankCode2 StolenCard = new("stolen_card");

    public static readonly TerminalTxnResultsBankCode2 StopPaymentOrder = new("stop_payment_order");

    public static readonly TerminalTxnResultsBankCode2 StopRecurringPaymentRequests = new(
        "stop_recurring_payment_requests");

    public static readonly TerminalTxnResultsBankCode2 StoreLocationZeroNotAllowed = new(
        "store_location_zero_not_allowed");

    public static readonly TerminalTxnResultsBankCode2 SubsystemUnavailable = new("subsystem_unavailable");

    public static readonly TerminalTxnResultsBankCode2 SurchargeLimitExceeded = new("surcharge_limit_exceeded");

    public static readonly TerminalTxnResultsBankCode2 SystemError = new("system_error");

    public static readonly TerminalTxnResultsBankCode2 TargetCardAndTransactionCountMismatch = new(
        "target_card_and_transaction_count_mismatch");

    public static readonly TerminalTxnResultsBankCode2 TerminalTransactionNumberMismatch = new(
        "terminal_transaction_number_mismatch");

    public static readonly TerminalTxnResultsBankCode2 TestmodeDecline = new("testmode_decline");

    public static readonly TerminalTxnResultsBankCode2 TicketLimitExceeded = new("ticket_limit_exceeded");

    public static readonly TerminalTxnResultsBankCode2 Timeout = new("timeout");

    public static readonly TerminalTxnResultsBankCode2 TimeoutReversalNotSupported = new(
        "timeout_reversal_not_supported");

    public static readonly TerminalTxnResultsBankCode2 TooManyTransactionsRequested = new(
        "too_many_transactions_requested");

    public static readonly TerminalTxnResultsBankCode2 TotalsUnavailable = new("totals_unavailable");

    public static readonly TerminalTxnResultsBankCode2 TransactionCountOrWithdrawalLimitExceeded = new(
        "transaction_count_or_withdrawal_limit_exceeded");

    public static readonly TerminalTxnResultsBankCode2 TransactionDestinationNotFoundForRouting = new(
        "transaction_destination_not_found_for_routing");

    public static readonly TerminalTxnResultsBankCode2 TransactionHistoryUnavailable = new(
        "transaction_history_unavailable");

    public static readonly TerminalTxnResultsBankCode2 TransactionNotAllowed = new("transaction_not_allowed");

    public static readonly TerminalTxnResultsBankCode2 TransactionNotPermitted = new("transaction_not_permitted");

    public static readonly TerminalTxnResultsBankCode2 TransactionNotSupported = new("transaction_not_supported");

    public static readonly TerminalTxnResultsBankCode2 TransactionTotalLimitPerProductClassExceeded = new(
        "transaction_total_limit_per_product_class_exceeded");

    public static readonly TerminalTxnResultsBankCode2 TransarmorInvalidTokenOrAccountNumber = new(
        "transarmor_invalid_token_or_account_number");

    public static readonly TerminalTxnResultsBankCode2 TransarmorKeyError = new("transarmor_key_error");

    public static readonly TerminalTxnResultsBankCode2 TransarmorServiceUnavailable = new(
        "transarmor_service_unavailable");

    public static readonly TerminalTxnResultsBankCode2 TryAgainLater = new("try_again_later");

    public static readonly TerminalTxnResultsBankCode2 UnableToLocatePreviousMessage = new(
        "unable_to_locate_previous_message");

    public static readonly TerminalTxnResultsBankCode2 UnableToLocateRecord = new("unable_to_locate_record");

    public static readonly TerminalTxnResultsBankCode2 UnableToProcess = new("unable_to_process");

    public static readonly TerminalTxnResultsBankCode2 UnableToVerifyPin = new("unable_to_verify_pin");

    public static readonly TerminalTxnResultsBankCode2 Unauthorized = new("unauthorized");

    public static readonly TerminalTxnResultsBankCode2 Unavailable = new("unavailable");

    public static readonly TerminalTxnResultsBankCode2 UndefinedCard = new("undefined_card");

    public static readonly TerminalTxnResultsBankCode2 UnderageCustomer = new("underage_customer");

    public static readonly TerminalTxnResultsBankCode2 UnknownVelocityErrorPayInside = new(
        "unknown_velocity_error_pay_inside");

    public static readonly TerminalTxnResultsBankCode2 Unsuccessful = new("unsuccessful");

    public static readonly TerminalTxnResultsBankCode2 UnsupportedMessage = new("unsupported_message");

    public static readonly TerminalTxnResultsBankCode2 ValidationError = new("validation_error");

    public static readonly TerminalTxnResultsBankCode2 VelocityErrorPayInside = new("velocity_error_pay_inside");

    public static readonly TerminalTxnResultsBankCode2 VerificationTransaction = new("verification_transaction");

    public static readonly TerminalTxnResultsBankCode2 ViolationOfBusinessArrangement = new(
        "violation_of_business_arrangement");

    public static readonly TerminalTxnResultsBankCode2 VisaOctMastercardMoneysendTransactionsBlocked = new(
        "visa_oct/mastercard_moneysend_transactions_blocked");

    public static readonly TerminalTxnResultsBankCode2 VoidCapturedItem = new("void_captured_item");

    public static readonly TerminalTxnResultsBankCode2 VoyagerIdProblem = new("voyager_id_problem");

    public static readonly TerminalTxnResultsBankCode2 YOrNRequired = new("y_or_n_required");

    public static readonly TerminalTxnResultsBankCode2 Wait2PmEastern = new("wait_2_pm_eastern");

    public static readonly TerminalTxnResultsBankCode2 WithdrawalCountLimitExceeded = new(
        "withdrawal_count_limit_exceeded");

    public static readonly TerminalTxnResultsBankCode2 WithdrawalLimitExceeded = new("withdrawal_limit_exceeded");

    public static readonly TerminalTxnResultsBankCode2 ZipAddressNotVerified = new("zip_address_not_verified");

    public static readonly TerminalTxnResultsBankCode2 ZipAndAddressNotVerified = new("zip_and_address_not_verified");

    public static readonly TerminalTxnResultsBankCode2 ZipNoMatch = new("zip_no_match");

    public static readonly TerminalTxnResultsBankCode2 AddressMatchZipMismatch = new("address_match_zip_mismatch");

    public static readonly TerminalTxnResultsBankCode2 ZipNotVerified = new("zip_not_verified");

    public static readonly TerminalTxnResultsBankCode2 _3DsAuthenticationSuccessful = new(
        "3ds_authentication_successful");

    public static readonly TerminalTxnResultsBankCode2 _3DsAuthenticationInvalid = new("3ds_authentication_invalid");

    public static readonly TerminalTxnResultsBankCode2 _3DsAuthenticationFailed = new("3ds_authentication_failed");

    public static readonly TerminalTxnResultsBankCode2 _3DsAuthenticationNotValidated = new(
        "3ds_authentication_not_validated");

    public static readonly TerminalTxnResultsBankCode2 _3DsAuthenticationSuccessfulWithoutLiabilityShift = new(
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
