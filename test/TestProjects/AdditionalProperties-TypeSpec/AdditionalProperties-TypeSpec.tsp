import "@typespec/rest";
import "@typespec/http";
import "@typespec/versioning";
import "@azure-tools/typespec-client-generator-core";

using TypeSpec.Rest;
using TypeSpec.Http;
using Azure.ClientGenerator.Core;
using TypeSpec.Versioning;

@service({
    title: "additional properties",
    version: "0.1.0",
})
@doc("This is a sample typespec project for additional properties.")
@server(
    "{endpoint}",
    "Endpoint Service",
    {
        endpoint: string,
    }
)
@useAuth(
    OAuth2Auth<[AuthFlow]> | ApiKeyAuth<ApiKeyLocation.header, "x-ms-api-key">
)
namespace AdditionalPropertiesInTypeSpec;

@doc("The auth flow model")
model AuthFlow {
    type: OAuth2FlowType.clientCredentials;
    tokenUrl: "https://api.example.com/oauth2/token";
    refreshUrl: "https://api.example.com/oauth2/refresh";
    scopes: ["https://api.example.com/.default"];
}

model InputIsAdditionalProperties is Record<unknown> {
    @doc("The foo property")
    foo: string;

    @doc("The bar property")
    bar?: string;
}

model InputExtendsAdditionalProperties extends Record<unknown> {
    @doc("The foo property")
    foo: string;

    @doc("The bar property")
    bar?: string;
}

@post
@route("/doInputIsAdditionalProperties")
@summary("Uses a model with additional properties as an input")
@convenientAPI(true)
op DoInputIsAdditionalProperties(@body body: InputIsAdditionalProperties): void;

@post
@route("/doInputExtendsAdditionalProperties")
@summary("Uses a model with additional properties as an input")
@convenientAPI(true)
op DoInputExtendsAdditionalProperties(@body body: InputExtendsAdditionalProperties): void;
