<?php
/**
 * OtherChannels
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

use \ArrayAccess;
use \OpenAPI\Client\ObjectSerializer;

/**
 * OtherChannels Class Doc Comment
 *
 * @category Class
 * @package  OpenAPI\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 * @implements \ArrayAccess<TKey, TValue>
 * @template TKey int|null
 * @template TValue mixed|null
 */
class OtherChannels implements ModelInterface, ArrayAccess, \JsonSerializable
{
    public const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $openAPIModelName = 'OtherChannels';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $openAPITypes = [
        'id' => 'int',
        'company_id' => 'int',
        'chart_of_account_id' => 'int',
        'chart_of_account' => 'OneOfChartOfAccount',
        'name' => 'string',
        'status' => '\OpenAPI\Client\Model\BankingChannelsStatus',
        'channel' => '\OpenAPI\Client\Model\PaymentChannelsType',
        'type' => '\OpenAPI\Client\Model\OtherChannelsType',
        'description' => 'string',
        'bank_id' => 'int',
        'bank' => 'OneOfBank',
        'bank_name' => 'string',
        'created_on' => '\DateTime',
        'modified_on' => '\DateTime',
        'is_delete' => 'bool'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      * @phpstan-var array<string, string|null>
      * @psalm-var array<string, string|null>
      */
    protected static $openAPIFormats = [
        'id' => 'int64',
        'company_id' => 'int64',
        'chart_of_account_id' => 'int64',
        'chart_of_account' => null,
        'name' => null,
        'status' => null,
        'channel' => null,
        'type' => null,
        'description' => null,
        'bank_id' => 'int32',
        'bank' => null,
        'bank_name' => null,
        'created_on' => 'date-time',
        'modified_on' => 'date-time',
        'is_delete' => null
    ];

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPITypes()
    {
        return self::$openAPITypes;
    }

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPIFormats()
    {
        return self::$openAPIFormats;
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'id' => 'id',
        'company_id' => 'companyId',
        'chart_of_account_id' => 'chartOfAccountId',
        'chart_of_account' => 'chartOfAccount',
        'name' => 'name',
        'status' => 'status',
        'channel' => 'channel',
        'type' => 'type',
        'description' => 'description',
        'bank_id' => 'bankId',
        'bank' => 'bank',
        'bank_name' => 'bankName',
        'created_on' => 'createdOn',
        'modified_on' => 'modifiedOn',
        'is_delete' => 'isDelete'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'id' => 'setId',
        'company_id' => 'setCompanyId',
        'chart_of_account_id' => 'setChartOfAccountId',
        'chart_of_account' => 'setChartOfAccount',
        'name' => 'setName',
        'status' => 'setStatus',
        'channel' => 'setChannel',
        'type' => 'setType',
        'description' => 'setDescription',
        'bank_id' => 'setBankId',
        'bank' => 'setBank',
        'bank_name' => 'setBankName',
        'created_on' => 'setCreatedOn',
        'modified_on' => 'setModifiedOn',
        'is_delete' => 'setIsDelete'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'id' => 'getId',
        'company_id' => 'getCompanyId',
        'chart_of_account_id' => 'getChartOfAccountId',
        'chart_of_account' => 'getChartOfAccount',
        'name' => 'getName',
        'status' => 'getStatus',
        'channel' => 'getChannel',
        'type' => 'getType',
        'description' => 'getDescription',
        'bank_id' => 'getBankId',
        'bank' => 'getBank',
        'bank_name' => 'getBankName',
        'created_on' => 'getCreatedOn',
        'modified_on' => 'getModifiedOn',
        'is_delete' => 'getIsDelete'
    ];

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @return array
     */
    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @return array
     */
    public static function setters()
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @return array
     */
    public static function getters()
    {
        return self::$getters;
    }

    /**
     * The original name of the model.
     *
     * @return string
     */
    public function getModelName()
    {
        return self::$openAPIModelName;
    }


    /**
     * Associative array for storing property values
     *
     * @var mixed[]
     */
    protected $container = [];

    /**
     * Constructor
     *
     * @param mixed[] $data Associated array of property values
     *                      initializing the model
     */
    public function __construct(array $data = null)
    {
        $this->container['id'] = $data['id'] ?? null;
        $this->container['company_id'] = $data['company_id'] ?? null;
        $this->container['chart_of_account_id'] = $data['chart_of_account_id'] ?? null;
        $this->container['chart_of_account'] = $data['chart_of_account'] ?? null;
        $this->container['name'] = $data['name'] ?? null;
        $this->container['status'] = $data['status'] ?? null;
        $this->container['channel'] = $data['channel'] ?? null;
        $this->container['type'] = $data['type'] ?? null;
        $this->container['description'] = $data['description'] ?? null;
        $this->container['bank_id'] = $data['bank_id'] ?? null;
        $this->container['bank'] = $data['bank'] ?? null;
        $this->container['bank_name'] = $data['bank_name'] ?? null;
        $this->container['created_on'] = $data['created_on'] ?? null;
        $this->container['modified_on'] = $data['modified_on'] ?? null;
        $this->container['is_delete'] = $data['is_delete'] ?? false;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['company_id'] === null) {
            $invalidProperties[] = "'company_id' can't be null";
        }
        return $invalidProperties;
    }

