// tslint:disable
/**
 * FlowAccount Business API
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import {
    Bank,
    BankingChannelsStatus,
    ChartOfAccount,
    CreditCardType,
} from './';

/**
 * @export
 * @interface CreditCard
 */
export interface CreditCard {
    /**
     * @type {number}
     * @memberof CreditCard
     */
    id?: number;
    /**
     * @type {number}
     * @memberof CreditCard
     */
    companyId: number;
    /**
     * @type {number}
     * @memberof CreditCard
     */
    chartOfAccountId?: number | null;
    /**
     * @type {ChartOfAccount}
     * @memberof CreditCard
     */
    chartOfAccount?: ChartOfAccount | null;
    /**
     * @type {number}
     * @memberof CreditCard
     */
    bankId?: number;
    /**
     * @type {Bank}
     * @memberof CreditCard
     */
    bank?: Bank | null;
    /**
     * @type {string}
     * @memberof CreditCard
     */
    bankName?: string | null;
    /**
     * @type {CreditCardType}
     * @memberof CreditCard
     */
    type?: CreditCardType;
    /**
     * @type {string}
     * @memberof CreditCard
     */
    cardNumber?: string | null;
    /**
     * @type {string}
     * @memberof CreditCard
     */
    cardHolderName?: string | null;
    /**
     * @type {string}
     * @memberof CreditCard
     */
    cardName?: string | null;
    /**
     * @type {number}
     * @memberof CreditCard
     */
    cashLimit?: number;
    /**
     * @type {number}
     * @memberof CreditCard
     */
    statementDate?: number;
    /**
     * @type {number}
     * @memberof CreditCard
     */
    dueDate?: number;
    /**
     * @type {BankingChannelsStatus}
     * @memberof CreditCard
     */
    status?: BankingChannelsStatus;
    /**
     * @type {boolean}
     * @memberof CreditCard
     */
    isDelete?: boolean;
    /**
     * @type {string}
     * @memberof CreditCard
     */
    createdOn?: string;
    /**
     * @type {string}
     * @memberof CreditCard
     */
    modifiedOn?: string;
}