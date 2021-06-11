// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using CognitiveSearch.Models;

namespace CognitiveSearch
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class CognitiveServicesModelFactory
    {
        /// <summary> Initializes new instance of SearchDocumentsResult class. </summary>
        /// <param name="count"> The total count of results found by the search operation, or null if the count was not requested. If present, the count may be greater than the number of results in this response. This can happen if you use the $top or $skip parameters, or if Azure Cognitive Search can&apos;t return all the requested documents in a single Search response. </param>
        /// <param name="coverage"> A value indicating the percentage of the index that was included in the query, or null if minimumCoverage was not specified in the request. </param>
        /// <param name="facets"> The facet query results for the search operation, organized as a collection of buckets for each faceted field; null if the query did not include any facet expressions. </param>
        /// <param name="nextPageParameters"> Continuation JSON payload returned when Azure Cognitive Search can&apos;t return all the requested results in a single Search response. You can use this JSON along with @odata.nextLink to formulate another POST Search request to get the next part of the search response. </param>
        /// <param name="results"> The sequence of results returned by the query. </param>
        /// <param name="nextLink"> Continuation URL returned when Azure Cognitive Search can&apos;t return all the requested results in a single Search response. You can use this URL to formulate another GET or POST Search request to get the next part of the search response. Make sure to use the same verb (GET or POST) as the request that produced this response. </param>
        /// <returns> A new <see cref="Models.SearchDocumentsResult"/> instance for mocking. </returns>
        public static SearchDocumentsResult SearchDocumentsResult(long? count = default, double? coverage = default, IReadOnlyDictionary<string, IList<FacetResult>> facets = default, SearchRequest nextPageParameters = default, IReadOnlyList<SearchResult> results = default, string nextLink = default)
        {
            facets ??= new Dictionary<string, IList<FacetResult>>();
            results ??= new List<SearchResult>();
            return new SearchDocumentsResult(count, coverage, facets, nextPageParameters, results, nextLink);
        }

        /// <summary> Initializes new instance of FacetResult class. </summary>
        /// <param name="count"> The approximate count of documents falling within the bucket described by this facet. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <returns> A new <see cref="Models.FacetResult"/> instance for mocking. </returns>
        public static FacetResult FacetResult(long? count = default, IReadOnlyDictionary<string, object> additionalProperties = default)
        {
            additionalProperties ??= new Dictionary<string, object>();
            return new FacetResult(count, additionalProperties);
        }

        /// <summary> Initializes new instance of SearchResult class. </summary>
        /// <param name="score"> The relevance score of the document compared to other documents returned by the query. </param>
        /// <param name="highlights"> Text fragments from the document that indicate the matching search terms, organized by each applicable field; null if hit highlighting was not enabled for the query. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <returns> A new <see cref="Models.SearchResult"/> instance for mocking. </returns>
        public static SearchResult SearchResult(double score = default, IReadOnlyDictionary<string, IList<string>> highlights = default, IReadOnlyDictionary<string, object> additionalProperties = default)
        {
            highlights ??= new Dictionary<string, IList<string>>();
            additionalProperties ??= new Dictionary<string, object>();
            return new SearchResult(score, highlights, additionalProperties);
        }

        /// <summary> Initializes new instance of SuggestDocumentsResult class. </summary>
        /// <param name="results"> The sequence of results returned by the query. </param>
        /// <param name="coverage"> A value indicating the percentage of the index that was included in the query, or null if minimumCoverage was not set in the request. </param>
        /// <returns> A new <see cref="Models.SuggestDocumentsResult"/> instance for mocking. </returns>
        public static SuggestDocumentsResult SuggestDocumentsResult(IReadOnlyList<SuggestResult> results = default, double? coverage = default)
        {
            results ??= new List<SuggestResult>();
            return new SuggestDocumentsResult(results, coverage);
        }

        /// <summary> Initializes new instance of SuggestResult class. </summary>
        /// <param name="text"> The text of the suggestion result. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <returns> A new <see cref="Models.SuggestResult"/> instance for mocking. </returns>
        public static SuggestResult SuggestResult(string text = default, IReadOnlyDictionary<string, object> additionalProperties = default)
        {
            additionalProperties ??= new Dictionary<string, object>();
            return new SuggestResult(text, additionalProperties);
        }

        /// <summary> Initializes new instance of IndexDocumentsResult class. </summary>
        /// <param name="results"> The list of status information for each document in the indexing request. </param>
        /// <returns> A new <see cref="Models.IndexDocumentsResult"/> instance for mocking. </returns>
        public static IndexDocumentsResult IndexDocumentsResult(IReadOnlyList<IndexingResult> results = default)
        {
            results ??= new List<IndexingResult>();
            return new IndexDocumentsResult(results);
        }

        /// <summary> Initializes new instance of IndexingResult class. </summary>
        /// <param name="key"> The key of a document that was in the indexing request. </param>
        /// <param name="errorMessage"> The error message explaining why the indexing operation failed for the document identified by the key; null if indexing succeeded. </param>
        /// <param name="succeeded"> A value indicating whether the indexing operation succeeded for the document identified by the key. </param>
        /// <param name="statusCode"> The status code of the indexing operation. Possible values include: 200 for a successful update or delete, 201 for successful document creation, 400 for a malformed input document, 404 for document not found, 409 for a version conflict, 422 when the index is temporarily unavailable, or 503 for when the service is too busy. </param>
        /// <returns> A new <see cref="Models.IndexingResult"/> instance for mocking. </returns>
        public static IndexingResult IndexingResult(string key = default, string errorMessage = default, bool succeeded = default, int statusCode = default)
        {
            return new IndexingResult(key, errorMessage, succeeded, statusCode);
        }

        /// <summary> Initializes new instance of AutocompleteResult class. </summary>
        /// <param name="coverage"> A value indicating the percentage of the index that was considered by the autocomplete request, or null if minimumCoverage was not specified in the request. </param>
        /// <param name="results"> The list of returned Autocompleted items. </param>
        /// <returns> A new <see cref="Models.AutocompleteResult"/> instance for mocking. </returns>
        public static AutocompleteResult AutocompleteResult(double? coverage = default, IReadOnlyList<AutocompleteItem> results = default)
        {
            results ??= new List<AutocompleteItem>();
            return new AutocompleteResult(coverage, results);
        }

        /// <summary> Initializes new instance of AutocompleteItem class. </summary>
        /// <param name="text"> The completed term. </param>
        /// <param name="queryPlusText"> The query along with the completed term. </param>
        /// <returns> A new <see cref="Models.AutocompleteItem"/> instance for mocking. </returns>
        public static AutocompleteItem AutocompleteItem(string text = default, string queryPlusText = default)
        {
            return new AutocompleteItem(text, queryPlusText);
        }

        /// <summary> Initializes new instance of ListDataSourcesResult class. </summary>
        /// <param name="dataSources"> The datasources in the Search service. </param>
        /// <returns> A new <see cref="Models.ListDataSourcesResult"/> instance for mocking. </returns>
        public static ListDataSourcesResult ListDataSourcesResult(IReadOnlyList<DataSource> dataSources = default)
        {
            dataSources ??= new List<DataSource>();
            return new ListDataSourcesResult(dataSources);
        }

        /// <summary> Initializes new instance of ListIndexersResult class. </summary>
        /// <param name="indexers"> The indexers in the Search service. </param>
        /// <returns> A new <see cref="Models.ListIndexersResult"/> instance for mocking. </returns>
        public static ListIndexersResult ListIndexersResult(IReadOnlyList<Indexer> indexers = default)
        {
            indexers ??= new List<Indexer>();
            return new ListIndexersResult(indexers);
        }

        /// <summary> Initializes new instance of IndexerExecutionInfo class. </summary>
        /// <param name="status"> Overall indexer status. </param>
        /// <param name="lastResult"> The result of the most recent or an in-progress indexer execution. </param>
        /// <param name="executionHistory"> History of the recent indexer executions, sorted in reverse chronological order. </param>
        /// <param name="limits"> The execution limits for the indexer. </param>
        /// <returns> A new <see cref="Models.IndexerExecutionInfo"/> instance for mocking. </returns>
        public static IndexerExecutionInfo IndexerExecutionInfo(IndexerStatus status = default, IndexerExecutionResult lastResult = default, IReadOnlyList<IndexerExecutionResult> executionHistory = default, IndexerLimits limits = default)
        {
            executionHistory ??= new List<IndexerExecutionResult>();
            return new IndexerExecutionInfo(status, lastResult, executionHistory, limits);
        }

        /// <summary> Initializes new instance of IndexerExecutionResult class. </summary>
        /// <param name="status"> The outcome of this indexer execution. </param>
        /// <param name="errorMessage"> The error message indicating the top-level error, if any. </param>
        /// <param name="startTime"> The start time of this indexer execution. </param>
        /// <param name="endTime"> The end time of this indexer execution, if the execution has already completed. </param>
        /// <param name="errors"> The item-level indexing errors. </param>
        /// <param name="warnings"> The item-level indexing warnings. </param>
        /// <param name="itemCount"> The number of items that were processed during this indexer execution. This includes both successfully processed items and items where indexing was attempted but failed. </param>
        /// <param name="failedItemCount"> The number of items that failed to be indexed during this indexer execution. </param>
        /// <param name="initialTrackingState"> Change tracking state with which an indexer execution started. </param>
        /// <param name="finalTrackingState"> Change tracking state with which an indexer execution finished. </param>
        /// <returns> A new <see cref="Models.IndexerExecutionResult"/> instance for mocking. </returns>
        public static IndexerExecutionResult IndexerExecutionResult(IndexerExecutionStatus status = default, string errorMessage = default, DateTimeOffset? startTime = default, DateTimeOffset? endTime = default, IReadOnlyList<ItemError> errors = default, IReadOnlyList<ItemWarning> warnings = default, int itemCount = default, int failedItemCount = default, string initialTrackingState = default, string finalTrackingState = default)
        {
            errors ??= new List<ItemError>();
            warnings ??= new List<ItemWarning>();
            return new IndexerExecutionResult(status, errorMessage, startTime, endTime, errors, warnings, itemCount, failedItemCount, initialTrackingState, finalTrackingState);
        }

        /// <summary> Initializes new instance of ItemError class. </summary>
        /// <param name="key"> The key of the item for which indexing failed. </param>
        /// <param name="errorMessage"> The message describing the error that occurred while processing the item. </param>
        /// <param name="statusCode"> The status code indicating why the indexing operation failed. Possible values include: 400 for a malformed input document, 404 for document not found, 409 for a version conflict, 422 when the index is temporarily unavailable, or 503 for when the service is too busy. </param>
        /// <param name="name"> The name of the source at which the error originated. For example, this could refer to a particular skill in the attached skillset. This may not be always available. </param>
        /// <param name="details"> Additional, verbose details about the error to assist in debugging the indexer. This may not be always available. </param>
        /// <param name="documentationLink"> A link to a troubleshooting guide for these classes of errors. This may not be always available. </param>
        /// <returns> A new <see cref="Models.ItemError"/> instance for mocking. </returns>
        public static ItemError ItemError(string key = default, string errorMessage = default, int statusCode = default, string name = default, string details = default, string documentationLink = default)
        {
            return new ItemError(key, errorMessage, statusCode, name, details, documentationLink);
        }

        /// <summary> Initializes new instance of ItemWarning class. </summary>
        /// <param name="key"> The key of the item which generated a warning. </param>
        /// <param name="message"> The message describing the warning that occurred while processing the item. </param>
        /// <param name="name"> The name of the source at which the warning originated. For example, this could refer to a particular skill in the attached skillset. This may not be always available. </param>
        /// <param name="details"> Additional, verbose details about the warning to assist in debugging the indexer. This may not be always available. </param>
        /// <param name="documentationLink"> A link to a troubleshooting guide for these classes of warnings. This may not be always available. </param>
        /// <returns> A new <see cref="Models.ItemWarning"/> instance for mocking. </returns>
        public static ItemWarning ItemWarning(string key = default, string message = default, string name = default, string details = default, string documentationLink = default)
        {
            return new ItemWarning(key, message, name, details, documentationLink);
        }

        /// <summary> Initializes new instance of IndexerLimits class. </summary>
        /// <param name="maxRunTime"> The maximum duration that the indexer is permitted to run for one execution. </param>
        /// <param name="maxDocumentExtractionSize"> The maximum size of a document, in bytes, which will be considered valid for indexing. </param>
        /// <param name="maxDocumentContentCharactersToExtract"> The maximum number of characters that will be extracted from a document picked up for indexing. </param>
        /// <returns> A new <see cref="Models.IndexerLimits"/> instance for mocking. </returns>
        public static IndexerLimits IndexerLimits(TimeSpan? maxRunTime = default, long? maxDocumentExtractionSize = default, long? maxDocumentContentCharactersToExtract = default)
        {
            return new IndexerLimits(maxRunTime, maxDocumentExtractionSize, maxDocumentContentCharactersToExtract);
        }

        /// <summary> Initializes new instance of ListSkillsetsResult class. </summary>
        /// <param name="skillsets"> The skillsets defined in the Search service. </param>
        /// <returns> A new <see cref="Models.ListSkillsetsResult"/> instance for mocking. </returns>
        public static ListSkillsetsResult ListSkillsetsResult(IReadOnlyList<Skillset> skillsets = default)
        {
            skillsets ??= new List<Skillset>();
            return new ListSkillsetsResult(skillsets);
        }

        /// <summary> Initializes new instance of ListSynonymMapsResult class. </summary>
        /// <param name="synonymMaps"> The synonym maps in the Search service. </param>
        /// <returns> A new <see cref="Models.ListSynonymMapsResult"/> instance for mocking. </returns>
        public static ListSynonymMapsResult ListSynonymMapsResult(IReadOnlyList<SynonymMap> synonymMaps = default)
        {
            synonymMaps ??= new List<SynonymMap>();
            return new ListSynonymMapsResult(synonymMaps);
        }

        /// <summary> Initializes new instance of ListIndexesResult class. </summary>
        /// <param name="indexes"> The indexes in the Search service. </param>
        /// <returns> A new <see cref="Models.ListIndexesResult"/> instance for mocking. </returns>
        public static ListIndexesResult ListIndexesResult(IReadOnlyList<Models.Index> indexes = default)
        {
            indexes ??= new List<Models.Index>();
            return new ListIndexesResult(indexes);
        }

        /// <summary> Initializes new instance of GetIndexStatisticsResult class. </summary>
        /// <param name="documentCount"> The number of documents in the index. </param>
        /// <param name="storageSize"> The amount of storage in bytes consumed by the index. </param>
        /// <returns> A new <see cref="Models.GetIndexStatisticsResult"/> instance for mocking. </returns>
        public static GetIndexStatisticsResult GetIndexStatisticsResult(long documentCount = default, long storageSize = default)
        {
            return new GetIndexStatisticsResult(documentCount, storageSize);
        }

        /// <summary> Initializes new instance of AnalyzeResult class. </summary>
        /// <param name="tokens"> The list of tokens returned by the analyzer specified in the request. </param>
        /// <returns> A new <see cref="Models.AnalyzeResult"/> instance for mocking. </returns>
        public static AnalyzeResult AnalyzeResult(IReadOnlyList<TokenInfo> tokens = default)
        {
            tokens ??= new List<TokenInfo>();
            return new AnalyzeResult(tokens);
        }

        /// <summary> Initializes new instance of TokenInfo class. </summary>
        /// <param name="token"> The token returned by the analyzer. </param>
        /// <param name="startOffset"> The index of the first character of the token in the input text. </param>
        /// <param name="endOffset"> The index of the last character of the token in the input text. </param>
        /// <param name="position"> The position of the token in the input text relative to other tokens. The first token in the input text has position 0, the next has position 1, and so on. Depending on the analyzer used, some tokens might have the same position, for example if they are synonyms of each other. </param>
        /// <returns> A new <see cref="Models.TokenInfo"/> instance for mocking. </returns>
        public static TokenInfo TokenInfo(string token = default, int startOffset = default, int endOffset = default, int position = default)
        {
            return new TokenInfo(token, startOffset, endOffset, position);
        }

        /// <summary> Initializes new instance of ServiceStatistics class. </summary>
        /// <param name="counters"> Service level resource counters. </param>
        /// <param name="limits"> Service level general limits. </param>
        /// <returns> A new <see cref="Models.ServiceStatistics"/> instance for mocking. </returns>
        public static ServiceStatistics ServiceStatistics(ServiceCounters counters = default, ServiceLimits limits = default)
        {
            return new ServiceStatistics(counters, limits);
        }

        /// <summary> Initializes new instance of ServiceCounters class. </summary>
        /// <param name="documentCounter"> Total number of documents across all indexes in the service. </param>
        /// <param name="indexCounter"> Total number of indexes. </param>
        /// <param name="indexerCounter"> Total number of indexers. </param>
        /// <param name="dataSourceCounter"> Total number of data sources. </param>
        /// <param name="storageSizeCounter"> Total size of used storage in bytes. </param>
        /// <param name="synonymMapCounter"> Total number of synonym maps. </param>
        /// <param name="skillsetCounter"> Total number of skillsets. </param>
        /// <returns> A new <see cref="Models.ServiceCounters"/> instance for mocking. </returns>
        public static ServiceCounters ServiceCounters(ResourceCounter documentCounter = default, ResourceCounter indexCounter = default, ResourceCounter indexerCounter = default, ResourceCounter dataSourceCounter = default, ResourceCounter storageSizeCounter = default, ResourceCounter synonymMapCounter = default, ResourceCounter skillsetCounter = default)
        {
            return new ServiceCounters(documentCounter, indexCounter, indexerCounter, dataSourceCounter, storageSizeCounter, synonymMapCounter, skillsetCounter);
        }

        /// <summary> Initializes new instance of ResourceCounter class. </summary>
        /// <param name="usage"> The resource usage amount. </param>
        /// <param name="quota"> The resource amount quota. </param>
        /// <returns> A new <see cref="Models.ResourceCounter"/> instance for mocking. </returns>
        public static ResourceCounter ResourceCounter(long usage = default, long? quota = default)
        {
            return new ResourceCounter(usage, quota);
        }

        /// <summary> Initializes new instance of ServiceLimits class. </summary>
        /// <param name="maxFieldsPerIndex"> The maximum allowed fields per index. </param>
        /// <param name="maxFieldNestingDepthPerIndex"> The maximum depth which you can nest sub-fields in an index, including the top-level complex field. For example, a/b/c has a nesting depth of 3. </param>
        /// <param name="maxComplexCollectionFieldsPerIndex"> The maximum number of fields of type Collection(Edm.ComplexType) allowed in an index. </param>
        /// <param name="maxComplexObjectsInCollectionsPerDocument"> The maximum number of objects in complex collections allowed per document. </param>
        /// <returns> A new <see cref="Models.ServiceLimits"/> instance for mocking. </returns>
        public static ServiceLimits ServiceLimits(int? maxFieldsPerIndex = default, int? maxFieldNestingDepthPerIndex = default, int? maxComplexCollectionFieldsPerIndex = default, int? maxComplexObjectsInCollectionsPerDocument = default)
        {
            return new ServiceLimits(maxFieldsPerIndex, maxFieldNestingDepthPerIndex, maxComplexCollectionFieldsPerIndex, maxComplexObjectsInCollectionsPerDocument);
        }
    }
}
