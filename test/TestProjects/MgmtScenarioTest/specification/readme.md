# AppConfiguration

> see https://aka.ms/autorest

This is the AutoRest configuration file for AppConfiguration.

---

## Getting Started

To build the SDK for AppConfiguration, simply [Install AutoRest](https://aka.ms/autorest/install) and in this folder, run:

> `autorest`

To see additional help and options, run:

> `autorest --help`

---

## Configuration

### Basic Information

These are the global settings for the AppConfiguration API.

``` yaml
openapi-type: arm

tag: package-2022-05-01
```

### Tag: package-2022-05-01

These settings apply only when `--tag=2022-05-01` is specified on the command line.

``` yaml $(tag) == 'package-2022-05-01'
input-file:
- appconfiguration.json
test-resources:
  - test: scenarios/basic.yaml
```
