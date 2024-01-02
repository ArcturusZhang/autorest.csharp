// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;
using MgmtDiscriminator;

namespace MgmtDiscriminator.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmMgmtDiscriminatorModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="MgmtDiscriminator.DeliveryRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The properties. </param>
        /// <returns> A new <see cref="MgmtDiscriminator.DeliveryRuleData"/> instance for mocking. </returns>
        public static DeliveryRuleData DeliveryRuleData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DeliveryRuleProperties properties = null)
        {
            return new DeliveryRuleData(id, name, resourceType, systemData, properties, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DeliveryRuleProperties"/>. </summary>
        /// <param name="order"> The order in which the rules are applied for the endpoint. Possible values {0,1,2,3,………}. A rule with a lesser order will be applied before a rule with a greater order. Rule with order 0 is a special rule. It does not require any condition and actions listed in it will always be applied. </param>
        /// <param name="conditions">
        /// The condition that must be matched for the actions to be executed
        /// Please note <see cref="Models.DeliveryRuleCondition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Models.DeliveryRuleQueryStringCondition"/>, <see cref="Models.DeliveryRuleRemoteAddressCondition"/> and <see cref="Models.DeliveryRuleRequestMethodCondition"/>.
        /// </param>
        /// <param name="actions">
        /// A list of actions that are executed when all the conditions of a rule are satisfied.
        /// Please note <see cref="Models.DeliveryRuleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Models.DeliveryRuleCacheExpirationAction"/>, <see cref="Models.DeliveryRuleCacheKeyQueryStringAction"/>, <see cref="Models.DeliveryRuleRequestHeaderAction"/>, <see cref="Models.DeliveryRuleResponseHeaderAction"/>, <see cref="Models.OriginGroupOverrideAction"/>, <see cref="Models.DeliveryRuleRouteConfigurationOverrideAction"/>, <see cref="Models.UrlRedirectAction"/>, <see cref="Models.UrlRewriteAction"/> and <see cref="Models.UrlSigningAction"/>.
        /// </param>
        /// <param name="extraMappingInfo">
        /// A dictionary of mapping details about the actions that are executed when all the conditions of a rule are satisfied.
        /// Please note <see cref="Models.DeliveryRuleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Models.DeliveryRuleCacheExpirationAction"/>, <see cref="Models.DeliveryRuleCacheKeyQueryStringAction"/>, <see cref="Models.DeliveryRuleRequestHeaderAction"/>, <see cref="Models.DeliveryRuleResponseHeaderAction"/>, <see cref="Models.OriginGroupOverrideAction"/>, <see cref="Models.DeliveryRuleRouteConfigurationOverrideAction"/>, <see cref="Models.UrlRedirectAction"/>, <see cref="Models.UrlRewriteAction"/> and <see cref="Models.UrlSigningAction"/>.
        /// </param>
        /// <param name="pet">
        /// A pet
        /// Please note <see cref="Models.Pet"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Models.Cat"/> and <see cref="Models.Dog"/>.
        /// </param>
        /// <param name="foo"> put a readonly property here so that this model will show up in the model factory. </param>
        /// <returns> A new <see cref="Models.DeliveryRuleProperties"/> instance for mocking. </returns>
        public static DeliveryRuleProperties DeliveryRuleProperties(int? order = null, DeliveryRuleCondition conditions = null, IEnumerable<DeliveryRuleAction> actions = null, IDictionary<string, DeliveryRuleAction> extraMappingInfo = null, Pet pet = null, string foo = null)
        {
            actions ??= new List<DeliveryRuleAction>();
            extraMappingInfo ??= new Dictionary<string, DeliveryRuleAction>();

            return new DeliveryRuleProperties(order, conditions, actions?.ToList(), extraMappingInfo, pet, foo, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DeliveryRuleCondition"/>. </summary>
        /// <param name="name"> The name of the condition for the delivery rule. </param>
        /// <param name="foo"> For test. </param>
        /// <returns> A new <see cref="Models.DeliveryRuleCondition"/> instance for mocking. </returns>
        public static DeliveryRuleCondition DeliveryRuleCondition(string name = "Unknown", string foo = null)
        {
            return new UnknownDeliveryRuleCondition(name, foo, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DeliveryRuleAction"/>. </summary>
        /// <param name="name"> The name of the action for the delivery rule. </param>
        /// <param name="foo"> for test. </param>
        /// <returns> A new <see cref="Models.DeliveryRuleAction"/> instance for mocking. </returns>
        public static DeliveryRuleAction DeliveryRuleAction(string name = "Unknown", string foo = null)
        {
            return new DeliveryRuleAction(name, foo, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.Pet"/>. </summary>
        /// <param name="id"> The Id of the pet. </param>
        /// <returns> A new <see cref="Models.Pet"/> instance for mocking. </returns>
        public static Pet Pet(string id = null)
        {
            return new UnknownPet(default, id, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.Cat"/>. </summary>
        /// <param name="id"> The Id of the pet. </param>
        /// <param name="meow"> A cat can meow. </param>
        /// <returns> A new <see cref="Models.Cat"/> instance for mocking. </returns>
        public static Cat Cat(string id = null, string meow = null)
        {
            return new Cat(PetKind.Cat, id, serializedAdditionalRawData: null, meow);
        }

        /// <summary> Initializes a new instance of <see cref="Models.Dog"/>. </summary>
        /// <param name="id"> The Id of the pet. </param>
        /// <param name="bark"> A dog can bark. </param>
        /// <returns> A new <see cref="Models.Dog"/> instance for mocking. </returns>
        public static Dog Dog(string id = null, string bark = null)
        {
            return new Dog(PetKind.Dog, id, serializedAdditionalRawData: null, bark);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DeliveryRuleRemoteAddressCondition"/>. </summary>
        /// <param name="foo"> For test. </param>
        /// <param name="parameters"> Defines the parameters for the condition. </param>
        /// <returns> A new <see cref="Models.DeliveryRuleRemoteAddressCondition"/> instance for mocking. </returns>
        public static DeliveryRuleRemoteAddressCondition DeliveryRuleRemoteAddressCondition(string foo = null, RemoteAddressMatchConditionParameters parameters = null)
        {
            return new DeliveryRuleRemoteAddressCondition(MatchVariable.RemoteAddress, foo, serializedAdditionalRawData: null, parameters);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DeliveryRuleRequestMethodCondition"/>. </summary>
        /// <param name="foo"> For test. </param>
        /// <param name="parameters"> Defines the parameters for the condition. </param>
        /// <returns> A new <see cref="Models.DeliveryRuleRequestMethodCondition"/> instance for mocking. </returns>
        public static DeliveryRuleRequestMethodCondition DeliveryRuleRequestMethodCondition(string foo = null, RequestMethodMatchConditionParameters parameters = null)
        {
            return new DeliveryRuleRequestMethodCondition(MatchVariable.RequestMethod, foo, serializedAdditionalRawData: null, parameters);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DeliveryRuleQueryStringCondition"/>. </summary>
        /// <param name="foo"> For test. </param>
        /// <param name="parameters"> Defines the parameters for the condition. </param>
        /// <returns> A new <see cref="Models.DeliveryRuleQueryStringCondition"/> instance for mocking. </returns>
        public static DeliveryRuleQueryStringCondition DeliveryRuleQueryStringCondition(string foo = null, QueryStringMatchConditionParameters parameters = null)
        {
            return new DeliveryRuleQueryStringCondition(MatchVariable.QueryString, foo, serializedAdditionalRawData: null, parameters);
        }

        /// <summary> Initializes a new instance of <see cref="Models.UrlRedirectAction"/>. </summary>
        /// <param name="foo"> for test. </param>
        /// <param name="parameters"> Defines the parameters for the action. </param>
        /// <returns> A new <see cref="Models.UrlRedirectAction"/> instance for mocking. </returns>
        public static UrlRedirectAction UrlRedirectAction(string foo = null, UrlRedirectActionParameters parameters = null)
        {
            return new UrlRedirectAction(DeliveryRuleActionType.UrlRedirect, foo, serializedAdditionalRawData: null, parameters);
        }

        /// <summary> Initializes a new instance of <see cref="Models.UrlSigningAction"/>. </summary>
        /// <param name="foo"> for test. </param>
        /// <param name="parameters"> Defines the parameters for the action. </param>
        /// <returns> A new <see cref="Models.UrlSigningAction"/> instance for mocking. </returns>
        public static UrlSigningAction UrlSigningAction(string foo = null, UrlSigningActionParameters parameters = null)
        {
            return new UrlSigningAction(DeliveryRuleActionType.UrlSigning, foo, serializedAdditionalRawData: null, parameters);
        }

        /// <summary> Initializes a new instance of <see cref="Models.OriginGroupOverrideAction"/>. </summary>
        /// <param name="foo"> for test. </param>
        /// <param name="parameters"> Defines the parameters for the action. </param>
        /// <returns> A new <see cref="Models.OriginGroupOverrideAction"/> instance for mocking. </returns>
        public static OriginGroupOverrideAction OriginGroupOverrideAction(string foo = null, OriginGroupOverrideActionParameters parameters = null)
        {
            return new OriginGroupOverrideAction(DeliveryRuleActionType.OriginGroupOverride, foo, serializedAdditionalRawData: null, parameters);
        }

        /// <summary> Initializes a new instance of <see cref="Models.UrlRewriteAction"/>. </summary>
        /// <param name="foo"> for test. </param>
        /// <param name="parameters"> Defines the parameters for the action. </param>
        /// <returns> A new <see cref="Models.UrlRewriteAction"/> instance for mocking. </returns>
        public static UrlRewriteAction UrlRewriteAction(string foo = null, UrlRewriteActionParameters parameters = null)
        {
            return new UrlRewriteAction(DeliveryRuleActionType.UrlRewrite, foo, serializedAdditionalRawData: null, parameters);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DeliveryRuleRequestHeaderAction"/>. </summary>
        /// <param name="foo"> for test. </param>
        /// <param name="parameters"> Defines the parameters for the action. </param>
        /// <returns> A new <see cref="Models.DeliveryRuleRequestHeaderAction"/> instance for mocking. </returns>
        public static DeliveryRuleRequestHeaderAction DeliveryRuleRequestHeaderAction(string foo = null, HeaderActionParameters parameters = null)
        {
            return new DeliveryRuleRequestHeaderAction(DeliveryRuleActionType.ModifyRequestHeader, foo, serializedAdditionalRawData: null, parameters);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DeliveryRuleResponseHeaderAction"/>. </summary>
        /// <param name="foo"> for test. </param>
        /// <param name="parameters"> Defines the parameters for the action. </param>
        /// <returns> A new <see cref="Models.DeliveryRuleResponseHeaderAction"/> instance for mocking. </returns>
        public static DeliveryRuleResponseHeaderAction DeliveryRuleResponseHeaderAction(string foo = null, HeaderActionParameters parameters = null)
        {
            return new DeliveryRuleResponseHeaderAction(DeliveryRuleActionType.ModifyResponseHeader, foo, serializedAdditionalRawData: null, parameters);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DeliveryRuleCacheExpirationAction"/>. </summary>
        /// <param name="foo"> for test. </param>
        /// <param name="parameters"> Defines the parameters for the action. </param>
        /// <returns> A new <see cref="Models.DeliveryRuleCacheExpirationAction"/> instance for mocking. </returns>
        public static DeliveryRuleCacheExpirationAction DeliveryRuleCacheExpirationAction(string foo = null, CacheExpirationActionParameters parameters = null)
        {
            return new DeliveryRuleCacheExpirationAction(DeliveryRuleActionType.CacheExpiration, foo, serializedAdditionalRawData: null, parameters);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DeliveryRuleCacheKeyQueryStringAction"/>. </summary>
        /// <param name="foo"> for test. </param>
        /// <param name="parameters"> Defines the parameters for the action. </param>
        /// <returns> A new <see cref="Models.DeliveryRuleCacheKeyQueryStringAction"/> instance for mocking. </returns>
        public static DeliveryRuleCacheKeyQueryStringAction DeliveryRuleCacheKeyQueryStringAction(string foo = null, CacheKeyQueryStringActionParameters parameters = null)
        {
            return new DeliveryRuleCacheKeyQueryStringAction(DeliveryRuleActionType.CacheKeyQueryString, foo, serializedAdditionalRawData: null, parameters);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DeliveryRuleRouteConfigurationOverrideAction"/>. </summary>
        /// <param name="foo"> for test. </param>
        /// <param name="parameters"> Defines the parameters for the action. </param>
        /// <returns> A new <see cref="Models.DeliveryRuleRouteConfigurationOverrideAction"/> instance for mocking. </returns>
        public static DeliveryRuleRouteConfigurationOverrideAction DeliveryRuleRouteConfigurationOverrideAction(string foo = null, RouteConfigurationOverrideActionParameters parameters = null)
        {
            return new DeliveryRuleRouteConfigurationOverrideAction(DeliveryRuleActionType.RouteConfigurationOverride, foo, serializedAdditionalRawData: null, parameters);
        }
    }
}