    /**
     * Validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {
        return count($this->listInvalidProperties()) === 0;
    }


    /**
     * Gets id
     *
     * @return int|null
     */
    public function getId()
    {
        return $this->container['id'];
    }

    /**
     * Sets id
     *
     * @param int|null $id id
     *
     * @return self
     */
    public function setId($id)
    {
        $this->container['id'] = $id;

        return $this;
    }

    /**
     * Gets company_id
     *
     * @return int
     */
    public function getCompanyId()
    {
        return $this->container['company_id'];
    }

    /**
     * Sets company_id
     *
     * @param int $company_id company_id
     *
     * @return self
     */
    public function setCompanyId($company_id)
    {
        $this->container['company_id'] = $company_id;

        return $this;
    }

    /**
     * Gets chart_of_account_id
     *
     * @return int|null
     */
    public function getChartOfAccountId()
    {
        return $this->container['chart_of_account_id'];
    }

    /**
     * Sets chart_of_account_id
     *
     * @param int|null $chart_of_account_id chart_of_account_id
     *
     * @return self
     */
    public function setChartOfAccountId($chart_of_account_id)
    {
        $this->container['chart_of_account_id'] = $chart_of_account_id;

        return $this;
    }

    /**
     * Gets chart_of_account
     *
     * @return OneOfChartOfAccount|null
     */
    public function getChartOfAccount()
    {
        return $this->container['chart_of_account'];
    }

    /**
     * Sets chart_of_account
     *
     * @param OneOfChartOfAccount|null $chart_of_account chart_of_account
     *
     * @return self
     */
    public function setChartOfAccount($chart_of_account)
    {
        $this->container['chart_of_account'] = $chart_of_account;

        return $this;
    }

    /**
     * Gets name
     *
     * @return string|null
     */
    public function getName()
    {
        return $this->container['name'];
    }

    /**
     * Sets name
     *
     * @param string|null $name name
     *
     * @return self
     */
    public function setName($name)
    {
        $this->container['name'] = $name;

        return $this;
    }

    /**
     * Gets status
     *
     * @return \OpenAPI\Client\Model\BankingChannelsStatus|null
     */
    public function getStatus()
    {
        return $this->container['status'];
    }

    /**
     * Sets status
     *
     * @param \OpenAPI\Client\Model\BankingChannelsStatus|null $status status
     *
     * @return self
     */
    public function setStatus($status)
    {
        $this->container['status'] = $status;

        return $this;
    }

    /**
     * Gets channel
     *
     * @return \OpenAPI\Client\Model\PaymentChannelsType|null
     */
    public function getChannel()
    {
        return $this->container['channel'];
    }

    /**
     * Sets channel
     *
     * @param \OpenAPI\Client\Model\PaymentChannelsType|null $channel channel
     *
     * @return self
     */
    public function setChannel($channel)
    {
        $this->container['channel'] = $channel;

        return $this;
    }

    /**
     * Gets type
     *
     * @return \OpenAPI\Client\Model\OtherChannelsType|null
     */
    public function getType()
    {
        return $this->container['type'];
    }

