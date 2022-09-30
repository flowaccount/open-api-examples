# # DocumentQuery

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**page_size** | **int** |  | [optional]
**current_page** | **int** |  | [optional]
**total_records** | **int** |  | [optional]
**date_type** | [**\OpenAPI\Client\Model\DateType**](DateType.md) |  | [optional]
**start_date** | **\DateTime** |  | [optional]
**end_date** | **\DateTime** |  | [optional]
**day** | **int** |  | [optional]
**month** | **int** |  | [optional]
**year** | **int** |  | [optional]
**range** | [**\OpenAPI\Client\Model\DataRange**](DataRange.md) |  | [optional]
**is_first_current** | **int** |  | [optional]
**hash_tags** | **string[]** |  | [optional]
**report_type** | [**\OpenAPI\Client\Model\ReportTypes**](ReportTypes.md) |  | [optional]
**filter** | [**\OpenAPI\Client\Model\FilterOptions[]**](FilterOptions.md) |  | [optional]
**sort_by** | [**\OpenAPI\Client\Model\SortOptions[]**](SortOptions.md) |  | [optional]
**total_value** | **float** |  | [optional]
**total_vat** | **float** |  | [optional]
**is_received** | **bool** |  | [optional]
**document_type** | [**\OpenAPI\Client\Model\DocumentTypes[]**](DocumentTypes.md) |  | [optional]
**revenue** | [**\OpenAPI\Client\Model\ListItem[]**](ListItem.md) |  | [optional]
**expenses** | [**\OpenAPI\Client\Model\ListItem[]**](ListItem.md) |  | [optional]
**previous_months** | [**\OpenAPI\Client\Model\ListItem[]**](ListItem.md) |  | [optional]
**previous_years** | [**\OpenAPI\Client\Model\ListItem[]**](ListItem.md) |  | [optional]
**custom_document_models** | [**\OpenAPI\Client\Model\CustomDocumentModel[]**](CustomDocumentModel.md) |  | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)