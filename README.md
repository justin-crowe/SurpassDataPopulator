# SurpassDataPopulator

Application to populate an instance of surpass with data. Used for development purposes.

## Usage

1. Open the appsettings.json and set the "BaseUrl", "Username" and "Password" under the "SurpassApi" section for your Surpass instance
2. Build the app / run it in VS with command line args

## Command line arg options

| Option      | Description | Required | Default Value | 
| ----------- | ----------- | -------- | ------------- |
| -s          | Subject Ref | True | n/a |
| -n          | Number of items | True | n/a |
| --showCorrect | Adds the correct answer to the stem to assist debugging | False | True |
| -c          | A List of category numbers that maps to [Open Trivia](https://opentdb.com/api_config.php). See [IOpenTriviaApi.cs](src\SurpassDataPopulator.Infrastructure\Services\OpenTriviaApi\IOpenTriviaApi.cs). Specifying this will mean the -n parameter is used as a number of items per category.  | False | any | 
| -v          | List of language codes to create items for. | False | n/a |
| -tags          | List of tags to add to each item. Use the format 'name:value' for static name and value tag data | False | n/a |
 
## Command line Verbs

A Verb is an action that you can perform. eg: calling "dotnet build" would use the build verb. The supported verbs are:

### createItems

TODO

### createAdaptiveItems

Creates items to be used in an adaptive test.

Example 1: Creates 500 items of random category in the subject with ref "AS1" and will add all adaptive tags required so that the items can be used in adpative tests.

```console
SurpassDataPopulator.Console.exe createAdaptiveItems -s "AS1" -n 500
```

Example 2: Specify certain category ids, 50 items in each

```console
SurpassDataPopulator.Console.exe createAdaptiveItems -s "AS1" -n 50 -c 9 11 12 15 28 23 22
```

Example 3: Create variants of the items for the two language codes "en" & "we"

```console
SurpassDataPopulator.Console.exe createAdaptiveItems -s "AS1" -n 50 -c 9 11 12 15 28 23 22 --variants en we
```