    /**
     * Sets type
     *
     * @param \OpenAPI\Client\Model\OtherChannelsType|null $type type
     *
     * @return self
     */
    public function setType($type)
    {
        $this->container['type'] = $type;

        return $this;
    }

    /**
     * Gets description
     *
     * @return string|null
     */
    public function getDescription()
    {
        return $this->container['description'];
    }

    /**
     * Sets description
     *
     * @param string|null $description description
     *
     * @return self
     */
    public function setDescription($description)
    {
        $this->container['description'] = $description;

        return $this;
    }

    /**
     * Gets bank_id
     *
     * @return int|null
     */
    public function getBankId()
    {
        return $this->container['bank_id'];
    }

    /**
     * Sets bank_id
     *
     * @param int|null $bank_id bank_id
     *
     * @return self
     */
    public function setBankId($bank_id)
    {
        $this->container['bank_id'] = $bank_id;

        return $this;
    }

    /**
     * Gets bank
     *
     * @return OneOfBank|null
     */
    public function getBank()
    {
        return $this->container['bank'];
    }

    /**
     * Sets bank
     *
     * @param OneOfBank|null $bank bank
     *
     * @return self
     */
    public function setBank($bank)
    {
        $this->container['bank'] = $bank;

        return $this;
    }

    /**
     * Gets bank_name
     *
     * @return string|null
     */
    public function getBankName()
    {
        return $this->container['bank_name'];
    }

    /**
     * Sets bank_name
     *
     * @param string|null $bank_name bank_name
     *
     * @return self
     */
    public function setBankName($bank_name)
    {
        $this->container['bank_name'] = $bank_name;

        return $this;
    }

    /**
     * Gets created_on
     *
     * @return \DateTime|null
     */
    public function getCreatedOn()
    {
        return $this->container['created_on'];
    }

    /**
     * Sets created_on
     *
     * @param \DateTime|null $created_on created_on
     *
     * @return self
     */
    public function setCreatedOn($created_on)
    {
        $this->container['created_on'] = $created_on;

        return $this;
    }

    /**
     * Gets modified_on
     *
     * @return \DateTime|null
     */
    public function getModifiedOn()
    {
        return $this->container['modified_on'];
    }

    /**
     * Sets modified_on
     *
     * @param \DateTime|null $modified_on modified_on
     *
     * @return self
     */
    public function setModifiedOn($modified_on)
    {
        $this->container['modified_on'] = $modified_on;

        return $this;
    }

    /**
     * Gets is_delete
     *
     * @return bool|null
     */
    public function getIsDelete()
    {
        return $this->container['is_delete'];
    }

    /**
     * Sets is_delete
     *
     * @param bool|null $is_delete is_delete
     *
     * @return self
     */
    public function setIsDelete($is_delete)
    {
        $this->container['is_delete'] = $is_delete;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param integer $offset Offset
     *
     * @return boolean
     */
    public function offsetExists($offset)
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     *
     * @param integer $offset Offset
     *
     * @return mixed|null
     */
    public function offsetGet($offset)
    {
        return $this->container[$offset] ?? null;
    }

    /**
     * Sets value based on offset.
     *
     * @param int|null $offset Offset
     * @param mixed    $value  Value to be set
     *
     * @return void
     */
    public function offsetSet($offset, $value)
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     *
     * @param integer $offset Offset
     *
     * @return void
     */
    public function offsetUnset($offset)
    {
        unset($this->container[$offset]);
    }

    /**
     * Serializes the object to a value that can be serialized natively by json_encode().
     * @link https://www.php.net/manual/en/jsonserializable.jsonserialize.php
     *
     * @return mixed Returns data which can be serialized by json_encode(), which is a value
     * of any type other than a resource.
     */
    public function jsonSerialize()
    {
       return ObjectSerializer::sanitizeForSerialization($this);
    }

    /**
     * Gets the string presentation of the object
     *
     * @return string
     */
    public function __toString()
    {
        return json_encode(
            ObjectSerializer::sanitizeForSerialization($this),
            JSON_PRETTY_PRINT
        );
    }

    /**
     * Gets a header-safe presentation of the object
     *
     * @return string
     */
    public function toHeaderValue()
    {
        return json_encode(ObjectSerializer::sanitizeForSerialization($this));
    }
}

