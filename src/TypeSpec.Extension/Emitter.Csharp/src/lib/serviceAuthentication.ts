// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

import { ServiceAuthentication } from "@typespec/http";
import { InputAuth } from "../type/inputAuth.js";
import { logger } from "./logger.js";

export function processServiceAuthentication(
    authentication: ServiceAuthentication
): InputAuth {
    const auth = {} as InputAuth;
    let scopes: Set<string> | undefined;

    for (const option of authentication.options) {
        for (const scheme of option.schemes) {
            switch (scheme.type) {
                case "apiKey":
                    auth.ApiKey = { Name: scheme.name };
                    break;
                case "oauth2":
                    for (const flow of scheme.flows) {
                        if (flow.scopes) {
                            scopes ??= new Set<string>();
                            for (const scope of flow.scopes) {
                                scopes.add(scope.value);
                            }
                        }
                    }
                    break;
                case "http":
                    const schemeOrApiKeyPrefix = scheme.scheme;
                    if (schemeOrApiKeyPrefix === "basic") {
                        logger.warn(
                            `{schemeOrApiKeyPrefix} auth method is currently not supported.`
                        );
                    } else if (schemeOrApiKeyPrefix === "bearer") {
                        auth.ApiKey = {
                            Name: "Authorization",
                            Prefix: "Bearer"
                        };
                    } else {
                        auth.ApiKey = {
                            Name: "Authorization",
                            Prefix: schemeOrApiKeyPrefix
                        };
                    }
                    break;
                default:
                    throw new Error("Not supported authentication.");
            }
        }
    }

    if (scopes) {
        auth.OAuth2 = {
            Scopes: Array.from(scopes.values())
        };
    }

    return auth;
}
