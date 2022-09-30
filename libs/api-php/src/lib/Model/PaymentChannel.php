<?php
/**
 * PaymentChannel
 *
 * PHP version 7.3
 *
 * @category Class
 * @package  OpenAPI\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 */

/**
 * FlowAccount Open API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://openapi-generator.tech
 * OpenAPI Generator version: 5.4.0
 */

/**
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

namespace OpenAPI\Client\Model;
use \OpenAPI\Client\ObjectSerializer;

/**
 * PaymentChannel Class Doc Comment
 *
 * @category Class
 * @description 1 &#x3D; Omise 3 &#x3D; InAppIOS 5 &#x3D; InAppAndriod 7 &#x3D; UssdAis 9 &#x3D; BankTranfer 11 &#x3D; PrePaidSerial
 * @package  OpenAPI\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 */
class PaymentChannel
{
    /**
     * Possible values of this enum
     */
    const NUMBER_1 = 1;

    const NUMBER_3 = 3;

    const NUMBER_5 = 5;

    const NUMBER_7 = 7;

    const NUMBER_9 = 9;

    const NUMBER_11 = 11;

    /**
     * Gets allowable values of the enum
     * @return string[]
     */
    public static function getAllowableEnumValues()
    {
        return [
            self::NUMBER_1,
            self::NUMBER_3,
            self::NUMBER_5,
            self::NUMBER_7,
            self::NUMBER_9,
            self::NUMBER_11
        ];
    }
}

