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

import { RequestFile } from './models';

export class BatchMessageSent {
    'batchId'?: string | null;
    'documentCount'?: number;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "batchId",
            "baseName": "batchId",
            "type": "string"
        },
        {
            "name": "documentCount",
            "baseName": "documentCount",
            "type": "number"
        }    ];

    static getAttributeTypeMap() {
        return BatchMessageSent.attributeTypeMap;
    }
}
