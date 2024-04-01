* Microsoft.Extensions.AmbientMetadata.ApplicationMetadata
  * public ApplicationMetadata ();
  * public string ApplicationName { get; set; }
  * public string? BuildVersion { get; set; }
  * public string? DeploymentRing { get; set; }
  * public string EnvironmentName { get; set; }
* Microsoft.Extensions.AsyncState.AsyncStateToken
  * public bool Equals (Microsoft.Extensions.AsyncState.AsyncStateToken other);
  * public override bool Equals (object? obj);
  * public override int GetHashCode ();
  * public static bool operator == (Microsoft.Extensions.AsyncState.AsyncStateToken left, Microsoft.Extensions.AsyncState.AsyncStateToken right);
  * public static bool operator != (Microsoft.Extensions.AsyncState.AsyncStateToken left, Microsoft.Extensions.AsyncState.AsyncStateToken right);
* Microsoft.Extensions.AsyncState.IAsyncContext<T>
  * public T? Get ();
  * public void Set (T? context);
  * public bool TryGet (out T? context);
* Microsoft.Extensions.AsyncState.IAsyncState
  * public object? Get (Microsoft.Extensions.AsyncState.AsyncStateToken token);
  * public void Initialize ();
  * public Microsoft.Extensions.AsyncState.AsyncStateToken RegisterAsyncContext ();
  * public void Reset ();
  * public void Set (Microsoft.Extensions.AsyncState.AsyncStateToken token, object? value);
  * public bool TryGet (Microsoft.Extensions.AsyncState.AsyncStateToken token, out object? value);
* Microsoft.Extensions.Compliance.Classification.DataClassification
  * public DataClassification (string taxonomyName, string value);
  * public bool Equals (Microsoft.Extensions.Compliance.Classification.DataClassification other);
  * public override bool Equals (object? obj);
  * public override int GetHashCode ();
  * public static Microsoft.Extensions.Compliance.Classification.DataClassification None { get; }
  * public static bool operator == (Microsoft.Extensions.Compliance.Classification.DataClassification left, Microsoft.Extensions.Compliance.Classification.DataClassification right);
  * public static bool operator != (Microsoft.Extensions.Compliance.Classification.DataClassification left, Microsoft.Extensions.Compliance.Classification.DataClassification right);
  * public string TaxonomyName { get; }
  * public override string ToString ();
  * public static Microsoft.Extensions.Compliance.Classification.DataClassification Unknown { get; }
  * public string Value { get; }
* Microsoft.Extensions.Compliance.Classification.DataClassificationAttribute
  * protected DataClassificationAttribute (Microsoft.Extensions.Compliance.Classification.DataClassification classification);
  * public Microsoft.Extensions.Compliance.Classification.DataClassification Classification { get; }
  * public string Notes { get; set; }
* Microsoft.Extensions.Compliance.Classification.DataClassificationSet
  * public DataClassificationSet (Microsoft.Extensions.Compliance.Classification.DataClassification classification);
  * public DataClassificationSet (params Microsoft.Extensions.Compliance.Classification.DataClassification[] classifications);
  * public DataClassificationSet (System.Collections.Generic.IEnumerable<Microsoft.Extensions.Compliance.Classification.DataClassification> classifications);
  * public bool Equals (Microsoft.Extensions.Compliance.Classification.DataClassificationSet? other);
  * public override bool Equals (object? obj);
  * public static Microsoft.Extensions.Compliance.Classification.DataClassificationSet FromDataClassification (Microsoft.Extensions.Compliance.Classification.DataClassification classification);
  * public override int GetHashCode ();
  * public static implicit operator Microsoft.Extensions.Compliance.Classification.DataClassificationSet (Microsoft.Extensions.Compliance.Classification.DataClassification classification);
  * public override string ToString ();
  * public Microsoft.Extensions.Compliance.Classification.DataClassificationSet Union (Microsoft.Extensions.Compliance.Classification.DataClassificationSet other);
* Microsoft.Extensions.Compliance.Classification.NoDataClassificationAttribute
  * public NoDataClassificationAttribute ();
* Microsoft.Extensions.Compliance.Classification.UnknownDataClassificationAttribute
  * public UnknownDataClassificationAttribute ();
* Microsoft.Extensions.Compliance.Redaction.ErasingRedactor
  * public ErasingRedactor ();
  * public override int GetRedactedLength (ReadOnlySpan<char> input);
  * public static Microsoft.Extensions.Compliance.Redaction.ErasingRedactor Instance { get; }
  * public override int Redact (ReadOnlySpan<char> source, Span<char> destination);
* Microsoft.Extensions.Compliance.Redaction.FakeRedactionBuilderExtensions
  * public static Microsoft.Extensions.Compliance.Redaction.IRedactionBuilder SetFakeRedactor (this Microsoft.Extensions.Compliance.Redaction.IRedactionBuilder builder, params Microsoft.Extensions.Compliance.Classification.DataClassificationSet[] classifications);
  * public static Microsoft.Extensions.Compliance.Redaction.IRedactionBuilder SetFakeRedactor (this Microsoft.Extensions.Compliance.Redaction.IRedactionBuilder builder, Microsoft.Extensions.Configuration.IConfigurationSection section, params Microsoft.Extensions.Compliance.Classification.DataClassificationSet[] classifications);
  * public static Microsoft.Extensions.Compliance.Redaction.IRedactionBuilder SetFakeRedactor (this Microsoft.Extensions.Compliance.Redaction.IRedactionBuilder builder, Action<Microsoft.Extensions.Compliance.Testing.FakeRedactorOptions> configure, params Microsoft.Extensions.Compliance.Classification.DataClassificationSet[] classifications);
* Microsoft.Extensions.Compliance.Redaction.HmacRedactorOptions
  * public HmacRedactorOptions ();
  * public string Key { get; set; }
  * public int? KeyId { get; set; }
* Microsoft.Extensions.Compliance.Redaction.IRedactionBuilder
  * public Microsoft.Extensions.DependencyInjection.IServiceCollection Services { get; }
  * public Microsoft.Extensions.Compliance.Redaction.IRedactionBuilder SetFallbackRedactor<T> () where T : Microsoft.Extensions.Compliance.Redaction.Redactor;
  * public Microsoft.Extensions.Compliance.Redaction.IRedactionBuilder SetRedactor<T> (params Microsoft.Extensions.Compliance.Classification.DataClassificationSet[] classifications) where T : Microsoft.Extensions.Compliance.Redaction.Redactor;
* Microsoft.Extensions.Compliance.Redaction.IRedactorProvider
  * public Microsoft.Extensions.Compliance.Redaction.Redactor GetRedactor (Microsoft.Extensions.Compliance.Classification.DataClassificationSet classifications);
* Microsoft.Extensions.Compliance.Redaction.NullRedactorProvider
  * public Microsoft.Extensions.Compliance.Redaction.Redactor GetRedactor (Microsoft.Extensions.Compliance.Classification.DataClassificationSet classifications);
* Microsoft.Extensions.Compliance.Redaction.RedactionExtensions
  * public static Microsoft.Extensions.Compliance.Redaction.IRedactionBuilder SetHmacRedactor (this Microsoft.Extensions.Compliance.Redaction.IRedactionBuilder builder, Microsoft.Extensions.Configuration.IConfigurationSection section, params Microsoft.Extensions.Compliance.Classification.DataClassificationSet[] classifications);
  * public static Microsoft.Extensions.Compliance.Redaction.IRedactionBuilder SetHmacRedactor (this Microsoft.Extensions.Compliance.Redaction.IRedactionBuilder builder, Action<Microsoft.Extensions.Compliance.Redaction.HmacRedactorOptions> configure, params Microsoft.Extensions.Compliance.Classification.DataClassificationSet[] classifications);
* Microsoft.Extensions.Compliance.Redaction.Redactor
  * protected Redactor ();
  * public abstract int GetRedactedLength (ReadOnlySpan<char> input);
  * public int GetRedactedLength (string? input);
  * public string Redact (ReadOnlySpan<char> source);
  * public virtual string Redact (string? source);
  * public abstract int Redact (ReadOnlySpan<char> source, Span<char> destination);
  * public int Redact (string? source, Span<char> destination);
  * public string Redact<T> (T value, string? format = default, IFormatProvider? provider = default);
  * public int Redact<T> (T value, Span<char> destination, string? format = default, IFormatProvider? provider = default);
  * public bool TryRedact<T> (T value, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider = default);
* Microsoft.Extensions.Compliance.Testing.FakeRedactionCollector
  * public FakeRedactionCollector ();
  * public System.Collections.Generic.IReadOnlyList<Microsoft.Extensions.Compliance.Testing.RedactedData> AllRedactedData { get; }
  * public System.Collections.Generic.IReadOnlyList<Microsoft.Extensions.Compliance.Testing.RedactorRequested> AllRedactorRequests { get; }
  * public Microsoft.Extensions.Compliance.Testing.RedactedData LastRedactedData { get; }
  * public Microsoft.Extensions.Compliance.Testing.RedactorRequested LastRedactorRequested { get; }
* Microsoft.Extensions.Compliance.Testing.FakeRedactor
  * public FakeRedactor (Microsoft.Extensions.Options.IOptions<Microsoft.Extensions.Compliance.Testing.FakeRedactorOptions>? options = default, Microsoft.Extensions.Compliance.Testing.FakeRedactionCollector? collector = default);
  * public static Microsoft.Extensions.Compliance.Testing.FakeRedactor Create (Microsoft.Extensions.Compliance.Testing.FakeRedactorOptions? options = default, Microsoft.Extensions.Compliance.Testing.FakeRedactionCollector? collector = default);
  * public Microsoft.Extensions.Compliance.Testing.FakeRedactionCollector EventCollector { get; }
  * public override int GetRedactedLength (ReadOnlySpan<char> input);
  * public override int Redact (ReadOnlySpan<char> source, Span<char> destination);
* Microsoft.Extensions.Compliance.Testing.FakeRedactorOptions
  * public FakeRedactorOptions ();
  * public string RedactionFormat { get; set; }
* Microsoft.Extensions.Compliance.Testing.FakeRedactorProvider
  * public FakeRedactorProvider (Microsoft.Extensions.Compliance.Testing.FakeRedactorOptions? options = default, Microsoft.Extensions.Compliance.Testing.FakeRedactionCollector? eventCollector = default);
  * public Microsoft.Extensions.Compliance.Testing.FakeRedactionCollector Collector { get; }
  * public Microsoft.Extensions.Compliance.Redaction.Redactor GetRedactor (Microsoft.Extensions.Compliance.Classification.DataClassificationSet classifications);
* Microsoft.Extensions.Compliance.Testing.FakeTaxonomy
  * public static Microsoft.Extensions.Compliance.Classification.DataClassification PrivateData { get; }
  * public static Microsoft.Extensions.Compliance.Classification.DataClassification PublicData { get; }
  * public static string TaxonomyName { get; }
* Microsoft.Extensions.Compliance.Testing.PrivateDataAttribute
  * public PrivateDataAttribute ();
* Microsoft.Extensions.Compliance.Testing.PublicDataAttribute
  * public PublicDataAttribute ();
* Microsoft.Extensions.Compliance.Testing.RedactedData
  * public RedactedData (string original, string redacted, int sequenceNumber);
  * public bool Equals (Microsoft.Extensions.Compliance.Testing.RedactedData other);
  * public override bool Equals (object? obj);
  * public override int GetHashCode ();
  * public static bool operator == (Microsoft.Extensions.Compliance.Testing.RedactedData left, Microsoft.Extensions.Compliance.Testing.RedactedData right);
  * public static bool operator != (Microsoft.Extensions.Compliance.Testing.RedactedData left, Microsoft.Extensions.Compliance.Testing.RedactedData right);
  * public string Original { get; }
  * public string Redacted { get; }
  * public int SequenceNumber { get; }
* Microsoft.Extensions.Compliance.Testing.RedactorRequested
  * public RedactorRequested (Microsoft.Extensions.Compliance.Classification.DataClassificationSet classifications, int sequenceNumber);
  * public Microsoft.Extensions.Compliance.Classification.DataClassificationSet DataClassifications { get; }
  * public bool Equals (Microsoft.Extensions.Compliance.Testing.RedactorRequested other);
  * public override bool Equals (object? obj);
  * public override int GetHashCode ();
  * public static bool operator == (Microsoft.Extensions.Compliance.Testing.RedactorRequested left, Microsoft.Extensions.Compliance.Testing.RedactorRequested right);
  * public static bool operator != (Microsoft.Extensions.Compliance.Testing.RedactorRequested left, Microsoft.Extensions.Compliance.Testing.RedactorRequested right);
  * public int SequenceNumber { get; }
* Microsoft.Extensions.Configuration.ApplicationMetadataConfigurationBuilderExtensions
  * public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddApplicationMetadata (this Microsoft.Extensions.Configuration.IConfigurationBuilder builder, Microsoft.Extensions.Hosting.IHostEnvironment hostEnvironment, string sectionName = "ambientmetadata:application");
* Microsoft.Extensions.DependencyInjection.ActivatorUtilities
  * public static Microsoft.Extensions.DependencyInjection.ObjectFactory<T> CreateFactory<T> (Type[] argumentTypes);
* Microsoft.Extensions.DependencyInjection.ApplicationEnricherServiceCollectionExtensions
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddServiceLogEnricher (this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddServiceLogEnricher (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Configuration.IConfigurationSection section);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddServiceLogEnricher (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Action<Microsoft.Extensions.Diagnostics.Enrichment.ApplicationLogEnricherOptions> configure);
* Microsoft.Extensions.DependencyInjection.ApplicationMetadataServiceCollectionExtensions
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddApplicationMetadata (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Configuration.IConfigurationSection section);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddApplicationMetadata (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Action<Microsoft.Extensions.AmbientMetadata.ApplicationMetadata> configure);
* Microsoft.Extensions.DependencyInjection.AsyncStateExtensions
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddAsyncState (this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
* Microsoft.Extensions.DependencyInjection.AutoActivationExtensions
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection ActivateKeyedSingleton (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Type serviceType, object? serviceKey);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection ActivateKeyedSingleton<TService> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, object? serviceKey) where TService : class;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection ActivateSingleton (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Type serviceType);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection ActivateSingleton<TService> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services) where TService : class;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddActivatedKeyedSingleton (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Type serviceType, object? serviceKey);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddActivatedKeyedSingleton (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Type serviceType, object? serviceKey, Func<IServiceProvider,object?,object> implementationFactory);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddActivatedKeyedSingleton (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Type serviceType, object? serviceKey, Type implementationType);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddActivatedKeyedSingleton<TService> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, object? serviceKey) where TService : class;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddActivatedKeyedSingleton<TService> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, object? serviceKey, Func<IServiceProvider,object?,TService> implementationFactory) where TService : class;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddActivatedKeyedSingleton<TService,TImplementation> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, object? serviceKey) where TService : class where TImplementation : class, TService;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddActivatedKeyedSingleton<TService,TImplementation> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, object? serviceKey, Func<IServiceProvider,object?,TImplementation> implementationFactory) where TService : class where TImplementation : class, TService;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddActivatedSingleton (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Type serviceType);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddActivatedSingleton (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Type serviceType, Func<IServiceProvider,object> implementationFactory);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddActivatedSingleton (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Type serviceType, Type implementationType);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddActivatedSingleton<TService> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services) where TService : class;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddActivatedSingleton<TService> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Func<IServiceProvider,TService> implementationFactory) where TService : class;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddActivatedSingleton<TService,TImplementation> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services) where TService : class where TImplementation : class, TService;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddActivatedSingleton<TService,TImplementation> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Func<IServiceProvider,TImplementation> implementationFactory) where TService : class where TImplementation : class, TService;
  * public static void TryAddActivatedKeyedSingleton (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Type serviceType, object? serviceKey);
  * public static void TryAddActivatedKeyedSingleton (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Type serviceType, object? serviceKey, Func<IServiceProvider,object?,object> implementationFactory);
  * public static void TryAddActivatedKeyedSingleton (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Type serviceType, object? serviceKey, Type implementationType);
  * public static void TryAddActivatedKeyedSingleton<TService> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, object? serviceKey) where TService : class;
  * public static void TryAddActivatedKeyedSingleton<TService> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, object? serviceKey, Func<IServiceProvider,object?,TService> implementationFactory) where TService : class;
  * public static void TryAddActivatedKeyedSingleton<TService,TImplementation> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, object? serviceKey) where TService : class where TImplementation : class, TService;
  * public static void TryAddActivatedSingleton (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Type serviceType);
  * public static void TryAddActivatedSingleton (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Type serviceType, Func<IServiceProvider,object> implementationFactory);
  * public static void TryAddActivatedSingleton (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Type serviceType, Type implementationType);
  * public static void TryAddActivatedSingleton<TService> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services) where TService : class;
  * public static void TryAddActivatedSingleton<TService> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Func<IServiceProvider,TService> implementationFactory) where TService : class;
  * public static void TryAddActivatedSingleton<TService,TImplementation> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services) where TService : class where TImplementation : class, TService;
* Microsoft.Extensions.DependencyInjection.CommonHealthChecksExtensions
  * public static Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder AddApplicationLifecycleHealthCheck (this Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder builder, System.Collections.Generic.IEnumerable<string> tags);
  * public static Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder AddApplicationLifecycleHealthCheck (this Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder builder, params string[] tags);
  * public static Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder AddManualHealthCheck (this Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder builder, System.Collections.Generic.IEnumerable<string> tags);
  * public static Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder AddManualHealthCheck (this Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder builder, params string[] tags);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddTelemetryHealthCheckPublisher (this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddTelemetryHealthCheckPublisher (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Configuration.IConfigurationSection section);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddTelemetryHealthCheckPublisher (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Action<Microsoft.Extensions.Diagnostics.HealthChecks.TelemetryHealthCheckPublisherOptions> configure);
  * public static void ReportHealthy (this Microsoft.Extensions.Diagnostics.HealthChecks.IManualHealthCheck manualHealthCheck);
  * public static void ReportUnhealthy (this Microsoft.Extensions.Diagnostics.HealthChecks.IManualHealthCheck manualHealthCheck, string reason);
* Microsoft.Extensions.DependencyInjection.ContextualOptionsServiceCollectionExtensions
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddContextualOptions (this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection Configure<TOptions> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Action<Microsoft.Extensions.Options.Contextual.IOptionsContext,TOptions> configureOptions) where TOptions : class;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection Configure<TOptions> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Func<Microsoft.Extensions.Options.Contextual.IOptionsContext,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<Microsoft.Extensions.Options.Contextual.IConfigureContextualOptions<TOptions>>> loadOptions) where TOptions : class;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection Configure<TOptions> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, string name, Action<Microsoft.Extensions.Options.Contextual.IOptionsContext,TOptions> configureOptions) where TOptions : class;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection Configure<TOptions> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, string name, Func<Microsoft.Extensions.Options.Contextual.IOptionsContext,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<Microsoft.Extensions.Options.Contextual.IConfigureContextualOptions<TOptions>>> loadOptions) where TOptions : class;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection PostConfigure<TOptions> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Action<Microsoft.Extensions.Options.Contextual.IOptionsContext,TOptions> configureOptions) where TOptions : class;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection PostConfigure<TOptions> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, string? name, Action<Microsoft.Extensions.Options.Contextual.IOptionsContext,TOptions> configureOptions) where TOptions : class;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection PostConfigureAll<TOptions> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Action<Microsoft.Extensions.Options.Contextual.IOptionsContext,TOptions> configureOptions) where TOptions : class;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection ValidateContextualOptions<TOptions> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Func<TOptions,bool> validate, string failureMessage) where TOptions : class;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection ValidateContextualOptions<TOptions> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, string name, Func<TOptions,bool> validate, string failureMessage) where TOptions : class;
* Microsoft.Extensions.DependencyInjection.EnrichmentServiceCollectionExtensions
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddLogEnricher (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Diagnostics.Enrichment.ILogEnricher enricher);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddLogEnricher<T> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services) where T : class, Microsoft.Extensions.Diagnostics.Enrichment.ILogEnricher;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddStaticLogEnricher (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Diagnostics.Enrichment.IStaticLogEnricher enricher);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddStaticLogEnricher<T> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services) where T : class, Microsoft.Extensions.Diagnostics.Enrichment.IStaticLogEnricher;
* Microsoft.Extensions.DependencyInjection.ExceptionSummarizationServiceCollectionExtensions
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddExceptionSummarizer (this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddExceptionSummarizer (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Action<Microsoft.Extensions.Diagnostics.ExceptionSummarization.IExceptionSummarizationBuilder> configure);
* Microsoft.Extensions.DependencyInjection.FakeLoggerServiceCollectionExtensions
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddFakeLogging (this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddFakeLogging (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Configuration.IConfigurationSection section);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddFakeLogging (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Action<Microsoft.Extensions.Logging.Testing.FakeLogCollectorOptions> configure);
* Microsoft.Extensions.DependencyInjection.FakeRedactionServiceCollectionExtensions
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddFakeRedaction (this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddFakeRedaction (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Action<Microsoft.Extensions.Compliance.Testing.FakeRedactorOptions> configure);
* Microsoft.Extensions.DependencyInjection.FromKeyedServicesAttribute
  * public FromKeyedServicesAttribute (object key);
  * public object Key { get; }
* Microsoft.Extensions.DependencyInjection.HttpClientBuilderExtensions
  * public static Microsoft.Extensions.DependencyInjection.IHttpClientBuilder AddDefaultLogger (this Microsoft.Extensions.DependencyInjection.IHttpClientBuilder builder);
  * public static Microsoft.Extensions.DependencyInjection.IHttpClientBuilder AddLogger (this Microsoft.Extensions.DependencyInjection.IHttpClientBuilder builder, Func<IServiceProvider,Microsoft.Extensions.Http.Logging.IHttpClientLogger> httpClientLoggerFactory, bool wrapHandlersPipeline = false);
  * public static Microsoft.Extensions.DependencyInjection.IHttpClientBuilder AddLogger<TLogger> (this Microsoft.Extensions.DependencyInjection.IHttpClientBuilder builder, bool wrapHandlersPipeline = false) where TLogger : Microsoft.Extensions.Http.Logging.IHttpClientLogger;
  * public static Microsoft.Extensions.DependencyInjection.IHttpClientBuilder ConfigureAdditionalHttpMessageHandlers (this Microsoft.Extensions.DependencyInjection.IHttpClientBuilder builder, Action<System.Collections.Generic.IList<System.Net.Http.DelegatingHandler>,IServiceProvider> configureAdditionalHandlers);
  * public static Microsoft.Extensions.DependencyInjection.IHttpClientBuilder ConfigurePrimaryHttpMessageHandler (this Microsoft.Extensions.DependencyInjection.IHttpClientBuilder builder, Action<System.Net.Http.HttpMessageHandler,IServiceProvider> configureHandler);
  * public static Microsoft.Extensions.DependencyInjection.IHttpClientBuilder RemoveAllLoggers (this Microsoft.Extensions.DependencyInjection.IHttpClientBuilder builder);
  * public static Microsoft.Extensions.DependencyInjection.IHttpClientBuilder UseSocketsHttpHandler (this Microsoft.Extensions.DependencyInjection.IHttpClientBuilder builder, Action<Microsoft.Extensions.DependencyInjection.ISocketsHttpHandlerBuilder> configureBuilder);
  * public static Microsoft.Extensions.DependencyInjection.IHttpClientBuilder UseSocketsHttpHandler (this Microsoft.Extensions.DependencyInjection.IHttpClientBuilder builder, Action<System.Net.Http.SocketsHttpHandler,IServiceProvider>? configureHandler = default);
* Microsoft.Extensions.DependencyInjection.HttpClientFactoryServiceCollectionExtensions
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection ConfigureHttpClientDefaults (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Action<Microsoft.Extensions.DependencyInjection.IHttpClientBuilder> configure);
* Microsoft.Extensions.DependencyInjection.HttpClientLatencyTelemetryExtensions
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddHttpClientLatencyTelemetry (this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddHttpClientLatencyTelemetry (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Configuration.IConfigurationSection section);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddHttpClientLatencyTelemetry (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Action<Microsoft.Extensions.Http.Latency.HttpClientLatencyTelemetryOptions> configure);
* Microsoft.Extensions.DependencyInjection.HttpClientLoggingHttpClientBuilderExtensions
  * public static Microsoft.Extensions.DependencyInjection.IHttpClientBuilder AddExtendedHttpClientLogging (this Microsoft.Extensions.DependencyInjection.IHttpClientBuilder builder);
  * public static Microsoft.Extensions.DependencyInjection.IHttpClientBuilder AddExtendedHttpClientLogging (this Microsoft.Extensions.DependencyInjection.IHttpClientBuilder builder, Microsoft.Extensions.Configuration.IConfigurationSection section);
  * public static Microsoft.Extensions.DependencyInjection.IHttpClientBuilder AddExtendedHttpClientLogging (this Microsoft.Extensions.DependencyInjection.IHttpClientBuilder builder, Action<Microsoft.Extensions.Http.Logging.LoggingOptions> configure);
* Microsoft.Extensions.DependencyInjection.HttpClientLoggingServiceCollectionExtensions
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddExtendedHttpClientLogging (this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddExtendedHttpClientLogging (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Configuration.IConfigurationSection section);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddExtendedHttpClientLogging (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Action<Microsoft.Extensions.Http.Logging.LoggingOptions> configure);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddHttpClientLogEnricher<T> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services) where T : class, Microsoft.Extensions.Http.Logging.IHttpClientLogEnricher;
* Microsoft.Extensions.DependencyInjection.HttpDiagnosticsServiceCollectionExtensions
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddDownstreamDependencyMetadata (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Http.Diagnostics.IDownstreamDependencyMetadata downstreamDependencyMetadata);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddDownstreamDependencyMetadata<T> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services) where T : class, Microsoft.Extensions.Http.Diagnostics.IDownstreamDependencyMetadata;
* Microsoft.Extensions.DependencyInjection.IKeyedServiceProvider
  * public object? GetKeyedService (Type serviceType, object? serviceKey);
  * public object GetRequiredKeyedService (Type serviceType, object? serviceKey);
* Microsoft.Extensions.DependencyInjection.IServiceProviderIsKeyedService
  * public bool IsKeyedService (Type serviceType, object? serviceKey);
* Microsoft.Extensions.DependencyInjection.ISocketsHttpHandlerBuilder
  * public string Name { get; }
  * public Microsoft.Extensions.DependencyInjection.IServiceCollection Services { get; }
* Microsoft.Extensions.DependencyInjection.KeyedService
  * public static object AnyKey { get; }
* Microsoft.Extensions.DependencyInjection.KubernetesProbesExtensions
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddKubernetesProbes (this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddKubernetesProbes (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Configuration.IConfigurationSection section);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddKubernetesProbes (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Action<Microsoft.Extensions.Diagnostics.Probes.KubernetesProbesOptions> configure);
* Microsoft.Extensions.DependencyInjection.LatencyConsoleExtensions
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddConsoleLatencyDataExporter (this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddConsoleLatencyDataExporter (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Configuration.IConfigurationSection section);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddConsoleLatencyDataExporter (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Action<Microsoft.Extensions.Diagnostics.Latency.LatencyConsoleOptions> configure);
* Microsoft.Extensions.DependencyInjection.LatencyContextExtensions
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddLatencyContext (this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddLatencyContext (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Configuration.IConfigurationSection section);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddLatencyContext (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Action<Microsoft.Extensions.Diagnostics.Latency.LatencyContextOptions> configure);
* Microsoft.Extensions.DependencyInjection.LatencyRegistryServiceCollectionExtensions
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection RegisterCheckpointNames (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, params string[] names);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection RegisterMeasureNames (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, params string[] names);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection RegisterTagNames (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, params string[] names);
* Microsoft.Extensions.DependencyInjection.MetricsServiceExtensions
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddMetrics (this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddMetrics (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Action<Microsoft.Extensions.Diagnostics.Metrics.IMetricsBuilder> configure);
* Microsoft.Extensions.DependencyInjection.NullLatencyContextServiceCollectionExtensions
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddNullLatencyContext (this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
* Microsoft.Extensions.DependencyInjection.ObjectPoolServiceCollectionExtensions
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddPooled<TService> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Action<Microsoft.Extensions.ObjectPool.DependencyInjectionPoolOptions>? configure = default) where TService : class;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddPooled<TService,TImplementation> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Action<Microsoft.Extensions.ObjectPool.DependencyInjectionPoolOptions>? configure = default) where TService : class where TImplementation : class, TService;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection ConfigurePool<TService> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Action<Microsoft.Extensions.ObjectPool.DependencyInjectionPoolOptions> configure) where TService : class;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection ConfigurePools (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Configuration.IConfigurationSection section);
* Microsoft.Extensions.DependencyInjection.OptionsServiceCollectionExtensions
  * public static Microsoft.Extensions.Options.OptionsBuilder<TOptions> AddOptionsWithValidateOnStart<TOptions> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, string? name = default) where TOptions : class;
  * public static Microsoft.Extensions.Options.OptionsBuilder<TOptions> AddOptionsWithValidateOnStart<TOptions,TValidateOptions> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, string? name = default) where TOptions : class where TValidateOptions : class, Microsoft.Extensions.Options.IValidateOptions<TOptions>;
* Microsoft.Extensions.DependencyInjection.ProcessEnricherServiceCollectionExtensions
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddProcessLogEnricher (this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddProcessLogEnricher (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Configuration.IConfigurationSection section);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddProcessLogEnricher (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Action<Microsoft.Extensions.Diagnostics.Enrichment.ProcessLogEnricherOptions> configure);
* Microsoft.Extensions.DependencyInjection.RedactionServiceCollectionExtensions
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddRedaction (this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddRedaction (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Action<Microsoft.Extensions.Compliance.Redaction.IRedactionBuilder> configure);
* Microsoft.Extensions.DependencyInjection.ResilienceHttpClientBuilderExtensions
  * public static Microsoft.Extensions.Http.Resilience.IHttpResiliencePipelineBuilder AddResilienceHandler (this Microsoft.Extensions.DependencyInjection.IHttpClientBuilder builder, string pipelineName, Action<Polly.ResiliencePipelineBuilder<System.Net.Http.HttpResponseMessage>,Microsoft.Extensions.Http.Resilience.ResilienceHandlerContext> configure);
  * public static Microsoft.Extensions.Http.Resilience.IHttpResiliencePipelineBuilder AddResilienceHandler (this Microsoft.Extensions.DependencyInjection.IHttpClientBuilder builder, string pipelineName, Action<Polly.ResiliencePipelineBuilder<System.Net.Http.HttpResponseMessage>> configure);
  * public static Microsoft.Extensions.Http.Resilience.IStandardHedgingHandlerBuilder AddStandardHedgingHandler (this Microsoft.Extensions.DependencyInjection.IHttpClientBuilder builder);
  * public static Microsoft.Extensions.Http.Resilience.IStandardHedgingHandlerBuilder AddStandardHedgingHandler (this Microsoft.Extensions.DependencyInjection.IHttpClientBuilder builder, Action<Microsoft.Extensions.Http.Resilience.IRoutingStrategyBuilder> configure);
  * public static Microsoft.Extensions.Http.Resilience.IHttpStandardResiliencePipelineBuilder AddStandardResilienceHandler (this Microsoft.Extensions.DependencyInjection.IHttpClientBuilder builder);
  * public static Microsoft.Extensions.Http.Resilience.IHttpStandardResiliencePipelineBuilder AddStandardResilienceHandler (this Microsoft.Extensions.DependencyInjection.IHttpClientBuilder builder, Microsoft.Extensions.Configuration.IConfigurationSection section);
  * public static Microsoft.Extensions.Http.Resilience.IHttpStandardResiliencePipelineBuilder AddStandardResilienceHandler (this Microsoft.Extensions.DependencyInjection.IHttpClientBuilder builder, Action<Microsoft.Extensions.Http.Resilience.HttpStandardResilienceOptions> configure);
* Microsoft.Extensions.DependencyInjection.ResilienceServiceCollectionExtensions
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddResilienceEnricher (this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
* Microsoft.Extensions.DependencyInjection.ResourceMonitoringServiceCollectionExtensions
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddResourceMonitoring (this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddResourceMonitoring (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Action<Microsoft.Extensions.Diagnostics.ResourceMonitoring.IResourceMonitorBuilder> configure);
* Microsoft.Extensions.DependencyInjection.ResourceUtilizationHealthCheckExtensions
  * public static Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder AddResourceUtilizationHealthCheck (this Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder builder, Microsoft.Extensions.Configuration.IConfigurationSection section);
  * public static Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder AddResourceUtilizationHealthCheck (this Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder builder, Action<Microsoft.Extensions.Diagnostics.HealthChecks.ResourceUtilizationHealthCheckOptions> configure);
  * public static Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder AddResourceUtilizationHealthCheck (this Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder builder, System.Collections.Generic.IEnumerable<string> tags);
  * public static Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder AddResourceUtilizationHealthCheck (this Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder builder, params string[] tags);
  * public static Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder AddResourceUtilizationHealthCheck (this Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder builder, Microsoft.Extensions.Configuration.IConfigurationSection section, System.Collections.Generic.IEnumerable<string> tags);
  * public static Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder AddResourceUtilizationHealthCheck (this Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder builder, Microsoft.Extensions.Configuration.IConfigurationSection section, params string[] tags);
  * public static Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder AddResourceUtilizationHealthCheck (this Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder builder, Action<Microsoft.Extensions.Diagnostics.HealthChecks.ResourceUtilizationHealthCheckOptions> configure, System.Collections.Generic.IEnumerable<string> tags);
  * public static Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder AddResourceUtilizationHealthCheck (this Microsoft.Extensions.DependencyInjection.IHealthChecksBuilder builder, Action<Microsoft.Extensions.Diagnostics.HealthChecks.ResourceUtilizationHealthCheckOptions> configure, params string[] tags);
* Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddKeyedScoped (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Type serviceType, object? serviceKey);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddKeyedScoped (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Type serviceType, object? serviceKey, Func<IServiceProvider,object?,object> implementationFactory);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddKeyedScoped (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Type serviceType, object? serviceKey, Type implementationType);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddKeyedScoped<TService> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, object? serviceKey) where TService : class;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddKeyedScoped<TService> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, object? serviceKey, Func<IServiceProvider,object?,TService> implementationFactory) where TService : class;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddKeyedScoped<TService,TImplementation> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, object? serviceKey) where TService : class where TImplementation : class, TService;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddKeyedScoped<TService,TImplementation> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, object? serviceKey, Func<IServiceProvider,object?,TImplementation> implementationFactory) where TService : class where TImplementation : class, TService;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddKeyedSingleton (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Type serviceType, object? serviceKey);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddKeyedSingleton (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Type serviceType, object? serviceKey, Func<IServiceProvider,object?,object> implementationFactory);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddKeyedSingleton (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Type serviceType, object? serviceKey, object implementationInstance);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddKeyedSingleton (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Type serviceType, object? serviceKey, Type implementationType);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddKeyedSingleton<TService> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, object? serviceKey) where TService : class;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddKeyedSingleton<TService> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, object? serviceKey, Func<IServiceProvider,object?,TService> implementationFactory) where TService : class;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddKeyedSingleton<TService> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, object? serviceKey, TService implementationInstance) where TService : class;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddKeyedSingleton<TService,TImplementation> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, object? serviceKey) where TService : class where TImplementation : class, TService;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddKeyedSingleton<TService,TImplementation> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, object? serviceKey, Func<IServiceProvider,object?,TImplementation> implementationFactory) where TService : class where TImplementation : class, TService;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddKeyedTransient (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Type serviceType, object? serviceKey);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddKeyedTransient (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Type serviceType, object? serviceKey, Func<IServiceProvider,object?,object> implementationFactory);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddKeyedTransient (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Type serviceType, object? serviceKey, Type implementationType);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddKeyedTransient<TService> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, object? serviceKey) where TService : class;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddKeyedTransient<TService> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, object? serviceKey, Func<IServiceProvider,object?,TService> implementationFactory) where TService : class;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddKeyedTransient<TService,TImplementation> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, object? serviceKey) where TService : class where TImplementation : class, TService;
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddKeyedTransient<TService,TImplementation> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, object? serviceKey, Func<IServiceProvider,object?,TImplementation> implementationFactory) where TService : class where TImplementation : class, TService;
* Microsoft.Extensions.DependencyInjection.ServiceDescriptor
  * public ServiceDescriptor (Type serviceType, object? serviceKey, object instance);
  * public ServiceDescriptor (Type serviceType, object? serviceKey, Func<IServiceProvider,object?,object> factory, Microsoft.Extensions.DependencyInjection.ServiceLifetime lifetime);
  * public ServiceDescriptor (Type serviceType, object? serviceKey, Type implementationType, Microsoft.Extensions.DependencyInjection.ServiceLifetime lifetime);
  * public static Microsoft.Extensions.DependencyInjection.ServiceDescriptor DescribeKeyed (Type serviceType, object? serviceKey, Func<IServiceProvider,object?,object> implementationFactory, Microsoft.Extensions.DependencyInjection.ServiceLifetime lifetime);
  * public static Microsoft.Extensions.DependencyInjection.ServiceDescriptor DescribeKeyed (Type serviceType, object? serviceKey, Type implementationType, Microsoft.Extensions.DependencyInjection.ServiceLifetime lifetime);
  * public bool IsKeyedService { get; }
  * public Func<IServiceProvider,object?,object>? KeyedImplementationFactory { get; }
  * public object? KeyedImplementationInstance { get; }
  * public Type? KeyedImplementationType { get; }
  * public static Microsoft.Extensions.DependencyInjection.ServiceDescriptor KeyedScoped (Type service, object? serviceKey, Func<IServiceProvider,object?,object> implementationFactory);
  * public static Microsoft.Extensions.DependencyInjection.ServiceDescriptor KeyedScoped (Type service, object? serviceKey, Type implementationType);
  * public static Microsoft.Extensions.DependencyInjection.ServiceDescriptor KeyedScoped<TService> (object? serviceKey, Func<IServiceProvider,object?,TService> implementationFactory) where TService : class;
  * public static Microsoft.Extensions.DependencyInjection.ServiceDescriptor KeyedScoped<TService,TImplementation> (object? serviceKey) where TService : class where TImplementation : class, TService;
  * public static Microsoft.Extensions.DependencyInjection.ServiceDescriptor KeyedScoped<TService,TImplementation> (object? serviceKey, Func<IServiceProvider,object?,TImplementation> implementationFactory) where TService : class where TImplementation : class, TService;
  * public static Microsoft.Extensions.DependencyInjection.ServiceDescriptor KeyedSingleton (Type serviceType, object? serviceKey, Func<IServiceProvider,object?,object> implementationFactory);
  * public static Microsoft.Extensions.DependencyInjection.ServiceDescriptor KeyedSingleton (Type serviceType, object? serviceKey, object implementationInstance);
  * public static Microsoft.Extensions.DependencyInjection.ServiceDescriptor KeyedSingleton (Type service, object? serviceKey, Type implementationType);
  * public static Microsoft.Extensions.DependencyInjection.ServiceDescriptor KeyedSingleton<TService> (object? serviceKey, Func<IServiceProvider,object?,TService> implementationFactory) where TService : class;
  * public static Microsoft.Extensions.DependencyInjection.ServiceDescriptor KeyedSingleton<TService> (object? serviceKey, TService implementationInstance) where TService : class;
  * public static Microsoft.Extensions.DependencyInjection.ServiceDescriptor KeyedSingleton<TService,TImplementation> (object? serviceKey) where TService : class where TImplementation : class, TService;
  * public static Microsoft.Extensions.DependencyInjection.ServiceDescriptor KeyedSingleton<TService,TImplementation> (object? serviceKey, Func<IServiceProvider,object?,TImplementation> implementationFactory) where TService : class where TImplementation : class, TService;
  * public static Microsoft.Extensions.DependencyInjection.ServiceDescriptor KeyedTransient (Type service, object? serviceKey, Func<IServiceProvider,object?,object> implementationFactory);
  * public static Microsoft.Extensions.DependencyInjection.ServiceDescriptor KeyedTransient (Type service, object? serviceKey, Type implementationType);
  * public static Microsoft.Extensions.DependencyInjection.ServiceDescriptor KeyedTransient<TService> (object? serviceKey, Func<IServiceProvider,object?,TService> implementationFactory) where TService : class;
  * public static Microsoft.Extensions.DependencyInjection.ServiceDescriptor KeyedTransient<TService,TImplementation> (object? serviceKey) where TService : class where TImplementation : class, TService;
  * public static Microsoft.Extensions.DependencyInjection.ServiceDescriptor KeyedTransient<TService,TImplementation> (object? serviceKey, Func<IServiceProvider,object?,TImplementation> implementationFactory) where TService : class where TImplementation : class, TService;
  * public object? ServiceKey { get; }
* Microsoft.Extensions.DependencyInjection.ServiceKeyAttribute
  * public ServiceKeyAttribute ();
* Microsoft.Extensions.DependencyInjection.ServiceProvider
  * public object? GetKeyedService (Type serviceType, object? serviceKey);
  * public object GetRequiredKeyedService (Type serviceType, object? serviceKey);
* Microsoft.Extensions.DependencyInjection.ServiceProviderKeyedServiceExtensions
  * public static T? GetKeyedService<T> (this IServiceProvider provider, object? serviceKey);
  * public static System.Collections.Generic.IEnumerable<object?> GetKeyedServices (this IServiceProvider provider, Type serviceType, object? serviceKey);
  * public static System.Collections.Generic.IEnumerable<T> GetKeyedServices<T> (this IServiceProvider provider, object? serviceKey);
  * public static object GetRequiredKeyedService (this IServiceProvider provider, Type serviceType, object? serviceKey);
  * public static T GetRequiredKeyedService<T> (this IServiceProvider provider, object? serviceKey);
* Microsoft.Extensions.DependencyInjection.SocketsHttpHandlerBuilderExtensions
  * public static Microsoft.Extensions.DependencyInjection.ISocketsHttpHandlerBuilder Configure (this Microsoft.Extensions.DependencyInjection.ISocketsHttpHandlerBuilder builder, Microsoft.Extensions.Configuration.IConfiguration configuration);
  * public static Microsoft.Extensions.DependencyInjection.ISocketsHttpHandlerBuilder Configure (this Microsoft.Extensions.DependencyInjection.ISocketsHttpHandlerBuilder builder, Action<System.Net.Http.SocketsHttpHandler,IServiceProvider> configure);
* Microsoft.Extensions.DependencyInjection.Extensions.ServiceCollectionDescriptorExtensions
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection RemoveAllKeyed (this Microsoft.Extensions.DependencyInjection.IServiceCollection collection, Type serviceType, object? serviceKey);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection RemoveAllKeyed<T> (this Microsoft.Extensions.DependencyInjection.IServiceCollection collection, object? serviceKey);
  * public static void TryAddKeyedScoped (this Microsoft.Extensions.DependencyInjection.IServiceCollection collection, Type service, object? serviceKey);
  * public static void TryAddKeyedScoped (this Microsoft.Extensions.DependencyInjection.IServiceCollection collection, Type service, object? serviceKey, Func<IServiceProvider,object?,object> implementationFactory);
  * public static void TryAddKeyedScoped (this Microsoft.Extensions.DependencyInjection.IServiceCollection collection, Type service, object? serviceKey, Type implementationType);
  * public static void TryAddKeyedScoped<TService> (this Microsoft.Extensions.DependencyInjection.IServiceCollection collection, object? serviceKey) where TService : class;
  * public static void TryAddKeyedScoped<TService> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, object? serviceKey, Func<IServiceProvider,object?,TService> implementationFactory) where TService : class;
  * public static void TryAddKeyedScoped<TService,TImplementation> (this Microsoft.Extensions.DependencyInjection.IServiceCollection collection, object? serviceKey) where TService : class where TImplementation : class, TService;
  * public static void TryAddKeyedSingleton (this Microsoft.Extensions.DependencyInjection.IServiceCollection collection, Type service, object? serviceKey);
  * public static void TryAddKeyedSingleton (this Microsoft.Extensions.DependencyInjection.IServiceCollection collection, Type service, object? serviceKey, Func<IServiceProvider,object?,object> implementationFactory);
  * public static void TryAddKeyedSingleton (this Microsoft.Extensions.DependencyInjection.IServiceCollection collection, Type service, object? serviceKey, Type implementationType);
  * public static void TryAddKeyedSingleton<TService> (this Microsoft.Extensions.DependencyInjection.IServiceCollection collection, object? serviceKey) where TService : class;
  * public static void TryAddKeyedSingleton<TService> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, object? serviceKey, Func<IServiceProvider,object?,TService> implementationFactory) where TService : class;
  * public static void TryAddKeyedSingleton<TService> (this Microsoft.Extensions.DependencyInjection.IServiceCollection collection, object? serviceKey, TService instance) where TService : class;
  * public static void TryAddKeyedSingleton<TService,TImplementation> (this Microsoft.Extensions.DependencyInjection.IServiceCollection collection, object? serviceKey) where TService : class where TImplementation : class, TService;
  * public static void TryAddKeyedTransient (this Microsoft.Extensions.DependencyInjection.IServiceCollection collection, Type service, object? serviceKey);
  * public static void TryAddKeyedTransient (this Microsoft.Extensions.DependencyInjection.IServiceCollection collection, Type service, object? serviceKey, Func<IServiceProvider,object?,object> implementationFactory);
  * public static void TryAddKeyedTransient (this Microsoft.Extensions.DependencyInjection.IServiceCollection collection, Type service, object? serviceKey, Type implementationType);
  * public static void TryAddKeyedTransient<TService> (this Microsoft.Extensions.DependencyInjection.IServiceCollection collection, object? serviceKey) where TService : class;
  * public static void TryAddKeyedTransient<TService> (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, object? serviceKey, Func<IServiceProvider,object?,TService> implementationFactory) where TService : class;
  * public static void TryAddKeyedTransient<TService,TImplementation> (this Microsoft.Extensions.DependencyInjection.IServiceCollection collection, object? serviceKey) where TService : class where TImplementation : class, TService;
* Microsoft.Extensions.Diagnostics.Enrichment.ApplicationEnricherTags
  * public const string ApplicationName;
  * public const string BuildVersion;
  * public const string DeploymentRing;
  * public static System.Collections.Generic.IReadOnlyList<string> DimensionNames { get; }
  * public const string EnvironmentName;
* Microsoft.Extensions.Diagnostics.Enrichment.ApplicationLogEnricherOptions
  * public ApplicationLogEnricherOptions ();
  * public bool ApplicationName { get; set; }
  * public bool BuildVersion { get; set; }
  * public bool DeploymentRing { get; set; }
  * public bool EnvironmentName { get; set; }
* Microsoft.Extensions.Diagnostics.Enrichment.IEnrichmentTagCollector
  * public void Add (string tagName, object tagValue);
* Microsoft.Extensions.Diagnostics.Enrichment.ILogEnricher
  * public void Enrich (Microsoft.Extensions.Diagnostics.Enrichment.IEnrichmentTagCollector collector);
* Microsoft.Extensions.Diagnostics.Enrichment.IStaticLogEnricher
  * public void Enrich (Microsoft.Extensions.Diagnostics.Enrichment.IEnrichmentTagCollector collector);
* Microsoft.Extensions.Diagnostics.Enrichment.ProcessEnricherTagNames
  * public static System.Collections.Generic.IReadOnlyList<string> DimensionNames { get; }
  * public const string ProcessId;
  * public const string ThreadId;
* Microsoft.Extensions.Diagnostics.Enrichment.ProcessLogEnricherOptions
  * public ProcessLogEnricherOptions ();
  * public bool ProcessId { get; set; }
  * public bool ThreadId { get; set; }
* Microsoft.Extensions.Diagnostics.ExceptionSummarization.ExceptionSummarizationBuilderExtensions
  * public static Microsoft.Extensions.Diagnostics.ExceptionSummarization.IExceptionSummarizationBuilder AddHttpProvider (this Microsoft.Extensions.Diagnostics.ExceptionSummarization.IExceptionSummarizationBuilder builder);
* Microsoft.Extensions.Diagnostics.ExceptionSummarization.ExceptionSummary
  * public ExceptionSummary (string exceptionType, string description, string additionalDetails);
  * public string AdditionalDetails { get; }
  * public string Description { get; }
  * public bool Equals (Microsoft.Extensions.Diagnostics.ExceptionSummarization.ExceptionSummary other);
  * public override bool Equals (object? obj);
  * public string ExceptionType { get; }
  * public override int GetHashCode ();
  * public static bool operator == (Microsoft.Extensions.Diagnostics.ExceptionSummarization.ExceptionSummary left, Microsoft.Extensions.Diagnostics.ExceptionSummarization.ExceptionSummary right);
  * public static bool operator != (Microsoft.Extensions.Diagnostics.ExceptionSummarization.ExceptionSummary left, Microsoft.Extensions.Diagnostics.ExceptionSummarization.ExceptionSummary right);
  * public override string ToString ();
* Microsoft.Extensions.Diagnostics.ExceptionSummarization.IExceptionSummarizationBuilder
  * public Microsoft.Extensions.Diagnostics.ExceptionSummarization.IExceptionSummarizationBuilder AddProvider<T> () where T : class, Microsoft.Extensions.Diagnostics.ExceptionSummarization.IExceptionSummaryProvider;
  * public Microsoft.Extensions.DependencyInjection.IServiceCollection Services { get; }
* Microsoft.Extensions.Diagnostics.ExceptionSummarization.IExceptionSummarizer
  * public Microsoft.Extensions.Diagnostics.ExceptionSummarization.ExceptionSummary Summarize (Exception exception);
* Microsoft.Extensions.Diagnostics.ExceptionSummarization.IExceptionSummaryProvider
  * public int Describe (Exception exception, out string? additionalDetails);
  * public System.Collections.Generic.IReadOnlyList<string> Descriptions { get; }
  * public System.Collections.Generic.IEnumerable<Type> SupportedExceptionTypes { get; }
* Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckRegistration
  * public TimeSpan? Delay { get; set; }
  * public TimeSpan? Period { get; set; }
* Microsoft.Extensions.Diagnostics.HealthChecks.ResourceUsageThresholds
  * public ResourceUsageThresholds ();
  * public double? DegradedUtilizationPercentage { get; set; }
  * public double? UnhealthyUtilizationPercentage { get; set; }
* Microsoft.Extensions.Diagnostics.HealthChecks.ResourceUtilizationHealthCheckOptions
  * public ResourceUtilizationHealthCheckOptions ();
  * public Microsoft.Extensions.Diagnostics.HealthChecks.ResourceUsageThresholds CpuThresholds { get; set; }
  * public Microsoft.Extensions.Diagnostics.HealthChecks.ResourceUsageThresholds MemoryThresholds { get; set; }
  * public TimeSpan SamplingWindow { get; set; }
* Microsoft.Extensions.Diagnostics.Latency.Checkpoint
  * public Checkpoint (string name, long elapsed, long frequency);
  * public long Elapsed { get; }
  * public bool Equals (Microsoft.Extensions.Diagnostics.Latency.Checkpoint other);
  * public override bool Equals (object? obj);
  * public long Frequency { get; }
  * public override int GetHashCode ();
  * public string Name { get; }
  * public static bool operator == (Microsoft.Extensions.Diagnostics.Latency.Checkpoint left, Microsoft.Extensions.Diagnostics.Latency.Checkpoint right);
  * public static bool operator != (Microsoft.Extensions.Diagnostics.Latency.Checkpoint left, Microsoft.Extensions.Diagnostics.Latency.Checkpoint right);
* Microsoft.Extensions.Diagnostics.Latency.CheckpointToken
  * public CheckpointToken (string name, int position);
  * public string Name { get; }
  * public int Position { get; }
* Microsoft.Extensions.Diagnostics.Latency.ILatencyContext
  * public void AddCheckpoint (Microsoft.Extensions.Diagnostics.Latency.CheckpointToken token);
  * public void AddMeasure (Microsoft.Extensions.Diagnostics.Latency.MeasureToken token, long value);
  * public void Freeze ();
  * public Microsoft.Extensions.Diagnostics.Latency.LatencyData LatencyData { get; }
  * public void RecordMeasure (Microsoft.Extensions.Diagnostics.Latency.MeasureToken token, long value);
  * public void SetTag (Microsoft.Extensions.Diagnostics.Latency.TagToken token, string value);
* Microsoft.Extensions.Diagnostics.Latency.ILatencyContextProvider
  * public Microsoft.Extensions.Diagnostics.Latency.ILatencyContext CreateContext ();
* Microsoft.Extensions.Diagnostics.Latency.ILatencyContextTokenIssuer
  * public Microsoft.Extensions.Diagnostics.Latency.CheckpointToken GetCheckpointToken (string name);
  * public Microsoft.Extensions.Diagnostics.Latency.MeasureToken GetMeasureToken (string name);
  * public Microsoft.Extensions.Diagnostics.Latency.TagToken GetTagToken (string name);
* Microsoft.Extensions.Diagnostics.Latency.ILatencyDataExporter
  * public System.Threading.Tasks.Task ExportAsync (Microsoft.Extensions.Diagnostics.Latency.LatencyData data, System.Threading.CancellationToken cancellationToken);
* Microsoft.Extensions.Diagnostics.Latency.LatencyConsoleOptions
  * public LatencyConsoleOptions ();
  * public bool OutputCheckpoints { get; set; }
  * public bool OutputMeasures { get; set; }
  * public bool OutputTags { get; set; }
* Microsoft.Extensions.Diagnostics.Latency.LatencyContextOptions
  * public LatencyContextOptions ();
  * public bool ThrowOnUnregisteredNames { get; set; }
* Microsoft.Extensions.Diagnostics.Latency.LatencyContextRegistrationOptions
  * public LatencyContextRegistrationOptions ();
  * public System.Collections.Generic.IReadOnlyList<string> CheckpointNames { get; set; }
  * public System.Collections.Generic.IReadOnlyList<string> MeasureNames { get; set; }
  * public System.Collections.Generic.IReadOnlyList<string> TagNames { get; set; }
* Microsoft.Extensions.Diagnostics.Latency.LatencyData
  * public LatencyData (ArraySegment<Microsoft.Extensions.Diagnostics.Latency.Tag> tags, ArraySegment<Microsoft.Extensions.Diagnostics.Latency.Checkpoint> checkpoints, ArraySegment<Microsoft.Extensions.Diagnostics.Latency.Measure> measures, long durationTimestamp, long durationTimestampFrequency);
  * public ReadOnlySpan<Microsoft.Extensions.Diagnostics.Latency.Checkpoint> Checkpoints { get; }
  * public long DurationTimestamp { get; }
  * public long DurationTimestampFrequency { get; }
  * public ReadOnlySpan<Microsoft.Extensions.Diagnostics.Latency.Measure> Measures { get; }
  * public ReadOnlySpan<Microsoft.Extensions.Diagnostics.Latency.Tag> Tags { get; }
* Microsoft.Extensions.Diagnostics.Latency.Measure
  * public Measure (string name, long value);
  * public bool Equals (Microsoft.Extensions.Diagnostics.Latency.Measure other);
  * public override bool Equals (object? obj);
  * public override int GetHashCode ();
  * public string Name { get; }
  * public static bool operator == (Microsoft.Extensions.Diagnostics.Latency.Measure left, Microsoft.Extensions.Diagnostics.Latency.Measure right);
  * public static bool operator != (Microsoft.Extensions.Diagnostics.Latency.Measure left, Microsoft.Extensions.Diagnostics.Latency.Measure right);
  * public long Value { get; }
* Microsoft.Extensions.Diagnostics.Latency.MeasureToken
  * public MeasureToken (string name, int position);
  * public string Name { get; }
  * public int Position { get; }
* Microsoft.Extensions.Diagnostics.Latency.Tag
  * public Tag (string name, string value);
  * public string Name { get; }
  * public string Value { get; }
* Microsoft.Extensions.Diagnostics.Latency.TagToken
  * public TagToken (string name, int position);
  * public string Name { get; }
  * public int Position { get; }
* Microsoft.Extensions.Diagnostics.Metrics.ConsoleMetrics
  * public static string DebugListenerName { get; }
* Microsoft.Extensions.Diagnostics.Metrics.CounterAttribute
  * public CounterAttribute (params string[] tagNames);
  * public CounterAttribute (Type type);
  * public string? Name { get; set; }
  * public string[]? TagNames { get; }
  * public Type? Type { get; }
* Microsoft.Extensions.Diagnostics.Metrics.CounterAttribute<T>
  * public CounterAttribute (params string[] tagNames);
  * public CounterAttribute (Type type);
  * public string? Name { get; set; }
  * public string[]? TagNames { get; }
  * public Type? Type { get; }
* Microsoft.Extensions.Diagnostics.Metrics.GaugeAttribute
  * public GaugeAttribute (params string[] tagNames);
  * public GaugeAttribute (Type type);
  * public string? Name { get; set; }
  * public string[]? TagNames { get; }
  * public Type? Type { get; }
* Microsoft.Extensions.Diagnostics.Metrics.HistogramAttribute
  * public HistogramAttribute (params string[] tagNames);
  * public HistogramAttribute (Type type);
  * public string? Name { get; set; }
  * public string[]? TagNames { get; }
  * public Type? Type { get; }
* Microsoft.Extensions.Diagnostics.Metrics.HistogramAttribute<T>
  * public HistogramAttribute (params string[] tagNames);
  * public HistogramAttribute (Type type);
  * public string? Name { get; set; }
  * public string[]? TagNames { get; }
  * public Type? Type { get; }
* Microsoft.Extensions.Diagnostics.Metrics.IMetricsBuilder
  * public Microsoft.Extensions.DependencyInjection.IServiceCollection Services { get; }
* Microsoft.Extensions.Diagnostics.Metrics.IMetricsListener
  * public Microsoft.Extensions.Diagnostics.Metrics.MeasurementHandlers GetMeasurementHandlers ();
  * public void Initialize (Microsoft.Extensions.Diagnostics.Metrics.IObservableInstrumentsSource source);
  * public bool InstrumentPublished (System.Diagnostics.Metrics.Instrument instrument, out object? userState);
  * public void MeasurementsCompleted (System.Diagnostics.Metrics.Instrument instrument, object? userState);
  * public string Name { get; }
* Microsoft.Extensions.Diagnostics.Metrics.InstrumentRule
  * public InstrumentRule (string? meterName, string? instrumentName, string? listenerName, Microsoft.Extensions.Diagnostics.Metrics.MeterScope scopes, bool enable);
  * public bool Enable { get; }
  * public string? InstrumentName { get; }
  * public string? ListenerName { get; }
  * public string? MeterName { get; }
  * public Microsoft.Extensions.Diagnostics.Metrics.MeterScope Scopes { get; }
* Microsoft.Extensions.Diagnostics.Metrics.IObservableInstrumentsSource
  * public void RecordObservableInstruments ();
* Microsoft.Extensions.Diagnostics.Metrics.MeasurementHandlers
  * public MeasurementHandlers ();
  * public System.Diagnostics.Metrics.MeasurementCallback<byte>? ByteHandler { get; set; }
  * public System.Diagnostics.Metrics.MeasurementCallback<decimal>? DecimalHandler { get; set; }
  * public System.Diagnostics.Metrics.MeasurementCallback<double>? DoubleHandler { get; set; }
  * public System.Diagnostics.Metrics.MeasurementCallback<float>? FloatHandler { get; set; }
  * public System.Diagnostics.Metrics.MeasurementCallback<int>? IntHandler { get; set; }
  * public System.Diagnostics.Metrics.MeasurementCallback<long>? LongHandler { get; set; }
  * public System.Diagnostics.Metrics.MeasurementCallback<short>? ShortHandler { get; set; }
* Microsoft.Extensions.Diagnostics.Metrics.MeterScope
  * Global
  * Local
  * None
* Microsoft.Extensions.Diagnostics.Metrics.MetricsBuilderConfigurationExtensions
  * public static Microsoft.Extensions.Diagnostics.Metrics.IMetricsBuilder AddConfiguration (this Microsoft.Extensions.Diagnostics.Metrics.IMetricsBuilder builder, Microsoft.Extensions.Configuration.IConfiguration configuration);
* Microsoft.Extensions.Diagnostics.Metrics.MetricsBuilderConsoleExtensions
  * public static Microsoft.Extensions.Diagnostics.Metrics.IMetricsBuilder AddDebugConsole (this Microsoft.Extensions.Diagnostics.Metrics.IMetricsBuilder builder);
* Microsoft.Extensions.Diagnostics.Metrics.MetricsBuilderExtensions
  * public static Microsoft.Extensions.Diagnostics.Metrics.IMetricsBuilder AddListener (this Microsoft.Extensions.Diagnostics.Metrics.IMetricsBuilder builder, Microsoft.Extensions.Diagnostics.Metrics.IMetricsListener listener);
  * public static Microsoft.Extensions.Diagnostics.Metrics.IMetricsBuilder AddListener<T> (this Microsoft.Extensions.Diagnostics.Metrics.IMetricsBuilder builder) where T : class, Microsoft.Extensions.Diagnostics.Metrics.IMetricsListener;
  * public static Microsoft.Extensions.Diagnostics.Metrics.IMetricsBuilder ClearListeners (this Microsoft.Extensions.Diagnostics.Metrics.IMetricsBuilder builder);
  * public static Microsoft.Extensions.Diagnostics.Metrics.IMetricsBuilder DisableMetrics (this Microsoft.Extensions.Diagnostics.Metrics.IMetricsBuilder builder, string? meterName);
  * public static Microsoft.Extensions.Diagnostics.Metrics.MetricsOptions DisableMetrics (this Microsoft.Extensions.Diagnostics.Metrics.MetricsOptions options, string? meterName);
  * public static Microsoft.Extensions.Diagnostics.Metrics.IMetricsBuilder DisableMetrics (this Microsoft.Extensions.Diagnostics.Metrics.IMetricsBuilder builder, string? meterName, string? instrumentName = default, string? listenerName = default, Microsoft.Extensions.Diagnostics.Metrics.MeterScope scopes = Microsoft.Extensions.Diagnostics.Metrics.MeterScope.Global | Microsoft.Extensions.Diagnostics.Metrics.MeterScope.Local);
  * public static Microsoft.Extensions.Diagnostics.Metrics.MetricsOptions DisableMetrics (this Microsoft.Extensions.Diagnostics.Metrics.MetricsOptions options, string? meterName, string? instrumentName = default, string? listenerName = default, Microsoft.Extensions.Diagnostics.Metrics.MeterScope scopes = Microsoft.Extensions.Diagnostics.Metrics.MeterScope.Global | Microsoft.Extensions.Diagnostics.Metrics.MeterScope.Local);
  * public static Microsoft.Extensions.Diagnostics.Metrics.IMetricsBuilder EnableMetrics (this Microsoft.Extensions.Diagnostics.Metrics.IMetricsBuilder builder, string? meterName);
  * public static Microsoft.Extensions.Diagnostics.Metrics.MetricsOptions EnableMetrics (this Microsoft.Extensions.Diagnostics.Metrics.MetricsOptions options, string? meterName);
  * public static Microsoft.Extensions.Diagnostics.Metrics.IMetricsBuilder EnableMetrics (this Microsoft.Extensions.Diagnostics.Metrics.IMetricsBuilder builder, string? meterName, string? instrumentName = default, string? listenerName = default, Microsoft.Extensions.Diagnostics.Metrics.MeterScope scopes = Microsoft.Extensions.Diagnostics.Metrics.MeterScope.Global | Microsoft.Extensions.Diagnostics.Metrics.MeterScope.Local);
  * public static Microsoft.Extensions.Diagnostics.Metrics.MetricsOptions EnableMetrics (this Microsoft.Extensions.Diagnostics.Metrics.MetricsOptions options, string? meterName, string? instrumentName = default, string? listenerName = default, Microsoft.Extensions.Diagnostics.Metrics.MeterScope scopes = Microsoft.Extensions.Diagnostics.Metrics.MeterScope.Global | Microsoft.Extensions.Diagnostics.Metrics.MeterScope.Local);
* Microsoft.Extensions.Diagnostics.Metrics.MetricsOptions
  * public MetricsOptions ();
  * public System.Collections.Generic.IList<Microsoft.Extensions.Diagnostics.Metrics.InstrumentRule> Rules { get; }
* Microsoft.Extensions.Diagnostics.Metrics.TagNameAttribute
  * public TagNameAttribute (string name);
  * public string Name { get; }
* Microsoft.Extensions.Diagnostics.Metrics.Configuration.IMetricListenerConfigurationFactory
  * public Microsoft.Extensions.Configuration.IConfiguration GetConfiguration (string listenerName);
* Microsoft.Extensions.Diagnostics.Probes.KubernetesProbesOptions
  * public KubernetesProbesOptions ();
  * public Microsoft.Extensions.Diagnostics.Probes.KubernetesProbesOptions.EndpointOptions LivenessProbe { get; set; }
  * public Microsoft.Extensions.Diagnostics.Probes.KubernetesProbesOptions.EndpointOptions ReadinessProbe { get; set; }
  * public Microsoft.Extensions.Diagnostics.Probes.KubernetesProbesOptions.EndpointOptions StartupProbe { get; set; }
* Microsoft.Extensions.Diagnostics.Probes.ProbeTags
  * public const string Liveness;
  * public const string Readiness;
  * public const string Startup;
* Microsoft.Extensions.Diagnostics.ResourceMonitoring.IResourceMonitor
  * public Microsoft.Extensions.Diagnostics.ResourceMonitoring.ResourceUtilization GetUtilization (TimeSpan window);
* Microsoft.Extensions.Diagnostics.ResourceMonitoring.IResourceMonitorBuilder
  * public Microsoft.Extensions.Diagnostics.ResourceMonitoring.IResourceMonitorBuilder AddPublisher<T> () where T : class, Microsoft.Extensions.Diagnostics.ResourceMonitoring.IResourceUtilizationPublisher;
  * public Microsoft.Extensions.DependencyInjection.IServiceCollection Services { get; }
* Microsoft.Extensions.Diagnostics.ResourceMonitoring.IResourceUtilizationPublisher
  * public System.Threading.Tasks.ValueTask PublishAsync (Microsoft.Extensions.Diagnostics.ResourceMonitoring.ResourceUtilization utilization, System.Threading.CancellationToken cancellationToken);
* Microsoft.Extensions.Diagnostics.ResourceMonitoring.ResourceMonitoringBuilderExtensions
  * public static Microsoft.Extensions.Diagnostics.ResourceMonitoring.IResourceMonitorBuilder ConfigureMonitor (this Microsoft.Extensions.Diagnostics.ResourceMonitoring.IResourceMonitorBuilder builder, Microsoft.Extensions.Configuration.IConfigurationSection section);
  * public static Microsoft.Extensions.Diagnostics.ResourceMonitoring.IResourceMonitorBuilder ConfigureMonitor (this Microsoft.Extensions.Diagnostics.ResourceMonitoring.IResourceMonitorBuilder builder, Action<Microsoft.Extensions.Diagnostics.ResourceMonitoring.ResourceMonitoringOptions> configure);
* Microsoft.Extensions.Diagnostics.ResourceMonitoring.ResourceMonitoringOptions
  * public ResourceMonitoringOptions ();
  * public TimeSpan CollectionWindow { get; set; }
  * public TimeSpan CpuConsumptionRefreshInterval { get; set; }
  * public TimeSpan MemoryConsumptionRefreshInterval { get; set; }
  * public TimeSpan PublishingWindow { get; set; }
  * public TimeSpan SamplingInterval { get; set; }
  * public System.Collections.Generic.ISet<string> SourceIpAddresses { get; set; }
* Microsoft.Extensions.Diagnostics.ResourceMonitoring.ResourceUtilization
  * public ResourceUtilization (double cpuUsedPercentage, ulong memoryUsedInBytes, Microsoft.Extensions.Diagnostics.ResourceMonitoring.SystemResources systemResources);
  * public double CpuUsedPercentage { get; }
  * public ulong MemoryUsedInBytes { get; }
  * public double MemoryUsedPercentage { get; }
  * public Microsoft.Extensions.Diagnostics.ResourceMonitoring.SystemResources SystemResources { get; }
* Microsoft.Extensions.Diagnostics.ResourceMonitoring.SystemResources
  * public SystemResources (double guaranteedCpuUnits, double maximumCpuUnits, ulong guaranteedMemoryInBytes, ulong maximumMemoryInBytes);
  * public double GuaranteedCpuUnits { get; }
  * public ulong GuaranteedMemoryInBytes { get; }
  * public double MaximumCpuUnits { get; }
  * public ulong MaximumMemoryInBytes { get; }
* Microsoft.Extensions.Hosting.ApplicationMetadataHostBuilderExtensions
  * public static Microsoft.Extensions.Hosting.IHostBuilder UseApplicationMetadata (this Microsoft.Extensions.Hosting.IHostBuilder builder, string sectionName = "ambientmetadata:application");
* Microsoft.Extensions.Hosting.FakeHostingExtensions
  * public static Microsoft.Extensions.Hosting.IHostBuilder AddFakeLoggingOutputSink (this Microsoft.Extensions.Hosting.IHostBuilder builder, Action<string> callback);
  * public static Microsoft.Extensions.Hosting.IHostBuilder Configure (this Microsoft.Extensions.Hosting.IHostBuilder builder, Action<Microsoft.Extensions.Hosting.IHostBuilder> configure);
  * public static Microsoft.Extensions.Hosting.IHostBuilder ConfigureAppConfiguration (this Microsoft.Extensions.Hosting.IHostBuilder builder, params (string key, string value)[] configurations);
  * public static Microsoft.Extensions.Hosting.IHostBuilder ConfigureAppConfiguration (this Microsoft.Extensions.Hosting.IHostBuilder builder, string key, string value);
  * public static Microsoft.Extensions.Hosting.IHostBuilder ConfigureHostConfiguration (this Microsoft.Extensions.Hosting.IHostBuilder builder, params (string key, string value)[] configurations);
  * public static Microsoft.Extensions.Hosting.IHostBuilder ConfigureHostConfiguration (this Microsoft.Extensions.Hosting.IHostBuilder builder, string key, string value);
  * public static Microsoft.Extensions.Logging.Testing.FakeLogCollector GetFakeLogCollector (this Microsoft.Extensions.Hosting.IHost host);
  * public static Microsoft.Extensions.Compliance.Testing.FakeRedactionCollector GetFakeRedactionCollector (this Microsoft.Extensions.Hosting.IHost host);
  * public static System.Threading.Tasks.Task StartAndStopAsync (this Microsoft.Extensions.Hosting.IHostedService service, System.Threading.CancellationToken cancellationToken = default);
* Microsoft.Extensions.Hosting.Host
  * public static Microsoft.Extensions.Hosting.HostApplicationBuilder CreateApplicationBuilder (Microsoft.Extensions.Hosting.HostApplicationBuilderSettings? settings);
  * public static Microsoft.Extensions.Hosting.HostApplicationBuilder CreateEmptyApplicationBuilder (Microsoft.Extensions.Hosting.HostApplicationBuilderSettings? settings);
* Microsoft.Extensions.Hosting.HostApplicationBuilder
  * public Microsoft.Extensions.Diagnostics.Metrics.IMetricsBuilder Metrics { get; }
  * Microsoft.Extensions.Configuration.IConfigurationManager Microsoft.Extensions.Hosting.IHostApplicationBuilder.Configuration { get; }
  * System.Collections.Generic.IDictionary<object,object> Microsoft.Extensions.Hosting.IHostApplicationBuilder.Properties { get; }
* Microsoft.Extensions.Hosting.HostingHostBuilderExtensions
  * public static Microsoft.Extensions.Hosting.IHostBuilder ConfigureMetrics (this Microsoft.Extensions.Hosting.IHostBuilder hostBuilder, Action<Microsoft.Extensions.Diagnostics.Metrics.IMetricsBuilder> configureMetrics);
  * public static Microsoft.Extensions.Hosting.IHostBuilder ConfigureMetrics (this Microsoft.Extensions.Hosting.IHostBuilder hostBuilder, Action<Microsoft.Extensions.Hosting.HostBuilderContext,Microsoft.Extensions.Diagnostics.Metrics.IMetricsBuilder> configureMetrics);
* Microsoft.Extensions.Hosting.HostOptions
  * public bool ServicesStartConcurrently { get; set; }
  * public bool ServicesStopConcurrently { get; set; }
  * public TimeSpan StartupTimeout { get; set; }
* Microsoft.Extensions.Hosting.IHostApplicationBuilder
  * public Microsoft.Extensions.Configuration.IConfigurationManager Configuration { get; }
  * public void ConfigureContainer<TContainerBuilder> (Microsoft.Extensions.DependencyInjection.IServiceProviderFactory<TContainerBuilder> factory, Action<TContainerBuilder>? configure = default);
  * public Microsoft.Extensions.Hosting.IHostEnvironment Environment { get; }
  * public Microsoft.Extensions.Logging.ILoggingBuilder Logging { get; }
  * public Microsoft.Extensions.Diagnostics.Metrics.IMetricsBuilder Metrics { get; }
  * public System.Collections.Generic.IDictionary<object,object> Properties { get; }
  * public Microsoft.Extensions.DependencyInjection.IServiceCollection Services { get; }
* Microsoft.Extensions.Hosting.IHostedLifecycleService
  * public System.Threading.Tasks.Task StartedAsync (System.Threading.CancellationToken cancellationToken);
  * public System.Threading.Tasks.Task StartingAsync (System.Threading.CancellationToken cancellationToken);
  * public System.Threading.Tasks.Task StoppedAsync (System.Threading.CancellationToken cancellationToken);
  * public System.Threading.Tasks.Task StoppingAsync (System.Threading.CancellationToken cancellationToken);
* Microsoft.Extensions.Hosting.SystemdHostBuilderExtensions
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddSystemd (this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
* Microsoft.Extensions.Hosting.WindowsServiceLifetimeHostBuilderExtensions
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddWindowsService (this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
  * public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddWindowsService (this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Action<Microsoft.Extensions.Hosting.WindowsServiceLifetimeOptions> configure);
  * public static Microsoft.Extensions.Hosting.IHostBuilder UseWindowsService (this Microsoft.Extensions.Hosting.IHostBuilder hostBuilder, Action<Microsoft.Extensions.Hosting.WindowsServiceLifetimeOptions> configure);
* Microsoft.Extensions.Hosting.WindowsServiceLifetimeOptions
  * public WindowsServiceLifetimeOptions ();
  * public string ServiceName { get; set; }
* Microsoft.Extensions.Hosting.Testing.FakeHost
  * public static Microsoft.Extensions.Hosting.IHostBuilder CreateBuilder ();
  * public static Microsoft.Extensions.Hosting.IHostBuilder CreateBuilder (Microsoft.Extensions.Hosting.Testing.FakeHostOptions options);
  * public static Microsoft.Extensions.Hosting.IHostBuilder CreateBuilder (Action<Microsoft.Extensions.Hosting.Testing.FakeHostOptions> configure);
  * public void Dispose ();
  * public IServiceProvider Services { get; }
  * public System.Threading.Tasks.Task StartAsync (System.Threading.CancellationToken cancellationToken = default);
  * public System.Threading.Tasks.Task StopAsync (System.Threading.CancellationToken cancellationToken = default);
* Microsoft.Extensions.Hosting.Testing.FakeHostOptions
  * public FakeHostOptions ();
  * public bool FakeLogging { get; set; }
  * public bool FakeRedaction { get; set; }
  * public TimeSpan ShutDownTimeout { get; set; }
  * public TimeSpan StartUpTimeout { get; set; }
  * public TimeSpan TimeToLive { get; set; }
  * public bool ValidateOnBuild { get; set; }
  * public bool ValidateScopes { get; set; }
* Microsoft.Extensions.Hosting.WindowsServices.WindowsServiceLifetime
  * public WindowsServiceLifetime (Microsoft.Extensions.Hosting.IHostEnvironment environment, Microsoft.Extensions.Hosting.IHostApplicationLifetime applicationLifetime, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.Extensions.Options.IOptions<Microsoft.Extensions.Hosting.HostOptions> optionsAccessor, Microsoft.Extensions.Options.IOptions<Microsoft.Extensions.Hosting.WindowsServiceLifetimeOptions> windowsServiceOptionsAccessor);
  * protected override void OnShutdown ();
* Microsoft.Extensions.Http.Diagnostics.HttpRouteParameterRedactionMode
  * Loose
  * None
  * Strict
* Microsoft.Extensions.Http.Diagnostics.IDownstreamDependencyMetadata
  * public string DependencyName { get; }
  * public System.Collections.Generic.ISet<Microsoft.Extensions.Http.Diagnostics.RequestMetadata> RequestMetadata { get; }
  * public System.Collections.Generic.ISet<string> UniqueHostNameSuffixes { get; }
* Microsoft.Extensions.Http.Diagnostics.IOutgoingRequestContext
  * public Microsoft.Extensions.Http.Diagnostics.RequestMetadata? RequestMetadata { get; }
  * public void SetRequestMetadata (Microsoft.Extensions.Http.Diagnostics.RequestMetadata metadata);
* Microsoft.Extensions.Http.Diagnostics.RequestMetadata
  * public RequestMetadata ();
  * public RequestMetadata (string methodType, string requestRoute, string requestName = "unknown");
  * public string DependencyName { get; set; }
  * public string MethodType { get; set; }
  * public string RequestName { get; set; }
  * public string RequestRoute { get; set; }
* Microsoft.Extensions.Http.Diagnostics.TelemetryConstants
  * public const string ClientApplicationNameHeader;
  * public const string Redacted;
  * public const string RequestMetadataKey;
  * public const string ServerApplicationNameHeader;
  * public const string Unknown;
* Microsoft.Extensions.Http.Latency.HttpClientLatencyTelemetryOptions
  * public HttpClientLatencyTelemetryOptions ();
  * public bool EnableDetailedLatencyBreakdown { get; set; }
* Microsoft.Extensions.Http.Logging.HttpClientLoggingTagNames
  * public const string Duration;
  * public const string Host;
  * public const string Method;
  * public const string Path;
  * public const string RequestBody;
  * public const string RequestHeaderPrefix;
  * public const string ResponseBody;
  * public const string ResponseHeaderPrefix;
  * public const string StatusCode;
  * public static System.Collections.Generic.IReadOnlyList<string> TagNames { get; }
* Microsoft.Extensions.Http.Logging.IHttpClientAsyncLogger
  * public System.Threading.Tasks.ValueTask LogRequestFailedAsync (object? context, System.Net.Http.HttpRequestMessage request, System.Net.Http.HttpResponseMessage? response, Exception exception, TimeSpan elapsed, System.Threading.CancellationToken cancellationToken = default);
  * public System.Threading.Tasks.ValueTask<object?> LogRequestStartAsync (System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken = default);
  * public System.Threading.Tasks.ValueTask LogRequestStopAsync (object? context, System.Net.Http.HttpRequestMessage request, System.Net.Http.HttpResponseMessage response, TimeSpan elapsed, System.Threading.CancellationToken cancellationToken = default);
* Microsoft.Extensions.Http.Logging.IHttpClientLogEnricher
  * public void Enrich (Microsoft.Extensions.Diagnostics.Enrichment.IEnrichmentTagCollector collector, System.Net.Http.HttpRequestMessage request, System.Net.Http.HttpResponseMessage? response, Exception? exception);
* Microsoft.Extensions.Http.Logging.IHttpClientLogger
  * public void LogRequestFailed (object? context, System.Net.Http.HttpRequestMessage request, System.Net.Http.HttpResponseMessage? response, Exception exception, TimeSpan elapsed);
  * public object? LogRequestStart (System.Net.Http.HttpRequestMessage request);
  * public void LogRequestStop (object? context, System.Net.Http.HttpRequestMessage request, System.Net.Http.HttpResponseMessage response, TimeSpan elapsed);
* Microsoft.Extensions.Http.Logging.LoggingHttpMessageHandler
  * protected override System.Net.Http.HttpResponseMessage Send (System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken);
* Microsoft.Extensions.Http.Logging.LoggingOptions
  * public LoggingOptions ();
  * public TimeSpan BodyReadTimeout { get; set; }
  * public int BodySizeLimit { get; set; }
  * public bool LogBody { get; set; }
  * public bool LogRequestStart { get; set; }
  * public System.Collections.Generic.ISet<string> RequestBodyContentTypes { get; set; }
  * public System.Collections.Generic.IDictionary<string,Microsoft.Extensions.Compliance.Classification.DataClassification> RequestHeadersDataClasses { get; set; }
  * public Microsoft.Extensions.Http.Logging.OutgoingPathLoggingMode RequestPathLoggingMode { get; set; }
  * public Microsoft.Extensions.Http.Diagnostics.HttpRouteParameterRedactionMode RequestPathParameterRedactionMode { get; set; }
  * public System.Collections.Generic.ISet<string> ResponseBodyContentTypes { get; set; }
  * public System.Collections.Generic.IDictionary<string,Microsoft.Extensions.Compliance.Classification.DataClassification> ResponseHeadersDataClasses { get; set; }
  * public System.Collections.Generic.IDictionary<string,Microsoft.Extensions.Compliance.Classification.DataClassification> RouteParameterDataClasses { get; set; }
* Microsoft.Extensions.Http.Logging.LoggingScopeHttpMessageHandler
  * protected override System.Net.Http.HttpResponseMessage Send (System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken);
* Microsoft.Extensions.Http.Logging.OutgoingPathLoggingMode
  * Formatted
  * Structured
* Microsoft.Extensions.Http.Resilience.HedgingEndpointOptions
  * public HedgingEndpointOptions ();
  * public Microsoft.Extensions.Http.Resilience.HttpCircuitBreakerStrategyOptions CircuitBreaker { get; set; }
  * public Microsoft.Extensions.Http.Resilience.HttpRateLimiterStrategyOptions RateLimiter { get; set; }
  * public Microsoft.Extensions.Http.Resilience.HttpTimeoutStrategyOptions Timeout { get; set; }
* Microsoft.Extensions.Http.Resilience.HttpCircuitBreakerStrategyOptions
  * public HttpCircuitBreakerStrategyOptions ();
* Microsoft.Extensions.Http.Resilience.HttpClientHedgingResiliencePredicates
  * public static bool IsTransient (Polly.Outcome<System.Net.Http.HttpResponseMessage> outcome);
* Microsoft.Extensions.Http.Resilience.HttpClientResiliencePredicates
  * public static bool IsTransient (Polly.Outcome<System.Net.Http.HttpResponseMessage> outcome);
* Microsoft.Extensions.Http.Resilience.HttpHedgingStrategyOptions
  * public HttpHedgingStrategyOptions ();
* Microsoft.Extensions.Http.Resilience.HttpRateLimiterStrategyOptions
  * public HttpRateLimiterStrategyOptions ();
* Microsoft.Extensions.Http.Resilience.HttpResiliencePipelineBuilderExtensions
  * public static Microsoft.Extensions.Http.Resilience.IHttpResiliencePipelineBuilder SelectPipelineBy (this Microsoft.Extensions.Http.Resilience.IHttpResiliencePipelineBuilder builder, Func<IServiceProvider,Func<System.Net.Http.HttpRequestMessage,string>> selectorFactory);
  * public static Microsoft.Extensions.Http.Resilience.IHttpResiliencePipelineBuilder SelectPipelineByAuthority (this Microsoft.Extensions.Http.Resilience.IHttpResiliencePipelineBuilder builder);
* Microsoft.Extensions.Http.Resilience.HttpRetryStrategyOptions
  * public HttpRetryStrategyOptions ();
  * public bool ShouldRetryAfterHeader { get; set; }
* Microsoft.Extensions.Http.Resilience.HttpStandardHedgingResilienceOptions
  * public HttpStandardHedgingResilienceOptions ();
  * public Microsoft.Extensions.Http.Resilience.HedgingEndpointOptions Endpoint { get; set; }
  * public Microsoft.Extensions.Http.Resilience.HttpHedgingStrategyOptions Hedging { get; set; }
  * public Microsoft.Extensions.Http.Resilience.HttpTimeoutStrategyOptions TotalRequestTimeout { get; set; }
* Microsoft.Extensions.Http.Resilience.HttpStandardResilienceOptions
  * public HttpStandardResilienceOptions ();
  * public Microsoft.Extensions.Http.Resilience.HttpTimeoutStrategyOptions AttemptTimeout { get; set; }
  * public Microsoft.Extensions.Http.Resilience.HttpCircuitBreakerStrategyOptions CircuitBreaker { get; set; }
  * public Microsoft.Extensions.Http.Resilience.HttpRateLimiterStrategyOptions RateLimiter { get; set; }
  * public Microsoft.Extensions.Http.Resilience.HttpRetryStrategyOptions Retry { get; set; }
  * public Microsoft.Extensions.Http.Resilience.HttpTimeoutStrategyOptions TotalRequestTimeout { get; set; }
* Microsoft.Extensions.Http.Resilience.HttpStandardResiliencePipelineBuilderExtensions
  * public static Microsoft.Extensions.Http.Resilience.IHttpStandardResiliencePipelineBuilder Configure (this Microsoft.Extensions.Http.Resilience.IHttpStandardResiliencePipelineBuilder builder, Microsoft.Extensions.Configuration.IConfigurationSection section);
  * public static Microsoft.Extensions.Http.Resilience.IHttpStandardResiliencePipelineBuilder Configure (this Microsoft.Extensions.Http.Resilience.IHttpStandardResiliencePipelineBuilder builder, Action<Microsoft.Extensions.Http.Resilience.HttpStandardResilienceOptions,IServiceProvider> configure);
  * public static Microsoft.Extensions.Http.Resilience.IHttpStandardResiliencePipelineBuilder Configure (this Microsoft.Extensions.Http.Resilience.IHttpStandardResiliencePipelineBuilder builder, Action<Microsoft.Extensions.Http.Resilience.HttpStandardResilienceOptions> configure);
  * public static Microsoft.Extensions.Http.Resilience.IHttpStandardResiliencePipelineBuilder SelectPipelineBy (this Microsoft.Extensions.Http.Resilience.IHttpStandardResiliencePipelineBuilder builder, Func<IServiceProvider,Func<System.Net.Http.HttpRequestMessage,string>> selectorFactory);
  * public static Microsoft.Extensions.Http.Resilience.IHttpStandardResiliencePipelineBuilder SelectPipelineByAuthority (this Microsoft.Extensions.Http.Resilience.IHttpStandardResiliencePipelineBuilder builder);
* Microsoft.Extensions.Http.Resilience.HttpTimeoutStrategyOptions
  * public HttpTimeoutStrategyOptions ();
* Microsoft.Extensions.Http.Resilience.IHttpResiliencePipelineBuilder
  * public string PipelineName { get; }
  * public Microsoft.Extensions.DependencyInjection.IServiceCollection Services { get; }
* Microsoft.Extensions.Http.Resilience.IHttpStandardResiliencePipelineBuilder
  * public string PipelineName { get; }
  * public Microsoft.Extensions.DependencyInjection.IServiceCollection Services { get; }
* Microsoft.Extensions.Http.Resilience.IRoutingStrategyBuilder
  * public string Name { get; }
  * public Microsoft.Extensions.DependencyInjection.IServiceCollection Services { get; }
* Microsoft.Extensions.Http.Resilience.IStandardHedgingHandlerBuilder
  * public string Name { get; }
  * public Microsoft.Extensions.Http.Resilience.IRoutingStrategyBuilder RoutingStrategyBuilder { get; }
  * public Microsoft.Extensions.DependencyInjection.IServiceCollection Services { get; }
* Microsoft.Extensions.Http.Resilience.OrderedGroupsRoutingOptions
  * public OrderedGroupsRoutingOptions ();
  * public System.Collections.Generic.IList<Microsoft.Extensions.Http.Resilience.UriEndpointGroup> Groups { get; set; }
* Microsoft.Extensions.Http.Resilience.ResilienceHandlerContext
  * public string BuilderName { get; }
  * public void EnableReloads<TOptions> (string? name = default);
  * public TOptions GetOptions<TOptions> (string? name = default);
  * public string InstanceName { get; }
  * public void OnPipelineDisposed (Action callback);
  * public IServiceProvider ServiceProvider { get; }
* Microsoft.Extensions.Http.Resilience.RoutingStrategyBuilderExtensions
  * public static Microsoft.Extensions.Http.Resilience.IRoutingStrategyBuilder ConfigureOrderedGroups (this Microsoft.Extensions.Http.Resilience.IRoutingStrategyBuilder builder, Microsoft.Extensions.Configuration.IConfigurationSection section);
  * public static Microsoft.Extensions.Http.Resilience.IRoutingStrategyBuilder ConfigureOrderedGroups (this Microsoft.Extensions.Http.Resilience.IRoutingStrategyBuilder builder, Action<Microsoft.Extensions.Http.Resilience.OrderedGroupsRoutingOptions,IServiceProvider> configure);
  * public static Microsoft.Extensions.Http.Resilience.IRoutingStrategyBuilder ConfigureOrderedGroups (this Microsoft.Extensions.Http.Resilience.IRoutingStrategyBuilder builder, Action<Microsoft.Extensions.Http.Resilience.OrderedGroupsRoutingOptions> configure);
  * public static Microsoft.Extensions.Http.Resilience.IRoutingStrategyBuilder ConfigureWeightedGroups (this Microsoft.Extensions.Http.Resilience.IRoutingStrategyBuilder builder, Microsoft.Extensions.Configuration.IConfigurationSection section);
  * public static Microsoft.Extensions.Http.Resilience.IRoutingStrategyBuilder ConfigureWeightedGroups (this Microsoft.Extensions.Http.Resilience.IRoutingStrategyBuilder builder, Action<Microsoft.Extensions.Http.Resilience.WeightedGroupsRoutingOptions,IServiceProvider> configure);
  * public static Microsoft.Extensions.Http.Resilience.IRoutingStrategyBuilder ConfigureWeightedGroups (this Microsoft.Extensions.Http.Resilience.IRoutingStrategyBuilder builder, Action<Microsoft.Extensions.Http.Resilience.WeightedGroupsRoutingOptions> configure);
* Microsoft.Extensions.Http.Resilience.StandardHedgingHandlerBuilderExtensions
  * public static Microsoft.Extensions.Http.Resilience.IStandardHedgingHandlerBuilder Configure (this Microsoft.Extensions.Http.Resilience.IStandardHedgingHandlerBuilder builder, Microsoft.Extensions.Configuration.IConfigurationSection section);
  * public static Microsoft.Extensions.Http.Resilience.IStandardHedgingHandlerBuilder Configure (this Microsoft.Extensions.Http.Resilience.IStandardHedgingHandlerBuilder builder, Action<Microsoft.Extensions.Http.Resilience.HttpStandardHedgingResilienceOptions,IServiceProvider> configure);
  * public static Microsoft.Extensions.Http.Resilience.IStandardHedgingHandlerBuilder Configure (this Microsoft.Extensions.Http.Resilience.IStandardHedgingHandlerBuilder builder, Action<Microsoft.Extensions.Http.Resilience.HttpStandardHedgingResilienceOptions> configure);
  * public static Microsoft.Extensions.Http.Resilience.IStandardHedgingHandlerBuilder SelectPipelineBy (this Microsoft.Extensions.Http.Resilience.IStandardHedgingHandlerBuilder builder, Func<IServiceProvider,Func<System.Net.Http.HttpRequestMessage,string>> selectorFactory);
  * public static Microsoft.Extensions.Http.Resilience.IStandardHedgingHandlerBuilder SelectPipelineByAuthority (this Microsoft.Extensions.Http.Resilience.IStandardHedgingHandlerBuilder builder);
* Microsoft.Extensions.Http.Resilience.UriEndpoint
  * public UriEndpoint ();
  * public Uri? Uri { get; set; }
* Microsoft.Extensions.Http.Resilience.UriEndpointGroup
  * public UriEndpointGroup ();
  * public System.Collections.Generic.IList<Microsoft.Extensions.Http.Resilience.WeightedUriEndpoint> Endpoints { get; set; }
* Microsoft.Extensions.Http.Resilience.WeightedGroupSelectionMode
  * EveryAttempt
  * InitialAttempt
* Microsoft.Extensions.Http.Resilience.WeightedGroupsRoutingOptions
  * public WeightedGroupsRoutingOptions ();
  * public System.Collections.Generic.IList<Microsoft.Extensions.Http.Resilience.WeightedUriEndpointGroup> Groups { get; set; }
  * public Microsoft.Extensions.Http.Resilience.WeightedGroupSelectionMode SelectionMode { get; set; }
* Microsoft.Extensions.Http.Resilience.WeightedUriEndpoint
  * public WeightedUriEndpoint ();
  * public Uri? Uri { get; set; }
  * public int Weight { get; set; }
* Microsoft.Extensions.Http.Resilience.WeightedUriEndpointGroup
  * public WeightedUriEndpointGroup ();
  * public int Weight { get; set; }
* Microsoft.Extensions.Logging.FakeLoggerBuilderExtensions
  * public static Microsoft.Extensions.Logging.ILoggingBuilder AddFakeLogging (this Microsoft.Extensions.Logging.ILoggingBuilder builder);
  * public static Microsoft.Extensions.Logging.ILoggingBuilder AddFakeLogging (this Microsoft.Extensions.Logging.ILoggingBuilder builder, Microsoft.Extensions.Configuration.IConfigurationSection section);
  * public static Microsoft.Extensions.Logging.ILoggingBuilder AddFakeLogging (this Microsoft.Extensions.Logging.ILoggingBuilder builder, Action<Microsoft.Extensions.Logging.Testing.FakeLogCollectorOptions> configure);
* Microsoft.Extensions.Logging.ITagCollector
  * public void Add (string tagName, object? tagValue);
  * public void Add (string tagName, object? tagValue, Microsoft.Extensions.Compliance.Classification.DataClassificationSet classifications);
* Microsoft.Extensions.Logging.LoggerEnrichmentOptions
  * public LoggerEnrichmentOptions ();
  * public bool CaptureStackTraces { get; set; }
  * public bool IncludeExceptionMessage { get; set; }
  * public int MaxStackTraceLength { get; set; }
  * public bool UseFileInfoForStackTraces { get; set; }
* Microsoft.Extensions.Logging.LoggerMessageAttribute
  * public LoggerMessageAttribute (Microsoft.Extensions.Logging.LogLevel level);
  * public LoggerMessageAttribute (string message);
  * public LoggerMessageAttribute (Microsoft.Extensions.Logging.LogLevel level, string message);
* Microsoft.Extensions.Logging.LoggerMessageHelper
  * public static string Stringify (System.Collections.IEnumerable? enumerable);
  * public static string Stringify<TKey,TValue> (System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>? enumerable);
  * public static Microsoft.Extensions.Logging.LoggerMessageState ThreadLocalState { get; }
* Microsoft.Extensions.Logging.LoggerMessageState+ClassifiedTag
  * public ClassifiedTag (string name, object? value, Microsoft.Extensions.Compliance.Classification.DataClassificationSet classifications);
  * public Microsoft.Extensions.Compliance.Classification.DataClassificationSet Classifications { get; }
  * public string Name { get; }
  * public object? Value { get; }
* Microsoft.Extensions.Logging.LoggerMessageState
  * public LoggerMessageState ();
  * public void AddClassifiedTag (string name, object? value, Microsoft.Extensions.Compliance.Classification.DataClassificationSet classifications);
  * public void AddTag (string name, object? value);
  * public Microsoft.Extensions.Logging.LoggerMessageState.ClassifiedTag[] ClassifiedTagArray { get; }
  * public int ClassifiedTagsCount { get; }
  * public void Clear ();
  * public System.Collections.Generic.KeyValuePair<string,object?> this[int index] { get; }
  * void IEnrichmentTagCollector.Add (string key, object value);
  * void ITagCollector.Add (string tagName, object? tagValue);
  * void ITagCollector.Add (string tagName, object? tagValue, Microsoft.Extensions.Compliance.Classification.DataClassificationSet classifications);
  * public System.Collections.Generic.KeyValuePair<string,object>[] RedactedTagArray { get; }
  * public int ReserveClassifiedTagSpace (int count);
  * public int ReserveTagSpace (int count);
  * System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string,object?>> IEnumerable<KeyValuePair<string,object>>.GetEnumerator ();
  * int System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Count { get; }
  * System.Collections.IEnumerator IEnumerable.GetEnumerator ();
  * public System.Collections.Generic.KeyValuePair<string,object>[] TagArray { get; }
  * public string TagNamePrefix { get; set; }
  * public int TagsCount { get; }
  * public override string ToString ();
* Microsoft.Extensions.Logging.LoggerRedactionOptions
  * public LoggerRedactionOptions ();
  * public bool ApplyDiscriminator { get; set; }
* Microsoft.Extensions.Logging.LoggingEnrichmentExtensions
  * public static Microsoft.Extensions.Logging.ILoggingBuilder EnableEnrichment (this Microsoft.Extensions.Logging.ILoggingBuilder builder);
  * public static Microsoft.Extensions.Logging.ILoggingBuilder EnableEnrichment (this Microsoft.Extensions.Logging.ILoggingBuilder builder, Microsoft.Extensions.Configuration.IConfigurationSection section);
  * public static Microsoft.Extensions.Logging.ILoggingBuilder EnableEnrichment (this Microsoft.Extensions.Logging.ILoggingBuilder builder, Action<Microsoft.Extensions.Logging.LoggerEnrichmentOptions> configure);
* Microsoft.Extensions.Logging.LoggingRedactionExtensions
  * public static Microsoft.Extensions.Logging.ILoggingBuilder EnableRedaction (this Microsoft.Extensions.Logging.ILoggingBuilder builder);
  * public static Microsoft.Extensions.Logging.ILoggingBuilder EnableRedaction (this Microsoft.Extensions.Logging.ILoggingBuilder builder, Microsoft.Extensions.Configuration.IConfigurationSection section);
  * public static Microsoft.Extensions.Logging.ILoggingBuilder EnableRedaction (this Microsoft.Extensions.Logging.ILoggingBuilder builder, Action<Microsoft.Extensions.Logging.LoggerRedactionOptions> configure);
* Microsoft.Extensions.Logging.LogPropertiesAttribute
  * public LogPropertiesAttribute ();
  * public bool OmitReferenceName { get; set; }
  * public bool SkipNullProperties { get; set; }
* Microsoft.Extensions.Logging.LogPropertyIgnoreAttribute
  * public LogPropertyIgnoreAttribute ();
* Microsoft.Extensions.Logging.TagProviderAttribute
  * public TagProviderAttribute (Type providerType, string providerMethod);
  * public bool OmitReferenceName { get; set; }
  * public string ProviderMethod { get; }
  * public Type ProviderType { get; }
* Microsoft.Extensions.ObjectPool.DependencyInjectionPoolOptions
  * public DependencyInjectionPoolOptions ();
  * public int Capacity { get; set; }
* Microsoft.Extensions.ObjectPool.IResettable
  * public bool TryReset ();
* Microsoft.Extensions.Options.IStartupValidator
  * public void Validate ();
* Microsoft.Extensions.Options.OptionsValidatorAttribute
  * public OptionsValidatorAttribute ();
* Microsoft.Extensions.Options.ValidateEnumeratedItemsAttribute
  * public ValidateEnumeratedItemsAttribute ();
  * public ValidateEnumeratedItemsAttribute (Type validator);
  * public Type? Validator { get; }
* Microsoft.Extensions.Options.ValidateObjectMembersAttribute
  * public ValidateObjectMembersAttribute ();
  * public ValidateObjectMembersAttribute (Type validator);
  * public Type? Validator { get; }
* Microsoft.Extensions.Options.ValidateOptionsResultBuilder
  * public ValidateOptionsResultBuilder ();
  * public void AddError (string error, string? propertyName = default);
  * public void AddResult (Microsoft.Extensions.Options.ValidateOptionsResult result);
  * public void AddResult (System.ComponentModel.DataAnnotations.ValidationResult? result);
  * public void AddResults (System.Collections.Generic.IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult?>? results);
  * public Microsoft.Extensions.Options.ValidateOptionsResult Build ();
  * public void Clear ();
* Microsoft.Extensions.Options.Contextual.IConfigureContextualOptions<TOptions>
  * public void Configure (TOptions options);
* Microsoft.Extensions.Options.Contextual.IContextualOptionsFactory<TOptions>
  * public System.Threading.Tasks.ValueTask<TOptions> CreateAsync<TContext> (string name, in TContext context, System.Threading.CancellationToken cancellationToken) where TContext : Microsoft.Extensions.Options.Contextual.IOptionsContext;
* Microsoft.Extensions.Options.Contextual.IContextualOptions<TOptions>
  * public System.Threading.Tasks.ValueTask<TOptions> GetAsync<TContext> (in TContext context, System.Threading.CancellationToken cancellationToken) where TContext : Microsoft.Extensions.Options.Contextual.IOptionsContext;
* Microsoft.Extensions.Options.Contextual.ILoadContextualOptions<TOptions>
  * public System.Threading.Tasks.ValueTask<Microsoft.Extensions.Options.Contextual.IConfigureContextualOptions<TOptions>> LoadAsync<TContext> (string name, in TContext context, System.Threading.CancellationToken cancellationToken) where TContext : Microsoft.Extensions.Options.Contextual.IOptionsContext;
* Microsoft.Extensions.Options.Contextual.INamedContextualOptions<TOptions>
  * public System.Threading.Tasks.ValueTask<TOptions> GetAsync<TContext> (string name, in TContext context, System.Threading.CancellationToken cancellationToken) where TContext : Microsoft.Extensions.Options.Contextual.IOptionsContext;
* Microsoft.Extensions.Options.Contextual.IOptionsContext
  * public void PopulateReceiver<T> (T receiver) where T : Microsoft.Extensions.Options.Contextual.IOptionsContextReceiver;
* Microsoft.Extensions.Options.Contextual.IOptionsContextReceiver
  * public void Receive<T> (string key, T value);
* Microsoft.Extensions.Options.Contextual.IPostConfigureContextualOptions<TOptions>
  * public void PostConfigure<TContext> (string name, in TContext context, TOptions options) where TContext : Microsoft.Extensions.Options.Contextual.IOptionsContext;
* Microsoft.Extensions.Options.Contextual.IValidateContextualOptions<TOptions>
  * public Microsoft.Extensions.Options.ValidateOptionsResult Validate (string? name, TOptions options);
* Microsoft.Extensions.Options.Contextual.NullConfigureContextualOptions
  * public static Microsoft.Extensions.Options.Contextual.IConfigureContextualOptions<TOptions> GetInstance<TOptions> () where TOptions : class;
* Microsoft.Extensions.Options.Contextual.OptionsContextAttribute
  * public OptionsContextAttribute ();
* Microsoft.Extensions.Time.Testing.FakeTimeProvider
  * public FakeTimeProvider ();
  * public FakeTimeProvider (DateTimeOffset startDateTime);
  * public void Advance (TimeSpan delta);
  * public TimeSpan AutoAdvanceAmount { get; set; }
  * public override System.Threading.ITimer CreateTimer (System.Threading.TimerCallback callback, object? state, TimeSpan dueTime, TimeSpan period);
  * public override long GetTimestamp ();
  * public override DateTimeOffset GetUtcNow ();
  * public override TimeZoneInfo LocalTimeZone { get; }
  * public void SetLocalTimeZone (TimeZoneInfo localTimeZone);
  * public void SetUtcNow (DateTimeOffset value);
  * public DateTimeOffset Start { get; }
  * public override long TimestampFrequency { get; }
  * public override string ToString ();
* Microsoft.Win32.CommonItemDialog
  * public bool AddToRecent { get; set; }
  * public Guid? ClientGuid { get; set; }
  * public System.Collections.Generic.IList<Microsoft.Win32.FileDialogCustomPlace> CustomPlaces { get; set; }
  * public string DefaultDirectory { get; set; }
  * public bool DereferenceLinks { get; set; }
  * public string InitialDirectory { get; set; }
  * protected virtual void OnItemOk (System.ComponentModel.CancelEventArgs e);
  * public override void Reset ();
  * public string RootDirectory { get; set; }
  * protected override bool RunDialog (IntPtr hwndOwner);
  * public bool ShowHiddenItems { get; set; }
  * public string Title { get; set; }
  * public override string ToString ();
  * public bool ValidateNames { get; set; }
* Microsoft.Win32.FileDialog
  * protected override void OnItemOk (System.ComponentModel.CancelEventArgs e);
* Microsoft.Win32.OpenFileDialog
  * public bool ForcePreviewPane { get; set; }
* Microsoft.Win32.OpenFolderDialog
  * public OpenFolderDialog ();
  * public string FolderName { get; set; }
  * public string[] FolderNames { get; }
  * public event System.ComponentModel.CancelEventHandler FolderOk;
  * public bool Multiselect { get; set; }
  * protected override void OnItemOk (System.ComponentModel.CancelEventArgs e);
  * public override void Reset ();
  * public string SafeFolderName { get; }
  * public string[] SafeFolderNames { get; }
  * public override string ToString ();
* Microsoft.Win32.SaveFileDialog
  * public bool CreateTestFile { get; set; }
* Polly.ResilienceContextExtensions
  * public static Microsoft.Extensions.Http.Diagnostics.RequestMetadata? GetRequestMetadata (this Polly.ResilienceContext context);
  * public static void SetRequestMetadata (this Polly.ResilienceContext context, Microsoft.Extensions.Http.Diagnostics.RequestMetadata requestMetadata);
* System.ArgumentException
  * public static void ThrowIfNullOrWhiteSpace (string? argument, string? paramName = default);
* System.ArgumentOutOfRangeException
  * public static void ThrowIfEqual<T> (T value, T other, string? paramName = default) where T : IEquatable<T>;
  * public static void ThrowIfGreaterThan<T> (T value, T other, string? paramName = default) where T : IComparable<T>;
  * public static void ThrowIfGreaterThanOrEqual<T> (T value, T other, string? paramName = default) where T : IComparable<T>;
  * public static void ThrowIfLessThan<T> (T value, T other, string? paramName = default) where T : IComparable<T>;
  * public static void ThrowIfLessThanOrEqual<T> (T value, T other, string? paramName = default) where T : IComparable<T>;
  * public static void ThrowIfNegative<T> (T value, string? paramName = default) where T : System.Numerics.INumberBase<T>;
  * public static void ThrowIfNegativeOrZero<T> (T value, string? paramName = default) where T : System.Numerics.INumberBase<T>;
  * public static void ThrowIfNotEqual<T> (T value, T other, string? paramName = default) where T : IEquatable<T>;
  * public static void ThrowIfZero<T> (T value, string? paramName = default) where T : System.Numerics.INumberBase<T>;
* System.BinaryData
  * public BinaryData (byte[] data, string? mediaType);
  * public BinaryData (ReadOnlyMemory<byte> data, string? mediaType);
  * public BinaryData (string data, string? mediaType);
  * public static BinaryData FromBytes (byte[] data, string? mediaType);
  * public static BinaryData FromBytes (ReadOnlyMemory<byte> data, string? mediaType);
  * public static BinaryData FromStream (System.IO.Stream stream, string? mediaType);
  * public static System.Threading.Tasks.Task<BinaryData> FromStreamAsync (System.IO.Stream stream, string? mediaType, System.Threading.CancellationToken cancellationToken = default);
  * public static BinaryData FromString (string data, string? mediaType);
  * public bool IsEmpty { get; }
  * public int Length { get; }
  * public string? MediaType { get; }
  * public BinaryData WithMediaType (string? mediaType);
* System.Boolean
  * static bool IParsable<bool>.Parse (string s, IFormatProvider provider);
  * static bool IParsable<bool>.TryParse (string s, IFormatProvider provider, out bool result);
  * static bool ISpanParsable<bool>.Parse (ReadOnlySpan<char> s, IFormatProvider provider);
  * static bool ISpanParsable<bool>.TryParse (ReadOnlySpan<char> s, IFormatProvider provider, out bool result);
* System.Byte
  * public static byte Parse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider);
  * public static byte Parse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.Integer, IFormatProvider? provider = default);
  * public bool TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, out byte result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, out byte result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style, IFormatProvider? provider, out byte result);
* System.Char
  * bool IUtf8SpanFormattable.TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider provider);
* System.ConsoleKey
  * None
* System.ConsoleModifiers
  * None
* System.DateOnly
  * public void Deconstruct (out int year, out int month, out int day);
  * public bool TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default);
* System.DateTime
  * public DateTime (DateOnly date, TimeOnly time);
  * public DateTime (DateOnly date, TimeOnly time, DateTimeKind kind);
  * public void Deconstruct (out DateOnly date, out TimeOnly time);
  * public void Deconstruct (out int year, out int month, out int day);
  * public bool TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default);
* System.DateTimeOffset
  * public DateTimeOffset (DateOnly date, TimeOnly time, TimeSpan offset);
  * public void Deconstruct (out DateOnly date, out TimeOnly time, out TimeSpan offset);
  * public int TotalOffsetMinutes { get; }
  * public bool TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = default, IFormatProvider? formatProvider = default);
* System.Decimal
  * public static decimal Parse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider);
  * public static decimal Parse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.Number, IFormatProvider? provider = default);
  * public bool TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, out decimal result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, out decimal result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style, IFormatProvider? provider, out decimal result);
* System.Double
  * public static double DegreesToRadians (double degrees);
  * public static double Lerp (double value1, double value2, double amount);
  * public static double Parse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider);
  * public static double Parse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, IFormatProvider? provider = default);
  * public static double RadiansToDegrees (double radians);
  * public bool TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, out double result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, out double result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style, IFormatProvider? provider, out double result);
* System.Enum
  * bool ISpanFormattable.TryFormat (Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider);
  * public static bool TryFormat<TEnum> (TEnum value, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default) where TEnum : struct;
* System.Environment
  * public static bool IsPrivilegedProcess { get; }
* System.FakeLoggerServiceProviderExtensions
  * public static Microsoft.Extensions.Logging.Testing.FakeLogCollector GetFakeLogCollector (this IServiceProvider services);
* System.FakeRedactionServiceProviderExtensions
  * public static Microsoft.Extensions.Compliance.Testing.FakeRedactionCollector GetFakeRedactionCollector (this IServiceProvider serviceProvider);
* System.GC
  * public static void RefreshMemoryLimit ();
  * public static void RegisterNoGCRegionCallback (long totalSize, Action callback);
* System.Guid
  * public Guid (ReadOnlySpan<byte> b, bool bigEndian);
  * bool IUtf8SpanFormattable.TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider provider);
  * public byte[] ToByteArray (bool bigEndian);
  * public bool TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = default);
  * public bool TryWriteBytes (Span<byte> destination, bool bigEndian, out int bytesWritten);
* System.Half
  * public static Half DegreesToRadians (Half degrees);
  * public static Half Lerp (Half value1, Half value2, Half amount);
  * public static Half Parse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider);
  * public static Half Parse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, IFormatProvider? provider = default);
  * public static Half RadiansToDegrees (Half radians);
  * public bool TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, out Half result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, out Half result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style, IFormatProvider? provider, out Half result);
* System.Int128
  * public static Int128 Parse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider);
  * public static Int128 Parse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.Integer, IFormatProvider? provider = default);
  * public bool TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, out Int128 result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, out Int128 result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style, IFormatProvider? provider, out Int128 result);
* System.Int16
  * public static short Parse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider);
  * public static short Parse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.Integer, IFormatProvider? provider = default);
  * public bool TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, out short result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, out short result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style, IFormatProvider? provider, out short result);
* System.Int32
  * public static int Parse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider);
  * public static int Parse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.Integer, IFormatProvider? provider = default);
  * public bool TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, out int result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, out int result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style, IFormatProvider? provider, out int result);
* System.Int64
  * public static long Parse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider);
  * public static long Parse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.Integer, IFormatProvider? provider = default);
  * public bool TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, out long result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, out long result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style, IFormatProvider? provider, out long result);
* System.IntPtr
  * public static IntPtr Parse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider);
  * public static IntPtr Parse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.Integer, IFormatProvider? provider = default);
  * public bool TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, out IntPtr result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, out IntPtr result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style, IFormatProvider? provider, out IntPtr result);
* System.IUtf8SpanFormattable
  * public bool TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider? provider);
* System.IUtf8SpanParsable<TSelf>
  * public static abstract TSelf Parse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider);
  * public static abstract bool TryParse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, out TSelf result);
* System.MemoryExtensions
  * public static ReadOnlySpan<char> AsSpan (this string? text, Index startIndex);
  * public static ReadOnlySpan<char> AsSpan (this string? text, Range range);
  * public static bool ContainsAny<T> (this ReadOnlySpan<T> span, System.Buffers.SearchValues<T> values) where T : IEquatable<T>;
  * public static bool ContainsAny<T> (this ReadOnlySpan<T> span, ReadOnlySpan<T> values) where T : IEquatable<T>;
  * public static bool ContainsAny<T> (this Span<T> span, System.Buffers.SearchValues<T> values) where T : IEquatable<T>;
  * public static bool ContainsAny<T> (this Span<T> span, ReadOnlySpan<T> values) where T : IEquatable<T>;
  * public static bool ContainsAny<T> (this ReadOnlySpan<T> span, T value0, T value1) where T : IEquatable<T>;
  * public static bool ContainsAny<T> (this Span<T> span, T value0, T value1) where T : IEquatable<T>;
  * public static bool ContainsAny<T> (this ReadOnlySpan<T> span, T value0, T value1, T value2) where T : IEquatable<T>;
  * public static bool ContainsAny<T> (this Span<T> span, T value0, T value1, T value2) where T : IEquatable<T>;
  * public static bool ContainsAnyExcept<T> (this ReadOnlySpan<T> span, System.Buffers.SearchValues<T> values) where T : IEquatable<T>;
  * public static bool ContainsAnyExcept<T> (this ReadOnlySpan<T> span, ReadOnlySpan<T> values) where T : IEquatable<T>;
  * public static bool ContainsAnyExcept<T> (this ReadOnlySpan<T> span, T value) where T : IEquatable<T>;
  * public static bool ContainsAnyExcept<T> (this Span<T> span, System.Buffers.SearchValues<T> values) where T : IEquatable<T>;
  * public static bool ContainsAnyExcept<T> (this Span<T> span, ReadOnlySpan<T> values) where T : IEquatable<T>;
  * public static bool ContainsAnyExcept<T> (this Span<T> span, T value) where T : IEquatable<T>;
  * public static bool ContainsAnyExcept<T> (this ReadOnlySpan<T> span, T value0, T value1) where T : IEquatable<T>;
  * public static bool ContainsAnyExcept<T> (this Span<T> span, T value0, T value1) where T : IEquatable<T>;
  * public static bool ContainsAnyExcept<T> (this ReadOnlySpan<T> span, T value0, T value1, T value2) where T : IEquatable<T>;
  * public static bool ContainsAnyExcept<T> (this Span<T> span, T value0, T value1, T value2) where T : IEquatable<T>;
  * public static bool ContainsAnyExceptInRange<T> (this ReadOnlySpan<T> span, T lowInclusive, T highInclusive) where T : IComparable<T>;
  * public static bool ContainsAnyExceptInRange<T> (this Span<T> span, T lowInclusive, T highInclusive) where T : IComparable<T>;
  * public static bool ContainsAnyInRange<T> (this ReadOnlySpan<T> span, T lowInclusive, T highInclusive) where T : IComparable<T>;
  * public static bool ContainsAnyInRange<T> (this Span<T> span, T lowInclusive, T highInclusive) where T : IComparable<T>;
  * public static int Count<T> (this ReadOnlySpan<T> span, ReadOnlySpan<T> value) where T : IEquatable<T>;
  * public static int Count<T> (this ReadOnlySpan<T> span, T value) where T : IEquatable<T>;
  * public static int Count<T> (this Span<T> span, ReadOnlySpan<T> value) where T : IEquatable<T>;
  * public static int Count<T> (this Span<T> span, T value) where T : IEquatable<T>;
  * public static int IndexOfAny<T> (this ReadOnlySpan<T> span, System.Buffers.SearchValues<T> values) where T : IEquatable<T>;
  * public static int IndexOfAny<T> (this Span<T> span, System.Buffers.SearchValues<T> values) where T : IEquatable<T>;
  * public static int IndexOfAnyExcept<T> (this ReadOnlySpan<T> span, System.Buffers.SearchValues<T> values) where T : IEquatable<T>;
  * public static int IndexOfAnyExcept<T> (this Span<T> span, System.Buffers.SearchValues<T> values) where T : IEquatable<T>;
  * public static int IndexOfAnyExceptInRange<T> (this ReadOnlySpan<T> span, T lowInclusive, T highInclusive) where T : IComparable<T>;
  * public static int IndexOfAnyExceptInRange<T> (this Span<T> span, T lowInclusive, T highInclusive) where T : IComparable<T>;
  * public static int IndexOfAnyInRange<T> (this ReadOnlySpan<T> span, T lowInclusive, T highInclusive) where T : IComparable<T>;
  * public static int IndexOfAnyInRange<T> (this Span<T> span, T lowInclusive, T highInclusive) where T : IComparable<T>;
  * public static int LastIndexOfAny<T> (this ReadOnlySpan<T> span, System.Buffers.SearchValues<T> values) where T : IEquatable<T>;
  * public static int LastIndexOfAny<T> (this Span<T> span, System.Buffers.SearchValues<T> values) where T : IEquatable<T>;
  * public static int LastIndexOfAnyExcept<T> (this ReadOnlySpan<T> span, System.Buffers.SearchValues<T> values) where T : IEquatable<T>;
  * public static int LastIndexOfAnyExcept<T> (this Span<T> span, System.Buffers.SearchValues<T> values) where T : IEquatable<T>;
  * public static int LastIndexOfAnyExceptInRange<T> (this ReadOnlySpan<T> span, T lowInclusive, T highInclusive) where T : IComparable<T>;
  * public static int LastIndexOfAnyExceptInRange<T> (this Span<T> span, T lowInclusive, T highInclusive) where T : IComparable<T>;
  * public static int LastIndexOfAnyInRange<T> (this ReadOnlySpan<T> span, T lowInclusive, T highInclusive) where T : IComparable<T>;
  * public static int LastIndexOfAnyInRange<T> (this Span<T> span, T lowInclusive, T highInclusive) where T : IComparable<T>;
  * public static void Replace<T> (this Span<T> span, T oldValue, T newValue) where T : IEquatable<T>;
  * public static void Replace<T> (this ReadOnlySpan<T> source, Span<T> destination, T oldValue, T newValue) where T : IEquatable<T>;
  * public static int Split (this ReadOnlySpan<char> source, Span<Range> destination, char separator, StringSplitOptions options = System.StringSplitOptions.None);
  * public static int Split (this ReadOnlySpan<char> source, Span<Range> destination, ReadOnlySpan<char> separator, StringSplitOptions options = System.StringSplitOptions.None);
  * public static int SplitAny (this ReadOnlySpan<char> source, Span<Range> destination, ReadOnlySpan<char> separators, StringSplitOptions options = System.StringSplitOptions.None);
  * public static int SplitAny (this ReadOnlySpan<char> source, Span<Range> destination, ReadOnlySpan<string> separators, StringSplitOptions options = System.StringSplitOptions.None);
  * public static bool TryWrite (this Span<char> destination, IFormatProvider? provider, System.Text.CompositeFormat format, out int charsWritten, params object?[] args);
  * public static bool TryWrite (this Span<char> destination, IFormatProvider? provider, System.Text.CompositeFormat format, out int charsWritten, ReadOnlySpan<object?> args);
  * public static bool TryWrite<TArg0> (this Span<char> destination, IFormatProvider? provider, System.Text.CompositeFormat format, out int charsWritten, TArg0 arg0);
  * public static bool TryWrite<TArg0,TArg1> (this Span<char> destination, IFormatProvider? provider, System.Text.CompositeFormat format, out int charsWritten, TArg0 arg0, TArg1 arg1);
  * public static bool TryWrite<TArg0,TArg1,TArg2> (this Span<char> destination, IFormatProvider? provider, System.Text.CompositeFormat format, out int charsWritten, TArg0 arg0, TArg1 arg1, TArg2 arg2);
* System.OperatingSystem
  * public static bool IsWasi ();
* System.Random
  * public T[] GetItems<T> (ReadOnlySpan<T> choices, int length);
  * public void GetItems<T> (ReadOnlySpan<T> choices, Span<T> destination);
  * public T[] GetItems<T> (T[] choices, int length);
  * public void Shuffle<T> (Span<T> values);
  * public void Shuffle<T> (T[] values);
* System.SByte
  * public static sbyte Parse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider);
  * public static sbyte Parse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.Integer, IFormatProvider? provider = default);
  * public bool TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, out sbyte result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, out sbyte result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style, IFormatProvider? provider, out sbyte result);
* System.Single
  * public static float DegreesToRadians (float degrees);
  * public static float Lerp (float value1, float value2, float amount);
  * public static float Parse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider);
  * public static float Parse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, IFormatProvider? provider = default);
  * public static float RadiansToDegrees (float radians);
  * public bool TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, out float result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, out float result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style, IFormatProvider? provider, out float result);
* System.String
  * public static string Format (IFormatProvider? provider, System.Text.CompositeFormat format, params object?[] args);
  * public static string Format (IFormatProvider? provider, System.Text.CompositeFormat format, ReadOnlySpan<object?> args);
  * public static string Format<TArg0> (IFormatProvider? provider, System.Text.CompositeFormat format, TArg0 arg0);
  * public static string Format<TArg0,TArg1> (IFormatProvider? provider, System.Text.CompositeFormat format, TArg0 arg0, TArg1 arg1);
  * public static string Format<TArg0,TArg1,TArg2> (IFormatProvider? provider, System.Text.CompositeFormat format, TArg0 arg0, TArg1 arg1, TArg2 arg2);
  * static string IParsable<string>.Parse (string s, IFormatProvider provider);
  * static bool IParsable<string>.TryParse (string s, IFormatProvider provider, out string result);
  * static string ISpanParsable<string>.Parse (ReadOnlySpan<char> s, IFormatProvider provider);
  * static bool ISpanParsable<string>.TryParse (ReadOnlySpan<char> s, IFormatProvider provider, out string result);
* System.TimeOnly
  * public void Deconstruct (out int hour, out int minute);
  * public void Deconstruct (out int hour, out int minute, out int second);
  * public void Deconstruct (out int hour, out int minute, out int second, out int millisecond);
  * public void Deconstruct (out int hour, out int minute, out int second, out int millisecond, out int microsecond);
  * public bool TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default);
* System.TimeProvider
  * protected TimeProvider ();
  * public virtual System.Threading.ITimer CreateTimer (System.Threading.TimerCallback callback, object? state, TimeSpan dueTime, TimeSpan period);
  * public TimeSpan GetElapsedTime (long startingTimestamp);
  * public TimeSpan GetElapsedTime (long startingTimestamp, long endingTimestamp);
  * public DateTimeOffset GetLocalNow ();
  * public virtual long GetTimestamp ();
  * public virtual DateTimeOffset GetUtcNow ();
  * public virtual TimeZoneInfo LocalTimeZone { get; }
  * public static TimeProvider System { get; }
  * public virtual long TimestampFrequency { get; }
* System.TimeSpan
  * public bool TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = default, IFormatProvider? formatProvider = default);
* System.TimeZoneInfo
  * public static System.Collections.ObjectModel.ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones (bool skipSorting);
  * public static bool TryFindSystemTimeZoneById (string id, out TimeZoneInfo? timeZoneInfo);
* System.Type
  * public virtual Type[] GetFunctionPointerCallingConventions ();
  * public virtual Type[] GetFunctionPointerParameterTypes ();
  * public virtual Type GetFunctionPointerReturnType ();
  * public virtual Type[] GetOptionalCustomModifiers ();
  * public virtual Type[] GetRequiredCustomModifiers ();
  * public virtual bool IsFunctionPointer { get; }
  * public virtual bool IsUnmanagedFunctionPointer { get; }
* System.UInt128
  * public static UInt128 Parse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider);
  * public static UInt128 Parse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.Integer, IFormatProvider? provider = default);
  * public bool TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, out UInt128 result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, out UInt128 result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style, IFormatProvider? provider, out UInt128 result);
* System.UInt16
  * public static ushort Parse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider);
  * public static ushort Parse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.Integer, IFormatProvider? provider = default);
  * public bool TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, out ushort result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, out ushort result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style, IFormatProvider? provider, out ushort result);
* System.UInt32
  * public static uint Parse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider);
  * public static uint Parse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.Integer, IFormatProvider? provider = default);
  * public bool TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, out uint result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, out uint result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style, IFormatProvider? provider, out uint result);
* System.UInt64
  * public static ulong Parse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider);
  * public static ulong Parse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.Integer, IFormatProvider? provider = default);
  * public bool TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, out ulong result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, out ulong result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style, IFormatProvider? provider, out ulong result);
* System.UIntPtr
  * public static UIntPtr Parse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider);
  * public static UIntPtr Parse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.Integer, IFormatProvider? provider = default);
  * public bool TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, out UIntPtr result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, out UIntPtr result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style, IFormatProvider? provider, out UIntPtr result);
* System.Uri
  * string IFormattable.ToString (string format, IFormatProvider formatProvider);
  * bool ISpanFormattable.TryFormat (Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider);
  * public bool TryFormat (Span<char> destination, out int charsWritten);
* System.Version
  * bool IUtf8SpanFormattable.TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider provider);
  * public bool TryFormat (Span<byte> utf8Destination, out int bytesWritten);
  * public bool TryFormat (Span<byte> utf8Destination, int fieldCount, out int bytesWritten);
* System.Buffers.ArrayBufferWriter<T>
  * public void ResetWrittenCount ();
* System.Buffers.SearchValues
  * public static System.Buffers.SearchValues<byte> Create (ReadOnlySpan<byte> values);
  * public static System.Buffers.SearchValues<char> Create (ReadOnlySpan<char> values);
* System.Buffers.SearchValues<T>
  * public bool Contains (T value);
* System.Buffers.Binary.BinaryPrimitives
  * public static Int128 ReadInt128BigEndian (ReadOnlySpan<byte> source);
  * public static Int128 ReadInt128LittleEndian (ReadOnlySpan<byte> source);
  * public static IntPtr ReadIntPtrBigEndian (ReadOnlySpan<byte> source);
  * public static IntPtr ReadIntPtrLittleEndian (ReadOnlySpan<byte> source);
  * public static UInt128 ReadUInt128BigEndian (ReadOnlySpan<byte> source);
  * public static UInt128 ReadUInt128LittleEndian (ReadOnlySpan<byte> source);
  * public static UIntPtr ReadUIntPtrBigEndian (ReadOnlySpan<byte> source);
  * public static UIntPtr ReadUIntPtrLittleEndian (ReadOnlySpan<byte> source);
  * public static Int128 ReverseEndianness (Int128 value);
  * public static IntPtr ReverseEndianness (IntPtr value);
  * public static UInt128 ReverseEndianness (UInt128 value);
  * public static UIntPtr ReverseEndianness (UIntPtr value);
  * public static void ReverseEndianness (ReadOnlySpan<Int128> source, Span<Int128> destination);
  * public static void ReverseEndianness (ReadOnlySpan<short> source, Span<short> destination);
  * public static void ReverseEndianness (ReadOnlySpan<int> source, Span<int> destination);
  * public static void ReverseEndianness (ReadOnlySpan<long> source, Span<long> destination);
  * public static void ReverseEndianness (ReadOnlySpan<IntPtr> source, Span<IntPtr> destination);
  * public static void ReverseEndianness (ReadOnlySpan<UInt128> source, Span<UInt128> destination);
  * public static void ReverseEndianness (ReadOnlySpan<ushort> source, Span<ushort> destination);
  * public static void ReverseEndianness (ReadOnlySpan<uint> source, Span<uint> destination);
  * public static void ReverseEndianness (ReadOnlySpan<ulong> source, Span<ulong> destination);
  * public static void ReverseEndianness (ReadOnlySpan<UIntPtr> source, Span<UIntPtr> destination);
  * public static bool TryReadInt128BigEndian (ReadOnlySpan<byte> source, out Int128 value);
  * public static bool TryReadInt128LittleEndian (ReadOnlySpan<byte> source, out Int128 value);
  * public static bool TryReadIntPtrBigEndian (ReadOnlySpan<byte> source, out IntPtr value);
  * public static bool TryReadIntPtrLittleEndian (ReadOnlySpan<byte> source, out IntPtr value);
  * public static bool TryReadUInt128BigEndian (ReadOnlySpan<byte> source, out UInt128 value);
  * public static bool TryReadUInt128LittleEndian (ReadOnlySpan<byte> source, out UInt128 value);
  * public static bool TryReadUIntPtrBigEndian (ReadOnlySpan<byte> source, out UIntPtr value);
  * public static bool TryReadUIntPtrLittleEndian (ReadOnlySpan<byte> source, out UIntPtr value);
  * public static bool TryWriteInt128BigEndian (Span<byte> destination, Int128 value);
  * public static bool TryWriteInt128LittleEndian (Span<byte> destination, Int128 value);
  * public static bool TryWriteIntPtrBigEndian (Span<byte> destination, IntPtr value);
  * public static bool TryWriteIntPtrLittleEndian (Span<byte> destination, IntPtr value);
  * public static bool TryWriteUInt128BigEndian (Span<byte> destination, UInt128 value);
  * public static bool TryWriteUInt128LittleEndian (Span<byte> destination, UInt128 value);
  * public static bool TryWriteUIntPtrBigEndian (Span<byte> destination, UIntPtr value);
  * public static bool TryWriteUIntPtrLittleEndian (Span<byte> destination, UIntPtr value);
  * public static void WriteInt128BigEndian (Span<byte> destination, Int128 value);
  * public static void WriteInt128LittleEndian (Span<byte> destination, Int128 value);
  * public static void WriteIntPtrBigEndian (Span<byte> destination, IntPtr value);
  * public static void WriteIntPtrLittleEndian (Span<byte> destination, IntPtr value);
  * public static void WriteUInt128BigEndian (Span<byte> destination, UInt128 value);
  * public static void WriteUInt128LittleEndian (Span<byte> destination, UInt128 value);
  * public static void WriteUIntPtrBigEndian (Span<byte> destination, UIntPtr value);
  * public static void WriteUIntPtrLittleEndian (Span<byte> destination, UIntPtr value);
* System.Buffers.Text.Base64
  * public static bool IsValid (ReadOnlySpan<byte> base64TextUtf8);
  * public static bool IsValid (ReadOnlySpan<char> base64Text);
  * public static bool IsValid (ReadOnlySpan<byte> base64TextUtf8, out int decodedLength);
  * public static bool IsValid (ReadOnlySpan<char> base64Text, out int decodedLength);
* System.CodeDom.Compiler.IndentedTextWriter
  * public override System.Threading.Tasks.Task FlushAsync (System.Threading.CancellationToken cancellationToken);
* System.Collections.BitArray
  * public bool HasAllSet ();
  * public bool HasAnySet ();
* System.Collections.Frozen.FrozenDictionary
  * public static System.Collections.Frozen.FrozenDictionary<TKey,TValue> ToFrozenDictionary<TKey,TValue> (this System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>> source, System.Collections.Generic.IEqualityComparer<TKey>? comparer = default);
  * public static System.Collections.Frozen.FrozenDictionary<TKey,TSource> ToFrozenDictionary<TSource,TKey> (this System.Collections.Generic.IEnumerable<TSource> source, Func<TSource,TKey> keySelector, System.Collections.Generic.IEqualityComparer<TKey>? comparer = default);
  * public static System.Collections.Frozen.FrozenDictionary<TKey,TElement> ToFrozenDictionary<TSource,TKey,TElement> (this System.Collections.Generic.IEnumerable<TSource> source, Func<TSource,TKey> keySelector, Func<TSource,TElement> elementSelector, System.Collections.Generic.IEqualityComparer<TKey>? comparer = default);
* System.Collections.Frozen.FrozenDictionary<TKey,TValue>+Enumerator
  * public System.Collections.Generic.KeyValuePair<TKey,TValue> Current { get; }
  * public bool MoveNext ();
  * object System.Collections.IEnumerator.Current { get; }
  * void IEnumerator.Reset ();
  * void IDisposable.Dispose ();
* System.Collections.Frozen.FrozenDictionary<TKey,TValue>
  * public System.Collections.Generic.IEqualityComparer<TKey> Comparer { get; }
  * public bool ContainsKey (TKey key);
  * public void CopyTo (Span<System.Collections.Generic.KeyValuePair<TKey,TValue>> destination);
  * public void CopyTo (System.Collections.Generic.KeyValuePair<TKey,TValue>[] destination, int destinationIndex);
  * public int Count { get; }
  * public static System.Collections.Frozen.FrozenDictionary<TKey,TValue> Empty { get; }
  * public System.Collections.Frozen.FrozenDictionary<TKey,TValue>.Enumerator GetEnumerator ();
  * public ref readonly TValue GetValueRefOrNullRef (TKey key);
  * public ref readonly TValue this[TKey key] { get; }
  * public System.Collections.Immutable.ImmutableArray<TKey> Keys { get; }
  * void ICollection<KeyValuePair<TKey,TValue>>.Add (System.Collections.Generic.KeyValuePair<TKey,TValue> item);
  * void ICollection<KeyValuePair<TKey,TValue>>.Clear ();
  * bool ICollection<KeyValuePair<TKey,TValue>>.Contains (System.Collections.Generic.KeyValuePair<TKey,TValue> item);
  * bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
  * bool ICollection<KeyValuePair<TKey,TValue>>.Remove (System.Collections.Generic.KeyValuePair<TKey,TValue> item);
  * void IDictionary<TKey,TValue>.Add (TKey key, TValue value);
  * TValue System.Collections.Generic.IDictionary<TKey,TValue>.Item[TKey key] { get; set; }
  * System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get; }
  * bool IDictionary<TKey,TValue>.Remove (TKey key);
  * System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get; }
  * System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> IEnumerable<KeyValuePair<TKey,TValue>>.GetEnumerator ();
  * TValue System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Item[TKey key] { get; }
  * System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get; }
  * System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get; }
  * void ICollection.CopyTo (Array array, int index);
  * bool System.Collections.ICollection.IsSynchronized { get; }
  * object System.Collections.ICollection.SyncRoot { get; }
  * void IDictionary.Add (object key, object value);
  * void IDictionary.Clear ();
  * bool IDictionary.Contains (object key);
  * System.Collections.IDictionaryEnumerator IDictionary.GetEnumerator ();
  * bool System.Collections.IDictionary.IsFixedSize { get; }
  * bool System.Collections.IDictionary.IsReadOnly { get; }
  * object? System.Collections.IDictionary.Item[object key] { get; set; }
  * System.Collections.ICollection System.Collections.IDictionary.Keys { get; }
  * void IDictionary.Remove (object key);
  * System.Collections.ICollection System.Collections.IDictionary.Values { get; }
  * System.Collections.IEnumerator IEnumerable.GetEnumerator ();
  * public bool TryGetValue (TKey key, out TValue value);
  * public System.Collections.Immutable.ImmutableArray<TValue> Values { get; }
* System.Collections.Frozen.FrozenSet
  * public static System.Collections.Frozen.FrozenSet<T> ToFrozenSet<T> (this System.Collections.Generic.IEnumerable<T> source, System.Collections.Generic.IEqualityComparer<T>? comparer = default);
* System.Collections.Frozen.FrozenSet<T>+Enumerator
  * public T Current { get; }
  * public bool MoveNext ();
  * object System.Collections.IEnumerator.Current { get; }
  * void IEnumerator.Reset ();
  * void IDisposable.Dispose ();
* System.Collections.Frozen.FrozenSet<T>
  * public System.Collections.Generic.IEqualityComparer<T> Comparer { get; }
  * public bool Contains (T item);
  * public void CopyTo (Span<T> destination);
  * public void CopyTo (T[] destination, int destinationIndex);
  * public int Count { get; }
  * public static System.Collections.Frozen.FrozenSet<T> Empty { get; }
  * public System.Collections.Frozen.FrozenSet<T>.Enumerator GetEnumerator ();
  * public bool IsProperSubsetOf (System.Collections.Generic.IEnumerable<T> other);
  * public bool IsProperSupersetOf (System.Collections.Generic.IEnumerable<T> other);
  * public bool IsSubsetOf (System.Collections.Generic.IEnumerable<T> other);
  * public bool IsSupersetOf (System.Collections.Generic.IEnumerable<T> other);
  * public System.Collections.Immutable.ImmutableArray<T> Items { get; }
  * public bool Overlaps (System.Collections.Generic.IEnumerable<T> other);
  * public bool SetEquals (System.Collections.Generic.IEnumerable<T> other);
  * void ICollection<T>.Add (T item);
  * void ICollection<T>.Clear ();
  * bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
  * bool ICollection<T>.Remove (T item);
  * System.Collections.Generic.IEnumerator<T> IEnumerable<T>.GetEnumerator ();
  * bool ISet<T>.Add (T item);
  * void ISet<T>.ExceptWith (System.Collections.Generic.IEnumerable<T> other);
  * void ISet<T>.IntersectWith (System.Collections.Generic.IEnumerable<T> other);
  * void ISet<T>.SymmetricExceptWith (System.Collections.Generic.IEnumerable<T> other);
  * void ISet<T>.UnionWith (System.Collections.Generic.IEnumerable<T> other);
  * void ICollection.CopyTo (Array array, int index);
  * bool System.Collections.ICollection.IsSynchronized { get; }
  * object System.Collections.ICollection.SyncRoot { get; }
  * System.Collections.IEnumerator IEnumerable.GetEnumerator ();
  * public bool TryGetValue (T equalValue, out T actualValue);
* System.Collections.Generic.CollectionExtensions
  * public static void AddRange<T> (this System.Collections.Generic.List<T> list, ReadOnlySpan<T> source);
  * public static void CopyTo<T> (this System.Collections.Generic.List<T> list, Span<T> destination);
  * public static void InsertRange<T> (this System.Collections.Generic.List<T> list, int index, ReadOnlySpan<T> source);
* System.Collections.Generic.Dictionary<TKey,TValue>+KeyCollection
  * public bool Contains (TKey item);
* System.Collections.Generic.EqualityComparer<T>
  * public static System.Collections.Generic.EqualityComparer<T> Create (Func<T?,T?,bool> equals, Func<T,int>? getHashCode = default);
* System.Collections.Generic.List<T>
  * public System.Collections.Generic.List<T> Slice (int start, int length);
* System.Collections.Generic.PriorityQueue<TElement,TPriority>
  * public TElement DequeueEnqueue (TElement element, TPriority priority);
* System.Collections.Generic.SortedDictionary<TKey,TValue>+KeyCollection
  * public bool Contains (TKey item);
* System.Collections.Immutable.ImmutableArray<T>+Builder
  * public System.Collections.Immutable.ImmutableArray<T> DrainToImmutable ();
* System.Collections.Immutable.ImmutableArray<T>
  * public bool Contains (T item, System.Collections.Generic.IEqualityComparer<T>? equalityComparer);
* System.Collections.Immutable.ImmutableHashSet
  * public static System.Collections.Immutable.ImmutableHashSet<T> Create<T> (ReadOnlySpan<T> items);
  * public static System.Collections.Immutable.ImmutableHashSet<T> Create<T> (System.Collections.Generic.IEqualityComparer<T>? equalityComparer, ReadOnlySpan<T> items);
* System.Collections.Immutable.ImmutableList
  * public static System.Collections.Immutable.ImmutableList<T> Create<T> (ReadOnlySpan<T> items);
* System.Collections.Immutable.ImmutableQueue
  * public static System.Collections.Immutable.ImmutableQueue<T> Create<T> (ReadOnlySpan<T> items);
* System.Collections.Immutable.ImmutableSortedSet
  * public static System.Collections.Immutable.ImmutableSortedSet<T> Create<T> (ReadOnlySpan<T> items);
  * public static System.Collections.Immutable.ImmutableSortedSet<T> Create<T> (System.Collections.Generic.IComparer<T>? comparer, ReadOnlySpan<T> items);
* System.Collections.Immutable.ImmutableStack
  * public static System.Collections.Immutable.ImmutableStack<T> Create<T> (ReadOnlySpan<T> items);
* System.Collections.ObjectModel.ReadOnlyCollection<T>
  * public static System.Collections.ObjectModel.ReadOnlyCollection<T> Empty { get; }
* System.Collections.ObjectModel.ReadOnlyDictionary<TKey,TValue>+KeyCollection
  * public bool Contains (TKey item);
* System.Collections.ObjectModel.ReadOnlyDictionary<TKey,TValue>
  * public static System.Collections.ObjectModel.ReadOnlyDictionary<TKey,TValue> Empty { get; }
* System.Collections.ObjectModel.ReadOnlyObservableCollection<T>
  * public static System.Collections.ObjectModel.ReadOnlyObservableCollection<T> Empty { get; }
* System.ComponentModel.DataAnnotations.AllowedValuesAttribute
  * public AllowedValuesAttribute (params object?[] values);
  * public override bool IsValid (object? value);
  * public object?[] Values { get; }
* System.ComponentModel.DataAnnotations.Base64StringAttribute
  * public Base64StringAttribute ();
  * public override bool IsValid (object? value);
* System.ComponentModel.DataAnnotations.DeniedValuesAttribute
  * public DeniedValuesAttribute (params object?[] values);
  * public override bool IsValid (object? value);
  * public object?[] Values { get; }
* System.ComponentModel.DataAnnotations.LengthAttribute
  * public LengthAttribute (int minimumLength, int maximumLength);
  * public override string FormatErrorMessage (string name);
  * public override bool IsValid (object? value);
  * public int MaximumLength { get; }
  * public int MinimumLength { get; }
* System.ComponentModel.DataAnnotations.RangeAttribute
  * public bool MaximumIsExclusive { get; set; }
  * public bool MinimumIsExclusive { get; set; }
* System.Data.Common.DbBatchCommand
  * public virtual bool CanCreateParameter { get; }
  * public virtual System.Data.Common.DbParameter CreateParameter ();
* System.Data.SqlTypes.SqlGuid
  * void ISerializable.GetObjectData (System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
* System.Diagnostics.DiagnosticSource
  * public System.Diagnostics.Activity StartActivity<T> (System.Diagnostics.Activity activity, T args);
  * public void StopActivity<T> (System.Diagnostics.Activity activity, T args);
  * public void Write<T> (string name, T value);
* System.Diagnostics.ProcessStartInfo
  * public ProcessStartInfo (string fileName, System.Collections.Generic.IEnumerable<string> arguments);
  * public bool UseCredentialsForNetworkingOnly { get; set; }
* System.Diagnostics.StackTrace
  * public StackTrace (System.Collections.Generic.IEnumerable<System.Diagnostics.StackFrame> frames);
* System.Diagnostics.Stopwatch
  * public override string ToString ();
* System.Diagnostics.CodeAnalysis.ExperimentalAttribute
  * public ExperimentalAttribute (string diagnosticId);
  * public string DiagnosticId { get; }
  * public string? UrlFormat { get; set; }
* System.Diagnostics.Metrics.IMeterFactory
  * public System.Diagnostics.Metrics.Meter Create (System.Diagnostics.Metrics.MeterOptions options);
* System.Diagnostics.Metrics.Instrument
  * protected Instrument (System.Diagnostics.Metrics.Meter meter, string name, string? unit, string? description, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string,object?>>? tags);
  * public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string,object?>>? Tags { get; }
* System.Diagnostics.Metrics.Instrument<T>
  * protected Instrument (System.Diagnostics.Metrics.Meter meter, string name, string? unit, string? description, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string,object?>>? tags);
* System.Diagnostics.Metrics.Meter
  * public Meter (System.Diagnostics.Metrics.MeterOptions options);
  * public Meter (string name, string? version, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string,object?>>? tags, object? scope = default);
  * public System.Diagnostics.Metrics.Counter<T> CreateCounter<T> (string name, string? unit, string? description, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string,object?>> tags) where T : struct;
  * public System.Diagnostics.Metrics.Histogram<T> CreateHistogram<T> (string name, string? unit, string? description, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string,object?>> tags) where T : struct;
  * public System.Diagnostics.Metrics.ObservableCounter<T> CreateObservableCounter<T> (string name, Func<System.Collections.Generic.IEnumerable<System.Diagnostics.Metrics.Measurement<T>>> observeValues, string? unit, string? description, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string,object?>> tags) where T : struct;
  * public System.Diagnostics.Metrics.ObservableCounter<T> CreateObservableCounter<T> (string name, Func<System.Diagnostics.Metrics.Measurement<T>> observeValue, string? unit, string? description, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string,object?>> tags) where T : struct;
  * public System.Diagnostics.Metrics.ObservableCounter<T> CreateObservableCounter<T> (string name, Func<T> observeValue, string? unit, string? description, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string,object?>> tags) where T : struct;
  * public System.Diagnostics.Metrics.ObservableGauge<T> CreateObservableGauge<T> (string name, Func<System.Collections.Generic.IEnumerable<System.Diagnostics.Metrics.Measurement<T>>> observeValues, string? unit, string? description, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string,object?>> tags) where T : struct;
  * public System.Diagnostics.Metrics.ObservableGauge<T> CreateObservableGauge<T> (string name, Func<System.Diagnostics.Metrics.Measurement<T>> observeValue, string? unit, string? description, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string,object?>> tags) where T : struct;
  * public System.Diagnostics.Metrics.ObservableGauge<T> CreateObservableGauge<T> (string name, Func<T> observeValue, string? unit, string? description, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string,object?>> tags) where T : struct;
  * public System.Diagnostics.Metrics.ObservableUpDownCounter<T> CreateObservableUpDownCounter<T> (string name, Func<System.Collections.Generic.IEnumerable<System.Diagnostics.Metrics.Measurement<T>>> observeValues, string? unit, string? description, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string,object?>> tags) where T : struct;
  * public System.Diagnostics.Metrics.ObservableUpDownCounter<T> CreateObservableUpDownCounter<T> (string name, Func<System.Diagnostics.Metrics.Measurement<T>> observeValue, string? unit, string? description, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string,object?>> tags) where T : struct;
  * public System.Diagnostics.Metrics.ObservableUpDownCounter<T> CreateObservableUpDownCounter<T> (string name, Func<T> observeValue, string? unit, string? description, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string,object?>> tags) where T : struct;
  * public System.Diagnostics.Metrics.UpDownCounter<T> CreateUpDownCounter<T> (string name, string? unit, string? description, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string,object?>> tags) where T : struct;
  * protected virtual void Dispose (bool disposing);
  * public object? Scope { get; }
  * public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string,object?>>? Tags { get; }
* System.Diagnostics.Metrics.MeterFactoryExtensions
  * public static System.Diagnostics.Metrics.Meter Create (this System.Diagnostics.Metrics.IMeterFactory meterFactory, string name, string? version = default, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string,object?>>? tags = default);
* System.Diagnostics.Metrics.MeterOptions
  * public MeterOptions (string name);
  * public string Name { get; set; }
  * public object? Scope { get; set; }
  * public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string,object?>>? Tags { get; set; }
  * public string? Version { get; set; }
* System.Diagnostics.Metrics.ObservableInstrument<T>
  * protected ObservableInstrument (System.Diagnostics.Metrics.Meter meter, string name, string? unit, string? description, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string,object?>> tags);
* System.Diagnostics.Tracing.EventSource+EventSourcePrimitive
  * public static implicit operator System.Diagnostics.Tracing.EventSource.EventSourcePrimitive (bool value);
  * public static implicit operator System.Diagnostics.Tracing.EventSource.EventSourcePrimitive (byte value);
  * public static implicit operator System.Diagnostics.Tracing.EventSource.EventSourcePrimitive (byte[] value);
  * public static implicit operator System.Diagnostics.Tracing.EventSource.EventSourcePrimitive (char value);
  * public static implicit operator System.Diagnostics.Tracing.EventSource.EventSourcePrimitive (DateTime value);
  * public static implicit operator System.Diagnostics.Tracing.EventSource.EventSourcePrimitive (decimal value);
  * public static implicit operator System.Diagnostics.Tracing.EventSource.EventSourcePrimitive (double value);
  * public static implicit operator System.Diagnostics.Tracing.EventSource.EventSourcePrimitive (Enum value);
  * public static implicit operator System.Diagnostics.Tracing.EventSource.EventSourcePrimitive (Guid value);
  * public static implicit operator System.Diagnostics.Tracing.EventSource.EventSourcePrimitive (short value);
  * public static implicit operator System.Diagnostics.Tracing.EventSource.EventSourcePrimitive (int value);
  * public static implicit operator System.Diagnostics.Tracing.EventSource.EventSourcePrimitive (long value);
  * public static implicit operator System.Diagnostics.Tracing.EventSource.EventSourcePrimitive (IntPtr value);
  * public static implicit operator System.Diagnostics.Tracing.EventSource.EventSourcePrimitive (sbyte value);
  * public static implicit operator System.Diagnostics.Tracing.EventSource.EventSourcePrimitive (float value);
  * public static implicit operator System.Diagnostics.Tracing.EventSource.EventSourcePrimitive (string value);
  * public static implicit operator System.Diagnostics.Tracing.EventSource.EventSourcePrimitive (ushort value);
  * public static implicit operator System.Diagnostics.Tracing.EventSource.EventSourcePrimitive (uint value);
  * public static implicit operator System.Diagnostics.Tracing.EventSource.EventSourcePrimitive (ulong value);
  * public static implicit operator System.Diagnostics.Tracing.EventSource.EventSourcePrimitive (UIntPtr value);
* System.Diagnostics.Tracing.EventSource
  * protected void WriteEvent (int eventId, params System.Diagnostics.Tracing.EventSource.EventSourcePrimitive[] args);
* System.Drawing.Font
  * public static System.Drawing.Font FromLogFont (in System.Drawing.Interop.LOGFONT logFont);
  * public static System.Drawing.Font FromLogFont (in System.Drawing.Interop.LOGFONT logFont, IntPtr hdc);
  * public void ToLogFont (out System.Drawing.Interop.LOGFONT logFont);
  * public void ToLogFont (out System.Drawing.Interop.LOGFONT logFont, System.Drawing.Graphics graphics);
* System.Drawing.Graphics
  * public void DrawCachedBitmap (System.Drawing.Imaging.CachedBitmap cachedBitmap, int x, int y);
  * public void DrawString (ReadOnlySpan<char> s, System.Drawing.Font font, System.Drawing.Brush brush, System.Drawing.PointF point);
  * public void DrawString (ReadOnlySpan<char> s, System.Drawing.Font font, System.Drawing.Brush brush, System.Drawing.RectangleF layoutRectangle);
  * public void DrawString (ReadOnlySpan<char> s, System.Drawing.Font font, System.Drawing.Brush brush, System.Drawing.PointF point, System.Drawing.StringFormat? format);
  * public void DrawString (ReadOnlySpan<char> s, System.Drawing.Font font, System.Drawing.Brush brush, System.Drawing.RectangleF layoutRectangle, System.Drawing.StringFormat? format);
  * public void DrawString (ReadOnlySpan<char> s, System.Drawing.Font font, System.Drawing.Brush brush, float x, float y);
  * public void DrawString (ReadOnlySpan<char> s, System.Drawing.Font font, System.Drawing.Brush brush, float x, float y, System.Drawing.StringFormat? format);
  * public System.Drawing.Region[] MeasureCharacterRanges (ReadOnlySpan<char> text, System.Drawing.Font font, System.Drawing.RectangleF layoutRect, System.Drawing.StringFormat? stringFormat);
  * public System.Drawing.SizeF MeasureString (ReadOnlySpan<char> text, System.Drawing.Font font);
  * public System.Drawing.SizeF MeasureString (ReadOnlySpan<char> text, System.Drawing.Font font, System.Drawing.SizeF layoutArea);
  * public System.Drawing.SizeF MeasureString (ReadOnlySpan<char> text, System.Drawing.Font font, int width);
  * public System.Drawing.SizeF MeasureString (ReadOnlySpan<char> text, System.Drawing.Font font, System.Drawing.PointF origin, System.Drawing.StringFormat? stringFormat);
  * public System.Drawing.SizeF MeasureString (ReadOnlySpan<char> text, System.Drawing.Font font, System.Drawing.SizeF layoutArea, System.Drawing.StringFormat? stringFormat);
  * public System.Drawing.SizeF MeasureString (ReadOnlySpan<char> text, System.Drawing.Font font, int width, System.Drawing.StringFormat? format);
  * public System.Drawing.SizeF MeasureString (ReadOnlySpan<char> text, System.Drawing.Font font, System.Drawing.SizeF layoutArea, System.Drawing.StringFormat? stringFormat, out int charactersFitted, out int linesFilled);
* System.Drawing.Icon
  * public static System.Drawing.Icon? ExtractIcon (string filePath, int id, bool smallIcon = false);
  * public static System.Drawing.Icon? ExtractIcon (string filePath, int id, int size);
* System.Drawing.StockIconId
  * Application
  * AudioFiles
  * AutoList
  * ClusteredDrive
  * Delete
  * DesktopPC
  * DeviceAudioPlayer
  * DeviceCamera
  * DeviceCellPhone
  * DeviceVideoCamera
  * DocumentNoAssociation
  * DocumentWithAssociation
  * Drive35
  * Drive525
  * DriveBD
  * DriveCD
  * DriveDVD
  * DriveFixed
  * DriveHDDVD
  * DriveNet
  * DriveNetDisabled
  * DriveRam
  * DriveRemovable
  * DriveUnknown
  * Error
  * Find
  * Folder
  * FolderBack
  * FolderFront
  * FolderOpen
  * Help
  * ImageFiles
  * Info
  * Internet
  * Key
  * Link
  * Lock
  * MediaAudioDVD
  * MediaBDR
  * MediaBDRE
  * MediaBDROM
  * MediaBlankCD
  * MediaBluRay
  * MediaCDAudio
  * MediaCDAudioPlus
  * MediaCDBurn
  * MediaCDR
  * MediaCDROM
  * MediaCDRW
  * MediaCompactFlash
  * MediaDVD
  * MediaDVDPlusR
  * MediaDVDPlusRW
  * MediaDVDR
  * MediaDVDRAM
  * MediaDVDROM
  * MediaDVDRW
  * MediaEnhancedCD
  * MediaEnhancedDVD
  * MediaHDDVD
  * MediaHDDVDR
  * MediaHDDVDRAM
  * MediaHDDVDROM
  * MediaMovieDVD
  * MediaSmartMedia
  * MediaSVCD
  * MediaVCD
  * MixedFiles
  * MobilePC
  * MyNetwork
  * NetworkConnect
  * Printer
  * PrinterFax
  * PrinterFaxNet
  * PrinterFile
  * PrinterNet
  * Recycler
  * RecyclerFull
  * Rename
  * Server
  * ServerShare
  * Settings
  * Share
  * Shield
  * SlowFile
  * Software
  * Stack
  * StuffedFolder
  * Users
  * VideoFiles
  * Warning
  * World
  * ZipFile
* System.Drawing.StockIconOptions
  * Default
  * LinkOverlay
  * Selected
  * ShellIconSize
  * SmallIcon
* System.Drawing.SystemIcons
  * public static System.Drawing.Icon GetStockIcon (System.Drawing.StockIconId stockIcon, System.Drawing.StockIconOptions options = System.Drawing.StockIconOptions.Default);
  * public static System.Drawing.Icon GetStockIcon (System.Drawing.StockIconId stockIcon, int size);
* System.Drawing.Imaging.CachedBitmap
  * public CachedBitmap (System.Drawing.Bitmap bitmap, System.Drawing.Graphics graphics);
  * public void Dispose ();
  * ~CachedBitmap ();
* System.Drawing.Interop.LOGFONT
  * public byte lfCharSet;
  * public byte lfClipPrecision;
  * public int lfEscapement;
  * public Span<char> lfFaceName { get; }
  * public int lfHeight;
  * public byte lfItalic;
  * public int lfOrientation;
  * public byte lfOutPrecision;
  * public byte lfPitchAndFamily;
  * public byte lfQuality;
  * public byte lfStrikeOut;
  * public byte lfUnderline;
  * public int lfWeight;
  * public int lfWidth;
* System.Formats.Asn1.AsnReader
  * public System.Formats.Asn1.AsnReader Clone ();
* System.Formats.Cbor.CborReader
  * public void Reset (ReadOnlyMemory<byte> data);
* System.Globalization.NumberStyles
  * AllowBinarySpecifier
  * BinaryNumber
* System.IO.FileAttributes
  * None
* System.IO.RandomAccess
  * public static void FlushToDisk (Microsoft.Win32.SafeHandles.SafeFileHandle handle);
* System.IO.StreamWriter
  * public override System.Threading.Tasks.Task FlushAsync (System.Threading.CancellationToken cancellationToken);
* System.IO.TextWriter
  * public virtual System.Threading.Tasks.Task FlushAsync (System.Threading.CancellationToken cancellationToken);
* System.IO.Compression.ZipFile
  * public static void CreateFromDirectory (string sourceDirectoryName, System.IO.Stream destination);
  * public static void CreateFromDirectory (string sourceDirectoryName, System.IO.Stream destination, System.IO.Compression.CompressionLevel compressionLevel, bool includeBaseDirectory);
  * public static void CreateFromDirectory (string sourceDirectoryName, System.IO.Stream destination, System.IO.Compression.CompressionLevel compressionLevel, bool includeBaseDirectory, System.Text.Encoding? entryNameEncoding);
  * public static void ExtractToDirectory (System.IO.Stream source, string destinationDirectoryName);
  * public static void ExtractToDirectory (System.IO.Stream source, string destinationDirectoryName, bool overwriteFiles);
  * public static void ExtractToDirectory (System.IO.Stream source, string destinationDirectoryName, System.Text.Encoding? entryNameEncoding);
  * public static void ExtractToDirectory (System.IO.Stream source, string destinationDirectoryName, System.Text.Encoding? entryNameEncoding, bool overwriteFiles);
* System.IO.Hashing.Crc32
  * public uint GetCurrentHashAsUInt32 ();
  * public static uint HashToUInt32 (ReadOnlySpan<byte> source);
* System.IO.Hashing.Crc64
  * public ulong GetCurrentHashAsUInt64 ();
  * public static ulong HashToUInt64 (ReadOnlySpan<byte> source);
* System.IO.Hashing.XxHash128
  * public XxHash128 ();
  * public XxHash128 (long seed);
  * public override void Append (ReadOnlySpan<byte> source);
  * public UInt128 GetCurrentHashAsUInt128 ();
  * protected override void GetCurrentHashCore (Span<byte> destination);
  * public static byte[] Hash (byte[] source);
  * public static byte[] Hash (byte[] source, long seed);
  * public static byte[] Hash (ReadOnlySpan<byte> source, long seed = 0);
  * public static int Hash (ReadOnlySpan<byte> source, Span<byte> destination, long seed = 0);
  * public static UInt128 HashToUInt128 (ReadOnlySpan<byte> source, long seed = 0);
  * public override void Reset ();
  * public static bool TryHash (ReadOnlySpan<byte> source, Span<byte> destination, out int bytesWritten, long seed = 0);
* System.IO.Hashing.XxHash3
  * public XxHash3 ();
  * public XxHash3 (long seed);
  * public override void Append (ReadOnlySpan<byte> source);
  * public ulong GetCurrentHashAsUInt64 ();
  * protected override void GetCurrentHashCore (Span<byte> destination);
  * public static byte[] Hash (byte[] source);
  * public static byte[] Hash (byte[] source, long seed);
  * public static byte[] Hash (ReadOnlySpan<byte> source, long seed = 0);
  * public static int Hash (ReadOnlySpan<byte> source, Span<byte> destination, long seed = 0);
  * public static ulong HashToUInt64 (ReadOnlySpan<byte> source, long seed = 0);
  * public override void Reset ();
  * public static bool TryHash (ReadOnlySpan<byte> source, Span<byte> destination, out int bytesWritten, long seed = 0);
* System.IO.Hashing.XxHash32
  * public uint GetCurrentHashAsUInt32 ();
  * public static uint HashToUInt32 (ReadOnlySpan<byte> source, int seed = 0);
* System.IO.Hashing.XxHash64
  * public ulong GetCurrentHashAsUInt64 ();
  * public static ulong HashToUInt64 (ReadOnlySpan<byte> source, long seed = 0);
* System.IO.MemoryMappedFiles.MemoryMappedFile
  * public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateFromFile (Microsoft.Win32.SafeHandles.SafeFileHandle fileHandle, string? mapName, long capacity, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access, System.IO.HandleInheritability inheritability, bool leaveOpen);
* System.IO.Pipes.PipeOptions
  * FirstPipeInstance
* System.Linq.Enumerable
  * public static System.Collections.Generic.Dictionary<TKey,TValue> ToDictionary<TKey,TValue> (this System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>> source);
  * public static System.Collections.Generic.Dictionary<TKey,TValue> ToDictionary<TKey,TValue> (this System.Collections.Generic.IEnumerable<(TKey Key, TValue Value)> source);
  * public static System.Collections.Generic.Dictionary<TKey,TValue> ToDictionary<TKey,TValue> (this System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>> source, System.Collections.Generic.IEqualityComparer<TKey>? comparer);
  * public static System.Collections.Generic.Dictionary<TKey,TValue> ToDictionary<TKey,TValue> (this System.Collections.Generic.IEnumerable<(TKey Key, TValue Value)> source, System.Collections.Generic.IEqualityComparer<TKey>? comparer);
* System.Net.HttpDiagnosticsHttpWebRequestExtensions
  * public static Microsoft.Extensions.Http.Diagnostics.RequestMetadata? GetRequestMetadata (this System.Net.HttpWebRequest request);
  * public static void SetRequestMetadata (this System.Net.HttpWebRequest request, Microsoft.Extensions.Http.Diagnostics.RequestMetadata metadata);
* System.Net.HttpStatusCode
  * UnprocessableContent
* System.Net.IPAddress
  * string IFormattable.ToString (string format, IFormatProvider formatProvider);
  * static System.Net.IPAddress IParsable<IPAddress>.Parse (string s, IFormatProvider provider);
  * static bool IParsable<IPAddress>.TryParse (string s, IFormatProvider provider, out System.Net.IPAddress result);
  * bool ISpanFormattable.TryFormat (Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider);
  * static System.Net.IPAddress ISpanParsable<IPAddress>.Parse (ReadOnlySpan<char> s, IFormatProvider provider);
  * static bool ISpanParsable<IPAddress>.TryParse (ReadOnlySpan<char> s, IFormatProvider provider, out System.Net.IPAddress result);
  * bool IUtf8SpanFormattable.TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider provider);
  * public bool TryFormat (Span<byte> utf8Destination, out int bytesWritten);
* System.Net.IPNetwork
  * public IPNetwork (System.Net.IPAddress baseAddress, int prefixLength);
  * public System.Net.IPAddress BaseAddress { get; }
  * public bool Contains (System.Net.IPAddress address);
  * public bool Equals (System.Net.IPNetwork other);
  * public override bool Equals (object? obj);
  * public override int GetHashCode ();
  * public static bool operator == (System.Net.IPNetwork left, System.Net.IPNetwork right);
  * public static bool operator != (System.Net.IPNetwork left, System.Net.IPNetwork right);
  * public static System.Net.IPNetwork Parse (ReadOnlySpan<char> s);
  * public static System.Net.IPNetwork Parse (string s);
  * public int PrefixLength { get; }
  * string IFormattable.ToString (string format, IFormatProvider provider);
  * static System.Net.IPNetwork IParsable<IPNetwork>.Parse (string s, IFormatProvider provider);
  * static bool IParsable<IPNetwork>.TryParse (string s, IFormatProvider provider, out System.Net.IPNetwork result);
  * bool ISpanFormattable.TryFormat (Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider);
  * static System.Net.IPNetwork ISpanParsable<IPNetwork>.Parse (ReadOnlySpan<char> s, IFormatProvider provider);
  * static bool ISpanParsable<IPNetwork>.TryParse (ReadOnlySpan<char> s, IFormatProvider provider, out System.Net.IPNetwork result);
  * bool IUtf8SpanFormattable.TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider provider);
  * public override string ToString ();
  * public bool TryFormat (Span<byte> utf8Destination, out int bytesWritten);
  * public bool TryFormat (Span<char> destination, out int charsWritten);
  * public static bool TryParse (ReadOnlySpan<char> s, out System.Net.IPNetwork result);
  * public static bool TryParse (string? s, out System.Net.IPNetwork result);
* System.Net.SocketAddress
  * public Memory<byte> Buffer { get; }
  * public bool Equals (System.Net.SocketAddress? comparand);
  * public static int GetMaximumAddressSize (System.Net.Sockets.AddressFamily addressFamily);
* System.Net.Http.HttpClientHandler
  * public System.Diagnostics.Metrics.IMeterFactory? MeterFactory { get; set; }
* System.Net.Http.HttpDiagnosticsHttpRequestMessageExtensions
  * public static Microsoft.Extensions.Http.Diagnostics.RequestMetadata? GetRequestMetadata (this System.Net.Http.HttpRequestMessage request);
  * public static void SetRequestMetadata (this System.Net.Http.HttpRequestMessage request, Microsoft.Extensions.Http.Diagnostics.RequestMetadata metadata);
* System.Net.Http.HttpIOException
  * public HttpIOException (System.Net.Http.HttpRequestError httpRequestError, string? message = default, Exception? innerException = default);
  * public System.Net.Http.HttpRequestError HttpRequestError { get; }
* System.Net.Http.HttpMethod
  * public static System.Net.Http.HttpMethod Parse (ReadOnlySpan<char> method);
* System.Net.Http.HttpRequestError
  * ConfigurationLimitExceeded
  * ConnectionError
  * ExtendedConnectNotSupported
  * HttpProtocolError
  * InvalidResponse
  * NameResolutionError
  * ProxyTunnelError
  * ResponseEnded
  * SecureConnectionError
  * Unknown
  * UserAuthenticationError
  * VersionNegotiationError
* System.Net.Http.HttpRequestException
  * public HttpRequestException (System.Net.Http.HttpRequestError httpRequestError, string? message = default, Exception? inner = default, System.Net.HttpStatusCode? statusCode = default);
  * public System.Net.Http.HttpRequestError HttpRequestError { get; }
* System.Net.Http.HttpRequestOptions
  * int System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Count { get; }
  * bool IReadOnlyDictionary<string,object>.ContainsKey (string key);
  * object? System.Collections.Generic.IReadOnlyDictionary<System.String,System.Object>.Item[string key] { get; }
  * System.Collections.Generic.IEnumerable<string> System.Collections.Generic.IReadOnlyDictionary<System.String,System.Object>.Keys { get; }
  * bool IReadOnlyDictionary<string,object>.TryGetValue (string key, out object value);
  * System.Collections.Generic.IEnumerable<object?> System.Collections.Generic.IReadOnlyDictionary<System.String,System.Object>.Values { get; }
* System.Net.Http.HttpResilienceHttpRequestMessageExtensions
  * public static Polly.ResilienceContext? GetResilienceContext (this System.Net.Http.HttpRequestMessage requestMessage);
  * public static void SetResilienceContext (this System.Net.Http.HttpRequestMessage requestMessage, Polly.ResilienceContext? resilienceContext);
* System.Net.Http.SocketsHttpHandler
  * public System.Diagnostics.Metrics.IMeterFactory? MeterFactory { get; set; }
* System.Net.Http.Json.HttpClientJsonExtensions
  * public static System.Collections.Generic.IAsyncEnumerable<TValue?> GetFromJsonAsAsyncEnumerable<TValue> (this System.Net.Http.HttpClient client, string? requestUri, System.Threading.CancellationToken cancellationToken = default);
  * public static System.Collections.Generic.IAsyncEnumerable<TValue?> GetFromJsonAsAsyncEnumerable<TValue> (this System.Net.Http.HttpClient client, Uri? requestUri, System.Threading.CancellationToken cancellationToken = default);
  * public static System.Collections.Generic.IAsyncEnumerable<TValue?> GetFromJsonAsAsyncEnumerable<TValue> (this System.Net.Http.HttpClient client, string? requestUri, System.Text.Json.JsonSerializerOptions? options, System.Threading.CancellationToken cancellationToken = default);
  * public static System.Collections.Generic.IAsyncEnumerable<TValue?> GetFromJsonAsAsyncEnumerable<TValue> (this System.Net.Http.HttpClient client, string? requestUri, System.Text.Json.Serialization.Metadata.JsonTypeInfo<TValue> jsonTypeInfo, System.Threading.CancellationToken cancellationToken = default);
  * public static System.Collections.Generic.IAsyncEnumerable<TValue?> GetFromJsonAsAsyncEnumerable<TValue> (this System.Net.Http.HttpClient client, Uri? requestUri, System.Text.Json.JsonSerializerOptions? options, System.Threading.CancellationToken cancellationToken = default);
  * public static System.Collections.Generic.IAsyncEnumerable<TValue?> GetFromJsonAsAsyncEnumerable<TValue> (this System.Net.Http.HttpClient client, Uri? requestUri, System.Text.Json.Serialization.Metadata.JsonTypeInfo<TValue> jsonTypeInfo, System.Threading.CancellationToken cancellationToken = default);
* System.Net.Http.Json.HttpContentJsonExtensions
  * public static System.Collections.Generic.IAsyncEnumerable<TValue?> ReadFromJsonAsAsyncEnumerable<TValue> (this System.Net.Http.HttpContent content, System.Threading.CancellationToken cancellationToken = default);
  * public static System.Collections.Generic.IAsyncEnumerable<TValue?> ReadFromJsonAsAsyncEnumerable<TValue> (this System.Net.Http.HttpContent content, System.Text.Json.JsonSerializerOptions? options, System.Threading.CancellationToken cancellationToken = default);
  * public static System.Collections.Generic.IAsyncEnumerable<TValue?> ReadFromJsonAsAsyncEnumerable<TValue> (this System.Net.Http.HttpContent content, System.Text.Json.Serialization.Metadata.JsonTypeInfo<TValue> jsonTypeInfo, System.Threading.CancellationToken cancellationToken = default);
  * public static System.Threading.Tasks.Task<object?> ReadFromJsonAsync (this System.Net.Http.HttpContent content, Type type, System.Threading.CancellationToken cancellationToken = default);
  * public static System.Threading.Tasks.Task<T?> ReadFromJsonAsync<T> (this System.Net.Http.HttpContent content, System.Threading.CancellationToken cancellationToken = default);
* System.Net.Http.Json.JsonContent
  * public static System.Net.Http.Json.JsonContent Create (object? inputValue, System.Text.Json.Serialization.Metadata.JsonTypeInfo jsonTypeInfo, System.Net.Http.Headers.MediaTypeHeaderValue? mediaType = default);
  * public static System.Net.Http.Json.JsonContent Create<T> (T? inputValue, System.Text.Json.Serialization.Metadata.JsonTypeInfo<T> jsonTypeInfo, System.Net.Http.Headers.MediaTypeHeaderValue? mediaType = default);
* System.Net.Http.Metrics.HttpMetricsEnrichmentContext
  * public static void AddCallback (System.Net.Http.HttpRequestMessage request, Action<System.Net.Http.Metrics.HttpMetricsEnrichmentContext> callback);
  * public void AddCustomTag (string name, object? value);
  * public Exception? Exception { get; }
  * public System.Net.Http.HttpRequestMessage Request { get; }
  * public System.Net.Http.HttpResponseMessage? Response { get; }
* System.Net.Mime.MediaTypeNames+Application
  * public const string FormUrlEncoded;
  * public const string JsonPatch;
  * public const string JsonSequence;
  * public const string Manifest;
  * public const string ProblemJson;
  * public const string ProblemXml;
  * public const string Wasm;
  * public const string XmlDtd;
  * public const string XmlPatch;
* System.Net.Mime.MediaTypeNames+Font
  * public const string Collection;
  * public const string Otf;
  * public const string Sfnt;
  * public const string Ttf;
  * public const string Woff;
  * public const string Woff2;
* System.Net.Mime.MediaTypeNames+Image
  * public const string Avif;
  * public const string Bmp;
  * public const string Icon;
  * public const string Png;
  * public const string Svg;
  * public const string Webp;
* System.Net.Mime.MediaTypeNames+Multipart
  * public const string ByteRanges;
  * public const string FormData;
* System.Net.Mime.MediaTypeNames+Text
  * public const string Css;
  * public const string Csv;
  * public const string JavaScript;
  * public const string Markdown;
  * public const string Rtf;
* System.Net.NetworkInformation.Ping
  * public System.Threading.Tasks.Task<System.Net.NetworkInformation.PingReply> SendPingAsync (System.Net.IPAddress address, TimeSpan timeout, byte[]? buffer = default, System.Net.NetworkInformation.PingOptions? options = default, System.Threading.CancellationToken cancellationToken = default);
  * public System.Threading.Tasks.Task<System.Net.NetworkInformation.PingReply> SendPingAsync (string hostNameOrAddress, TimeSpan timeout, byte[]? buffer = default, System.Net.NetworkInformation.PingOptions? options = default, System.Threading.CancellationToken cancellationToken = default);
* System.Net.Quic.QuicConnection
  * public string TargetHostName { get; }
* System.Net.Quic.QuicError
  * AlpnInUse
  * CallbackError
  * TransportError
* System.Net.Quic.QuicException
  * public long? TransportErrorCode { get; }
* System.Net.Quic.QuicStream
  * public override string ToString ();
* System.Net.Security.SslClientAuthenticationOptions
  * public bool AllowTlsResume { get; set; }
  * public System.Net.Security.SslStreamCertificateContext? ClientCertificateContext { get; set; }
* System.Net.Security.SslClientHelloInfo
  * public SslClientHelloInfo (string serverName, System.Security.Authentication.SslProtocols sslProtocols);
* System.Net.Security.SslServerAuthenticationOptions
  * public bool AllowTlsResume { get; set; }
* System.Net.Security.SslStreamCertificateContext
  * public System.Collections.ObjectModel.ReadOnlyCollection<System.Security.Cryptography.X509Certificates.X509Certificate2> IntermediateCertificates { get; }
  * public System.Security.Cryptography.X509Certificates.X509Certificate2 TargetCertificate { get; }
* System.Net.Sockets.LingerOption
  * public override bool Equals (object? comparand);
  * public override int GetHashCode ();
* System.Net.Sockets.Socket
  * public int ReceiveFrom (Span<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, System.Net.SocketAddress receivedAddress);
  * public System.Threading.Tasks.ValueTask<int> ReceiveFromAsync (Memory<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, System.Net.SocketAddress receivedAddress, System.Threading.CancellationToken cancellationToken = default);
  * public int SendTo (ReadOnlySpan<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, System.Net.SocketAddress socketAddress);
  * public System.Threading.Tasks.ValueTask<int> SendToAsync (ReadOnlyMemory<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, System.Net.SocketAddress socketAddress, System.Threading.CancellationToken cancellationToken = default);
* System.Net.Sockets.SocketException
  * public SocketException (int errorCode, string? message);
* System.Net.Sockets.TcpListener
  * public void Dispose ();
* System.Net.Sockets.UnixDomainSocketEndPoint
  * public override bool Equals (object? obj);
  * public override int GetHashCode ();
* System.Net.WebSockets.ClientWebSocket
  * public override System.Threading.Tasks.ValueTask SendAsync (ReadOnlyMemory<byte> buffer, System.Net.WebSockets.WebSocketMessageType messageType, System.Net.WebSockets.WebSocketMessageFlags messageFlags, System.Threading.CancellationToken cancellationToken);
* System.Numerics.BitOperations
  * public static uint Crc32C (uint crc, byte data);
  * public static uint Crc32C (uint crc, ushort data);
  * public static uint Crc32C (uint crc, uint data);
  * public static uint Crc32C (uint crc, ulong data);
* System.Numerics.Complex
  * public bool TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default);
* System.Numerics.IFloatingPointIeee754<TSelf>
  * public static virtual TSelf Lerp (TSelf value1, TSelf value2, TSelf amount);
* System.Numerics.INumberBase<TSelf>
  * public static virtual TSelf Parse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style, IFormatProvider? provider);
  * override sealed bool IUtf8SpanFormattable.TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider provider);
  * static TSelf IUtf8SpanParsable<TSelf>.Parse (ReadOnlySpan<byte> utf8Text, IFormatProvider provider);
  * static bool IUtf8SpanParsable<TSelf>.TryParse (ReadOnlySpan<byte> utf8Text, IFormatProvider provider, out TSelf result);
  * public static virtual bool TryParse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style, IFormatProvider? provider, out TSelf result);
* System.Numerics.ITrigonometricFunctions<TSelf>
  * public static virtual TSelf DegreesToRadians (TSelf degrees);
  * public static virtual TSelf RadiansToDegrees (TSelf radians);
* System.Numerics.Matrix4x4
  * public static System.Numerics.Matrix4x4 CreateLookAtLeftHanded (System.Numerics.Vector3 cameraPosition, System.Numerics.Vector3 cameraTarget, System.Numerics.Vector3 cameraUpVector);
  * public static System.Numerics.Matrix4x4 CreateLookTo (System.Numerics.Vector3 cameraPosition, System.Numerics.Vector3 cameraDirection, System.Numerics.Vector3 cameraUpVector);
  * public static System.Numerics.Matrix4x4 CreateLookToLeftHanded (System.Numerics.Vector3 cameraPosition, System.Numerics.Vector3 cameraDirection, System.Numerics.Vector3 cameraUpVector);
  * public static System.Numerics.Matrix4x4 CreateOrthographicLeftHanded (float width, float height, float zNearPlane, float zFarPlane);
  * public static System.Numerics.Matrix4x4 CreateOrthographicOffCenterLeftHanded (float left, float right, float bottom, float top, float zNearPlane, float zFarPlane);
  * public static System.Numerics.Matrix4x4 CreatePerspectiveFieldOfViewLeftHanded (float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance);
  * public static System.Numerics.Matrix4x4 CreatePerspectiveLeftHanded (float width, float height, float nearPlaneDistance, float farPlaneDistance);
  * public static System.Numerics.Matrix4x4 CreatePerspectiveOffCenterLeftHanded (float left, float right, float bottom, float top, float nearPlaneDistance, float farPlaneDistance);
  * public static System.Numerics.Matrix4x4 CreateViewport (float x, float y, float width, float height, float minDepth, float maxDepth);
  * public static System.Numerics.Matrix4x4 CreateViewportLeftHanded (float x, float y, float width, float height, float minDepth, float maxDepth);
* System.Numerics.TotalOrderIeee754Comparer<T>
  * public int Compare (T? x, T? y);
  * public bool Equals (System.Numerics.TotalOrderIeee754Comparer<T> other);
  * public override bool Equals (object? obj);
  * public bool Equals (T? x, T? y);
  * public override int GetHashCode ();
  * public int GetHashCode (T obj);
* System.Numerics.Vector
  * public static System.Numerics.Vector<T> Divide<T> (System.Numerics.Vector<T> left, T right);
  * public static T GetElement<T> (this System.Numerics.Vector<T> vector, int index);
  * public static System.Numerics.Vector<T> Load<T> (T* source);
  * public static System.Numerics.Vector<T> LoadAligned<T> (T* source);
  * public static System.Numerics.Vector<T> LoadAlignedNonTemporal<T> (T* source);
  * public static System.Numerics.Vector<T> LoadUnsafe<T> (ref T source);
  * public static System.Numerics.Vector<T> LoadUnsafe<T> (ref T source, UIntPtr elementOffset);
  * public static void Store<T> (this System.Numerics.Vector<T> source, T* destination);
  * public static void StoreAligned<T> (this System.Numerics.Vector<T> source, T* destination);
  * public static void StoreAlignedNonTemporal<T> (this System.Numerics.Vector<T> source, T* destination);
  * public static void StoreUnsafe<T> (this System.Numerics.Vector<T> source, ref T destination);
  * public static void StoreUnsafe<T> (this System.Numerics.Vector<T> source, ref T destination, UIntPtr elementOffset);
  * public static T ToScalar<T> (this System.Numerics.Vector<T> vector);
  * public static System.Numerics.Vector<ushort> WidenLower (System.Numerics.Vector<byte> source);
  * public static System.Numerics.Vector<int> WidenLower (System.Numerics.Vector<short> source);
  * public static System.Numerics.Vector<long> WidenLower (System.Numerics.Vector<int> source);
  * public static System.Numerics.Vector<short> WidenLower (System.Numerics.Vector<sbyte> source);
  * public static System.Numerics.Vector<double> WidenLower (System.Numerics.Vector<float> source);
  * public static System.Numerics.Vector<uint> WidenLower (System.Numerics.Vector<ushort> source);
  * public static System.Numerics.Vector<ulong> WidenLower (System.Numerics.Vector<uint> source);
  * public static System.Numerics.Vector<ushort> WidenUpper (System.Numerics.Vector<byte> source);
  * public static System.Numerics.Vector<int> WidenUpper (System.Numerics.Vector<short> source);
  * public static System.Numerics.Vector<long> WidenUpper (System.Numerics.Vector<int> source);
  * public static System.Numerics.Vector<short> WidenUpper (System.Numerics.Vector<sbyte> source);
  * public static System.Numerics.Vector<double> WidenUpper (System.Numerics.Vector<float> source);
  * public static System.Numerics.Vector<uint> WidenUpper (System.Numerics.Vector<ushort> source);
  * public static System.Numerics.Vector<ulong> WidenUpper (System.Numerics.Vector<uint> source);
  * public static System.Numerics.Vector<T> WithElement<T> (this System.Numerics.Vector<T> vector, int index, T value);
* System.Numerics.Vector<T>
  * public static System.Numerics.Vector<T> AllBitsSet { get; }
  * public static System.Numerics.Vector<T> operator / (System.Numerics.Vector<T> left, T right);
  * public static System.Numerics.Vector<T> operator << (System.Numerics.Vector<T> value, int shiftCount);
  * public static System.Numerics.Vector<T> operator >> (System.Numerics.Vector<T> value, int shiftCount);
  * public static System.Numerics.Vector<T> operator + (System.Numerics.Vector<T> value);
  * public static System.Numerics.Vector<T> op_UnsignedRightShift (System.Numerics.Vector<T> value, int shiftCount);
* System.Numerics.Tensors.TensorPrimitives
  * public static void Abs (ReadOnlySpan<float> x, Span<float> destination);
  * public static void Add (ReadOnlySpan<float> x, ReadOnlySpan<float> y, Span<float> destination);
  * public static void Add (ReadOnlySpan<float> x, float y, Span<float> destination);
  * public static void AddMultiply (ReadOnlySpan<float> x, ReadOnlySpan<float> y, ReadOnlySpan<float> multiplier, Span<float> destination);
  * public static void AddMultiply (ReadOnlySpan<float> x, ReadOnlySpan<float> y, float multiplier, Span<float> destination);
  * public static void AddMultiply (ReadOnlySpan<float> x, float y, ReadOnlySpan<float> multiplier, Span<float> destination);
  * public static void ConvertToHalf (ReadOnlySpan<float> source, Span<Half> destination);
  * public static void ConvertToSingle (ReadOnlySpan<Half> source, Span<float> destination);
  * public static void Cosh (ReadOnlySpan<float> x, Span<float> destination);
  * public static float CosineSimilarity (ReadOnlySpan<float> x, ReadOnlySpan<float> y);
  * public static float Distance (ReadOnlySpan<float> x, ReadOnlySpan<float> y);
  * public static void Divide (ReadOnlySpan<float> x, ReadOnlySpan<float> y, Span<float> destination);
  * public static void Divide (ReadOnlySpan<float> x, float y, Span<float> destination);
  * public static float Dot (ReadOnlySpan<float> x, ReadOnlySpan<float> y);
  * public static void Exp (ReadOnlySpan<float> x, Span<float> destination);
  * public static int IndexOfMax (ReadOnlySpan<float> x);
  * public static int IndexOfMaxMagnitude (ReadOnlySpan<float> x);
  * public static int IndexOfMin (ReadOnlySpan<float> x);
  * public static int IndexOfMinMagnitude (ReadOnlySpan<float> x);
  * public static void Log (ReadOnlySpan<float> x, Span<float> destination);
  * public static void Log2 (ReadOnlySpan<float> x, Span<float> destination);
  * public static float Max (ReadOnlySpan<float> x);
  * public static void Max (ReadOnlySpan<float> x, ReadOnlySpan<float> y, Span<float> destination);
  * public static float MaxMagnitude (ReadOnlySpan<float> x);
  * public static void MaxMagnitude (ReadOnlySpan<float> x, ReadOnlySpan<float> y, Span<float> destination);
  * public static float Min (ReadOnlySpan<float> x);
  * public static void Min (ReadOnlySpan<float> x, ReadOnlySpan<float> y, Span<float> destination);
  * public static float MinMagnitude (ReadOnlySpan<float> x);
  * public static void MinMagnitude (ReadOnlySpan<float> x, ReadOnlySpan<float> y, Span<float> destination);
  * public static void Multiply (ReadOnlySpan<float> x, ReadOnlySpan<float> y, Span<float> destination);
  * public static void Multiply (ReadOnlySpan<float> x, float y, Span<float> destination);
  * public static void MultiplyAdd (ReadOnlySpan<float> x, ReadOnlySpan<float> y, ReadOnlySpan<float> addend, Span<float> destination);
  * public static void MultiplyAdd (ReadOnlySpan<float> x, ReadOnlySpan<float> y, float addend, Span<float> destination);
  * public static void MultiplyAdd (ReadOnlySpan<float> x, float y, ReadOnlySpan<float> addend, Span<float> destination);
  * public static void Negate (ReadOnlySpan<float> x, Span<float> destination);
  * public static float Norm (ReadOnlySpan<float> x);
  * public static float Product (ReadOnlySpan<float> x);
  * public static float ProductOfDifferences (ReadOnlySpan<float> x, ReadOnlySpan<float> y);
  * public static float ProductOfSums (ReadOnlySpan<float> x, ReadOnlySpan<float> y);
  * public static void Sigmoid (ReadOnlySpan<float> x, Span<float> destination);
  * public static void Sinh (ReadOnlySpan<float> x, Span<float> destination);
  * public static void SoftMax (ReadOnlySpan<float> x, Span<float> destination);
  * public static void Subtract (ReadOnlySpan<float> x, ReadOnlySpan<float> y, Span<float> destination);
  * public static void Subtract (ReadOnlySpan<float> x, float y, Span<float> destination);
  * public static float Sum (ReadOnlySpan<float> x);
  * public static float SumOfMagnitudes (ReadOnlySpan<float> x);
  * public static float SumOfSquares (ReadOnlySpan<float> x);
  * public static void Tanh (ReadOnlySpan<float> x, Span<float> destination);
* System.Reflection.ConstructorInvoker
  * public static System.Reflection.ConstructorInvoker Create (System.Reflection.ConstructorInfo constructor);
  * public object Invoke ();
  * public object Invoke (object? arg1);
  * public object Invoke (Span<object?> arguments);
  * public object Invoke (object? arg1, object? arg2);
  * public object Invoke (object? arg1, object? arg2, object? arg3);
  * public object Invoke (object? arg1, object? arg2, object? arg3, object? arg4);
* System.Reflection.DispatchProxy
  * public static object Create (Type interfaceType, Type proxyType);
* System.Reflection.FieldInfo
  * public virtual Type GetModifiedFieldType ();
* System.Reflection.MethodInvoker
  * public static System.Reflection.MethodInvoker Create (System.Reflection.MethodBase method);
  * public object? Invoke (object? obj);
  * public object? Invoke (object? obj, object? arg1);
  * public object? Invoke (object? obj, Span<object?> arguments);
  * public object? Invoke (object? obj, object? arg1, object? arg2);
  * public object? Invoke (object? obj, object? arg1, object? arg2, object? arg3);
  * public object? Invoke (object? obj, object? arg1, object? arg2, object? arg3, object? arg4);
* System.Reflection.ParameterInfo
  * public virtual Type GetModifiedParameterType ();
* System.Reflection.PropertyInfo
  * public virtual Type GetModifiedPropertyType ();
* System.Reflection.TypeDelegator
  * public override Type[] GetFunctionPointerCallingConventions ();
  * public override Type[] GetFunctionPointerParameterTypes ();
  * public override Type GetFunctionPointerReturnType ();
  * public override bool IsFunctionPointer { get; }
  * public override bool IsUnmanagedFunctionPointer { get; }
* System.Reflection.Emit.AssemblyBuilder
  * protected abstract System.Reflection.Emit.ModuleBuilder DefineDynamicModuleCore (string name);
  * protected abstract System.Reflection.Emit.ModuleBuilder? GetDynamicModuleCore (string name);
  * protected abstract void SetCustomAttributeCore (System.Reflection.ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);
* System.Reflection.Emit.ConstructorBuilder
  * protected abstract System.Reflection.Emit.ParameterBuilder DefineParameterCore (int iSequence, System.Reflection.ParameterAttributes attributes, string strParamName);
  * protected abstract System.Reflection.Emit.ILGenerator GetILGeneratorCore (int streamSize);
  * protected abstract bool InitLocalsCore { get; set; }
  * protected abstract void SetCustomAttributeCore (System.Reflection.ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);
  * protected abstract void SetImplementationFlagsCore (System.Reflection.MethodImplAttributes attributes);
* System.Reflection.Emit.EnumBuilder
  * protected abstract System.Reflection.TypeInfo CreateTypeInfoCore ();
  * protected abstract System.Reflection.Emit.FieldBuilder DefineLiteralCore (string literalName, object? literalValue);
  * protected abstract void SetCustomAttributeCore (System.Reflection.ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);
  * protected abstract System.Reflection.Emit.FieldBuilder UnderlyingFieldCore { get; }
* System.Reflection.Emit.EventBuilder
  * protected abstract void AddOtherMethodCore (System.Reflection.Emit.MethodBuilder mdBuilder);
  * protected abstract void SetAddOnMethodCore (System.Reflection.Emit.MethodBuilder mdBuilder);
  * protected abstract void SetCustomAttributeCore (System.Reflection.ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);
  * protected abstract void SetRaiseMethodCore (System.Reflection.Emit.MethodBuilder mdBuilder);
  * protected abstract void SetRemoveOnMethodCore (System.Reflection.Emit.MethodBuilder mdBuilder);
* System.Reflection.Emit.FieldBuilder
  * protected abstract void SetConstantCore (object? defaultValue);
  * protected abstract void SetCustomAttributeCore (System.Reflection.ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);
  * protected abstract void SetOffsetCore (int iOffset);
* System.Reflection.Emit.GenericTypeParameterBuilder
  * protected abstract void SetBaseTypeConstraintCore (Type? baseTypeConstraint);
  * protected abstract void SetCustomAttributeCore (System.Reflection.ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);
  * protected abstract void SetGenericParameterAttributesCore (System.Reflection.GenericParameterAttributes genericParameterAttributes);
  * protected abstract void SetInterfaceConstraintsCore (params Type[]? interfaceConstraints);
* System.Reflection.Emit.ILGenerator
  * protected ILGenerator ();
* System.Reflection.Emit.MethodBuilder
  * protected abstract System.Reflection.Emit.GenericTypeParameterBuilder[] DefineGenericParametersCore (params string[] names);
  * protected abstract System.Reflection.Emit.ParameterBuilder DefineParameterCore (int position, System.Reflection.ParameterAttributes attributes, string? strParamName);
  * protected abstract System.Reflection.Emit.ILGenerator GetILGeneratorCore (int size);
  * protected abstract bool InitLocalsCore { get; set; }
  * protected abstract void SetCustomAttributeCore (System.Reflection.ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);
  * protected abstract void SetImplementationFlagsCore (System.Reflection.MethodImplAttributes attributes);
  * protected abstract void SetSignatureCore (Type? returnType, Type[]? returnTypeRequiredCustomModifiers, Type[]? returnTypeOptionalCustomModifiers, Type[]? parameterTypes, Type[][]? parameterTypeRequiredCustomModifiers, Type[][]? parameterTypeOptionalCustomModifiers);
* System.Reflection.Emit.ModuleBuilder
  * protected abstract void CreateGlobalFunctionsCore ();
  * protected abstract System.Reflection.Emit.EnumBuilder DefineEnumCore (string name, System.Reflection.TypeAttributes visibility, Type underlyingType);
  * protected abstract System.Reflection.Emit.MethodBuilder DefineGlobalMethodCore (string name, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, Type? returnType, Type[]? requiredReturnTypeCustomModifiers, Type[]? optionalReturnTypeCustomModifiers, Type[]? parameterTypes, Type[][]? requiredParameterTypeCustomModifiers, Type[][]? optionalParameterTypeCustomModifiers);
  * protected abstract System.Reflection.Emit.FieldBuilder DefineInitializedDataCore (string name, byte[] data, System.Reflection.FieldAttributes attributes);
  * protected abstract System.Reflection.Emit.MethodBuilder DefinePInvokeMethodCore (string name, string dllName, string entryName, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, Type? returnType, Type[]? parameterTypes, System.Runtime.InteropServices.CallingConvention nativeCallConv, System.Runtime.InteropServices.CharSet nativeCharSet);
  * protected abstract System.Reflection.Emit.TypeBuilder DefineTypeCore (string name, System.Reflection.TypeAttributes attr, Type? parent, Type[]? interfaces, System.Reflection.Emit.PackingSize packingSize, int typesize);
  * protected abstract System.Reflection.Emit.FieldBuilder DefineUninitializedDataCore (string name, int size, System.Reflection.FieldAttributes attributes);
  * protected abstract System.Reflection.MethodInfo GetArrayMethodCore (Type arrayClass, string methodName, System.Reflection.CallingConventions callingConvention, Type? returnType, Type[]? parameterTypes);
  * public abstract int GetFieldMetadataToken (System.Reflection.FieldInfo field);
  * public abstract int GetMethodMetadataToken (System.Reflection.ConstructorInfo constructor);
  * public abstract int GetMethodMetadataToken (System.Reflection.MethodInfo method);
  * public abstract int GetSignatureMetadataToken (System.Reflection.Emit.SignatureHelper signature);
  * public abstract int GetStringMetadataToken (string stringConstant);
  * public abstract int GetTypeMetadataToken (Type type);
  * protected abstract void SetCustomAttributeCore (System.Reflection.ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);
* System.Reflection.Emit.ParameterBuilder
  * protected ParameterBuilder ();
  * protected abstract void SetCustomAttributeCore (System.Reflection.ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);
* System.Reflection.Emit.PropertyBuilder
  * protected abstract void AddOtherMethodCore (System.Reflection.Emit.MethodBuilder mdBuilder);
  * protected abstract void SetConstantCore (object? defaultValue);
  * protected abstract void SetCustomAttributeCore (System.Reflection.ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);
  * protected abstract void SetGetMethodCore (System.Reflection.Emit.MethodBuilder mdBuilder);
  * protected abstract void SetSetMethodCore (System.Reflection.Emit.MethodBuilder mdBuilder);
* System.Reflection.Emit.TypeBuilder
  * protected abstract void AddInterfaceImplementationCore (Type interfaceType);
  * protected abstract System.Reflection.TypeInfo CreateTypeInfoCore ();
  * protected abstract System.Reflection.Emit.ConstructorBuilder DefineConstructorCore (System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, Type[]? parameterTypes, Type[][]? requiredCustomModifiers, Type[][]? optionalCustomModifiers);
  * protected abstract System.Reflection.Emit.ConstructorBuilder DefineDefaultConstructorCore (System.Reflection.MethodAttributes attributes);
  * protected abstract System.Reflection.Emit.EventBuilder DefineEventCore (string name, System.Reflection.EventAttributes attributes, Type eventtype);
  * protected abstract System.Reflection.Emit.FieldBuilder DefineFieldCore (string fieldName, Type type, Type[]? requiredCustomModifiers, Type[]? optionalCustomModifiers, System.Reflection.FieldAttributes attributes);
  * protected abstract System.Reflection.Emit.GenericTypeParameterBuilder[] DefineGenericParametersCore (params string[] names);
  * protected abstract System.Reflection.Emit.FieldBuilder DefineInitializedDataCore (string name, byte[] data, System.Reflection.FieldAttributes attributes);
  * protected abstract System.Reflection.Emit.MethodBuilder DefineMethodCore (string name, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, Type? returnType, Type[]? returnTypeRequiredCustomModifiers, Type[]? returnTypeOptionalCustomModifiers, Type[]? parameterTypes, Type[][]? parameterTypeRequiredCustomModifiers, Type[][]? parameterTypeOptionalCustomModifiers);
  * protected abstract void DefineMethodOverrideCore (System.Reflection.MethodInfo methodInfoBody, System.Reflection.MethodInfo methodInfoDeclaration);
  * protected abstract System.Reflection.Emit.TypeBuilder DefineNestedTypeCore (string name, System.Reflection.TypeAttributes attr, Type? parent, Type[]? interfaces, System.Reflection.Emit.PackingSize packSize, int typeSize);
  * protected abstract System.Reflection.Emit.MethodBuilder DefinePInvokeMethodCore (string name, string dllName, string entryName, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, Type? returnType, Type[]? returnTypeRequiredCustomModifiers, Type[]? returnTypeOptionalCustomModifiers, Type[]? parameterTypes, Type[][]? parameterTypeRequiredCustomModifiers, Type[][]? parameterTypeOptionalCustomModifiers, System.Runtime.InteropServices.CallingConvention nativeCallConv, System.Runtime.InteropServices.CharSet nativeCharSet);
  * protected abstract System.Reflection.Emit.PropertyBuilder DefinePropertyCore (string name, System.Reflection.PropertyAttributes attributes, System.Reflection.CallingConventions callingConvention, Type returnType, Type[]? returnTypeRequiredCustomModifiers, Type[]? returnTypeOptionalCustomModifiers, Type[]? parameterTypes, Type[][]? parameterTypeRequiredCustomModifiers, Type[][]? parameterTypeOptionalCustomModifiers);
  * protected abstract System.Reflection.Emit.ConstructorBuilder DefineTypeInitializerCore ();
  * protected abstract System.Reflection.Emit.FieldBuilder DefineUninitializedDataCore (string name, int size, System.Reflection.FieldAttributes attributes);
  * protected abstract bool IsCreatedCore ();
  * protected abstract System.Reflection.Emit.PackingSize PackingSizeCore { get; }
  * protected abstract void SetCustomAttributeCore (System.Reflection.ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);
  * protected abstract void SetParentCore (Type? parent);
  * protected abstract int SizeCore { get; }
* System.Reflection.Metadata.Ecma335.InstructionEncoder
  * public System.Reflection.Metadata.Ecma335.SwitchInstructionEncoder Switch (int branchCount);
* System.Reflection.Metadata.Ecma335.SignatureTypeEncoder
  * public void TypedReference ();
* System.Reflection.Metadata.Ecma335.SwitchInstructionEncoder
  * public void Branch (System.Reflection.Metadata.Ecma335.LabelHandle label);
* System.Reflection.PortableExecutable.DllCharacteristics
  * ControlFlowGuard
  * ForceIntegrity
* System.Runtime.CompilerServices.CollectionBuilderAttribute
  * public CollectionBuilderAttribute (Type builderType, string methodName);
  * public Type BuilderType { get; }
  * public string MethodName { get; }
* System.Runtime.CompilerServices.InlineArrayAttribute
  * public InlineArrayAttribute (int length);
  * public int Length { get; }
* System.Runtime.CompilerServices.IsUnmanagedAttribute
  * public IsUnmanagedAttribute ();
* System.Runtime.CompilerServices.NullableAttribute
  * public NullableAttribute (byte value);
  * public NullableAttribute (byte[] value);
  * public readonly byte[] NullableFlags;
* System.Runtime.CompilerServices.NullableContextAttribute
  * public NullableContextAttribute (byte value);
  * public readonly byte Flag;
* System.Runtime.CompilerServices.NullablePublicOnlyAttribute
  * public NullablePublicOnlyAttribute (bool value);
  * public readonly bool IncludesInternals;
* System.Runtime.CompilerServices.RefSafetyRulesAttribute
  * public RefSafetyRulesAttribute (int version);
  * public int Version { get; }
* System.Runtime.CompilerServices.RequiresLocationAttribute
  * public RequiresLocationAttribute ();
* System.Runtime.CompilerServices.ScopedRefAttribute
  * public ScopedRefAttribute ();
* System.Runtime.CompilerServices.Unsafe
  * public static TTo BitCast<TFrom,TTo> (TFrom source) where TFrom : struct where TTo : struct;
* System.Runtime.CompilerServices.UnsafeAccessorAttribute
  * public UnsafeAccessorAttribute (System.Runtime.CompilerServices.UnsafeAccessorKind kind);
  * public System.Runtime.CompilerServices.UnsafeAccessorKind Kind { get; }
  * public string? Name { get; set; }
* System.Runtime.CompilerServices.UnsafeAccessorKind
  * Constructor
  * Field
  * Method
  * StaticField
  * StaticMethod
* System.Runtime.InteropServices.CollectionsMarshal
  * public static void SetCount<T> (System.Collections.Generic.List<T> list, int count);
* System.Runtime.InteropServices.ComWrappers
  * public static bool TryGetComInstance (object obj, out IntPtr unknown);
  * public static bool TryGetObject (IntPtr unknown, out object? obj);
* System.Runtime.InteropServices.ImmutableCollectionsMarshal
  * public static T[]? AsArray<T> (System.Collections.Immutable.ImmutableArray<T> array);
  * public static System.Collections.Immutable.ImmutableArray<T> AsImmutableArray<T> (T[]? array);
* System.Runtime.InteropServices.NFloat
  * public static System.Runtime.InteropServices.NFloat DegreesToRadians (System.Runtime.InteropServices.NFloat degrees);
  * public static System.Runtime.InteropServices.NFloat Lerp (System.Runtime.InteropServices.NFloat value1, System.Runtime.InteropServices.NFloat value2, System.Runtime.InteropServices.NFloat amount);
  * public static System.Runtime.InteropServices.NFloat Parse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider);
  * public static System.Runtime.InteropServices.NFloat Parse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, IFormatProvider? provider = default);
  * public static System.Runtime.InteropServices.NFloat RadiansToDegrees (System.Runtime.InteropServices.NFloat radians);
  * public bool TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, out System.Runtime.InteropServices.NFloat result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, out System.Runtime.InteropServices.NFloat result);
  * public static bool TryParse (ReadOnlySpan<byte> utf8Text, System.Globalization.NumberStyles style, IFormatProvider? provider, out System.Runtime.InteropServices.NFloat result);
* System.Runtime.InteropServices.Marshalling.ComExposedClassAttribute<T>
  * public ComExposedClassAttribute ();
  * public System.Runtime.InteropServices.ComWrappers.ComInterfaceEntry* GetComInterfaceEntries (out int count);
* System.Runtime.InteropServices.Marshalling.ComInterfaceMarshaller<T>
  * public static T? ConvertToManaged (void* unmanaged);
  * public static void* ConvertToUnmanaged (T? managed);
  * public static void Free (void* unmanaged);
* System.Runtime.InteropServices.Marshalling.ComInterfaceOptions
  * ComObjectWrapper
  * ManagedObjectWrapper
  * None
* System.Runtime.InteropServices.Marshalling.ComObject
  * ~ComObject ();
  * public void FinalRelease ();
  * RuntimeTypeHandle IDynamicInterfaceCastable.GetInterfaceImplementation (RuntimeTypeHandle interfaceType);
  * bool IDynamicInterfaceCastable.IsInterfaceImplemented (RuntimeTypeHandle interfaceType, bool throwIfNotImplemented);
  * System.Runtime.InteropServices.Marshalling.VirtualMethodTableInfo IUnmanagedVirtualMethodTableProvider.GetVirtualMethodTableInfoForKey (Type type);
* System.Runtime.InteropServices.Marshalling.ExceptionAsDefaultMarshaller<T>
  * public static T ConvertToUnmanaged (Exception e);
* System.Runtime.InteropServices.Marshalling.ExceptionAsHResultMarshaller<T>
  * public static T ConvertToUnmanaged (Exception e);
* System.Runtime.InteropServices.Marshalling.ExceptionAsNaNMarshaller<T>
  * public static T ConvertToUnmanaged (Exception e);
* System.Runtime.InteropServices.Marshalling.ExceptionAsVoidMarshaller
  * public static void ConvertToUnmanaged (Exception e);
* System.Runtime.InteropServices.Marshalling.GeneratedComClassAttribute
  * public GeneratedComClassAttribute ();
* System.Runtime.InteropServices.Marshalling.GeneratedComInterfaceAttribute
  * public GeneratedComInterfaceAttribute ();
  * public System.Runtime.InteropServices.Marshalling.ComInterfaceOptions Options { get; set; }
  * public System.Runtime.InteropServices.StringMarshalling StringMarshalling { get; set; }
  * public Type? StringMarshallingCustomType { get; set; }
* System.Runtime.InteropServices.Marshalling.IComExposedClass
  * public static abstract System.Runtime.InteropServices.ComWrappers.ComInterfaceEntry* GetComInterfaceEntries (out int count);
* System.Runtime.InteropServices.Marshalling.IComExposedDetails
  * public System.Runtime.InteropServices.ComWrappers.ComInterfaceEntry* GetComInterfaceEntries (out int count);
* System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy+TableInfo
  * public RuntimeTypeHandle ManagedType { get; init; }
  * public void** Table { get; init; }
  * public void* ThisPtr { get; init; }
* System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy
  * public void Clear (System.Runtime.InteropServices.Marshalling.IIUnknownStrategy unknownStrategy);
  * public System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy.TableInfo ConstructTableInfo (RuntimeTypeHandle handle, System.Runtime.InteropServices.Marshalling.IIUnknownDerivedDetails interfaceDetails, void* ptr);
  * public bool TryGetTableInfo (RuntimeTypeHandle handle, out System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy.TableInfo info);
  * public bool TrySetTableInfo (RuntimeTypeHandle handle, System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy.TableInfo info);
* System.Runtime.InteropServices.Marshalling.IIUnknownDerivedDetails
  * public Guid Iid { get; }
  * public Type Implementation { get; }
  * public void** ManagedVirtualMethodTable { get; }
* System.Runtime.InteropServices.Marshalling.IIUnknownInterfaceDetailsStrategy
  * public System.Runtime.InteropServices.Marshalling.IComExposedDetails? GetComExposedTypeDetails (RuntimeTypeHandle type);
  * public System.Runtime.InteropServices.Marshalling.IIUnknownDerivedDetails? GetIUnknownDerivedDetails (RuntimeTypeHandle type);
* System.Runtime.InteropServices.Marshalling.IIUnknownInterfaceType
  * public static abstract Guid Iid { get; }
  * public static abstract void** ManagedVirtualMethodTable { get; }
* System.Runtime.InteropServices.Marshalling.IIUnknownStrategy
  * public void* CreateInstancePointer (void* unknown);
  * public int QueryInterface (void* instancePtr, in Guid iid, out void* ppObj);
  * public int Release (void* instancePtr);
* System.Runtime.InteropServices.Marshalling.IUnknownDerivedAttribute<T,TImpl>
  * public IUnknownDerivedAttribute ();
  * public Guid Iid { get; }
  * public Type Implementation { get; }
  * public void** ManagedVirtualMethodTable { get; }
* System.Runtime.InteropServices.Marshalling.IUnmanagedVirtualMethodTableProvider
  * public System.Runtime.InteropServices.Marshalling.VirtualMethodTableInfo GetVirtualMethodTableInfoForKey (Type type);
* System.Runtime.InteropServices.Marshalling.SafeHandleMarshaller<T>+ManagedToUnmanagedIn
  * public void Free ();
  * public void FromManaged (T handle);
  * public IntPtr ToUnmanaged ();
* System.Runtime.InteropServices.Marshalling.SafeHandleMarshaller<T>+ManagedToUnmanagedOut
  * public ManagedToUnmanagedOut ();
  * public void Free ();
  * public void FromUnmanaged (IntPtr value);
  * public T ToManaged ();
* System.Runtime.InteropServices.Marshalling.SafeHandleMarshaller<T>+ManagedToUnmanagedRef
  * public ManagedToUnmanagedRef ();
  * public void Free ();
  * public void FromManaged (T handle);
  * public void FromUnmanaged (IntPtr value);
  * public void OnInvoked ();
  * public T ToManagedFinally ();
  * public IntPtr ToUnmanaged ();
* System.Runtime.InteropServices.Marshalling.StrategyBasedComWrappers
  * public StrategyBasedComWrappers ();
  * protected override sealed System.Runtime.InteropServices.ComWrappers.ComInterfaceEntry* ComputeVtables (object obj, System.Runtime.InteropServices.CreateComInterfaceFlags flags, out int count);
  * protected virtual System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy CreateCacheStrategy ();
  * protected static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy CreateDefaultCacheStrategy ();
  * protected override sealed object CreateObject (IntPtr externalComObject, System.Runtime.InteropServices.CreateObjectFlags flags);
  * public static System.Runtime.InteropServices.Marshalling.IIUnknownInterfaceDetailsStrategy DefaultIUnknownInterfaceDetailsStrategy { get; }
  * public static System.Runtime.InteropServices.Marshalling.IIUnknownStrategy DefaultIUnknownStrategy { get; }
  * protected virtual System.Runtime.InteropServices.Marshalling.IIUnknownInterfaceDetailsStrategy GetOrCreateInterfaceDetailsStrategy ();
  * protected virtual System.Runtime.InteropServices.Marshalling.IIUnknownStrategy GetOrCreateIUnknownStrategy ();
  * protected override sealed void ReleaseObjects (System.Collections.IEnumerable objects);
* System.Runtime.InteropServices.Marshalling.UniqueComInterfaceMarshaller<T>
  * public static T? ConvertToManaged (void* unmanaged);
  * public static void* ConvertToUnmanaged (T? managed);
  * public static void Free (void* unmanaged);
* System.Runtime.InteropServices.Marshalling.VirtualMethodTableInfo
  * public VirtualMethodTableInfo (void* thisPointer, void** virtualMethodTable);
  * public void Deconstruct (out void* thisPointer, out void** virtualMethodTable);
  * public void* ThisPointer { get; }
  * public void** VirtualMethodTable { get; }
* System.Runtime.Intrinsics.Vector128
  * public static System.Runtime.Intrinsics.Vector128<IntPtr> Create (System.Runtime.Intrinsics.Vector64<IntPtr> lower, System.Runtime.Intrinsics.Vector64<IntPtr> upper);
  * public static System.Runtime.Intrinsics.Vector128<UIntPtr> Create (System.Runtime.Intrinsics.Vector64<UIntPtr> lower, System.Runtime.Intrinsics.Vector64<UIntPtr> upper);
  * public static System.Runtime.Intrinsics.Vector128<T> Create<T> (System.Runtime.Intrinsics.Vector64<T> lower, System.Runtime.Intrinsics.Vector64<T> upper);
  * public static System.Runtime.Intrinsics.Vector128<T> CreateScalar<T> (T value);
  * public static System.Runtime.Intrinsics.Vector128<T> CreateScalarUnsafe<T> (T value);
  * public static System.Runtime.Intrinsics.Vector128<T> Divide<T> (System.Runtime.Intrinsics.Vector128<T> left, T right);
  * public static System.Runtime.Intrinsics.Vector128<ushort> WidenLower (System.Runtime.Intrinsics.Vector128<byte> source);
  * public static System.Runtime.Intrinsics.Vector128<int> WidenLower (System.Runtime.Intrinsics.Vector128<short> source);
  * public static System.Runtime.Intrinsics.Vector128<long> WidenLower (System.Runtime.Intrinsics.Vector128<int> source);
  * public static System.Runtime.Intrinsics.Vector128<short> WidenLower (System.Runtime.Intrinsics.Vector128<sbyte> source);
  * public static System.Runtime.Intrinsics.Vector128<double> WidenLower (System.Runtime.Intrinsics.Vector128<float> source);
  * public static System.Runtime.Intrinsics.Vector128<uint> WidenLower (System.Runtime.Intrinsics.Vector128<ushort> source);
  * public static System.Runtime.Intrinsics.Vector128<ulong> WidenLower (System.Runtime.Intrinsics.Vector128<uint> source);
  * public static System.Runtime.Intrinsics.Vector128<ushort> WidenUpper (System.Runtime.Intrinsics.Vector128<byte> source);
  * public static System.Runtime.Intrinsics.Vector128<int> WidenUpper (System.Runtime.Intrinsics.Vector128<short> source);
  * public static System.Runtime.Intrinsics.Vector128<long> WidenUpper (System.Runtime.Intrinsics.Vector128<int> source);
  * public static System.Runtime.Intrinsics.Vector128<short> WidenUpper (System.Runtime.Intrinsics.Vector128<sbyte> source);
  * public static System.Runtime.Intrinsics.Vector128<double> WidenUpper (System.Runtime.Intrinsics.Vector128<float> source);
  * public static System.Runtime.Intrinsics.Vector128<uint> WidenUpper (System.Runtime.Intrinsics.Vector128<ushort> source);
  * public static System.Runtime.Intrinsics.Vector128<ulong> WidenUpper (System.Runtime.Intrinsics.Vector128<uint> source);
* System.Runtime.Intrinsics.Vector128<T>
  * public static System.Runtime.Intrinsics.Vector128<T> One { get; }
  * public static System.Runtime.Intrinsics.Vector128<T> operator / (System.Runtime.Intrinsics.Vector128<T> left, T right);
  * public static System.Runtime.Intrinsics.Vector128<T> operator << (System.Runtime.Intrinsics.Vector128<T> value, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector128<T> operator >> (System.Runtime.Intrinsics.Vector128<T> value, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector128<T> op_UnsignedRightShift (System.Runtime.Intrinsics.Vector128<T> value, int shiftCount);
* System.Runtime.Intrinsics.Vector256
  * public static System.Runtime.Intrinsics.Vector256<IntPtr> Create (System.Runtime.Intrinsics.Vector128<IntPtr> lower, System.Runtime.Intrinsics.Vector128<IntPtr> upper);
  * public static System.Runtime.Intrinsics.Vector256<UIntPtr> Create (System.Runtime.Intrinsics.Vector128<UIntPtr> lower, System.Runtime.Intrinsics.Vector128<UIntPtr> upper);
  * public static System.Runtime.Intrinsics.Vector256<T> Create<T> (System.Runtime.Intrinsics.Vector128<T> lower, System.Runtime.Intrinsics.Vector128<T> upper);
  * public static System.Runtime.Intrinsics.Vector256<T> CreateScalar<T> (T value);
  * public static System.Runtime.Intrinsics.Vector256<T> CreateScalarUnsafe<T> (T value);
  * public static System.Runtime.Intrinsics.Vector256<T> Divide<T> (System.Runtime.Intrinsics.Vector256<T> left, T right);
  * public static System.Runtime.Intrinsics.Vector512<T> ToVector512<T> (this System.Runtime.Intrinsics.Vector256<T> vector);
  * public static System.Runtime.Intrinsics.Vector512<T> ToVector512Unsafe<T> (this System.Runtime.Intrinsics.Vector256<T> vector);
  * public static System.Runtime.Intrinsics.Vector256<ushort> WidenLower (System.Runtime.Intrinsics.Vector256<byte> source);
  * public static System.Runtime.Intrinsics.Vector256<int> WidenLower (System.Runtime.Intrinsics.Vector256<short> source);
  * public static System.Runtime.Intrinsics.Vector256<long> WidenLower (System.Runtime.Intrinsics.Vector256<int> source);
  * public static System.Runtime.Intrinsics.Vector256<short> WidenLower (System.Runtime.Intrinsics.Vector256<sbyte> source);
  * public static System.Runtime.Intrinsics.Vector256<double> WidenLower (System.Runtime.Intrinsics.Vector256<float> source);
  * public static System.Runtime.Intrinsics.Vector256<uint> WidenLower (System.Runtime.Intrinsics.Vector256<ushort> source);
  * public static System.Runtime.Intrinsics.Vector256<ulong> WidenLower (System.Runtime.Intrinsics.Vector256<uint> source);
  * public static System.Runtime.Intrinsics.Vector256<ushort> WidenUpper (System.Runtime.Intrinsics.Vector256<byte> source);
  * public static System.Runtime.Intrinsics.Vector256<int> WidenUpper (System.Runtime.Intrinsics.Vector256<short> source);
  * public static System.Runtime.Intrinsics.Vector256<long> WidenUpper (System.Runtime.Intrinsics.Vector256<int> source);
  * public static System.Runtime.Intrinsics.Vector256<short> WidenUpper (System.Runtime.Intrinsics.Vector256<sbyte> source);
  * public static System.Runtime.Intrinsics.Vector256<double> WidenUpper (System.Runtime.Intrinsics.Vector256<float> source);
  * public static System.Runtime.Intrinsics.Vector256<uint> WidenUpper (System.Runtime.Intrinsics.Vector256<ushort> source);
  * public static System.Runtime.Intrinsics.Vector256<ulong> WidenUpper (System.Runtime.Intrinsics.Vector256<uint> source);
* System.Runtime.Intrinsics.Vector256<T>
  * public static System.Runtime.Intrinsics.Vector256<T> One { get; }
  * public static System.Runtime.Intrinsics.Vector256<T> operator / (System.Runtime.Intrinsics.Vector256<T> left, T right);
  * public static System.Runtime.Intrinsics.Vector256<T> operator << (System.Runtime.Intrinsics.Vector256<T> value, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector256<T> operator >> (System.Runtime.Intrinsics.Vector256<T> value, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector256<T> op_UnsignedRightShift (System.Runtime.Intrinsics.Vector256<T> value, int shiftCount);
* System.Runtime.Intrinsics.Vector512
  * public static System.Runtime.Intrinsics.Vector512<T> Abs<T> (System.Runtime.Intrinsics.Vector512<T> vector);
  * public static System.Runtime.Intrinsics.Vector512<T> Add<T> (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static System.Runtime.Intrinsics.Vector512<T> AndNot<T> (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static System.Runtime.Intrinsics.Vector512<TTo> As<TFrom,TTo> (this System.Runtime.Intrinsics.Vector512<TFrom> vector);
  * public static System.Runtime.Intrinsics.Vector512<byte> AsByte<T> (this System.Runtime.Intrinsics.Vector512<T> vector);
  * public static System.Runtime.Intrinsics.Vector512<double> AsDouble<T> (this System.Runtime.Intrinsics.Vector512<T> vector);
  * public static System.Runtime.Intrinsics.Vector512<short> AsInt16<T> (this System.Runtime.Intrinsics.Vector512<T> vector);
  * public static System.Runtime.Intrinsics.Vector512<int> AsInt32<T> (this System.Runtime.Intrinsics.Vector512<T> vector);
  * public static System.Runtime.Intrinsics.Vector512<long> AsInt64<T> (this System.Runtime.Intrinsics.Vector512<T> vector);
  * public static System.Runtime.Intrinsics.Vector512<IntPtr> AsNInt<T> (this System.Runtime.Intrinsics.Vector512<T> vector);
  * public static System.Runtime.Intrinsics.Vector512<UIntPtr> AsNUInt<T> (this System.Runtime.Intrinsics.Vector512<T> vector);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> AsSByte<T> (this System.Runtime.Intrinsics.Vector512<T> vector);
  * public static System.Runtime.Intrinsics.Vector512<float> AsSingle<T> (this System.Runtime.Intrinsics.Vector512<T> vector);
  * public static System.Runtime.Intrinsics.Vector512<ushort> AsUInt16<T> (this System.Runtime.Intrinsics.Vector512<T> vector);
  * public static System.Runtime.Intrinsics.Vector512<uint> AsUInt32<T> (this System.Runtime.Intrinsics.Vector512<T> vector);
  * public static System.Runtime.Intrinsics.Vector512<ulong> AsUInt64<T> (this System.Runtime.Intrinsics.Vector512<T> vector);
  * public static System.Numerics.Vector<T> AsVector<T> (this System.Runtime.Intrinsics.Vector512<T> value);
  * public static System.Runtime.Intrinsics.Vector512<T> AsVector512<T> (this System.Numerics.Vector<T> value);
  * public static System.Runtime.Intrinsics.Vector512<T> BitwiseAnd<T> (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static System.Runtime.Intrinsics.Vector512<T> BitwiseOr<T> (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static System.Runtime.Intrinsics.Vector512<double> Ceiling (System.Runtime.Intrinsics.Vector512<double> vector);
  * public static System.Runtime.Intrinsics.Vector512<float> Ceiling (System.Runtime.Intrinsics.Vector512<float> vector);
  * public static System.Runtime.Intrinsics.Vector512<T> ConditionalSelect<T> (System.Runtime.Intrinsics.Vector512<T> condition, System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static System.Runtime.Intrinsics.Vector512<double> ConvertToDouble (System.Runtime.Intrinsics.Vector512<long> vector);
  * public static System.Runtime.Intrinsics.Vector512<double> ConvertToDouble (System.Runtime.Intrinsics.Vector512<ulong> vector);
  * public static System.Runtime.Intrinsics.Vector512<int> ConvertToInt32 (System.Runtime.Intrinsics.Vector512<float> vector);
  * public static System.Runtime.Intrinsics.Vector512<long> ConvertToInt64 (System.Runtime.Intrinsics.Vector512<double> vector);
  * public static System.Runtime.Intrinsics.Vector512<float> ConvertToSingle (System.Runtime.Intrinsics.Vector512<int> vector);
  * public static System.Runtime.Intrinsics.Vector512<float> ConvertToSingle (System.Runtime.Intrinsics.Vector512<uint> vector);
  * public static System.Runtime.Intrinsics.Vector512<uint> ConvertToUInt32 (System.Runtime.Intrinsics.Vector512<float> vector);
  * public static System.Runtime.Intrinsics.Vector512<ulong> ConvertToUInt64 (System.Runtime.Intrinsics.Vector512<double> vector);
  * public static void CopyTo<T> (this System.Runtime.Intrinsics.Vector512<T> vector, Span<T> destination);
  * public static void CopyTo<T> (this System.Runtime.Intrinsics.Vector512<T> vector, T[] destination);
  * public static void CopyTo<T> (this System.Runtime.Intrinsics.Vector512<T> vector, T[] destination, int startIndex);
  * public static System.Runtime.Intrinsics.Vector512<byte> Create (byte value);
  * public static System.Runtime.Intrinsics.Vector512<double> Create (double value);
  * public static System.Runtime.Intrinsics.Vector512<short> Create (short value);
  * public static System.Runtime.Intrinsics.Vector512<int> Create (int value);
  * public static System.Runtime.Intrinsics.Vector512<long> Create (long value);
  * public static System.Runtime.Intrinsics.Vector512<IntPtr> Create (IntPtr value);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> Create (sbyte value);
  * public static System.Runtime.Intrinsics.Vector512<float> Create (float value);
  * public static System.Runtime.Intrinsics.Vector512<ushort> Create (ushort value);
  * public static System.Runtime.Intrinsics.Vector512<uint> Create (uint value);
  * public static System.Runtime.Intrinsics.Vector512<ulong> Create (ulong value);
  * public static System.Runtime.Intrinsics.Vector512<UIntPtr> Create (UIntPtr value);
  * public static System.Runtime.Intrinsics.Vector512<byte> Create (System.Runtime.Intrinsics.Vector256<byte> lower, System.Runtime.Intrinsics.Vector256<byte> upper);
  * public static System.Runtime.Intrinsics.Vector512<double> Create (System.Runtime.Intrinsics.Vector256<double> lower, System.Runtime.Intrinsics.Vector256<double> upper);
  * public static System.Runtime.Intrinsics.Vector512<short> Create (System.Runtime.Intrinsics.Vector256<short> lower, System.Runtime.Intrinsics.Vector256<short> upper);
  * public static System.Runtime.Intrinsics.Vector512<int> Create (System.Runtime.Intrinsics.Vector256<int> lower, System.Runtime.Intrinsics.Vector256<int> upper);
  * public static System.Runtime.Intrinsics.Vector512<long> Create (System.Runtime.Intrinsics.Vector256<long> lower, System.Runtime.Intrinsics.Vector256<long> upper);
  * public static System.Runtime.Intrinsics.Vector512<IntPtr> Create (System.Runtime.Intrinsics.Vector256<IntPtr> lower, System.Runtime.Intrinsics.Vector256<IntPtr> upper);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> Create (System.Runtime.Intrinsics.Vector256<sbyte> lower, System.Runtime.Intrinsics.Vector256<sbyte> upper);
  * public static System.Runtime.Intrinsics.Vector512<float> Create (System.Runtime.Intrinsics.Vector256<float> lower, System.Runtime.Intrinsics.Vector256<float> upper);
  * public static System.Runtime.Intrinsics.Vector512<ushort> Create (System.Runtime.Intrinsics.Vector256<ushort> lower, System.Runtime.Intrinsics.Vector256<ushort> upper);
  * public static System.Runtime.Intrinsics.Vector512<uint> Create (System.Runtime.Intrinsics.Vector256<uint> lower, System.Runtime.Intrinsics.Vector256<uint> upper);
  * public static System.Runtime.Intrinsics.Vector512<ulong> Create (System.Runtime.Intrinsics.Vector256<ulong> lower, System.Runtime.Intrinsics.Vector256<ulong> upper);
  * public static System.Runtime.Intrinsics.Vector512<UIntPtr> Create (System.Runtime.Intrinsics.Vector256<UIntPtr> lower, System.Runtime.Intrinsics.Vector256<UIntPtr> upper);
  * public static System.Runtime.Intrinsics.Vector512<double> Create (double e0, double e1, double e2, double e3, double e4, double e5, double e6, double e7);
  * public static System.Runtime.Intrinsics.Vector512<long> Create (long e0, long e1, long e2, long e3, long e4, long e5, long e6, long e7);
  * public static System.Runtime.Intrinsics.Vector512<ulong> Create (ulong e0, ulong e1, ulong e2, ulong e3, ulong e4, ulong e5, ulong e6, ulong e7);
  * public static System.Runtime.Intrinsics.Vector512<int> Create (int e0, int e1, int e2, int e3, int e4, int e5, int e6, int e7, int e8, int e9, int e10, int e11, int e12, int e13, int e14, int e15);
  * public static System.Runtime.Intrinsics.Vector512<float> Create (float e0, float e1, float e2, float e3, float e4, float e5, float e6, float e7, float e8, float e9, float e10, float e11, float e12, float e13, float e14, float e15);
  * public static System.Runtime.Intrinsics.Vector512<uint> Create (uint e0, uint e1, uint e2, uint e3, uint e4, uint e5, uint e6, uint e7, uint e8, uint e9, uint e10, uint e11, uint e12, uint e13, uint e14, uint e15);
  * public static System.Runtime.Intrinsics.Vector512<short> Create (short e0, short e1, short e2, short e3, short e4, short e5, short e6, short e7, short e8, short e9, short e10, short e11, short e12, short e13, short e14, short e15, short e16, short e17, short e18, short e19, short e20, short e21, short e22, short e23, short e24, short e25, short e26, short e27, short e28, short e29, short e30, short e31);
  * public static System.Runtime.Intrinsics.Vector512<ushort> Create (ushort e0, ushort e1, ushort e2, ushort e3, ushort e4, ushort e5, ushort e6, ushort e7, ushort e8, ushort e9, ushort e10, ushort e11, ushort e12, ushort e13, ushort e14, ushort e15, ushort e16, ushort e17, ushort e18, ushort e19, ushort e20, ushort e21, ushort e22, ushort e23, ushort e24, ushort e25, ushort e26, ushort e27, ushort e28, ushort e29, ushort e30, ushort e31);
  * public static System.Runtime.Intrinsics.Vector512<byte> Create (byte e0, byte e1, byte e2, byte e3, byte e4, byte e5, byte e6, byte e7, byte e8, byte e9, byte e10, byte e11, byte e12, byte e13, byte e14, byte e15, byte e16, byte e17, byte e18, byte e19, byte e20, byte e21, byte e22, byte e23, byte e24, byte e25, byte e26, byte e27, byte e28, byte e29, byte e30, byte e31, byte e32, byte e33, byte e34, byte e35, byte e36, byte e37, byte e38, byte e39, byte e40, byte e41, byte e42, byte e43, byte e44, byte e45, byte e46, byte e47, byte e48, byte e49, byte e50, byte e51, byte e52, byte e53, byte e54, byte e55, byte e56, byte e57, byte e58, byte e59, byte e60, byte e61, byte e62, byte e63);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> Create (sbyte e0, sbyte e1, sbyte e2, sbyte e3, sbyte e4, sbyte e5, sbyte e6, sbyte e7, sbyte e8, sbyte e9, sbyte e10, sbyte e11, sbyte e12, sbyte e13, sbyte e14, sbyte e15, sbyte e16, sbyte e17, sbyte e18, sbyte e19, sbyte e20, sbyte e21, sbyte e22, sbyte e23, sbyte e24, sbyte e25, sbyte e26, sbyte e27, sbyte e28, sbyte e29, sbyte e30, sbyte e31, sbyte e32, sbyte e33, sbyte e34, sbyte e35, sbyte e36, sbyte e37, sbyte e38, sbyte e39, sbyte e40, sbyte e41, sbyte e42, sbyte e43, sbyte e44, sbyte e45, sbyte e46, sbyte e47, sbyte e48, sbyte e49, sbyte e50, sbyte e51, sbyte e52, sbyte e53, sbyte e54, sbyte e55, sbyte e56, sbyte e57, sbyte e58, sbyte e59, sbyte e60, sbyte e61, sbyte e62, sbyte e63);
  * public static System.Runtime.Intrinsics.Vector512<T> Create<T> (ReadOnlySpan<T> values);
  * public static System.Runtime.Intrinsics.Vector512<T> Create<T> (T value);
  * public static System.Runtime.Intrinsics.Vector512<T> Create<T> (T[] values);
  * public static System.Runtime.Intrinsics.Vector512<T> Create<T> (System.Runtime.Intrinsics.Vector256<T> lower, System.Runtime.Intrinsics.Vector256<T> upper);
  * public static System.Runtime.Intrinsics.Vector512<T> Create<T> (T[] values, int index);
  * public static System.Runtime.Intrinsics.Vector512<byte> CreateScalar (byte value);
  * public static System.Runtime.Intrinsics.Vector512<double> CreateScalar (double value);
  * public static System.Runtime.Intrinsics.Vector512<short> CreateScalar (short value);
  * public static System.Runtime.Intrinsics.Vector512<int> CreateScalar (int value);
  * public static System.Runtime.Intrinsics.Vector512<long> CreateScalar (long value);
  * public static System.Runtime.Intrinsics.Vector512<IntPtr> CreateScalar (IntPtr value);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> CreateScalar (sbyte value);
  * public static System.Runtime.Intrinsics.Vector512<float> CreateScalar (float value);
  * public static System.Runtime.Intrinsics.Vector512<ushort> CreateScalar (ushort value);
  * public static System.Runtime.Intrinsics.Vector512<uint> CreateScalar (uint value);
  * public static System.Runtime.Intrinsics.Vector512<ulong> CreateScalar (ulong value);
  * public static System.Runtime.Intrinsics.Vector512<UIntPtr> CreateScalar (UIntPtr value);
  * public static System.Runtime.Intrinsics.Vector512<T> CreateScalar<T> (T value);
  * public static System.Runtime.Intrinsics.Vector512<byte> CreateScalarUnsafe (byte value);
  * public static System.Runtime.Intrinsics.Vector512<double> CreateScalarUnsafe (double value);
  * public static System.Runtime.Intrinsics.Vector512<short> CreateScalarUnsafe (short value);
  * public static System.Runtime.Intrinsics.Vector512<int> CreateScalarUnsafe (int value);
  * public static System.Runtime.Intrinsics.Vector512<long> CreateScalarUnsafe (long value);
  * public static System.Runtime.Intrinsics.Vector512<IntPtr> CreateScalarUnsafe (IntPtr value);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> CreateScalarUnsafe (sbyte value);
  * public static System.Runtime.Intrinsics.Vector512<float> CreateScalarUnsafe (float value);
  * public static System.Runtime.Intrinsics.Vector512<ushort> CreateScalarUnsafe (ushort value);
  * public static System.Runtime.Intrinsics.Vector512<uint> CreateScalarUnsafe (uint value);
  * public static System.Runtime.Intrinsics.Vector512<ulong> CreateScalarUnsafe (ulong value);
  * public static System.Runtime.Intrinsics.Vector512<UIntPtr> CreateScalarUnsafe (UIntPtr value);
  * public static System.Runtime.Intrinsics.Vector512<T> CreateScalarUnsafe<T> (T value);
  * public static System.Runtime.Intrinsics.Vector512<T> Divide<T> (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static System.Runtime.Intrinsics.Vector512<T> Divide<T> (System.Runtime.Intrinsics.Vector512<T> left, T right);
  * public static T Dot<T> (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static System.Runtime.Intrinsics.Vector512<T> Equals<T> (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static bool EqualsAll<T> (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static bool EqualsAny<T> (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static ulong ExtractMostSignificantBits<T> (this System.Runtime.Intrinsics.Vector512<T> vector);
  * public static System.Runtime.Intrinsics.Vector512<double> Floor (System.Runtime.Intrinsics.Vector512<double> vector);
  * public static System.Runtime.Intrinsics.Vector512<float> Floor (System.Runtime.Intrinsics.Vector512<float> vector);
  * public static T GetElement<T> (this System.Runtime.Intrinsics.Vector512<T> vector, int index);
  * public static System.Runtime.Intrinsics.Vector256<T> GetLower<T> (this System.Runtime.Intrinsics.Vector512<T> vector);
  * public static System.Runtime.Intrinsics.Vector256<T> GetUpper<T> (this System.Runtime.Intrinsics.Vector512<T> vector);
  * public static System.Runtime.Intrinsics.Vector512<T> GreaterThan<T> (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static bool GreaterThanAll<T> (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static bool GreaterThanAny<T> (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static System.Runtime.Intrinsics.Vector512<T> GreaterThanOrEqual<T> (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static bool GreaterThanOrEqualAll<T> (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static bool GreaterThanOrEqualAny<T> (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static bool IsHardwareAccelerated { get; }
  * public static System.Runtime.Intrinsics.Vector512<T> LessThan<T> (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static bool LessThanAll<T> (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static bool LessThanAny<T> (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static System.Runtime.Intrinsics.Vector512<T> LessThanOrEqual<T> (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static bool LessThanOrEqualAll<T> (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static bool LessThanOrEqualAny<T> (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static System.Runtime.Intrinsics.Vector512<T> Load<T> (T* source);
  * public static System.Runtime.Intrinsics.Vector512<T> LoadAligned<T> (T* source);
  * public static System.Runtime.Intrinsics.Vector512<T> LoadAlignedNonTemporal<T> (T* source);
  * public static System.Runtime.Intrinsics.Vector512<T> LoadUnsafe<T> (ref T source);
  * public static System.Runtime.Intrinsics.Vector512<T> LoadUnsafe<T> (ref T source, UIntPtr elementOffset);
  * public static System.Runtime.Intrinsics.Vector512<T> Max<T> (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static System.Runtime.Intrinsics.Vector512<T> Min<T> (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static System.Runtime.Intrinsics.Vector512<T> Multiply<T> (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static System.Runtime.Intrinsics.Vector512<T> Multiply<T> (System.Runtime.Intrinsics.Vector512<T> left, T right);
  * public static System.Runtime.Intrinsics.Vector512<T> Multiply<T> (T left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static System.Runtime.Intrinsics.Vector512<float> Narrow (System.Runtime.Intrinsics.Vector512<double> lower, System.Runtime.Intrinsics.Vector512<double> upper);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> Narrow (System.Runtime.Intrinsics.Vector512<short> lower, System.Runtime.Intrinsics.Vector512<short> upper);
  * public static System.Runtime.Intrinsics.Vector512<short> Narrow (System.Runtime.Intrinsics.Vector512<int> lower, System.Runtime.Intrinsics.Vector512<int> upper);
  * public static System.Runtime.Intrinsics.Vector512<int> Narrow (System.Runtime.Intrinsics.Vector512<long> lower, System.Runtime.Intrinsics.Vector512<long> upper);
  * public static System.Runtime.Intrinsics.Vector512<byte> Narrow (System.Runtime.Intrinsics.Vector512<ushort> lower, System.Runtime.Intrinsics.Vector512<ushort> upper);
  * public static System.Runtime.Intrinsics.Vector512<ushort> Narrow (System.Runtime.Intrinsics.Vector512<uint> lower, System.Runtime.Intrinsics.Vector512<uint> upper);
  * public static System.Runtime.Intrinsics.Vector512<uint> Narrow (System.Runtime.Intrinsics.Vector512<ulong> lower, System.Runtime.Intrinsics.Vector512<ulong> upper);
  * public static System.Runtime.Intrinsics.Vector512<T> Negate<T> (System.Runtime.Intrinsics.Vector512<T> vector);
  * public static System.Runtime.Intrinsics.Vector512<T> OnesComplement<T> (System.Runtime.Intrinsics.Vector512<T> vector);
  * public static System.Runtime.Intrinsics.Vector512<byte> ShiftLeft (System.Runtime.Intrinsics.Vector512<byte> vector, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector512<short> ShiftLeft (System.Runtime.Intrinsics.Vector512<short> vector, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector512<int> ShiftLeft (System.Runtime.Intrinsics.Vector512<int> vector, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector512<long> ShiftLeft (System.Runtime.Intrinsics.Vector512<long> vector, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector512<IntPtr> ShiftLeft (System.Runtime.Intrinsics.Vector512<IntPtr> vector, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> ShiftLeft (System.Runtime.Intrinsics.Vector512<sbyte> vector, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector512<ushort> ShiftLeft (System.Runtime.Intrinsics.Vector512<ushort> vector, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector512<uint> ShiftLeft (System.Runtime.Intrinsics.Vector512<uint> vector, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector512<ulong> ShiftLeft (System.Runtime.Intrinsics.Vector512<ulong> vector, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector512<UIntPtr> ShiftLeft (System.Runtime.Intrinsics.Vector512<UIntPtr> vector, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector512<short> ShiftRightArithmetic (System.Runtime.Intrinsics.Vector512<short> vector, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector512<int> ShiftRightArithmetic (System.Runtime.Intrinsics.Vector512<int> vector, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector512<long> ShiftRightArithmetic (System.Runtime.Intrinsics.Vector512<long> vector, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector512<IntPtr> ShiftRightArithmetic (System.Runtime.Intrinsics.Vector512<IntPtr> vector, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> ShiftRightArithmetic (System.Runtime.Intrinsics.Vector512<sbyte> vector, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector512<byte> ShiftRightLogical (System.Runtime.Intrinsics.Vector512<byte> vector, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector512<short> ShiftRightLogical (System.Runtime.Intrinsics.Vector512<short> vector, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector512<int> ShiftRightLogical (System.Runtime.Intrinsics.Vector512<int> vector, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector512<long> ShiftRightLogical (System.Runtime.Intrinsics.Vector512<long> vector, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector512<IntPtr> ShiftRightLogical (System.Runtime.Intrinsics.Vector512<IntPtr> vector, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> ShiftRightLogical (System.Runtime.Intrinsics.Vector512<sbyte> vector, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector512<ushort> ShiftRightLogical (System.Runtime.Intrinsics.Vector512<ushort> vector, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector512<uint> ShiftRightLogical (System.Runtime.Intrinsics.Vector512<uint> vector, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector512<ulong> ShiftRightLogical (System.Runtime.Intrinsics.Vector512<ulong> vector, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector512<UIntPtr> ShiftRightLogical (System.Runtime.Intrinsics.Vector512<UIntPtr> vector, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector512<byte> Shuffle (System.Runtime.Intrinsics.Vector512<byte> vector, System.Runtime.Intrinsics.Vector512<byte> indices);
  * public static System.Runtime.Intrinsics.Vector512<double> Shuffle (System.Runtime.Intrinsics.Vector512<double> vector, System.Runtime.Intrinsics.Vector512<long> indices);
  * public static System.Runtime.Intrinsics.Vector512<short> Shuffle (System.Runtime.Intrinsics.Vector512<short> vector, System.Runtime.Intrinsics.Vector512<short> indices);
  * public static System.Runtime.Intrinsics.Vector512<int> Shuffle (System.Runtime.Intrinsics.Vector512<int> vector, System.Runtime.Intrinsics.Vector512<int> indices);
  * public static System.Runtime.Intrinsics.Vector512<long> Shuffle (System.Runtime.Intrinsics.Vector512<long> vector, System.Runtime.Intrinsics.Vector512<long> indices);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> Shuffle (System.Runtime.Intrinsics.Vector512<sbyte> vector, System.Runtime.Intrinsics.Vector512<sbyte> indices);
  * public static System.Runtime.Intrinsics.Vector512<float> Shuffle (System.Runtime.Intrinsics.Vector512<float> vector, System.Runtime.Intrinsics.Vector512<int> indices);
  * public static System.Runtime.Intrinsics.Vector512<ushort> Shuffle (System.Runtime.Intrinsics.Vector512<ushort> vector, System.Runtime.Intrinsics.Vector512<ushort> indices);
  * public static System.Runtime.Intrinsics.Vector512<uint> Shuffle (System.Runtime.Intrinsics.Vector512<uint> vector, System.Runtime.Intrinsics.Vector512<uint> indices);
  * public static System.Runtime.Intrinsics.Vector512<ulong> Shuffle (System.Runtime.Intrinsics.Vector512<ulong> vector, System.Runtime.Intrinsics.Vector512<ulong> indices);
  * public static System.Runtime.Intrinsics.Vector512<T> Sqrt<T> (System.Runtime.Intrinsics.Vector512<T> vector);
  * public static void Store<T> (this System.Runtime.Intrinsics.Vector512<T> source, T* destination);
  * public static void StoreAligned<T> (this System.Runtime.Intrinsics.Vector512<T> source, T* destination);
  * public static void StoreAlignedNonTemporal<T> (this System.Runtime.Intrinsics.Vector512<T> source, T* destination);
  * public static void StoreUnsafe<T> (this System.Runtime.Intrinsics.Vector512<T> source, ref T destination);
  * public static void StoreUnsafe<T> (this System.Runtime.Intrinsics.Vector512<T> source, ref T destination, UIntPtr elementOffset);
  * public static System.Runtime.Intrinsics.Vector512<T> Subtract<T> (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static T Sum<T> (System.Runtime.Intrinsics.Vector512<T> vector);
  * public static T ToScalar<T> (this System.Runtime.Intrinsics.Vector512<T> vector);
  * public static bool TryCopyTo<T> (this System.Runtime.Intrinsics.Vector512<T> vector, Span<T> destination);
  * public static (System.Runtime.Intrinsics.Vector512<ushort> Lower, System.Runtime.Intrinsics.Vector512<ushort> Upper) Widen (System.Runtime.Intrinsics.Vector512<byte> source);
  * public static (System.Runtime.Intrinsics.Vector512<int> Lower, System.Runtime.Intrinsics.Vector512<int> Upper) Widen (System.Runtime.Intrinsics.Vector512<short> source);
  * public static (System.Runtime.Intrinsics.Vector512<long> Lower, System.Runtime.Intrinsics.Vector512<long> Upper) Widen (System.Runtime.Intrinsics.Vector512<int> source);
  * public static (System.Runtime.Intrinsics.Vector512<short> Lower, System.Runtime.Intrinsics.Vector512<short> Upper) Widen (System.Runtime.Intrinsics.Vector512<sbyte> source);
  * public static (System.Runtime.Intrinsics.Vector512<double> Lower, System.Runtime.Intrinsics.Vector512<double> Upper) Widen (System.Runtime.Intrinsics.Vector512<float> source);
  * public static (System.Runtime.Intrinsics.Vector512<uint> Lower, System.Runtime.Intrinsics.Vector512<uint> Upper) Widen (System.Runtime.Intrinsics.Vector512<ushort> source);
  * public static (System.Runtime.Intrinsics.Vector512<ulong> Lower, System.Runtime.Intrinsics.Vector512<ulong> Upper) Widen (System.Runtime.Intrinsics.Vector512<uint> source);
  * public static System.Runtime.Intrinsics.Vector512<ushort> WidenLower (System.Runtime.Intrinsics.Vector512<byte> source);
  * public static System.Runtime.Intrinsics.Vector512<int> WidenLower (System.Runtime.Intrinsics.Vector512<short> source);
  * public static System.Runtime.Intrinsics.Vector512<long> WidenLower (System.Runtime.Intrinsics.Vector512<int> source);
  * public static System.Runtime.Intrinsics.Vector512<short> WidenLower (System.Runtime.Intrinsics.Vector512<sbyte> source);
  * public static System.Runtime.Intrinsics.Vector512<double> WidenLower (System.Runtime.Intrinsics.Vector512<float> source);
  * public static System.Runtime.Intrinsics.Vector512<uint> WidenLower (System.Runtime.Intrinsics.Vector512<ushort> source);
  * public static System.Runtime.Intrinsics.Vector512<ulong> WidenLower (System.Runtime.Intrinsics.Vector512<uint> source);
  * public static System.Runtime.Intrinsics.Vector512<ushort> WidenUpper (System.Runtime.Intrinsics.Vector512<byte> source);
  * public static System.Runtime.Intrinsics.Vector512<int> WidenUpper (System.Runtime.Intrinsics.Vector512<short> source);
  * public static System.Runtime.Intrinsics.Vector512<long> WidenUpper (System.Runtime.Intrinsics.Vector512<int> source);
  * public static System.Runtime.Intrinsics.Vector512<short> WidenUpper (System.Runtime.Intrinsics.Vector512<sbyte> source);
  * public static System.Runtime.Intrinsics.Vector512<double> WidenUpper (System.Runtime.Intrinsics.Vector512<float> source);
  * public static System.Runtime.Intrinsics.Vector512<uint> WidenUpper (System.Runtime.Intrinsics.Vector512<ushort> source);
  * public static System.Runtime.Intrinsics.Vector512<ulong> WidenUpper (System.Runtime.Intrinsics.Vector512<uint> source);
  * public static System.Runtime.Intrinsics.Vector512<T> WithElement<T> (this System.Runtime.Intrinsics.Vector512<T> vector, int index, T value);
  * public static System.Runtime.Intrinsics.Vector512<T> WithLower<T> (this System.Runtime.Intrinsics.Vector512<T> vector, System.Runtime.Intrinsics.Vector256<T> value);
  * public static System.Runtime.Intrinsics.Vector512<T> WithUpper<T> (this System.Runtime.Intrinsics.Vector512<T> vector, System.Runtime.Intrinsics.Vector256<T> value);
  * public static System.Runtime.Intrinsics.Vector512<T> Xor<T> (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
* System.Runtime.Intrinsics.Vector512<T>
  * public static System.Runtime.Intrinsics.Vector512<T> AllBitsSet { get; }
  * public static int Count { get; }
  * public override bool Equals (object? obj);
  * public bool Equals (System.Runtime.Intrinsics.Vector512<T> other);
  * public override int GetHashCode ();
  * public static bool IsSupported { get; }
  * public T this[int index] { get; }
  * public static System.Runtime.Intrinsics.Vector512<T> One { get; }
  * public static System.Runtime.Intrinsics.Vector512<T> operator + (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static System.Runtime.Intrinsics.Vector512<T> operator & (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static System.Runtime.Intrinsics.Vector512<T> operator | (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static System.Runtime.Intrinsics.Vector512<T> operator / (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static System.Runtime.Intrinsics.Vector512<T> operator / (System.Runtime.Intrinsics.Vector512<T> left, T right);
  * public static bool operator == (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static System.Runtime.Intrinsics.Vector512<T> operator ^ (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static bool operator != (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static System.Runtime.Intrinsics.Vector512<T> operator << (System.Runtime.Intrinsics.Vector512<T> value, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector512<T> operator * (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static System.Runtime.Intrinsics.Vector512<T> operator * (System.Runtime.Intrinsics.Vector512<T> left, T right);
  * public static System.Runtime.Intrinsics.Vector512<T> operator * (T left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static System.Runtime.Intrinsics.Vector512<T> operator ~ (System.Runtime.Intrinsics.Vector512<T> vector);
  * public static System.Runtime.Intrinsics.Vector512<T> operator >> (System.Runtime.Intrinsics.Vector512<T> value, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector512<T> operator - (System.Runtime.Intrinsics.Vector512<T> left, System.Runtime.Intrinsics.Vector512<T> right);
  * public static System.Runtime.Intrinsics.Vector512<T> operator - (System.Runtime.Intrinsics.Vector512<T> vector);
  * public static System.Runtime.Intrinsics.Vector512<T> operator + (System.Runtime.Intrinsics.Vector512<T> value);
  * public static System.Runtime.Intrinsics.Vector512<T> op_UnsignedRightShift (System.Runtime.Intrinsics.Vector512<T> value, int shiftCount);
  * public override string ToString ();
  * public static System.Runtime.Intrinsics.Vector512<T> Zero { get; }
* System.Runtime.Intrinsics.Vector64
  * public static System.Runtime.Intrinsics.Vector64<T> CreateScalar<T> (T value);
  * public static System.Runtime.Intrinsics.Vector64<double> CreateScalarUnsafe (double value);
  * public static System.Runtime.Intrinsics.Vector64<long> CreateScalarUnsafe (long value);
  * public static System.Runtime.Intrinsics.Vector64<ulong> CreateScalarUnsafe (ulong value);
  * public static System.Runtime.Intrinsics.Vector64<T> CreateScalarUnsafe<T> (T value);
  * public static System.Runtime.Intrinsics.Vector64<T> Divide<T> (System.Runtime.Intrinsics.Vector64<T> left, T right);
  * public static System.Runtime.Intrinsics.Vector64<ushort> WidenLower (System.Runtime.Intrinsics.Vector64<byte> source);
  * public static System.Runtime.Intrinsics.Vector64<int> WidenLower (System.Runtime.Intrinsics.Vector64<short> source);
  * public static System.Runtime.Intrinsics.Vector64<long> WidenLower (System.Runtime.Intrinsics.Vector64<int> source);
  * public static System.Runtime.Intrinsics.Vector64<short> WidenLower (System.Runtime.Intrinsics.Vector64<sbyte> source);
  * public static System.Runtime.Intrinsics.Vector64<double> WidenLower (System.Runtime.Intrinsics.Vector64<float> source);
  * public static System.Runtime.Intrinsics.Vector64<uint> WidenLower (System.Runtime.Intrinsics.Vector64<ushort> source);
  * public static System.Runtime.Intrinsics.Vector64<ulong> WidenLower (System.Runtime.Intrinsics.Vector64<uint> source);
  * public static System.Runtime.Intrinsics.Vector64<ushort> WidenUpper (System.Runtime.Intrinsics.Vector64<byte> source);
  * public static System.Runtime.Intrinsics.Vector64<int> WidenUpper (System.Runtime.Intrinsics.Vector64<short> source);
  * public static System.Runtime.Intrinsics.Vector64<long> WidenUpper (System.Runtime.Intrinsics.Vector64<int> source);
  * public static System.Runtime.Intrinsics.Vector64<short> WidenUpper (System.Runtime.Intrinsics.Vector64<sbyte> source);
  * public static System.Runtime.Intrinsics.Vector64<double> WidenUpper (System.Runtime.Intrinsics.Vector64<float> source);
  * public static System.Runtime.Intrinsics.Vector64<uint> WidenUpper (System.Runtime.Intrinsics.Vector64<ushort> source);
  * public static System.Runtime.Intrinsics.Vector64<ulong> WidenUpper (System.Runtime.Intrinsics.Vector64<uint> source);
* System.Runtime.Intrinsics.Vector64<T>
  * public static System.Runtime.Intrinsics.Vector64<T> One { get; }
  * public static System.Runtime.Intrinsics.Vector64<T> operator / (System.Runtime.Intrinsics.Vector64<T> left, T right);
  * public static System.Runtime.Intrinsics.Vector64<T> operator << (System.Runtime.Intrinsics.Vector64<T> value, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector64<T> operator >> (System.Runtime.Intrinsics.Vector64<T> value, int shiftCount);
  * public static System.Runtime.Intrinsics.Vector64<T> op_UnsignedRightShift (System.Runtime.Intrinsics.Vector64<T> value, int shiftCount);
* System.Runtime.Intrinsics.Arm.AdvSimd+Arm64
  * public static System.Runtime.Intrinsics.Vector128<byte> VectorTableLookup ((System.Runtime.Intrinsics.Vector128<byte>, System.Runtime.Intrinsics.Vector128<byte>, System.Runtime.Intrinsics.Vector128<byte>, System.Runtime.Intrinsics.Vector128<byte>) table, System.Runtime.Intrinsics.Vector128<byte> byteIndexes);
  * public static System.Runtime.Intrinsics.Vector128<byte> VectorTableLookup ((System.Runtime.Intrinsics.Vector128<byte>, System.Runtime.Intrinsics.Vector128<byte>, System.Runtime.Intrinsics.Vector128<byte>) table, System.Runtime.Intrinsics.Vector128<byte> byteIndexes);
  * public static System.Runtime.Intrinsics.Vector128<byte> VectorTableLookup ((System.Runtime.Intrinsics.Vector128<byte>, System.Runtime.Intrinsics.Vector128<byte>) table, System.Runtime.Intrinsics.Vector128<byte> byteIndexes);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> VectorTableLookup ((System.Runtime.Intrinsics.Vector128<sbyte>, System.Runtime.Intrinsics.Vector128<sbyte>, System.Runtime.Intrinsics.Vector128<sbyte>, System.Runtime.Intrinsics.Vector128<sbyte>) table, System.Runtime.Intrinsics.Vector128<sbyte> byteIndexes);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> VectorTableLookup ((System.Runtime.Intrinsics.Vector128<sbyte>, System.Runtime.Intrinsics.Vector128<sbyte>, System.Runtime.Intrinsics.Vector128<sbyte>) table, System.Runtime.Intrinsics.Vector128<sbyte> byteIndexes);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> VectorTableLookup ((System.Runtime.Intrinsics.Vector128<sbyte>, System.Runtime.Intrinsics.Vector128<sbyte>) table, System.Runtime.Intrinsics.Vector128<sbyte> byteIndexes);
  * public static System.Runtime.Intrinsics.Vector128<byte> VectorTableLookupExtension (System.Runtime.Intrinsics.Vector128<byte> defaultValues, (System.Runtime.Intrinsics.Vector128<byte>, System.Runtime.Intrinsics.Vector128<byte>, System.Runtime.Intrinsics.Vector128<byte>, System.Runtime.Intrinsics.Vector128<byte>) table, System.Runtime.Intrinsics.Vector128<byte> byteIndexes);
  * public static System.Runtime.Intrinsics.Vector128<byte> VectorTableLookupExtension (System.Runtime.Intrinsics.Vector128<byte> defaultValues, (System.Runtime.Intrinsics.Vector128<byte>, System.Runtime.Intrinsics.Vector128<byte>, System.Runtime.Intrinsics.Vector128<byte>) table, System.Runtime.Intrinsics.Vector128<byte> byteIndexes);
  * public static System.Runtime.Intrinsics.Vector128<byte> VectorTableLookupExtension (System.Runtime.Intrinsics.Vector128<byte> defaultValues, (System.Runtime.Intrinsics.Vector128<byte>, System.Runtime.Intrinsics.Vector128<byte>) table, System.Runtime.Intrinsics.Vector128<byte> byteIndexes);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> VectorTableLookupExtension (System.Runtime.Intrinsics.Vector128<sbyte> defaultValues, (System.Runtime.Intrinsics.Vector128<sbyte>, System.Runtime.Intrinsics.Vector128<sbyte>, System.Runtime.Intrinsics.Vector128<sbyte>, System.Runtime.Intrinsics.Vector128<sbyte>) table, System.Runtime.Intrinsics.Vector128<sbyte> byteIndexes);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> VectorTableLookupExtension (System.Runtime.Intrinsics.Vector128<sbyte> defaultValues, (System.Runtime.Intrinsics.Vector128<sbyte>, System.Runtime.Intrinsics.Vector128<sbyte>, System.Runtime.Intrinsics.Vector128<sbyte>) table, System.Runtime.Intrinsics.Vector128<sbyte> byteIndexes);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> VectorTableLookupExtension (System.Runtime.Intrinsics.Vector128<sbyte> defaultValues, (System.Runtime.Intrinsics.Vector128<sbyte>, System.Runtime.Intrinsics.Vector128<sbyte>) table, System.Runtime.Intrinsics.Vector128<sbyte> byteIndexes);
* System.Runtime.Intrinsics.Arm.AdvSimd
  * public static System.Runtime.Intrinsics.Vector64<byte> VectorTableLookup ((System.Runtime.Intrinsics.Vector128<byte>, System.Runtime.Intrinsics.Vector128<byte>, System.Runtime.Intrinsics.Vector128<byte>, System.Runtime.Intrinsics.Vector128<byte>) table, System.Runtime.Intrinsics.Vector64<byte> byteIndexes);
  * public static System.Runtime.Intrinsics.Vector64<byte> VectorTableLookup ((System.Runtime.Intrinsics.Vector128<byte>, System.Runtime.Intrinsics.Vector128<byte>, System.Runtime.Intrinsics.Vector128<byte>) table, System.Runtime.Intrinsics.Vector64<byte> byteIndexes);
  * public static System.Runtime.Intrinsics.Vector64<byte> VectorTableLookup ((System.Runtime.Intrinsics.Vector128<byte>, System.Runtime.Intrinsics.Vector128<byte>) table, System.Runtime.Intrinsics.Vector64<byte> byteIndexes);
  * public static System.Runtime.Intrinsics.Vector64<sbyte> VectorTableLookup ((System.Runtime.Intrinsics.Vector128<sbyte>, System.Runtime.Intrinsics.Vector128<sbyte>, System.Runtime.Intrinsics.Vector128<sbyte>, System.Runtime.Intrinsics.Vector128<sbyte>) table, System.Runtime.Intrinsics.Vector64<sbyte> byteIndexes);
  * public static System.Runtime.Intrinsics.Vector64<sbyte> VectorTableLookup ((System.Runtime.Intrinsics.Vector128<sbyte>, System.Runtime.Intrinsics.Vector128<sbyte>, System.Runtime.Intrinsics.Vector128<sbyte>) table, System.Runtime.Intrinsics.Vector64<sbyte> byteIndexes);
  * public static System.Runtime.Intrinsics.Vector64<sbyte> VectorTableLookup ((System.Runtime.Intrinsics.Vector128<sbyte>, System.Runtime.Intrinsics.Vector128<sbyte>) table, System.Runtime.Intrinsics.Vector64<sbyte> byteIndexes);
  * public static System.Runtime.Intrinsics.Vector64<byte> VectorTableLookupExtension (System.Runtime.Intrinsics.Vector64<byte> defaultValues, (System.Runtime.Intrinsics.Vector128<byte>, System.Runtime.Intrinsics.Vector128<byte>, System.Runtime.Intrinsics.Vector128<byte>, System.Runtime.Intrinsics.Vector128<byte>) table, System.Runtime.Intrinsics.Vector64<byte> byteIndexes);
  * public static System.Runtime.Intrinsics.Vector64<byte> VectorTableLookupExtension (System.Runtime.Intrinsics.Vector64<byte> defaultValues, (System.Runtime.Intrinsics.Vector128<byte>, System.Runtime.Intrinsics.Vector128<byte>, System.Runtime.Intrinsics.Vector128<byte>) table, System.Runtime.Intrinsics.Vector64<byte> byteIndexes);
  * public static System.Runtime.Intrinsics.Vector64<byte> VectorTableLookupExtension (System.Runtime.Intrinsics.Vector64<byte> defaultValues, (System.Runtime.Intrinsics.Vector128<byte>, System.Runtime.Intrinsics.Vector128<byte>) table, System.Runtime.Intrinsics.Vector64<byte> byteIndexes);
  * public static System.Runtime.Intrinsics.Vector64<sbyte> VectorTableLookupExtension (System.Runtime.Intrinsics.Vector64<sbyte> defaultValues, (System.Runtime.Intrinsics.Vector128<sbyte>, System.Runtime.Intrinsics.Vector128<sbyte>, System.Runtime.Intrinsics.Vector128<sbyte>, System.Runtime.Intrinsics.Vector128<sbyte>) table, System.Runtime.Intrinsics.Vector64<sbyte> byteIndexes);
  * public static System.Runtime.Intrinsics.Vector64<sbyte> VectorTableLookupExtension (System.Runtime.Intrinsics.Vector64<sbyte> defaultValues, (System.Runtime.Intrinsics.Vector128<sbyte>, System.Runtime.Intrinsics.Vector128<sbyte>, System.Runtime.Intrinsics.Vector128<sbyte>) table, System.Runtime.Intrinsics.Vector64<sbyte> byteIndexes);
  * public static System.Runtime.Intrinsics.Vector64<sbyte> VectorTableLookupExtension (System.Runtime.Intrinsics.Vector64<sbyte> defaultValues, (System.Runtime.Intrinsics.Vector128<sbyte>, System.Runtime.Intrinsics.Vector128<sbyte>) table, System.Runtime.Intrinsics.Vector64<sbyte> byteIndexes);
* System.Runtime.Intrinsics.Wasm.PackedSimd
  * protected PackedSimd ();
  * public static System.Runtime.Intrinsics.Vector128<double> Abs (System.Runtime.Intrinsics.Vector128<double> value);
  * public static System.Runtime.Intrinsics.Vector128<short> Abs (System.Runtime.Intrinsics.Vector128<short> value);
  * public static System.Runtime.Intrinsics.Vector128<int> Abs (System.Runtime.Intrinsics.Vector128<int> value);
  * public static System.Runtime.Intrinsics.Vector128<long> Abs (System.Runtime.Intrinsics.Vector128<long> value);
  * public static System.Runtime.Intrinsics.Vector128<IntPtr> Abs (System.Runtime.Intrinsics.Vector128<IntPtr> value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> Abs (System.Runtime.Intrinsics.Vector128<sbyte> value);
  * public static System.Runtime.Intrinsics.Vector128<float> Abs (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> Add (System.Runtime.Intrinsics.Vector128<byte> left, System.Runtime.Intrinsics.Vector128<byte> right);
  * public static System.Runtime.Intrinsics.Vector128<double> Add (System.Runtime.Intrinsics.Vector128<double> left, System.Runtime.Intrinsics.Vector128<double> right);
  * public static System.Runtime.Intrinsics.Vector128<short> Add (System.Runtime.Intrinsics.Vector128<short> left, System.Runtime.Intrinsics.Vector128<short> right);
  * public static System.Runtime.Intrinsics.Vector128<int> Add (System.Runtime.Intrinsics.Vector128<int> left, System.Runtime.Intrinsics.Vector128<int> right);
  * public static System.Runtime.Intrinsics.Vector128<long> Add (System.Runtime.Intrinsics.Vector128<long> left, System.Runtime.Intrinsics.Vector128<long> right);
  * public static System.Runtime.Intrinsics.Vector128<IntPtr> Add (System.Runtime.Intrinsics.Vector128<IntPtr> left, System.Runtime.Intrinsics.Vector128<IntPtr> right);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> Add (System.Runtime.Intrinsics.Vector128<sbyte> left, System.Runtime.Intrinsics.Vector128<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector128<float> Add (System.Runtime.Intrinsics.Vector128<float> left, System.Runtime.Intrinsics.Vector128<float> right);
  * public static System.Runtime.Intrinsics.Vector128<ushort> Add (System.Runtime.Intrinsics.Vector128<ushort> left, System.Runtime.Intrinsics.Vector128<ushort> right);
  * public static System.Runtime.Intrinsics.Vector128<uint> Add (System.Runtime.Intrinsics.Vector128<uint> left, System.Runtime.Intrinsics.Vector128<uint> right);
  * public static System.Runtime.Intrinsics.Vector128<ulong> Add (System.Runtime.Intrinsics.Vector128<ulong> left, System.Runtime.Intrinsics.Vector128<ulong> right);
  * public static System.Runtime.Intrinsics.Vector128<UIntPtr> Add (System.Runtime.Intrinsics.Vector128<UIntPtr> left, System.Runtime.Intrinsics.Vector128<UIntPtr> right);
  * public static System.Runtime.Intrinsics.Vector128<ushort> AddPairwiseWidening (System.Runtime.Intrinsics.Vector128<byte> value);
  * public static System.Runtime.Intrinsics.Vector128<int> AddPairwiseWidening (System.Runtime.Intrinsics.Vector128<short> value);
  * public static System.Runtime.Intrinsics.Vector128<short> AddPairwiseWidening (System.Runtime.Intrinsics.Vector128<sbyte> value);
  * public static System.Runtime.Intrinsics.Vector128<uint> AddPairwiseWidening (System.Runtime.Intrinsics.Vector128<ushort> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> AddSaturate (System.Runtime.Intrinsics.Vector128<byte> left, System.Runtime.Intrinsics.Vector128<byte> right);
  * public static System.Runtime.Intrinsics.Vector128<short> AddSaturate (System.Runtime.Intrinsics.Vector128<short> left, System.Runtime.Intrinsics.Vector128<short> right);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> AddSaturate (System.Runtime.Intrinsics.Vector128<sbyte> left, System.Runtime.Intrinsics.Vector128<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector128<ushort> AddSaturate (System.Runtime.Intrinsics.Vector128<ushort> left, System.Runtime.Intrinsics.Vector128<ushort> right);
  * public static bool AllTrue (System.Runtime.Intrinsics.Vector128<byte> value);
  * public static bool AllTrue (System.Runtime.Intrinsics.Vector128<short> value);
  * public static bool AllTrue (System.Runtime.Intrinsics.Vector128<int> value);
  * public static bool AllTrue (System.Runtime.Intrinsics.Vector128<long> value);
  * public static bool AllTrue (System.Runtime.Intrinsics.Vector128<IntPtr> value);
  * public static bool AllTrue (System.Runtime.Intrinsics.Vector128<sbyte> value);
  * public static bool AllTrue (System.Runtime.Intrinsics.Vector128<ushort> value);
  * public static bool AllTrue (System.Runtime.Intrinsics.Vector128<uint> value);
  * public static bool AllTrue (System.Runtime.Intrinsics.Vector128<ulong> value);
  * public static bool AllTrue (System.Runtime.Intrinsics.Vector128<UIntPtr> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> And (System.Runtime.Intrinsics.Vector128<byte> left, System.Runtime.Intrinsics.Vector128<byte> right);
  * public static System.Runtime.Intrinsics.Vector128<double> And (System.Runtime.Intrinsics.Vector128<double> left, System.Runtime.Intrinsics.Vector128<double> right);
  * public static System.Runtime.Intrinsics.Vector128<short> And (System.Runtime.Intrinsics.Vector128<short> left, System.Runtime.Intrinsics.Vector128<short> right);
  * public static System.Runtime.Intrinsics.Vector128<int> And (System.Runtime.Intrinsics.Vector128<int> left, System.Runtime.Intrinsics.Vector128<int> right);
  * public static System.Runtime.Intrinsics.Vector128<long> And (System.Runtime.Intrinsics.Vector128<long> left, System.Runtime.Intrinsics.Vector128<long> right);
  * public static System.Runtime.Intrinsics.Vector128<IntPtr> And (System.Runtime.Intrinsics.Vector128<IntPtr> left, System.Runtime.Intrinsics.Vector128<IntPtr> right);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> And (System.Runtime.Intrinsics.Vector128<sbyte> left, System.Runtime.Intrinsics.Vector128<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector128<float> And (System.Runtime.Intrinsics.Vector128<float> left, System.Runtime.Intrinsics.Vector128<float> right);
  * public static System.Runtime.Intrinsics.Vector128<ushort> And (System.Runtime.Intrinsics.Vector128<ushort> left, System.Runtime.Intrinsics.Vector128<ushort> right);
  * public static System.Runtime.Intrinsics.Vector128<uint> And (System.Runtime.Intrinsics.Vector128<uint> left, System.Runtime.Intrinsics.Vector128<uint> right);
  * public static System.Runtime.Intrinsics.Vector128<ulong> And (System.Runtime.Intrinsics.Vector128<ulong> left, System.Runtime.Intrinsics.Vector128<ulong> right);
  * public static System.Runtime.Intrinsics.Vector128<UIntPtr> And (System.Runtime.Intrinsics.Vector128<UIntPtr> left, System.Runtime.Intrinsics.Vector128<UIntPtr> right);
  * public static System.Runtime.Intrinsics.Vector128<byte> AndNot (System.Runtime.Intrinsics.Vector128<byte> left, System.Runtime.Intrinsics.Vector128<byte> right);
  * public static System.Runtime.Intrinsics.Vector128<double> AndNot (System.Runtime.Intrinsics.Vector128<double> left, System.Runtime.Intrinsics.Vector128<double> right);
  * public static System.Runtime.Intrinsics.Vector128<short> AndNot (System.Runtime.Intrinsics.Vector128<short> left, System.Runtime.Intrinsics.Vector128<short> right);
  * public static System.Runtime.Intrinsics.Vector128<int> AndNot (System.Runtime.Intrinsics.Vector128<int> left, System.Runtime.Intrinsics.Vector128<int> right);
  * public static System.Runtime.Intrinsics.Vector128<long> AndNot (System.Runtime.Intrinsics.Vector128<long> left, System.Runtime.Intrinsics.Vector128<long> right);
  * public static System.Runtime.Intrinsics.Vector128<IntPtr> AndNot (System.Runtime.Intrinsics.Vector128<IntPtr> left, System.Runtime.Intrinsics.Vector128<IntPtr> right);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> AndNot (System.Runtime.Intrinsics.Vector128<sbyte> left, System.Runtime.Intrinsics.Vector128<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector128<float> AndNot (System.Runtime.Intrinsics.Vector128<float> left, System.Runtime.Intrinsics.Vector128<float> right);
  * public static System.Runtime.Intrinsics.Vector128<ushort> AndNot (System.Runtime.Intrinsics.Vector128<ushort> left, System.Runtime.Intrinsics.Vector128<ushort> right);
  * public static System.Runtime.Intrinsics.Vector128<uint> AndNot (System.Runtime.Intrinsics.Vector128<uint> left, System.Runtime.Intrinsics.Vector128<uint> right);
  * public static System.Runtime.Intrinsics.Vector128<ulong> AndNot (System.Runtime.Intrinsics.Vector128<ulong> left, System.Runtime.Intrinsics.Vector128<ulong> right);
  * public static System.Runtime.Intrinsics.Vector128<UIntPtr> AndNot (System.Runtime.Intrinsics.Vector128<UIntPtr> left, System.Runtime.Intrinsics.Vector128<UIntPtr> right);
  * public static bool AnyTrue (System.Runtime.Intrinsics.Vector128<byte> value);
  * public static bool AnyTrue (System.Runtime.Intrinsics.Vector128<double> value);
  * public static bool AnyTrue (System.Runtime.Intrinsics.Vector128<short> value);
  * public static bool AnyTrue (System.Runtime.Intrinsics.Vector128<int> value);
  * public static bool AnyTrue (System.Runtime.Intrinsics.Vector128<long> value);
  * public static bool AnyTrue (System.Runtime.Intrinsics.Vector128<IntPtr> value);
  * public static bool AnyTrue (System.Runtime.Intrinsics.Vector128<sbyte> value);
  * public static bool AnyTrue (System.Runtime.Intrinsics.Vector128<float> value);
  * public static bool AnyTrue (System.Runtime.Intrinsics.Vector128<ushort> value);
  * public static bool AnyTrue (System.Runtime.Intrinsics.Vector128<uint> value);
  * public static bool AnyTrue (System.Runtime.Intrinsics.Vector128<ulong> value);
  * public static bool AnyTrue (System.Runtime.Intrinsics.Vector128<UIntPtr> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> AverageRounded (System.Runtime.Intrinsics.Vector128<byte> left, System.Runtime.Intrinsics.Vector128<byte> right);
  * public static System.Runtime.Intrinsics.Vector128<ushort> AverageRounded (System.Runtime.Intrinsics.Vector128<ushort> left, System.Runtime.Intrinsics.Vector128<ushort> right);
  * public static int Bitmask (System.Runtime.Intrinsics.Vector128<byte> value);
  * public static int Bitmask (System.Runtime.Intrinsics.Vector128<short> value);
  * public static int Bitmask (System.Runtime.Intrinsics.Vector128<int> value);
  * public static int Bitmask (System.Runtime.Intrinsics.Vector128<long> value);
  * public static int Bitmask (System.Runtime.Intrinsics.Vector128<IntPtr> value);
  * public static int Bitmask (System.Runtime.Intrinsics.Vector128<sbyte> value);
  * public static int Bitmask (System.Runtime.Intrinsics.Vector128<ushort> value);
  * public static int Bitmask (System.Runtime.Intrinsics.Vector128<uint> value);
  * public static int Bitmask (System.Runtime.Intrinsics.Vector128<ulong> value);
  * public static int Bitmask (System.Runtime.Intrinsics.Vector128<UIntPtr> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> BitwiseSelect (System.Runtime.Intrinsics.Vector128<byte> left, System.Runtime.Intrinsics.Vector128<byte> right, System.Runtime.Intrinsics.Vector128<byte> select);
  * public static System.Runtime.Intrinsics.Vector128<double> BitwiseSelect (System.Runtime.Intrinsics.Vector128<double> left, System.Runtime.Intrinsics.Vector128<double> right, System.Runtime.Intrinsics.Vector128<double> select);
  * public static System.Runtime.Intrinsics.Vector128<short> BitwiseSelect (System.Runtime.Intrinsics.Vector128<short> left, System.Runtime.Intrinsics.Vector128<short> right, System.Runtime.Intrinsics.Vector128<short> select);
  * public static System.Runtime.Intrinsics.Vector128<int> BitwiseSelect (System.Runtime.Intrinsics.Vector128<int> left, System.Runtime.Intrinsics.Vector128<int> right, System.Runtime.Intrinsics.Vector128<int> select);
  * public static System.Runtime.Intrinsics.Vector128<long> BitwiseSelect (System.Runtime.Intrinsics.Vector128<long> left, System.Runtime.Intrinsics.Vector128<long> right, System.Runtime.Intrinsics.Vector128<long> select);
  * public static System.Runtime.Intrinsics.Vector128<IntPtr> BitwiseSelect (System.Runtime.Intrinsics.Vector128<IntPtr> left, System.Runtime.Intrinsics.Vector128<IntPtr> right, System.Runtime.Intrinsics.Vector128<IntPtr> select);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> BitwiseSelect (System.Runtime.Intrinsics.Vector128<sbyte> left, System.Runtime.Intrinsics.Vector128<sbyte> right, System.Runtime.Intrinsics.Vector128<sbyte> select);
  * public static System.Runtime.Intrinsics.Vector128<float> BitwiseSelect (System.Runtime.Intrinsics.Vector128<float> left, System.Runtime.Intrinsics.Vector128<float> right, System.Runtime.Intrinsics.Vector128<float> select);
  * public static System.Runtime.Intrinsics.Vector128<ushort> BitwiseSelect (System.Runtime.Intrinsics.Vector128<ushort> left, System.Runtime.Intrinsics.Vector128<ushort> right, System.Runtime.Intrinsics.Vector128<ushort> select);
  * public static System.Runtime.Intrinsics.Vector128<uint> BitwiseSelect (System.Runtime.Intrinsics.Vector128<uint> left, System.Runtime.Intrinsics.Vector128<uint> right, System.Runtime.Intrinsics.Vector128<uint> select);
  * public static System.Runtime.Intrinsics.Vector128<ulong> BitwiseSelect (System.Runtime.Intrinsics.Vector128<ulong> left, System.Runtime.Intrinsics.Vector128<ulong> right, System.Runtime.Intrinsics.Vector128<ulong> select);
  * public static System.Runtime.Intrinsics.Vector128<UIntPtr> BitwiseSelect (System.Runtime.Intrinsics.Vector128<UIntPtr> left, System.Runtime.Intrinsics.Vector128<UIntPtr> right, System.Runtime.Intrinsics.Vector128<UIntPtr> select);
  * public static System.Runtime.Intrinsics.Vector128<double> Ceiling (System.Runtime.Intrinsics.Vector128<double> value);
  * public static System.Runtime.Intrinsics.Vector128<float> Ceiling (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> CompareEqual (System.Runtime.Intrinsics.Vector128<byte> left, System.Runtime.Intrinsics.Vector128<byte> right);
  * public static System.Runtime.Intrinsics.Vector128<double> CompareEqual (System.Runtime.Intrinsics.Vector128<double> left, System.Runtime.Intrinsics.Vector128<double> right);
  * public static System.Runtime.Intrinsics.Vector128<short> CompareEqual (System.Runtime.Intrinsics.Vector128<short> left, System.Runtime.Intrinsics.Vector128<short> right);
  * public static System.Runtime.Intrinsics.Vector128<int> CompareEqual (System.Runtime.Intrinsics.Vector128<int> left, System.Runtime.Intrinsics.Vector128<int> right);
  * public static System.Runtime.Intrinsics.Vector128<long> CompareEqual (System.Runtime.Intrinsics.Vector128<long> left, System.Runtime.Intrinsics.Vector128<long> right);
  * public static System.Runtime.Intrinsics.Vector128<IntPtr> CompareEqual (System.Runtime.Intrinsics.Vector128<IntPtr> left, System.Runtime.Intrinsics.Vector128<IntPtr> right);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> CompareEqual (System.Runtime.Intrinsics.Vector128<sbyte> left, System.Runtime.Intrinsics.Vector128<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector128<float> CompareEqual (System.Runtime.Intrinsics.Vector128<float> left, System.Runtime.Intrinsics.Vector128<float> right);
  * public static System.Runtime.Intrinsics.Vector128<ushort> CompareEqual (System.Runtime.Intrinsics.Vector128<ushort> left, System.Runtime.Intrinsics.Vector128<ushort> right);
  * public static System.Runtime.Intrinsics.Vector128<uint> CompareEqual (System.Runtime.Intrinsics.Vector128<uint> left, System.Runtime.Intrinsics.Vector128<uint> right);
  * public static System.Runtime.Intrinsics.Vector128<ulong> CompareEqual (System.Runtime.Intrinsics.Vector128<ulong> left, System.Runtime.Intrinsics.Vector128<ulong> right);
  * public static System.Runtime.Intrinsics.Vector128<UIntPtr> CompareEqual (System.Runtime.Intrinsics.Vector128<UIntPtr> left, System.Runtime.Intrinsics.Vector128<UIntPtr> right);
  * public static System.Runtime.Intrinsics.Vector128<byte> CompareGreaterThan (System.Runtime.Intrinsics.Vector128<byte> left, System.Runtime.Intrinsics.Vector128<byte> right);
  * public static System.Runtime.Intrinsics.Vector128<double> CompareGreaterThan (System.Runtime.Intrinsics.Vector128<double> left, System.Runtime.Intrinsics.Vector128<double> right);
  * public static System.Runtime.Intrinsics.Vector128<short> CompareGreaterThan (System.Runtime.Intrinsics.Vector128<short> left, System.Runtime.Intrinsics.Vector128<short> right);
  * public static System.Runtime.Intrinsics.Vector128<int> CompareGreaterThan (System.Runtime.Intrinsics.Vector128<int> left, System.Runtime.Intrinsics.Vector128<int> right);
  * public static System.Runtime.Intrinsics.Vector128<long> CompareGreaterThan (System.Runtime.Intrinsics.Vector128<long> left, System.Runtime.Intrinsics.Vector128<long> right);
  * public static System.Runtime.Intrinsics.Vector128<IntPtr> CompareGreaterThan (System.Runtime.Intrinsics.Vector128<IntPtr> left, System.Runtime.Intrinsics.Vector128<IntPtr> right);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> CompareGreaterThan (System.Runtime.Intrinsics.Vector128<sbyte> left, System.Runtime.Intrinsics.Vector128<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector128<float> CompareGreaterThan (System.Runtime.Intrinsics.Vector128<float> left, System.Runtime.Intrinsics.Vector128<float> right);
  * public static System.Runtime.Intrinsics.Vector128<ushort> CompareGreaterThan (System.Runtime.Intrinsics.Vector128<ushort> left, System.Runtime.Intrinsics.Vector128<ushort> right);
  * public static System.Runtime.Intrinsics.Vector128<uint> CompareGreaterThan (System.Runtime.Intrinsics.Vector128<uint> left, System.Runtime.Intrinsics.Vector128<uint> right);
  * public static System.Runtime.Intrinsics.Vector128<ulong> CompareGreaterThan (System.Runtime.Intrinsics.Vector128<ulong> left, System.Runtime.Intrinsics.Vector128<ulong> right);
  * public static System.Runtime.Intrinsics.Vector128<UIntPtr> CompareGreaterThan (System.Runtime.Intrinsics.Vector128<UIntPtr> left, System.Runtime.Intrinsics.Vector128<UIntPtr> right);
  * public static System.Runtime.Intrinsics.Vector128<byte> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector128<byte> left, System.Runtime.Intrinsics.Vector128<byte> right);
  * public static System.Runtime.Intrinsics.Vector128<double> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector128<double> left, System.Runtime.Intrinsics.Vector128<double> right);
  * public static System.Runtime.Intrinsics.Vector128<short> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector128<short> left, System.Runtime.Intrinsics.Vector128<short> right);
  * public static System.Runtime.Intrinsics.Vector128<int> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector128<int> left, System.Runtime.Intrinsics.Vector128<int> right);
  * public static System.Runtime.Intrinsics.Vector128<long> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector128<long> left, System.Runtime.Intrinsics.Vector128<long> right);
  * public static System.Runtime.Intrinsics.Vector128<IntPtr> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector128<IntPtr> left, System.Runtime.Intrinsics.Vector128<IntPtr> right);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector128<sbyte> left, System.Runtime.Intrinsics.Vector128<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector128<float> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector128<float> left, System.Runtime.Intrinsics.Vector128<float> right);
  * public static System.Runtime.Intrinsics.Vector128<ushort> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector128<ushort> left, System.Runtime.Intrinsics.Vector128<ushort> right);
  * public static System.Runtime.Intrinsics.Vector128<uint> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector128<uint> left, System.Runtime.Intrinsics.Vector128<uint> right);
  * public static System.Runtime.Intrinsics.Vector128<ulong> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector128<ulong> left, System.Runtime.Intrinsics.Vector128<ulong> right);
  * public static System.Runtime.Intrinsics.Vector128<UIntPtr> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector128<UIntPtr> left, System.Runtime.Intrinsics.Vector128<UIntPtr> right);
  * public static System.Runtime.Intrinsics.Vector128<byte> CompareLessThan (System.Runtime.Intrinsics.Vector128<byte> left, System.Runtime.Intrinsics.Vector128<byte> right);
  * public static System.Runtime.Intrinsics.Vector128<double> CompareLessThan (System.Runtime.Intrinsics.Vector128<double> left, System.Runtime.Intrinsics.Vector128<double> right);
  * public static System.Runtime.Intrinsics.Vector128<short> CompareLessThan (System.Runtime.Intrinsics.Vector128<short> left, System.Runtime.Intrinsics.Vector128<short> right);
  * public static System.Runtime.Intrinsics.Vector128<int> CompareLessThan (System.Runtime.Intrinsics.Vector128<int> left, System.Runtime.Intrinsics.Vector128<int> right);
  * public static System.Runtime.Intrinsics.Vector128<long> CompareLessThan (System.Runtime.Intrinsics.Vector128<long> left, System.Runtime.Intrinsics.Vector128<long> right);
  * public static System.Runtime.Intrinsics.Vector128<IntPtr> CompareLessThan (System.Runtime.Intrinsics.Vector128<IntPtr> left, System.Runtime.Intrinsics.Vector128<IntPtr> right);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> CompareLessThan (System.Runtime.Intrinsics.Vector128<sbyte> left, System.Runtime.Intrinsics.Vector128<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector128<float> CompareLessThan (System.Runtime.Intrinsics.Vector128<float> left, System.Runtime.Intrinsics.Vector128<float> right);
  * public static System.Runtime.Intrinsics.Vector128<ushort> CompareLessThan (System.Runtime.Intrinsics.Vector128<ushort> left, System.Runtime.Intrinsics.Vector128<ushort> right);
  * public static System.Runtime.Intrinsics.Vector128<uint> CompareLessThan (System.Runtime.Intrinsics.Vector128<uint> left, System.Runtime.Intrinsics.Vector128<uint> right);
  * public static System.Runtime.Intrinsics.Vector128<ulong> CompareLessThan (System.Runtime.Intrinsics.Vector128<ulong> left, System.Runtime.Intrinsics.Vector128<ulong> right);
  * public static System.Runtime.Intrinsics.Vector128<UIntPtr> CompareLessThan (System.Runtime.Intrinsics.Vector128<UIntPtr> left, System.Runtime.Intrinsics.Vector128<UIntPtr> right);
  * public static System.Runtime.Intrinsics.Vector128<byte> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector128<byte> left, System.Runtime.Intrinsics.Vector128<byte> right);
  * public static System.Runtime.Intrinsics.Vector128<double> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector128<double> left, System.Runtime.Intrinsics.Vector128<double> right);
  * public static System.Runtime.Intrinsics.Vector128<short> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector128<short> left, System.Runtime.Intrinsics.Vector128<short> right);
  * public static System.Runtime.Intrinsics.Vector128<int> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector128<int> left, System.Runtime.Intrinsics.Vector128<int> right);
  * public static System.Runtime.Intrinsics.Vector128<long> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector128<long> left, System.Runtime.Intrinsics.Vector128<long> right);
  * public static System.Runtime.Intrinsics.Vector128<IntPtr> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector128<IntPtr> left, System.Runtime.Intrinsics.Vector128<IntPtr> right);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector128<sbyte> left, System.Runtime.Intrinsics.Vector128<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector128<float> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector128<float> left, System.Runtime.Intrinsics.Vector128<float> right);
  * public static System.Runtime.Intrinsics.Vector128<ushort> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector128<ushort> left, System.Runtime.Intrinsics.Vector128<ushort> right);
  * public static System.Runtime.Intrinsics.Vector128<uint> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector128<uint> left, System.Runtime.Intrinsics.Vector128<uint> right);
  * public static System.Runtime.Intrinsics.Vector128<ulong> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector128<ulong> left, System.Runtime.Intrinsics.Vector128<ulong> right);
  * public static System.Runtime.Intrinsics.Vector128<UIntPtr> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector128<UIntPtr> left, System.Runtime.Intrinsics.Vector128<UIntPtr> right);
  * public static System.Runtime.Intrinsics.Vector128<byte> CompareNotEqual (System.Runtime.Intrinsics.Vector128<byte> left, System.Runtime.Intrinsics.Vector128<byte> right);
  * public static System.Runtime.Intrinsics.Vector128<double> CompareNotEqual (System.Runtime.Intrinsics.Vector128<double> left, System.Runtime.Intrinsics.Vector128<double> right);
  * public static System.Runtime.Intrinsics.Vector128<short> CompareNotEqual (System.Runtime.Intrinsics.Vector128<short> left, System.Runtime.Intrinsics.Vector128<short> right);
  * public static System.Runtime.Intrinsics.Vector128<int> CompareNotEqual (System.Runtime.Intrinsics.Vector128<int> left, System.Runtime.Intrinsics.Vector128<int> right);
  * public static System.Runtime.Intrinsics.Vector128<long> CompareNotEqual (System.Runtime.Intrinsics.Vector128<long> left, System.Runtime.Intrinsics.Vector128<long> right);
  * public static System.Runtime.Intrinsics.Vector128<IntPtr> CompareNotEqual (System.Runtime.Intrinsics.Vector128<IntPtr> left, System.Runtime.Intrinsics.Vector128<IntPtr> right);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> CompareNotEqual (System.Runtime.Intrinsics.Vector128<sbyte> left, System.Runtime.Intrinsics.Vector128<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector128<float> CompareNotEqual (System.Runtime.Intrinsics.Vector128<float> left, System.Runtime.Intrinsics.Vector128<float> right);
  * public static System.Runtime.Intrinsics.Vector128<ushort> CompareNotEqual (System.Runtime.Intrinsics.Vector128<ushort> left, System.Runtime.Intrinsics.Vector128<ushort> right);
  * public static System.Runtime.Intrinsics.Vector128<uint> CompareNotEqual (System.Runtime.Intrinsics.Vector128<uint> left, System.Runtime.Intrinsics.Vector128<uint> right);
  * public static System.Runtime.Intrinsics.Vector128<ulong> CompareNotEqual (System.Runtime.Intrinsics.Vector128<ulong> left, System.Runtime.Intrinsics.Vector128<ulong> right);
  * public static System.Runtime.Intrinsics.Vector128<UIntPtr> CompareNotEqual (System.Runtime.Intrinsics.Vector128<UIntPtr> left, System.Runtime.Intrinsics.Vector128<UIntPtr> right);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ConvertNarrowingSaturateSigned (System.Runtime.Intrinsics.Vector128<short> lower, System.Runtime.Intrinsics.Vector128<short> upper);
  * public static System.Runtime.Intrinsics.Vector128<short> ConvertNarrowingSaturateSigned (System.Runtime.Intrinsics.Vector128<int> lower, System.Runtime.Intrinsics.Vector128<int> upper);
  * public static System.Runtime.Intrinsics.Vector128<byte> ConvertNarrowingSaturateUnsigned (System.Runtime.Intrinsics.Vector128<short> lower, System.Runtime.Intrinsics.Vector128<short> upper);
  * public static System.Runtime.Intrinsics.Vector128<ushort> ConvertNarrowingSaturateUnsigned (System.Runtime.Intrinsics.Vector128<int> lower, System.Runtime.Intrinsics.Vector128<int> upper);
  * public static System.Runtime.Intrinsics.Vector128<double> ConvertToDoubleLower (System.Runtime.Intrinsics.Vector128<int> value);
  * public static System.Runtime.Intrinsics.Vector128<double> ConvertToDoubleLower (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector128<double> ConvertToDoubleLower (System.Runtime.Intrinsics.Vector128<uint> value);
  * public static System.Runtime.Intrinsics.Vector128<int> ConvertToInt32Saturate (System.Runtime.Intrinsics.Vector128<double> value);
  * public static System.Runtime.Intrinsics.Vector128<int> ConvertToInt32Saturate (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector128<float> ConvertToSingle (System.Runtime.Intrinsics.Vector128<double> value);
  * public static System.Runtime.Intrinsics.Vector128<float> ConvertToSingle (System.Runtime.Intrinsics.Vector128<int> value);
  * public static System.Runtime.Intrinsics.Vector128<float> ConvertToSingle (System.Runtime.Intrinsics.Vector128<uint> value);
  * public static System.Runtime.Intrinsics.Vector128<uint> ConvertToUInt32Saturate (System.Runtime.Intrinsics.Vector128<double> value);
  * public static System.Runtime.Intrinsics.Vector128<uint> ConvertToUInt32Saturate (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector128<double> Divide (System.Runtime.Intrinsics.Vector128<double> left, System.Runtime.Intrinsics.Vector128<double> right);
  * public static System.Runtime.Intrinsics.Vector128<float> Divide (System.Runtime.Intrinsics.Vector128<float> left, System.Runtime.Intrinsics.Vector128<float> right);
  * public static System.Runtime.Intrinsics.Vector128<int> Dot (System.Runtime.Intrinsics.Vector128<short> left, System.Runtime.Intrinsics.Vector128<short> right);
  * public static uint ExtractScalar (System.Runtime.Intrinsics.Vector128<byte> value, byte index);
  * public static double ExtractScalar (System.Runtime.Intrinsics.Vector128<double> value, byte index);
  * public static int ExtractScalar (System.Runtime.Intrinsics.Vector128<short> value, byte index);
  * public static int ExtractScalar (System.Runtime.Intrinsics.Vector128<int> value, byte index);
  * public static long ExtractScalar (System.Runtime.Intrinsics.Vector128<long> value, byte index);
  * public static IntPtr ExtractScalar (System.Runtime.Intrinsics.Vector128<IntPtr> value, byte index);
  * public static int ExtractScalar (System.Runtime.Intrinsics.Vector128<sbyte> value, byte index);
  * public static float ExtractScalar (System.Runtime.Intrinsics.Vector128<float> value, byte index);
  * public static uint ExtractScalar (System.Runtime.Intrinsics.Vector128<ushort> value, byte index);
  * public static uint ExtractScalar (System.Runtime.Intrinsics.Vector128<uint> value, byte index);
  * public static ulong ExtractScalar (System.Runtime.Intrinsics.Vector128<ulong> value, byte index);
  * public static UIntPtr ExtractScalar (System.Runtime.Intrinsics.Vector128<UIntPtr> value, byte index);
  * public static System.Runtime.Intrinsics.Vector128<double> Floor (System.Runtime.Intrinsics.Vector128<double> value);
  * public static System.Runtime.Intrinsics.Vector128<float> Floor (System.Runtime.Intrinsics.Vector128<float> value);
  * public static bool IsSupported { get; }
  * public static System.Runtime.Intrinsics.Vector128<byte> LoadScalarAndInsert (byte* address, System.Runtime.Intrinsics.Vector128<byte> vector, byte index);
  * public static System.Runtime.Intrinsics.Vector128<double> LoadScalarAndInsert (double* address, System.Runtime.Intrinsics.Vector128<double> vector, byte index);
  * public static System.Runtime.Intrinsics.Vector128<short> LoadScalarAndInsert (short* address, System.Runtime.Intrinsics.Vector128<short> vector, byte index);
  * public static System.Runtime.Intrinsics.Vector128<int> LoadScalarAndInsert (int* address, System.Runtime.Intrinsics.Vector128<int> vector, byte index);
  * public static System.Runtime.Intrinsics.Vector128<long> LoadScalarAndInsert (long* address, System.Runtime.Intrinsics.Vector128<long> vector, byte index);
  * public static System.Runtime.Intrinsics.Vector128<IntPtr> LoadScalarAndInsert (IntPtr* address, System.Runtime.Intrinsics.Vector128<IntPtr> vector, byte index);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> LoadScalarAndInsert (sbyte* address, System.Runtime.Intrinsics.Vector128<sbyte> vector, byte index);
  * public static System.Runtime.Intrinsics.Vector128<float> LoadScalarAndInsert (float* address, System.Runtime.Intrinsics.Vector128<float> vector, byte index);
  * public static System.Runtime.Intrinsics.Vector128<ushort> LoadScalarAndInsert (ushort* address, System.Runtime.Intrinsics.Vector128<ushort> vector, byte index);
  * public static System.Runtime.Intrinsics.Vector128<uint> LoadScalarAndInsert (uint* address, System.Runtime.Intrinsics.Vector128<uint> vector, byte index);
  * public static System.Runtime.Intrinsics.Vector128<ulong> LoadScalarAndInsert (ulong* address, System.Runtime.Intrinsics.Vector128<ulong> vector, byte index);
  * public static System.Runtime.Intrinsics.Vector128<UIntPtr> LoadScalarAndInsert (UIntPtr* address, System.Runtime.Intrinsics.Vector128<UIntPtr> vector, byte index);
  * public static System.Runtime.Intrinsics.Vector128<byte> LoadScalarAndSplatVector128 (byte* address);
  * public static System.Runtime.Intrinsics.Vector128<double> LoadScalarAndSplatVector128 (double* address);
  * public static System.Runtime.Intrinsics.Vector128<short> LoadScalarAndSplatVector128 (short* address);
  * public static System.Runtime.Intrinsics.Vector128<int> LoadScalarAndSplatVector128 (int* address);
  * public static System.Runtime.Intrinsics.Vector128<long> LoadScalarAndSplatVector128 (long* address);
  * public static System.Runtime.Intrinsics.Vector128<IntPtr> LoadScalarAndSplatVector128 (IntPtr* address);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> LoadScalarAndSplatVector128 (sbyte* address);
  * public static System.Runtime.Intrinsics.Vector128<float> LoadScalarAndSplatVector128 (float* address);
  * public static System.Runtime.Intrinsics.Vector128<ushort> LoadScalarAndSplatVector128 (ushort* address);
  * public static System.Runtime.Intrinsics.Vector128<uint> LoadScalarAndSplatVector128 (uint* address);
  * public static System.Runtime.Intrinsics.Vector128<ulong> LoadScalarAndSplatVector128 (ulong* address);
  * public static System.Runtime.Intrinsics.Vector128<UIntPtr> LoadScalarAndSplatVector128 (UIntPtr* address);
  * public static System.Runtime.Intrinsics.Vector128<double> LoadScalarVector128 (double* address);
  * public static System.Runtime.Intrinsics.Vector128<int> LoadScalarVector128 (int* address);
  * public static System.Runtime.Intrinsics.Vector128<long> LoadScalarVector128 (long* address);
  * public static System.Runtime.Intrinsics.Vector128<IntPtr> LoadScalarVector128 (IntPtr* address);
  * public static System.Runtime.Intrinsics.Vector128<float> LoadScalarVector128 (float* address);
  * public static System.Runtime.Intrinsics.Vector128<uint> LoadScalarVector128 (uint* address);
  * public static System.Runtime.Intrinsics.Vector128<ulong> LoadScalarVector128 (ulong* address);
  * public static System.Runtime.Intrinsics.Vector128<UIntPtr> LoadScalarVector128 (UIntPtr* address);
  * public static System.Runtime.Intrinsics.Vector128<byte> LoadVector128 (byte* address);
  * public static System.Runtime.Intrinsics.Vector128<double> LoadVector128 (double* address);
  * public static System.Runtime.Intrinsics.Vector128<short> LoadVector128 (short* address);
  * public static System.Runtime.Intrinsics.Vector128<int> LoadVector128 (int* address);
  * public static System.Runtime.Intrinsics.Vector128<long> LoadVector128 (long* address);
  * public static System.Runtime.Intrinsics.Vector128<IntPtr> LoadVector128 (IntPtr* address);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> LoadVector128 (sbyte* address);
  * public static System.Runtime.Intrinsics.Vector128<float> LoadVector128 (float* address);
  * public static System.Runtime.Intrinsics.Vector128<ushort> LoadVector128 (ushort* address);
  * public static System.Runtime.Intrinsics.Vector128<uint> LoadVector128 (uint* address);
  * public static System.Runtime.Intrinsics.Vector128<ulong> LoadVector128 (ulong* address);
  * public static System.Runtime.Intrinsics.Vector128<UIntPtr> LoadVector128 (UIntPtr* address);
  * public static System.Runtime.Intrinsics.Vector128<ushort> LoadWideningVector128 (byte* address);
  * public static System.Runtime.Intrinsics.Vector128<int> LoadWideningVector128 (short* address);
  * public static System.Runtime.Intrinsics.Vector128<long> LoadWideningVector128 (int* address);
  * public static System.Runtime.Intrinsics.Vector128<short> LoadWideningVector128 (sbyte* address);
  * public static System.Runtime.Intrinsics.Vector128<uint> LoadWideningVector128 (ushort* address);
  * public static System.Runtime.Intrinsics.Vector128<ulong> LoadWideningVector128 (uint* address);
  * public static System.Runtime.Intrinsics.Vector128<byte> Max (System.Runtime.Intrinsics.Vector128<byte> left, System.Runtime.Intrinsics.Vector128<byte> right);
  * public static System.Runtime.Intrinsics.Vector128<double> Max (System.Runtime.Intrinsics.Vector128<double> left, System.Runtime.Intrinsics.Vector128<double> right);
  * public static System.Runtime.Intrinsics.Vector128<short> Max (System.Runtime.Intrinsics.Vector128<short> left, System.Runtime.Intrinsics.Vector128<short> right);
  * public static System.Runtime.Intrinsics.Vector128<int> Max (System.Runtime.Intrinsics.Vector128<int> left, System.Runtime.Intrinsics.Vector128<int> right);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> Max (System.Runtime.Intrinsics.Vector128<sbyte> left, System.Runtime.Intrinsics.Vector128<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector128<float> Max (System.Runtime.Intrinsics.Vector128<float> left, System.Runtime.Intrinsics.Vector128<float> right);
  * public static System.Runtime.Intrinsics.Vector128<ushort> Max (System.Runtime.Intrinsics.Vector128<ushort> left, System.Runtime.Intrinsics.Vector128<ushort> right);
  * public static System.Runtime.Intrinsics.Vector128<uint> Max (System.Runtime.Intrinsics.Vector128<uint> left, System.Runtime.Intrinsics.Vector128<uint> right);
  * public static System.Runtime.Intrinsics.Vector128<byte> Min (System.Runtime.Intrinsics.Vector128<byte> left, System.Runtime.Intrinsics.Vector128<byte> right);
  * public static System.Runtime.Intrinsics.Vector128<double> Min (System.Runtime.Intrinsics.Vector128<double> left, System.Runtime.Intrinsics.Vector128<double> right);
  * public static System.Runtime.Intrinsics.Vector128<short> Min (System.Runtime.Intrinsics.Vector128<short> left, System.Runtime.Intrinsics.Vector128<short> right);
  * public static System.Runtime.Intrinsics.Vector128<int> Min (System.Runtime.Intrinsics.Vector128<int> left, System.Runtime.Intrinsics.Vector128<int> right);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> Min (System.Runtime.Intrinsics.Vector128<sbyte> left, System.Runtime.Intrinsics.Vector128<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector128<float> Min (System.Runtime.Intrinsics.Vector128<float> left, System.Runtime.Intrinsics.Vector128<float> right);
  * public static System.Runtime.Intrinsics.Vector128<ushort> Min (System.Runtime.Intrinsics.Vector128<ushort> left, System.Runtime.Intrinsics.Vector128<ushort> right);
  * public static System.Runtime.Intrinsics.Vector128<uint> Min (System.Runtime.Intrinsics.Vector128<uint> left, System.Runtime.Intrinsics.Vector128<uint> right);
  * public static System.Runtime.Intrinsics.Vector128<double> Multiply (System.Runtime.Intrinsics.Vector128<double> left, System.Runtime.Intrinsics.Vector128<double> right);
  * public static System.Runtime.Intrinsics.Vector128<short> Multiply (System.Runtime.Intrinsics.Vector128<short> left, System.Runtime.Intrinsics.Vector128<short> right);
  * public static System.Runtime.Intrinsics.Vector128<int> Multiply (System.Runtime.Intrinsics.Vector128<int> left, System.Runtime.Intrinsics.Vector128<int> right);
  * public static System.Runtime.Intrinsics.Vector128<long> Multiply (System.Runtime.Intrinsics.Vector128<long> left, System.Runtime.Intrinsics.Vector128<long> right);
  * public static System.Runtime.Intrinsics.Vector128<IntPtr> Multiply (System.Runtime.Intrinsics.Vector128<IntPtr> left, System.Runtime.Intrinsics.Vector128<IntPtr> right);
  * public static System.Runtime.Intrinsics.Vector128<float> Multiply (System.Runtime.Intrinsics.Vector128<float> left, System.Runtime.Intrinsics.Vector128<float> right);
  * public static System.Runtime.Intrinsics.Vector128<ushort> Multiply (System.Runtime.Intrinsics.Vector128<ushort> left, System.Runtime.Intrinsics.Vector128<ushort> right);
  * public static System.Runtime.Intrinsics.Vector128<uint> Multiply (System.Runtime.Intrinsics.Vector128<uint> left, System.Runtime.Intrinsics.Vector128<uint> right);
  * public static System.Runtime.Intrinsics.Vector128<ulong> Multiply (System.Runtime.Intrinsics.Vector128<ulong> left, System.Runtime.Intrinsics.Vector128<ulong> right);
  * public static System.Runtime.Intrinsics.Vector128<UIntPtr> Multiply (System.Runtime.Intrinsics.Vector128<UIntPtr> left, System.Runtime.Intrinsics.Vector128<UIntPtr> right);
  * public static System.Runtime.Intrinsics.Vector128<short> MultiplyRoundedSaturateQ15 (System.Runtime.Intrinsics.Vector128<short> left, System.Runtime.Intrinsics.Vector128<short> right);
  * public static System.Runtime.Intrinsics.Vector128<ushort> MultiplyWideningLower (System.Runtime.Intrinsics.Vector128<byte> left, System.Runtime.Intrinsics.Vector128<byte> right);
  * public static System.Runtime.Intrinsics.Vector128<int> MultiplyWideningLower (System.Runtime.Intrinsics.Vector128<short> left, System.Runtime.Intrinsics.Vector128<short> right);
  * public static System.Runtime.Intrinsics.Vector128<long> MultiplyWideningLower (System.Runtime.Intrinsics.Vector128<int> left, System.Runtime.Intrinsics.Vector128<int> right);
  * public static System.Runtime.Intrinsics.Vector128<short> MultiplyWideningLower (System.Runtime.Intrinsics.Vector128<sbyte> left, System.Runtime.Intrinsics.Vector128<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector128<uint> MultiplyWideningLower (System.Runtime.Intrinsics.Vector128<ushort> left, System.Runtime.Intrinsics.Vector128<ushort> right);
  * public static System.Runtime.Intrinsics.Vector128<ulong> MultiplyWideningLower (System.Runtime.Intrinsics.Vector128<uint> left, System.Runtime.Intrinsics.Vector128<uint> right);
  * public static System.Runtime.Intrinsics.Vector128<ushort> MultiplyWideningUpper (System.Runtime.Intrinsics.Vector128<byte> left, System.Runtime.Intrinsics.Vector128<byte> right);
  * public static System.Runtime.Intrinsics.Vector128<int> MultiplyWideningUpper (System.Runtime.Intrinsics.Vector128<short> left, System.Runtime.Intrinsics.Vector128<short> right);
  * public static System.Runtime.Intrinsics.Vector128<long> MultiplyWideningUpper (System.Runtime.Intrinsics.Vector128<int> left, System.Runtime.Intrinsics.Vector128<int> right);
  * public static System.Runtime.Intrinsics.Vector128<short> MultiplyWideningUpper (System.Runtime.Intrinsics.Vector128<sbyte> left, System.Runtime.Intrinsics.Vector128<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector128<uint> MultiplyWideningUpper (System.Runtime.Intrinsics.Vector128<ushort> left, System.Runtime.Intrinsics.Vector128<ushort> right);
  * public static System.Runtime.Intrinsics.Vector128<ulong> MultiplyWideningUpper (System.Runtime.Intrinsics.Vector128<uint> left, System.Runtime.Intrinsics.Vector128<uint> right);
  * public static System.Runtime.Intrinsics.Vector128<byte> Negate (System.Runtime.Intrinsics.Vector128<byte> value);
  * public static System.Runtime.Intrinsics.Vector128<double> Negate (System.Runtime.Intrinsics.Vector128<double> value);
  * public static System.Runtime.Intrinsics.Vector128<short> Negate (System.Runtime.Intrinsics.Vector128<short> value);
  * public static System.Runtime.Intrinsics.Vector128<int> Negate (System.Runtime.Intrinsics.Vector128<int> value);
  * public static System.Runtime.Intrinsics.Vector128<long> Negate (System.Runtime.Intrinsics.Vector128<long> value);
  * public static System.Runtime.Intrinsics.Vector128<IntPtr> Negate (System.Runtime.Intrinsics.Vector128<IntPtr> value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> Negate (System.Runtime.Intrinsics.Vector128<sbyte> value);
  * public static System.Runtime.Intrinsics.Vector128<float> Negate (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector128<ushort> Negate (System.Runtime.Intrinsics.Vector128<ushort> value);
  * public static System.Runtime.Intrinsics.Vector128<uint> Negate (System.Runtime.Intrinsics.Vector128<uint> value);
  * public static System.Runtime.Intrinsics.Vector128<ulong> Negate (System.Runtime.Intrinsics.Vector128<ulong> value);
  * public static System.Runtime.Intrinsics.Vector128<UIntPtr> Negate (System.Runtime.Intrinsics.Vector128<UIntPtr> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> Not (System.Runtime.Intrinsics.Vector128<byte> value);
  * public static System.Runtime.Intrinsics.Vector128<double> Not (System.Runtime.Intrinsics.Vector128<double> value);
  * public static System.Runtime.Intrinsics.Vector128<short> Not (System.Runtime.Intrinsics.Vector128<short> value);
  * public static System.Runtime.Intrinsics.Vector128<int> Not (System.Runtime.Intrinsics.Vector128<int> value);
  * public static System.Runtime.Intrinsics.Vector128<long> Not (System.Runtime.Intrinsics.Vector128<long> value);
  * public static System.Runtime.Intrinsics.Vector128<IntPtr> Not (System.Runtime.Intrinsics.Vector128<IntPtr> value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> Not (System.Runtime.Intrinsics.Vector128<sbyte> value);
  * public static System.Runtime.Intrinsics.Vector128<float> Not (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector128<ushort> Not (System.Runtime.Intrinsics.Vector128<ushort> value);
  * public static System.Runtime.Intrinsics.Vector128<uint> Not (System.Runtime.Intrinsics.Vector128<uint> value);
  * public static System.Runtime.Intrinsics.Vector128<ulong> Not (System.Runtime.Intrinsics.Vector128<ulong> value);
  * public static System.Runtime.Intrinsics.Vector128<UIntPtr> Not (System.Runtime.Intrinsics.Vector128<UIntPtr> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> Or (System.Runtime.Intrinsics.Vector128<byte> left, System.Runtime.Intrinsics.Vector128<byte> right);
  * public static System.Runtime.Intrinsics.Vector128<double> Or (System.Runtime.Intrinsics.Vector128<double> left, System.Runtime.Intrinsics.Vector128<double> right);
  * public static System.Runtime.Intrinsics.Vector128<short> Or (System.Runtime.Intrinsics.Vector128<short> left, System.Runtime.Intrinsics.Vector128<short> right);
  * public static System.Runtime.Intrinsics.Vector128<int> Or (System.Runtime.Intrinsics.Vector128<int> left, System.Runtime.Intrinsics.Vector128<int> right);
  * public static System.Runtime.Intrinsics.Vector128<long> Or (System.Runtime.Intrinsics.Vector128<long> left, System.Runtime.Intrinsics.Vector128<long> right);
  * public static System.Runtime.Intrinsics.Vector128<IntPtr> Or (System.Runtime.Intrinsics.Vector128<IntPtr> left, System.Runtime.Intrinsics.Vector128<IntPtr> right);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> Or (System.Runtime.Intrinsics.Vector128<sbyte> left, System.Runtime.Intrinsics.Vector128<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector128<float> Or (System.Runtime.Intrinsics.Vector128<float> left, System.Runtime.Intrinsics.Vector128<float> right);
  * public static System.Runtime.Intrinsics.Vector128<ushort> Or (System.Runtime.Intrinsics.Vector128<ushort> left, System.Runtime.Intrinsics.Vector128<ushort> right);
  * public static System.Runtime.Intrinsics.Vector128<uint> Or (System.Runtime.Intrinsics.Vector128<uint> left, System.Runtime.Intrinsics.Vector128<uint> right);
  * public static System.Runtime.Intrinsics.Vector128<ulong> Or (System.Runtime.Intrinsics.Vector128<ulong> left, System.Runtime.Intrinsics.Vector128<ulong> right);
  * public static System.Runtime.Intrinsics.Vector128<UIntPtr> Or (System.Runtime.Intrinsics.Vector128<UIntPtr> left, System.Runtime.Intrinsics.Vector128<UIntPtr> right);
  * public static System.Runtime.Intrinsics.Vector128<byte> PopCount (System.Runtime.Intrinsics.Vector128<byte> value);
  * public static System.Runtime.Intrinsics.Vector128<double> PseudoMax (System.Runtime.Intrinsics.Vector128<double> left, System.Runtime.Intrinsics.Vector128<double> right);
  * public static System.Runtime.Intrinsics.Vector128<float> PseudoMax (System.Runtime.Intrinsics.Vector128<float> left, System.Runtime.Intrinsics.Vector128<float> right);
  * public static System.Runtime.Intrinsics.Vector128<double> PseudoMin (System.Runtime.Intrinsics.Vector128<double> left, System.Runtime.Intrinsics.Vector128<double> right);
  * public static System.Runtime.Intrinsics.Vector128<float> PseudoMin (System.Runtime.Intrinsics.Vector128<float> left, System.Runtime.Intrinsics.Vector128<float> right);
  * public static System.Runtime.Intrinsics.Vector128<byte> ReplaceScalar (System.Runtime.Intrinsics.Vector128<byte> vector, byte imm, uint value);
  * public static System.Runtime.Intrinsics.Vector128<double> ReplaceScalar (System.Runtime.Intrinsics.Vector128<double> vector, byte imm, double value);
  * public static System.Runtime.Intrinsics.Vector128<short> ReplaceScalar (System.Runtime.Intrinsics.Vector128<short> vector, byte imm, int value);
  * public static System.Runtime.Intrinsics.Vector128<int> ReplaceScalar (System.Runtime.Intrinsics.Vector128<int> vector, byte imm, int value);
  * public static System.Runtime.Intrinsics.Vector128<long> ReplaceScalar (System.Runtime.Intrinsics.Vector128<long> vector, byte imm, long value);
  * public static System.Runtime.Intrinsics.Vector128<IntPtr> ReplaceScalar (System.Runtime.Intrinsics.Vector128<IntPtr> vector, byte imm, IntPtr value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ReplaceScalar (System.Runtime.Intrinsics.Vector128<sbyte> vector, byte imm, int value);
  * public static System.Runtime.Intrinsics.Vector128<float> ReplaceScalar (System.Runtime.Intrinsics.Vector128<float> vector, byte imm, float value);
  * public static System.Runtime.Intrinsics.Vector128<ushort> ReplaceScalar (System.Runtime.Intrinsics.Vector128<ushort> vector, byte imm, uint value);
  * public static System.Runtime.Intrinsics.Vector128<int> ReplaceScalar (System.Runtime.Intrinsics.Vector128<uint> vector, byte imm, uint value);
  * public static System.Runtime.Intrinsics.Vector128<ulong> ReplaceScalar (System.Runtime.Intrinsics.Vector128<ulong> vector, byte imm, ulong value);
  * public static System.Runtime.Intrinsics.Vector128<UIntPtr> ReplaceScalar (System.Runtime.Intrinsics.Vector128<UIntPtr> vector, byte imm, UIntPtr value);
  * public static System.Runtime.Intrinsics.Vector128<double> RoundToNearest (System.Runtime.Intrinsics.Vector128<double> value);
  * public static System.Runtime.Intrinsics.Vector128<float> RoundToNearest (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> ShiftLeft (System.Runtime.Intrinsics.Vector128<byte> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<short> ShiftLeft (System.Runtime.Intrinsics.Vector128<short> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<int> ShiftLeft (System.Runtime.Intrinsics.Vector128<int> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<long> ShiftLeft (System.Runtime.Intrinsics.Vector128<long> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<IntPtr> ShiftLeft (System.Runtime.Intrinsics.Vector128<IntPtr> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ShiftLeft (System.Runtime.Intrinsics.Vector128<sbyte> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<ushort> ShiftLeft (System.Runtime.Intrinsics.Vector128<ushort> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<uint> ShiftLeft (System.Runtime.Intrinsics.Vector128<uint> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<ulong> ShiftLeft (System.Runtime.Intrinsics.Vector128<ulong> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<UIntPtr> ShiftLeft (System.Runtime.Intrinsics.Vector128<UIntPtr> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<byte> ShiftRightArithmetic (System.Runtime.Intrinsics.Vector128<byte> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<short> ShiftRightArithmetic (System.Runtime.Intrinsics.Vector128<short> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<int> ShiftRightArithmetic (System.Runtime.Intrinsics.Vector128<int> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<long> ShiftRightArithmetic (System.Runtime.Intrinsics.Vector128<long> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<IntPtr> ShiftRightArithmetic (System.Runtime.Intrinsics.Vector128<IntPtr> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ShiftRightArithmetic (System.Runtime.Intrinsics.Vector128<sbyte> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<ushort> ShiftRightArithmetic (System.Runtime.Intrinsics.Vector128<ushort> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<uint> ShiftRightArithmetic (System.Runtime.Intrinsics.Vector128<uint> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<ulong> ShiftRightArithmetic (System.Runtime.Intrinsics.Vector128<ulong> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<UIntPtr> ShiftRightArithmetic (System.Runtime.Intrinsics.Vector128<UIntPtr> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<byte> ShiftRightLogical (System.Runtime.Intrinsics.Vector128<byte> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<short> ShiftRightLogical (System.Runtime.Intrinsics.Vector128<short> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<int> ShiftRightLogical (System.Runtime.Intrinsics.Vector128<int> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<long> ShiftRightLogical (System.Runtime.Intrinsics.Vector128<long> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<IntPtr> ShiftRightLogical (System.Runtime.Intrinsics.Vector128<IntPtr> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ShiftRightLogical (System.Runtime.Intrinsics.Vector128<sbyte> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<ushort> ShiftRightLogical (System.Runtime.Intrinsics.Vector128<ushort> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<uint> ShiftRightLogical (System.Runtime.Intrinsics.Vector128<uint> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<ulong> ShiftRightLogical (System.Runtime.Intrinsics.Vector128<ulong> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<UIntPtr> ShiftRightLogical (System.Runtime.Intrinsics.Vector128<UIntPtr> value, int count);
  * public static System.Runtime.Intrinsics.Vector128<ushort> SignExtendWideningLower (System.Runtime.Intrinsics.Vector128<byte> value);
  * public static System.Runtime.Intrinsics.Vector128<int> SignExtendWideningLower (System.Runtime.Intrinsics.Vector128<short> value);
  * public static System.Runtime.Intrinsics.Vector128<long> SignExtendWideningLower (System.Runtime.Intrinsics.Vector128<int> value);
  * public static System.Runtime.Intrinsics.Vector128<short> SignExtendWideningLower (System.Runtime.Intrinsics.Vector128<sbyte> value);
  * public static System.Runtime.Intrinsics.Vector128<uint> SignExtendWideningLower (System.Runtime.Intrinsics.Vector128<ushort> value);
  * public static System.Runtime.Intrinsics.Vector128<ulong> SignExtendWideningLower (System.Runtime.Intrinsics.Vector128<uint> value);
  * public static System.Runtime.Intrinsics.Vector128<ushort> SignExtendWideningUpper (System.Runtime.Intrinsics.Vector128<byte> value);
  * public static System.Runtime.Intrinsics.Vector128<int> SignExtendWideningUpper (System.Runtime.Intrinsics.Vector128<short> value);
  * public static System.Runtime.Intrinsics.Vector128<long> SignExtendWideningUpper (System.Runtime.Intrinsics.Vector128<int> value);
  * public static System.Runtime.Intrinsics.Vector128<short> SignExtendWideningUpper (System.Runtime.Intrinsics.Vector128<sbyte> value);
  * public static System.Runtime.Intrinsics.Vector128<uint> SignExtendWideningUpper (System.Runtime.Intrinsics.Vector128<ushort> value);
  * public static System.Runtime.Intrinsics.Vector128<ulong> SignExtendWideningUpper (System.Runtime.Intrinsics.Vector128<uint> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> Splat (byte value);
  * public static System.Runtime.Intrinsics.Vector128<double> Splat (double value);
  * public static System.Runtime.Intrinsics.Vector128<short> Splat (short value);
  * public static System.Runtime.Intrinsics.Vector128<int> Splat (int value);
  * public static System.Runtime.Intrinsics.Vector128<long> Splat (long value);
  * public static System.Runtime.Intrinsics.Vector128<IntPtr> Splat (IntPtr value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> Splat (sbyte value);
  * public static System.Runtime.Intrinsics.Vector128<float> Splat (float value);
  * public static System.Runtime.Intrinsics.Vector128<ushort> Splat (ushort value);
  * public static System.Runtime.Intrinsics.Vector128<uint> Splat (uint value);
  * public static System.Runtime.Intrinsics.Vector128<ulong> Splat (ulong value);
  * public static System.Runtime.Intrinsics.Vector128<UIntPtr> Splat (UIntPtr value);
  * public static System.Runtime.Intrinsics.Vector128<double> Sqrt (System.Runtime.Intrinsics.Vector128<double> value);
  * public static System.Runtime.Intrinsics.Vector128<float> Sqrt (System.Runtime.Intrinsics.Vector128<float> value);
  * public static void Store (byte* address, System.Runtime.Intrinsics.Vector128<byte> source);
  * public static void Store (double* address, System.Runtime.Intrinsics.Vector128<double> source);
  * public static void Store (short* address, System.Runtime.Intrinsics.Vector128<short> source);
  * public static void Store (int* address, System.Runtime.Intrinsics.Vector128<int> source);
  * public static void Store (long* address, System.Runtime.Intrinsics.Vector128<long> source);
  * public static void Store (IntPtr* address, System.Runtime.Intrinsics.Vector128<IntPtr> source);
  * public static void Store (sbyte* address, System.Runtime.Intrinsics.Vector128<sbyte> source);
  * public static void Store (float* address, System.Runtime.Intrinsics.Vector128<float> source);
  * public static void Store (ushort* address, System.Runtime.Intrinsics.Vector128<ushort> source);
  * public static void Store (uint* address, System.Runtime.Intrinsics.Vector128<uint> source);
  * public static void Store (ulong* address, System.Runtime.Intrinsics.Vector128<ulong> source);
  * public static void Store (UIntPtr* address, System.Runtime.Intrinsics.Vector128<UIntPtr> source);
  * public static void StoreSelectedScalar (byte* address, System.Runtime.Intrinsics.Vector128<byte> source, byte index);
  * public static void StoreSelectedScalar (double* address, System.Runtime.Intrinsics.Vector128<double> source, byte index);
  * public static void StoreSelectedScalar (short* address, System.Runtime.Intrinsics.Vector128<short> source, byte index);
  * public static void StoreSelectedScalar (int* address, System.Runtime.Intrinsics.Vector128<int> source, byte index);
  * public static void StoreSelectedScalar (long* address, System.Runtime.Intrinsics.Vector128<long> source, byte index);
  * public static void StoreSelectedScalar (IntPtr* address, System.Runtime.Intrinsics.Vector128<IntPtr> source, byte index);
  * public static void StoreSelectedScalar (sbyte* address, System.Runtime.Intrinsics.Vector128<sbyte> source, byte index);
  * public static void StoreSelectedScalar (float* address, System.Runtime.Intrinsics.Vector128<float> source, byte index);
  * public static void StoreSelectedScalar (ushort* address, System.Runtime.Intrinsics.Vector128<ushort> source, byte index);
  * public static void StoreSelectedScalar (uint* address, System.Runtime.Intrinsics.Vector128<uint> source, byte index);
  * public static void StoreSelectedScalar (ulong* address, System.Runtime.Intrinsics.Vector128<ulong> source, byte index);
  * public static void StoreSelectedScalar (UIntPtr* address, System.Runtime.Intrinsics.Vector128<UIntPtr> source, byte index);
  * public static System.Runtime.Intrinsics.Vector128<byte> Subtract (System.Runtime.Intrinsics.Vector128<byte> left, System.Runtime.Intrinsics.Vector128<byte> right);
  * public static System.Runtime.Intrinsics.Vector128<double> Subtract (System.Runtime.Intrinsics.Vector128<double> left, System.Runtime.Intrinsics.Vector128<double> right);
  * public static System.Runtime.Intrinsics.Vector128<short> Subtract (System.Runtime.Intrinsics.Vector128<short> left, System.Runtime.Intrinsics.Vector128<short> right);
  * public static System.Runtime.Intrinsics.Vector128<int> Subtract (System.Runtime.Intrinsics.Vector128<int> left, System.Runtime.Intrinsics.Vector128<int> right);
  * public static System.Runtime.Intrinsics.Vector128<long> Subtract (System.Runtime.Intrinsics.Vector128<long> left, System.Runtime.Intrinsics.Vector128<long> right);
  * public static System.Runtime.Intrinsics.Vector128<IntPtr> Subtract (System.Runtime.Intrinsics.Vector128<IntPtr> left, System.Runtime.Intrinsics.Vector128<IntPtr> right);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> Subtract (System.Runtime.Intrinsics.Vector128<sbyte> left, System.Runtime.Intrinsics.Vector128<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector128<float> Subtract (System.Runtime.Intrinsics.Vector128<float> left, System.Runtime.Intrinsics.Vector128<float> right);
  * public static System.Runtime.Intrinsics.Vector128<ushort> Subtract (System.Runtime.Intrinsics.Vector128<ushort> left, System.Runtime.Intrinsics.Vector128<ushort> right);
  * public static System.Runtime.Intrinsics.Vector128<uint> Subtract (System.Runtime.Intrinsics.Vector128<uint> left, System.Runtime.Intrinsics.Vector128<uint> right);
  * public static System.Runtime.Intrinsics.Vector128<ulong> Subtract (System.Runtime.Intrinsics.Vector128<ulong> left, System.Runtime.Intrinsics.Vector128<ulong> right);
  * public static System.Runtime.Intrinsics.Vector128<UIntPtr> Subtract (System.Runtime.Intrinsics.Vector128<UIntPtr> left, System.Runtime.Intrinsics.Vector128<UIntPtr> right);
  * public static System.Runtime.Intrinsics.Vector128<byte> SubtractSaturate (System.Runtime.Intrinsics.Vector128<byte> left, System.Runtime.Intrinsics.Vector128<byte> right);
  * public static System.Runtime.Intrinsics.Vector128<short> SubtractSaturate (System.Runtime.Intrinsics.Vector128<short> left, System.Runtime.Intrinsics.Vector128<short> right);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> SubtractSaturate (System.Runtime.Intrinsics.Vector128<sbyte> left, System.Runtime.Intrinsics.Vector128<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector128<ushort> SubtractSaturate (System.Runtime.Intrinsics.Vector128<ushort> left, System.Runtime.Intrinsics.Vector128<ushort> right);
  * public static System.Runtime.Intrinsics.Vector128<byte> Swizzle (System.Runtime.Intrinsics.Vector128<byte> vector, System.Runtime.Intrinsics.Vector128<byte> indices);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> Swizzle (System.Runtime.Intrinsics.Vector128<sbyte> vector, System.Runtime.Intrinsics.Vector128<sbyte> indices);
  * public static System.Runtime.Intrinsics.Vector128<double> Truncate (System.Runtime.Intrinsics.Vector128<double> value);
  * public static System.Runtime.Intrinsics.Vector128<float> Truncate (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> Xor (System.Runtime.Intrinsics.Vector128<byte> left, System.Runtime.Intrinsics.Vector128<byte> right);
  * public static System.Runtime.Intrinsics.Vector128<double> Xor (System.Runtime.Intrinsics.Vector128<double> left, System.Runtime.Intrinsics.Vector128<double> right);
  * public static System.Runtime.Intrinsics.Vector128<short> Xor (System.Runtime.Intrinsics.Vector128<short> left, System.Runtime.Intrinsics.Vector128<short> right);
  * public static System.Runtime.Intrinsics.Vector128<int> Xor (System.Runtime.Intrinsics.Vector128<int> left, System.Runtime.Intrinsics.Vector128<int> right);
  * public static System.Runtime.Intrinsics.Vector128<long> Xor (System.Runtime.Intrinsics.Vector128<long> left, System.Runtime.Intrinsics.Vector128<long> right);
  * public static System.Runtime.Intrinsics.Vector128<IntPtr> Xor (System.Runtime.Intrinsics.Vector128<IntPtr> left, System.Runtime.Intrinsics.Vector128<IntPtr> right);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> Xor (System.Runtime.Intrinsics.Vector128<sbyte> left, System.Runtime.Intrinsics.Vector128<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector128<float> Xor (System.Runtime.Intrinsics.Vector128<float> left, System.Runtime.Intrinsics.Vector128<float> right);
  * public static System.Runtime.Intrinsics.Vector128<ushort> Xor (System.Runtime.Intrinsics.Vector128<ushort> left, System.Runtime.Intrinsics.Vector128<ushort> right);
  * public static System.Runtime.Intrinsics.Vector128<uint> Xor (System.Runtime.Intrinsics.Vector128<uint> left, System.Runtime.Intrinsics.Vector128<uint> right);
  * public static System.Runtime.Intrinsics.Vector128<ulong> Xor (System.Runtime.Intrinsics.Vector128<ulong> left, System.Runtime.Intrinsics.Vector128<ulong> right);
  * public static System.Runtime.Intrinsics.Vector128<UIntPtr> Xor (System.Runtime.Intrinsics.Vector128<UIntPtr> left, System.Runtime.Intrinsics.Vector128<UIntPtr> right);
  * public static System.Runtime.Intrinsics.Vector128<ushort> ZeroExtendWideningLower (System.Runtime.Intrinsics.Vector128<byte> value);
  * public static System.Runtime.Intrinsics.Vector128<int> ZeroExtendWideningLower (System.Runtime.Intrinsics.Vector128<short> value);
  * public static System.Runtime.Intrinsics.Vector128<long> ZeroExtendWideningLower (System.Runtime.Intrinsics.Vector128<int> value);
  * public static System.Runtime.Intrinsics.Vector128<short> ZeroExtendWideningLower (System.Runtime.Intrinsics.Vector128<sbyte> value);
  * public static System.Runtime.Intrinsics.Vector128<uint> ZeroExtendWideningLower (System.Runtime.Intrinsics.Vector128<ushort> value);
  * public static System.Runtime.Intrinsics.Vector128<ulong> ZeroExtendWideningLower (System.Runtime.Intrinsics.Vector128<uint> value);
  * public static System.Runtime.Intrinsics.Vector128<ushort> ZeroExtendWideningUpper (System.Runtime.Intrinsics.Vector128<byte> value);
  * public static System.Runtime.Intrinsics.Vector128<int> ZeroExtendWideningUpper (System.Runtime.Intrinsics.Vector128<short> value);
  * public static System.Runtime.Intrinsics.Vector128<long> ZeroExtendWideningUpper (System.Runtime.Intrinsics.Vector128<int> value);
  * public static System.Runtime.Intrinsics.Vector128<short> ZeroExtendWideningUpper (System.Runtime.Intrinsics.Vector128<sbyte> value);
  * public static System.Runtime.Intrinsics.Vector128<uint> ZeroExtendWideningUpper (System.Runtime.Intrinsics.Vector128<ushort> value);
  * public static System.Runtime.Intrinsics.Vector128<ulong> ZeroExtendWideningUpper (System.Runtime.Intrinsics.Vector128<uint> value);
* System.Runtime.Intrinsics.X86.Avx512BW+VL
  * public static System.Runtime.Intrinsics.Vector128<byte> CompareGreaterThan (System.Runtime.Intrinsics.Vector128<byte> left, System.Runtime.Intrinsics.Vector128<byte> right);
  * public static System.Runtime.Intrinsics.Vector128<ushort> CompareGreaterThan (System.Runtime.Intrinsics.Vector128<ushort> left, System.Runtime.Intrinsics.Vector128<ushort> right);
  * public static System.Runtime.Intrinsics.Vector256<byte> CompareGreaterThan (System.Runtime.Intrinsics.Vector256<byte> left, System.Runtime.Intrinsics.Vector256<byte> right);
  * public static System.Runtime.Intrinsics.Vector256<ushort> CompareGreaterThan (System.Runtime.Intrinsics.Vector256<ushort> left, System.Runtime.Intrinsics.Vector256<ushort> right);
  * public static System.Runtime.Intrinsics.Vector128<byte> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector128<byte> left, System.Runtime.Intrinsics.Vector128<byte> right);
  * public static System.Runtime.Intrinsics.Vector128<short> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector128<short> left, System.Runtime.Intrinsics.Vector128<short> right);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector128<sbyte> left, System.Runtime.Intrinsics.Vector128<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector128<ushort> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector128<ushort> left, System.Runtime.Intrinsics.Vector128<ushort> right);
  * public static System.Runtime.Intrinsics.Vector256<byte> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector256<byte> left, System.Runtime.Intrinsics.Vector256<byte> right);
  * public static System.Runtime.Intrinsics.Vector256<short> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector256<short> left, System.Runtime.Intrinsics.Vector256<short> right);
  * public static System.Runtime.Intrinsics.Vector256<sbyte> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector256<sbyte> left, System.Runtime.Intrinsics.Vector256<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector256<ushort> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector256<ushort> left, System.Runtime.Intrinsics.Vector256<ushort> right);
  * public static System.Runtime.Intrinsics.Vector128<byte> CompareLessThan (System.Runtime.Intrinsics.Vector128<byte> left, System.Runtime.Intrinsics.Vector128<byte> right);
  * public static System.Runtime.Intrinsics.Vector128<short> CompareLessThan (System.Runtime.Intrinsics.Vector128<short> left, System.Runtime.Intrinsics.Vector128<short> right);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> CompareLessThan (System.Runtime.Intrinsics.Vector128<sbyte> left, System.Runtime.Intrinsics.Vector128<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector128<ushort> CompareLessThan (System.Runtime.Intrinsics.Vector128<ushort> left, System.Runtime.Intrinsics.Vector128<ushort> right);
  * public static System.Runtime.Intrinsics.Vector256<byte> CompareLessThan (System.Runtime.Intrinsics.Vector256<byte> left, System.Runtime.Intrinsics.Vector256<byte> right);
  * public static System.Runtime.Intrinsics.Vector256<short> CompareLessThan (System.Runtime.Intrinsics.Vector256<short> left, System.Runtime.Intrinsics.Vector256<short> right);
  * public static System.Runtime.Intrinsics.Vector256<sbyte> CompareLessThan (System.Runtime.Intrinsics.Vector256<sbyte> left, System.Runtime.Intrinsics.Vector256<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector256<ushort> CompareLessThan (System.Runtime.Intrinsics.Vector256<ushort> left, System.Runtime.Intrinsics.Vector256<ushort> right);
  * public static System.Runtime.Intrinsics.Vector128<byte> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector128<byte> left, System.Runtime.Intrinsics.Vector128<byte> right);
  * public static System.Runtime.Intrinsics.Vector128<short> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector128<short> left, System.Runtime.Intrinsics.Vector128<short> right);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector128<sbyte> left, System.Runtime.Intrinsics.Vector128<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector128<ushort> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector128<ushort> left, System.Runtime.Intrinsics.Vector128<ushort> right);
  * public static System.Runtime.Intrinsics.Vector256<byte> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector256<byte> left, System.Runtime.Intrinsics.Vector256<byte> right);
  * public static System.Runtime.Intrinsics.Vector256<short> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector256<short> left, System.Runtime.Intrinsics.Vector256<short> right);
  * public static System.Runtime.Intrinsics.Vector256<sbyte> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector256<sbyte> left, System.Runtime.Intrinsics.Vector256<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector256<ushort> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector256<ushort> left, System.Runtime.Intrinsics.Vector256<ushort> right);
  * public static System.Runtime.Intrinsics.Vector128<byte> CompareNotEqual (System.Runtime.Intrinsics.Vector128<byte> left, System.Runtime.Intrinsics.Vector128<byte> right);
  * public static System.Runtime.Intrinsics.Vector128<short> CompareNotEqual (System.Runtime.Intrinsics.Vector128<short> left, System.Runtime.Intrinsics.Vector128<short> right);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> CompareNotEqual (System.Runtime.Intrinsics.Vector128<sbyte> left, System.Runtime.Intrinsics.Vector128<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector128<ushort> CompareNotEqual (System.Runtime.Intrinsics.Vector128<ushort> left, System.Runtime.Intrinsics.Vector128<ushort> right);
  * public static System.Runtime.Intrinsics.Vector256<byte> CompareNotEqual (System.Runtime.Intrinsics.Vector256<byte> left, System.Runtime.Intrinsics.Vector256<byte> right);
  * public static System.Runtime.Intrinsics.Vector256<short> CompareNotEqual (System.Runtime.Intrinsics.Vector256<short> left, System.Runtime.Intrinsics.Vector256<short> right);
  * public static System.Runtime.Intrinsics.Vector256<sbyte> CompareNotEqual (System.Runtime.Intrinsics.Vector256<sbyte> left, System.Runtime.Intrinsics.Vector256<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector256<ushort> CompareNotEqual (System.Runtime.Intrinsics.Vector256<ushort> left, System.Runtime.Intrinsics.Vector256<ushort> right);
  * public static System.Runtime.Intrinsics.Vector128<byte> ConvertToVector128Byte (System.Runtime.Intrinsics.Vector128<short> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> ConvertToVector128Byte (System.Runtime.Intrinsics.Vector128<ushort> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> ConvertToVector128Byte (System.Runtime.Intrinsics.Vector256<short> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> ConvertToVector128Byte (System.Runtime.Intrinsics.Vector256<ushort> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> ConvertToVector128ByteWithSaturation (System.Runtime.Intrinsics.Vector128<ushort> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> ConvertToVector128ByteWithSaturation (System.Runtime.Intrinsics.Vector256<ushort> value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ConvertToVector128SByte (System.Runtime.Intrinsics.Vector128<short> value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ConvertToVector128SByte (System.Runtime.Intrinsics.Vector128<ushort> value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ConvertToVector128SByte (System.Runtime.Intrinsics.Vector256<short> value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ConvertToVector128SByte (System.Runtime.Intrinsics.Vector256<ushort> value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ConvertToVector128SByteWithSaturation (System.Runtime.Intrinsics.Vector128<short> value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ConvertToVector128SByteWithSaturation (System.Runtime.Intrinsics.Vector256<short> value);
  * public static bool IsSupported { get; }
  * public static System.Runtime.Intrinsics.Vector256<short> PermuteVar16x16 (System.Runtime.Intrinsics.Vector256<short> left, System.Runtime.Intrinsics.Vector256<short> control);
  * public static System.Runtime.Intrinsics.Vector256<ushort> PermuteVar16x16 (System.Runtime.Intrinsics.Vector256<ushort> left, System.Runtime.Intrinsics.Vector256<ushort> control);
  * public static System.Runtime.Intrinsics.Vector256<short> PermuteVar16x16x2 (System.Runtime.Intrinsics.Vector256<short> lower, System.Runtime.Intrinsics.Vector256<short> indices, System.Runtime.Intrinsics.Vector256<short> upper);
  * public static System.Runtime.Intrinsics.Vector256<ushort> PermuteVar16x16x2 (System.Runtime.Intrinsics.Vector256<ushort> lower, System.Runtime.Intrinsics.Vector256<ushort> indices, System.Runtime.Intrinsics.Vector256<ushort> upper);
  * public static System.Runtime.Intrinsics.Vector128<short> PermuteVar8x16 (System.Runtime.Intrinsics.Vector128<short> left, System.Runtime.Intrinsics.Vector128<short> control);
  * public static System.Runtime.Intrinsics.Vector128<ushort> PermuteVar8x16 (System.Runtime.Intrinsics.Vector128<ushort> left, System.Runtime.Intrinsics.Vector128<ushort> control);
  * public static System.Runtime.Intrinsics.Vector128<short> PermuteVar8x16x2 (System.Runtime.Intrinsics.Vector128<short> lower, System.Runtime.Intrinsics.Vector128<short> indices, System.Runtime.Intrinsics.Vector128<short> upper);
  * public static System.Runtime.Intrinsics.Vector128<ushort> PermuteVar8x16x2 (System.Runtime.Intrinsics.Vector128<ushort> lower, System.Runtime.Intrinsics.Vector128<ushort> indices, System.Runtime.Intrinsics.Vector128<ushort> upper);
  * public static System.Runtime.Intrinsics.Vector128<short> ShiftLeftLogicalVariable (System.Runtime.Intrinsics.Vector128<short> value, System.Runtime.Intrinsics.Vector128<ushort> count);
  * public static System.Runtime.Intrinsics.Vector128<ushort> ShiftLeftLogicalVariable (System.Runtime.Intrinsics.Vector128<ushort> value, System.Runtime.Intrinsics.Vector128<ushort> count);
  * public static System.Runtime.Intrinsics.Vector256<short> ShiftLeftLogicalVariable (System.Runtime.Intrinsics.Vector256<short> value, System.Runtime.Intrinsics.Vector256<ushort> count);
  * public static System.Runtime.Intrinsics.Vector256<ushort> ShiftLeftLogicalVariable (System.Runtime.Intrinsics.Vector256<ushort> value, System.Runtime.Intrinsics.Vector256<ushort> count);
  * public static System.Runtime.Intrinsics.Vector128<short> ShiftRightArithmeticVariable (System.Runtime.Intrinsics.Vector128<short> value, System.Runtime.Intrinsics.Vector128<ushort> count);
  * public static System.Runtime.Intrinsics.Vector256<short> ShiftRightArithmeticVariable (System.Runtime.Intrinsics.Vector256<short> value, System.Runtime.Intrinsics.Vector256<ushort> count);
  * public static System.Runtime.Intrinsics.Vector128<short> ShiftRightLogicalVariable (System.Runtime.Intrinsics.Vector128<short> value, System.Runtime.Intrinsics.Vector128<ushort> count);
  * public static System.Runtime.Intrinsics.Vector128<ushort> ShiftRightLogicalVariable (System.Runtime.Intrinsics.Vector128<ushort> value, System.Runtime.Intrinsics.Vector128<ushort> count);
  * public static System.Runtime.Intrinsics.Vector256<short> ShiftRightLogicalVariable (System.Runtime.Intrinsics.Vector256<short> value, System.Runtime.Intrinsics.Vector256<ushort> count);
  * public static System.Runtime.Intrinsics.Vector256<ushort> ShiftRightLogicalVariable (System.Runtime.Intrinsics.Vector256<ushort> value, System.Runtime.Intrinsics.Vector256<ushort> count);
  * public static System.Runtime.Intrinsics.Vector128<ushort> SumAbsoluteDifferencesInBlock32 (System.Runtime.Intrinsics.Vector128<byte> left, System.Runtime.Intrinsics.Vector128<byte> right, byte control);
  * public static System.Runtime.Intrinsics.Vector256<ushort> SumAbsoluteDifferencesInBlock32 (System.Runtime.Intrinsics.Vector256<byte> left, System.Runtime.Intrinsics.Vector256<byte> right, byte control);
* System.Runtime.Intrinsics.X86.Avx512BW+X64
  * public static bool IsSupported { get; }
* System.Runtime.Intrinsics.X86.Avx512BW
  * public static System.Runtime.Intrinsics.Vector512<ushort> Abs (System.Runtime.Intrinsics.Vector512<short> value);
  * public static System.Runtime.Intrinsics.Vector512<byte> Abs (System.Runtime.Intrinsics.Vector512<sbyte> value);
  * public static System.Runtime.Intrinsics.Vector512<byte> Add (System.Runtime.Intrinsics.Vector512<byte> left, System.Runtime.Intrinsics.Vector512<byte> right);
  * public static System.Runtime.Intrinsics.Vector512<short> Add (System.Runtime.Intrinsics.Vector512<short> left, System.Runtime.Intrinsics.Vector512<short> right);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> Add (System.Runtime.Intrinsics.Vector512<sbyte> left, System.Runtime.Intrinsics.Vector512<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector512<ushort> Add (System.Runtime.Intrinsics.Vector512<ushort> left, System.Runtime.Intrinsics.Vector512<ushort> right);
  * public static System.Runtime.Intrinsics.Vector512<byte> AddSaturate (System.Runtime.Intrinsics.Vector512<byte> left, System.Runtime.Intrinsics.Vector512<byte> right);
  * public static System.Runtime.Intrinsics.Vector512<short> AddSaturate (System.Runtime.Intrinsics.Vector512<short> left, System.Runtime.Intrinsics.Vector512<short> right);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> AddSaturate (System.Runtime.Intrinsics.Vector512<sbyte> left, System.Runtime.Intrinsics.Vector512<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector512<ushort> AddSaturate (System.Runtime.Intrinsics.Vector512<ushort> left, System.Runtime.Intrinsics.Vector512<ushort> right);
  * public static System.Runtime.Intrinsics.Vector512<byte> AlignRight (System.Runtime.Intrinsics.Vector512<byte> left, System.Runtime.Intrinsics.Vector512<byte> right, byte mask);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> AlignRight (System.Runtime.Intrinsics.Vector512<sbyte> left, System.Runtime.Intrinsics.Vector512<sbyte> right, byte mask);
  * public static System.Runtime.Intrinsics.Vector512<byte> Average (System.Runtime.Intrinsics.Vector512<byte> left, System.Runtime.Intrinsics.Vector512<byte> right);
  * public static System.Runtime.Intrinsics.Vector512<ushort> Average (System.Runtime.Intrinsics.Vector512<ushort> left, System.Runtime.Intrinsics.Vector512<ushort> right);
  * public static System.Runtime.Intrinsics.Vector512<byte> BlendVariable (System.Runtime.Intrinsics.Vector512<byte> left, System.Runtime.Intrinsics.Vector512<byte> right, System.Runtime.Intrinsics.Vector512<byte> mask);
  * public static System.Runtime.Intrinsics.Vector512<short> BlendVariable (System.Runtime.Intrinsics.Vector512<short> left, System.Runtime.Intrinsics.Vector512<short> right, System.Runtime.Intrinsics.Vector512<short> mask);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> BlendVariable (System.Runtime.Intrinsics.Vector512<sbyte> left, System.Runtime.Intrinsics.Vector512<sbyte> right, System.Runtime.Intrinsics.Vector512<sbyte> mask);
  * public static System.Runtime.Intrinsics.Vector512<ushort> BlendVariable (System.Runtime.Intrinsics.Vector512<ushort> left, System.Runtime.Intrinsics.Vector512<ushort> right, System.Runtime.Intrinsics.Vector512<ushort> mask);
  * public static System.Runtime.Intrinsics.Vector512<byte> BroadcastScalarToVector512 (System.Runtime.Intrinsics.Vector128<byte> value);
  * public static System.Runtime.Intrinsics.Vector512<short> BroadcastScalarToVector512 (System.Runtime.Intrinsics.Vector128<short> value);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> BroadcastScalarToVector512 (System.Runtime.Intrinsics.Vector128<sbyte> value);
  * public static System.Runtime.Intrinsics.Vector512<ushort> BroadcastScalarToVector512 (System.Runtime.Intrinsics.Vector128<ushort> value);
  * public static System.Runtime.Intrinsics.Vector512<byte> CompareEqual (System.Runtime.Intrinsics.Vector512<byte> left, System.Runtime.Intrinsics.Vector512<byte> right);
  * public static System.Runtime.Intrinsics.Vector512<short> CompareEqual (System.Runtime.Intrinsics.Vector512<short> left, System.Runtime.Intrinsics.Vector512<short> right);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> CompareEqual (System.Runtime.Intrinsics.Vector512<sbyte> left, System.Runtime.Intrinsics.Vector512<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector512<ushort> CompareEqual (System.Runtime.Intrinsics.Vector512<ushort> left, System.Runtime.Intrinsics.Vector512<ushort> right);
  * public static System.Runtime.Intrinsics.Vector512<byte> CompareGreaterThan (System.Runtime.Intrinsics.Vector512<byte> left, System.Runtime.Intrinsics.Vector512<byte> right);
  * public static System.Runtime.Intrinsics.Vector512<short> CompareGreaterThan (System.Runtime.Intrinsics.Vector512<short> left, System.Runtime.Intrinsics.Vector512<short> right);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> CompareGreaterThan (System.Runtime.Intrinsics.Vector512<sbyte> left, System.Runtime.Intrinsics.Vector512<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector512<ushort> CompareGreaterThan (System.Runtime.Intrinsics.Vector512<ushort> left, System.Runtime.Intrinsics.Vector512<ushort> right);
  * public static System.Runtime.Intrinsics.Vector512<byte> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector512<byte> left, System.Runtime.Intrinsics.Vector512<byte> right);
  * public static System.Runtime.Intrinsics.Vector512<short> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector512<short> left, System.Runtime.Intrinsics.Vector512<short> right);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector512<sbyte> left, System.Runtime.Intrinsics.Vector512<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector512<ushort> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector512<ushort> left, System.Runtime.Intrinsics.Vector512<ushort> right);
  * public static System.Runtime.Intrinsics.Vector512<byte> CompareLessThan (System.Runtime.Intrinsics.Vector512<byte> left, System.Runtime.Intrinsics.Vector512<byte> right);
  * public static System.Runtime.Intrinsics.Vector512<short> CompareLessThan (System.Runtime.Intrinsics.Vector512<short> left, System.Runtime.Intrinsics.Vector512<short> right);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> CompareLessThan (System.Runtime.Intrinsics.Vector512<sbyte> left, System.Runtime.Intrinsics.Vector512<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector512<ushort> CompareLessThan (System.Runtime.Intrinsics.Vector512<ushort> left, System.Runtime.Intrinsics.Vector512<ushort> right);
  * public static System.Runtime.Intrinsics.Vector512<byte> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector512<byte> left, System.Runtime.Intrinsics.Vector512<byte> right);
  * public static System.Runtime.Intrinsics.Vector512<short> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector512<short> left, System.Runtime.Intrinsics.Vector512<short> right);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector512<sbyte> left, System.Runtime.Intrinsics.Vector512<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector512<ushort> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector512<ushort> left, System.Runtime.Intrinsics.Vector512<ushort> right);
  * public static System.Runtime.Intrinsics.Vector512<byte> CompareNotEqual (System.Runtime.Intrinsics.Vector512<byte> left, System.Runtime.Intrinsics.Vector512<byte> right);
  * public static System.Runtime.Intrinsics.Vector512<short> CompareNotEqual (System.Runtime.Intrinsics.Vector512<short> left, System.Runtime.Intrinsics.Vector512<short> right);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> CompareNotEqual (System.Runtime.Intrinsics.Vector512<sbyte> left, System.Runtime.Intrinsics.Vector512<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector512<ushort> CompareNotEqual (System.Runtime.Intrinsics.Vector512<ushort> left, System.Runtime.Intrinsics.Vector512<ushort> right);
  * public static System.Runtime.Intrinsics.Vector256<byte> ConvertToVector256Byte (System.Runtime.Intrinsics.Vector512<short> value);
  * public static System.Runtime.Intrinsics.Vector256<byte> ConvertToVector256Byte (System.Runtime.Intrinsics.Vector512<ushort> value);
  * public static System.Runtime.Intrinsics.Vector256<byte> ConvertToVector256ByteWithSaturation (System.Runtime.Intrinsics.Vector512<ushort> value);
  * public static System.Runtime.Intrinsics.Vector256<sbyte> ConvertToVector256SByte (System.Runtime.Intrinsics.Vector512<short> value);
  * public static System.Runtime.Intrinsics.Vector256<sbyte> ConvertToVector256SByte (System.Runtime.Intrinsics.Vector512<ushort> value);
  * public static System.Runtime.Intrinsics.Vector256<sbyte> ConvertToVector256SByteWithSaturation (System.Runtime.Intrinsics.Vector512<short> value);
  * public static System.Runtime.Intrinsics.Vector512<short> ConvertToVector512Int16 (System.Runtime.Intrinsics.Vector256<byte> value);
  * public static System.Runtime.Intrinsics.Vector512<short> ConvertToVector512Int16 (System.Runtime.Intrinsics.Vector256<sbyte> value);
  * public static System.Runtime.Intrinsics.Vector512<ushort> ConvertToVector512UInt16 (System.Runtime.Intrinsics.Vector256<byte> value);
  * public static System.Runtime.Intrinsics.Vector512<ushort> ConvertToVector512UInt16 (System.Runtime.Intrinsics.Vector256<sbyte> value);
  * public static bool IsSupported { get; }
  * public static System.Runtime.Intrinsics.Vector512<byte> LoadVector512 (byte* address);
  * public static System.Runtime.Intrinsics.Vector512<short> LoadVector512 (short* address);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> LoadVector512 (sbyte* address);
  * public static System.Runtime.Intrinsics.Vector512<ushort> LoadVector512 (ushort* address);
  * public static System.Runtime.Intrinsics.Vector512<byte> Max (System.Runtime.Intrinsics.Vector512<byte> left, System.Runtime.Intrinsics.Vector512<byte> right);
  * public static System.Runtime.Intrinsics.Vector512<short> Max (System.Runtime.Intrinsics.Vector512<short> left, System.Runtime.Intrinsics.Vector512<short> right);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> Max (System.Runtime.Intrinsics.Vector512<sbyte> left, System.Runtime.Intrinsics.Vector512<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector512<ushort> Max (System.Runtime.Intrinsics.Vector512<ushort> left, System.Runtime.Intrinsics.Vector512<ushort> right);
  * public static System.Runtime.Intrinsics.Vector512<byte> Min (System.Runtime.Intrinsics.Vector512<byte> left, System.Runtime.Intrinsics.Vector512<byte> right);
  * public static System.Runtime.Intrinsics.Vector512<short> Min (System.Runtime.Intrinsics.Vector512<short> left, System.Runtime.Intrinsics.Vector512<short> right);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> Min (System.Runtime.Intrinsics.Vector512<sbyte> left, System.Runtime.Intrinsics.Vector512<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector512<ushort> Min (System.Runtime.Intrinsics.Vector512<ushort> left, System.Runtime.Intrinsics.Vector512<ushort> right);
  * public static System.Runtime.Intrinsics.Vector512<short> MultiplyAddAdjacent (System.Runtime.Intrinsics.Vector512<byte> left, System.Runtime.Intrinsics.Vector512<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector512<int> MultiplyAddAdjacent (System.Runtime.Intrinsics.Vector512<short> left, System.Runtime.Intrinsics.Vector512<short> right);
  * public static System.Runtime.Intrinsics.Vector512<short> MultiplyHigh (System.Runtime.Intrinsics.Vector512<short> left, System.Runtime.Intrinsics.Vector512<short> right);
  * public static System.Runtime.Intrinsics.Vector512<ushort> MultiplyHigh (System.Runtime.Intrinsics.Vector512<ushort> left, System.Runtime.Intrinsics.Vector512<ushort> right);
  * public static System.Runtime.Intrinsics.Vector512<short> MultiplyHighRoundScale (System.Runtime.Intrinsics.Vector512<short> left, System.Runtime.Intrinsics.Vector512<short> right);
  * public static System.Runtime.Intrinsics.Vector512<short> MultiplyLow (System.Runtime.Intrinsics.Vector512<short> left, System.Runtime.Intrinsics.Vector512<short> right);
  * public static System.Runtime.Intrinsics.Vector512<ushort> MultiplyLow (System.Runtime.Intrinsics.Vector512<ushort> left, System.Runtime.Intrinsics.Vector512<ushort> right);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> PackSignedSaturate (System.Runtime.Intrinsics.Vector512<short> left, System.Runtime.Intrinsics.Vector512<short> right);
  * public static System.Runtime.Intrinsics.Vector512<short> PackSignedSaturate (System.Runtime.Intrinsics.Vector512<int> left, System.Runtime.Intrinsics.Vector512<int> right);
  * public static System.Runtime.Intrinsics.Vector512<byte> PackUnsignedSaturate (System.Runtime.Intrinsics.Vector512<short> left, System.Runtime.Intrinsics.Vector512<short> right);
  * public static System.Runtime.Intrinsics.Vector512<ushort> PackUnsignedSaturate (System.Runtime.Intrinsics.Vector512<int> left, System.Runtime.Intrinsics.Vector512<int> right);
  * public static System.Runtime.Intrinsics.Vector512<short> PermuteVar32x16 (System.Runtime.Intrinsics.Vector512<short> left, System.Runtime.Intrinsics.Vector512<short> control);
  * public static System.Runtime.Intrinsics.Vector512<ushort> PermuteVar32x16 (System.Runtime.Intrinsics.Vector512<ushort> left, System.Runtime.Intrinsics.Vector512<ushort> control);
  * public static System.Runtime.Intrinsics.Vector512<short> PermuteVar32x16x2 (System.Runtime.Intrinsics.Vector512<short> lower, System.Runtime.Intrinsics.Vector512<short> indices, System.Runtime.Intrinsics.Vector512<short> upper);
  * public static System.Runtime.Intrinsics.Vector512<ushort> PermuteVar32x16x2 (System.Runtime.Intrinsics.Vector512<ushort> lower, System.Runtime.Intrinsics.Vector512<ushort> indices, System.Runtime.Intrinsics.Vector512<ushort> upper);
  * public static System.Runtime.Intrinsics.Vector512<short> ShiftLeftLogical (System.Runtime.Intrinsics.Vector512<short> value, byte count);
  * public static System.Runtime.Intrinsics.Vector512<short> ShiftLeftLogical (System.Runtime.Intrinsics.Vector512<short> value, System.Runtime.Intrinsics.Vector128<short> count);
  * public static System.Runtime.Intrinsics.Vector512<ushort> ShiftLeftLogical (System.Runtime.Intrinsics.Vector512<ushort> value, byte count);
  * public static System.Runtime.Intrinsics.Vector512<ushort> ShiftLeftLogical (System.Runtime.Intrinsics.Vector512<ushort> value, System.Runtime.Intrinsics.Vector128<ushort> count);
  * public static System.Runtime.Intrinsics.Vector512<byte> ShiftLeftLogical128BitLane (System.Runtime.Intrinsics.Vector512<byte> value, byte numBytes);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> ShiftLeftLogical128BitLane (System.Runtime.Intrinsics.Vector512<sbyte> value, byte numBytes);
  * public static System.Runtime.Intrinsics.Vector512<short> ShiftLeftLogicalVariable (System.Runtime.Intrinsics.Vector512<short> value, System.Runtime.Intrinsics.Vector512<ushort> count);
  * public static System.Runtime.Intrinsics.Vector512<ushort> ShiftLeftLogicalVariable (System.Runtime.Intrinsics.Vector512<ushort> value, System.Runtime.Intrinsics.Vector512<ushort> count);
  * public static System.Runtime.Intrinsics.Vector512<short> ShiftRightArithmetic (System.Runtime.Intrinsics.Vector512<short> value, byte count);
  * public static System.Runtime.Intrinsics.Vector512<short> ShiftRightArithmetic (System.Runtime.Intrinsics.Vector512<short> value, System.Runtime.Intrinsics.Vector128<short> count);
  * public static System.Runtime.Intrinsics.Vector512<short> ShiftRightArithmeticVariable (System.Runtime.Intrinsics.Vector512<short> value, System.Runtime.Intrinsics.Vector512<ushort> count);
  * public static System.Runtime.Intrinsics.Vector512<short> ShiftRightLogical (System.Runtime.Intrinsics.Vector512<short> value, byte count);
  * public static System.Runtime.Intrinsics.Vector512<short> ShiftRightLogical (System.Runtime.Intrinsics.Vector512<short> value, System.Runtime.Intrinsics.Vector128<short> count);
  * public static System.Runtime.Intrinsics.Vector512<ushort> ShiftRightLogical (System.Runtime.Intrinsics.Vector512<ushort> value, byte count);
  * public static System.Runtime.Intrinsics.Vector512<ushort> ShiftRightLogical (System.Runtime.Intrinsics.Vector512<ushort> value, System.Runtime.Intrinsics.Vector128<ushort> count);
  * public static System.Runtime.Intrinsics.Vector512<byte> ShiftRightLogical128BitLane (System.Runtime.Intrinsics.Vector512<byte> value, byte numBytes);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> ShiftRightLogical128BitLane (System.Runtime.Intrinsics.Vector512<sbyte> value, byte numBytes);
  * public static System.Runtime.Intrinsics.Vector512<short> ShiftRightLogicalVariable (System.Runtime.Intrinsics.Vector512<short> value, System.Runtime.Intrinsics.Vector512<ushort> count);
  * public static System.Runtime.Intrinsics.Vector512<ushort> ShiftRightLogicalVariable (System.Runtime.Intrinsics.Vector512<ushort> value, System.Runtime.Intrinsics.Vector512<ushort> count);
  * public static System.Runtime.Intrinsics.Vector512<byte> Shuffle (System.Runtime.Intrinsics.Vector512<byte> value, System.Runtime.Intrinsics.Vector512<byte> mask);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> Shuffle (System.Runtime.Intrinsics.Vector512<sbyte> value, System.Runtime.Intrinsics.Vector512<sbyte> mask);
  * public static System.Runtime.Intrinsics.Vector512<short> ShuffleHigh (System.Runtime.Intrinsics.Vector512<short> value, byte control);
  * public static System.Runtime.Intrinsics.Vector512<ushort> ShuffleHigh (System.Runtime.Intrinsics.Vector512<ushort> value, byte control);
  * public static System.Runtime.Intrinsics.Vector512<short> ShuffleLow (System.Runtime.Intrinsics.Vector512<short> value, byte control);
  * public static System.Runtime.Intrinsics.Vector512<ushort> ShuffleLow (System.Runtime.Intrinsics.Vector512<ushort> value, byte control);
  * public static void Store (byte* address, System.Runtime.Intrinsics.Vector512<byte> source);
  * public static void Store (short* address, System.Runtime.Intrinsics.Vector512<short> source);
  * public static void Store (sbyte* address, System.Runtime.Intrinsics.Vector512<sbyte> source);
  * public static void Store (ushort* address, System.Runtime.Intrinsics.Vector512<ushort> source);
  * public static System.Runtime.Intrinsics.Vector512<byte> Subtract (System.Runtime.Intrinsics.Vector512<byte> left, System.Runtime.Intrinsics.Vector512<byte> right);
  * public static System.Runtime.Intrinsics.Vector512<short> Subtract (System.Runtime.Intrinsics.Vector512<short> left, System.Runtime.Intrinsics.Vector512<short> right);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> Subtract (System.Runtime.Intrinsics.Vector512<sbyte> left, System.Runtime.Intrinsics.Vector512<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector512<ushort> Subtract (System.Runtime.Intrinsics.Vector512<ushort> left, System.Runtime.Intrinsics.Vector512<ushort> right);
  * public static System.Runtime.Intrinsics.Vector512<byte> SubtractSaturate (System.Runtime.Intrinsics.Vector512<byte> left, System.Runtime.Intrinsics.Vector512<byte> right);
  * public static System.Runtime.Intrinsics.Vector512<short> SubtractSaturate (System.Runtime.Intrinsics.Vector512<short> left, System.Runtime.Intrinsics.Vector512<short> right);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> SubtractSaturate (System.Runtime.Intrinsics.Vector512<sbyte> left, System.Runtime.Intrinsics.Vector512<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector512<ushort> SubtractSaturate (System.Runtime.Intrinsics.Vector512<ushort> left, System.Runtime.Intrinsics.Vector512<ushort> right);
  * public static System.Runtime.Intrinsics.Vector512<ushort> SumAbsoluteDifferences (System.Runtime.Intrinsics.Vector512<byte> left, System.Runtime.Intrinsics.Vector512<byte> right);
  * public static System.Runtime.Intrinsics.Vector512<ushort> SumAbsoluteDifferencesInBlock32 (System.Runtime.Intrinsics.Vector512<byte> left, System.Runtime.Intrinsics.Vector512<byte> right, byte control);
  * public static System.Runtime.Intrinsics.Vector512<byte> UnpackHigh (System.Runtime.Intrinsics.Vector512<byte> left, System.Runtime.Intrinsics.Vector512<byte> right);
  * public static System.Runtime.Intrinsics.Vector512<short> UnpackHigh (System.Runtime.Intrinsics.Vector512<short> left, System.Runtime.Intrinsics.Vector512<short> right);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> UnpackHigh (System.Runtime.Intrinsics.Vector512<sbyte> left, System.Runtime.Intrinsics.Vector512<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector512<ushort> UnpackHigh (System.Runtime.Intrinsics.Vector512<ushort> left, System.Runtime.Intrinsics.Vector512<ushort> right);
  * public static System.Runtime.Intrinsics.Vector512<byte> UnpackLow (System.Runtime.Intrinsics.Vector512<byte> left, System.Runtime.Intrinsics.Vector512<byte> right);
  * public static System.Runtime.Intrinsics.Vector512<short> UnpackLow (System.Runtime.Intrinsics.Vector512<short> left, System.Runtime.Intrinsics.Vector512<short> right);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> UnpackLow (System.Runtime.Intrinsics.Vector512<sbyte> left, System.Runtime.Intrinsics.Vector512<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector512<ushort> UnpackLow (System.Runtime.Intrinsics.Vector512<ushort> left, System.Runtime.Intrinsics.Vector512<ushort> right);
* System.Runtime.Intrinsics.X86.Avx512CD+VL
  * public static System.Runtime.Intrinsics.Vector128<int> DetectConflicts (System.Runtime.Intrinsics.Vector128<int> value);
  * public static System.Runtime.Intrinsics.Vector128<long> DetectConflicts (System.Runtime.Intrinsics.Vector128<long> value);
  * public static System.Runtime.Intrinsics.Vector128<uint> DetectConflicts (System.Runtime.Intrinsics.Vector128<uint> value);
  * public static System.Runtime.Intrinsics.Vector128<ulong> DetectConflicts (System.Runtime.Intrinsics.Vector128<ulong> value);
  * public static System.Runtime.Intrinsics.Vector256<int> DetectConflicts (System.Runtime.Intrinsics.Vector256<int> value);
  * public static System.Runtime.Intrinsics.Vector256<long> DetectConflicts (System.Runtime.Intrinsics.Vector256<long> value);
  * public static System.Runtime.Intrinsics.Vector256<uint> DetectConflicts (System.Runtime.Intrinsics.Vector256<uint> value);
  * public static System.Runtime.Intrinsics.Vector256<ulong> DetectConflicts (System.Runtime.Intrinsics.Vector256<ulong> value);
  * public static bool IsSupported { get; }
  * public static System.Runtime.Intrinsics.Vector128<int> LeadingZeroCount (System.Runtime.Intrinsics.Vector128<int> value);
  * public static System.Runtime.Intrinsics.Vector128<long> LeadingZeroCount (System.Runtime.Intrinsics.Vector128<long> value);
  * public static System.Runtime.Intrinsics.Vector128<uint> LeadingZeroCount (System.Runtime.Intrinsics.Vector128<uint> value);
  * public static System.Runtime.Intrinsics.Vector128<ulong> LeadingZeroCount (System.Runtime.Intrinsics.Vector128<ulong> value);
  * public static System.Runtime.Intrinsics.Vector256<int> LeadingZeroCount (System.Runtime.Intrinsics.Vector256<int> value);
  * public static System.Runtime.Intrinsics.Vector256<long> LeadingZeroCount (System.Runtime.Intrinsics.Vector256<long> value);
  * public static System.Runtime.Intrinsics.Vector256<uint> LeadingZeroCount (System.Runtime.Intrinsics.Vector256<uint> value);
  * public static System.Runtime.Intrinsics.Vector256<ulong> LeadingZeroCount (System.Runtime.Intrinsics.Vector256<ulong> value);
* System.Runtime.Intrinsics.X86.Avx512CD+X64
  * public static bool IsSupported { get; }
* System.Runtime.Intrinsics.X86.Avx512CD
  * public static System.Runtime.Intrinsics.Vector512<int> DetectConflicts (System.Runtime.Intrinsics.Vector512<int> value);
  * public static System.Runtime.Intrinsics.Vector512<long> DetectConflicts (System.Runtime.Intrinsics.Vector512<long> value);
  * public static System.Runtime.Intrinsics.Vector512<uint> DetectConflicts (System.Runtime.Intrinsics.Vector512<uint> value);
  * public static System.Runtime.Intrinsics.Vector512<ulong> DetectConflicts (System.Runtime.Intrinsics.Vector512<ulong> value);
  * public static bool IsSupported { get; }
  * public static System.Runtime.Intrinsics.Vector512<int> LeadingZeroCount (System.Runtime.Intrinsics.Vector512<int> value);
  * public static System.Runtime.Intrinsics.Vector512<long> LeadingZeroCount (System.Runtime.Intrinsics.Vector512<long> value);
  * public static System.Runtime.Intrinsics.Vector512<uint> LeadingZeroCount (System.Runtime.Intrinsics.Vector512<uint> value);
  * public static System.Runtime.Intrinsics.Vector512<ulong> LeadingZeroCount (System.Runtime.Intrinsics.Vector512<ulong> value);
* System.Runtime.Intrinsics.X86.Avx512DQ+VL
  * public static System.Runtime.Intrinsics.Vector128<int> BroadcastPairScalarToVector128 (System.Runtime.Intrinsics.Vector128<int> value);
  * public static System.Runtime.Intrinsics.Vector128<uint> BroadcastPairScalarToVector128 (System.Runtime.Intrinsics.Vector128<uint> value);
  * public static System.Runtime.Intrinsics.Vector256<int> BroadcastPairScalarToVector256 (System.Runtime.Intrinsics.Vector128<int> value);
  * public static System.Runtime.Intrinsics.Vector256<float> BroadcastPairScalarToVector256 (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector256<uint> BroadcastPairScalarToVector256 (System.Runtime.Intrinsics.Vector128<uint> value);
  * public static System.Runtime.Intrinsics.Vector128<double> ConvertToVector128Double (System.Runtime.Intrinsics.Vector128<long> value);
  * public static System.Runtime.Intrinsics.Vector128<double> ConvertToVector128Double (System.Runtime.Intrinsics.Vector128<ulong> value);
  * public static System.Runtime.Intrinsics.Vector128<long> ConvertToVector128Int64 (System.Runtime.Intrinsics.Vector128<double> value);
  * public static System.Runtime.Intrinsics.Vector128<long> ConvertToVector128Int64 (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector128<long> ConvertToVector128Int64WithTruncation (System.Runtime.Intrinsics.Vector128<double> value);
  * public static System.Runtime.Intrinsics.Vector128<long> ConvertToVector128Int64WithTruncation (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector128<float> ConvertToVector128Single (System.Runtime.Intrinsics.Vector128<long> value);
  * public static System.Runtime.Intrinsics.Vector128<float> ConvertToVector128Single (System.Runtime.Intrinsics.Vector128<ulong> value);
  * public static System.Runtime.Intrinsics.Vector128<float> ConvertToVector128Single (System.Runtime.Intrinsics.Vector256<long> value);
  * public static System.Runtime.Intrinsics.Vector128<float> ConvertToVector128Single (System.Runtime.Intrinsics.Vector256<ulong> value);
  * public static System.Runtime.Intrinsics.Vector128<ulong> ConvertToVector128UInt64 (System.Runtime.Intrinsics.Vector128<double> value);
  * public static System.Runtime.Intrinsics.Vector128<ulong> ConvertToVector128UInt64 (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector128<ulong> ConvertToVector128UInt64WithTruncation (System.Runtime.Intrinsics.Vector128<double> value);
  * public static System.Runtime.Intrinsics.Vector128<ulong> ConvertToVector128UInt64WithTruncation (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector256<double> ConvertToVector256Double (System.Runtime.Intrinsics.Vector256<long> value);
  * public static System.Runtime.Intrinsics.Vector256<double> ConvertToVector256Double (System.Runtime.Intrinsics.Vector256<ulong> value);
  * public static System.Runtime.Intrinsics.Vector256<long> ConvertToVector256Int64 (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector256<long> ConvertToVector256Int64 (System.Runtime.Intrinsics.Vector256<double> value);
  * public static System.Runtime.Intrinsics.Vector256<long> ConvertToVector256Int64WithTruncation (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector256<long> ConvertToVector256Int64WithTruncation (System.Runtime.Intrinsics.Vector256<double> value);
  * public static System.Runtime.Intrinsics.Vector256<ulong> ConvertToVector256UInt64 (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector256<ulong> ConvertToVector256UInt64 (System.Runtime.Intrinsics.Vector256<double> value);
  * public static System.Runtime.Intrinsics.Vector256<ulong> ConvertToVector256UInt64WithTruncation (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector256<ulong> ConvertToVector256UInt64WithTruncation (System.Runtime.Intrinsics.Vector256<double> value);
  * public static bool IsSupported { get; }
  * public static System.Runtime.Intrinsics.Vector128<long> MultiplyLow (System.Runtime.Intrinsics.Vector128<long> left, System.Runtime.Intrinsics.Vector128<long> right);
  * public static System.Runtime.Intrinsics.Vector128<ulong> MultiplyLow (System.Runtime.Intrinsics.Vector128<ulong> left, System.Runtime.Intrinsics.Vector128<ulong> right);
  * public static System.Runtime.Intrinsics.Vector256<long> MultiplyLow (System.Runtime.Intrinsics.Vector256<long> left, System.Runtime.Intrinsics.Vector256<long> right);
  * public static System.Runtime.Intrinsics.Vector256<ulong> MultiplyLow (System.Runtime.Intrinsics.Vector256<ulong> left, System.Runtime.Intrinsics.Vector256<ulong> right);
  * public static System.Runtime.Intrinsics.Vector128<double> Range (System.Runtime.Intrinsics.Vector128<double> left, System.Runtime.Intrinsics.Vector128<double> right, byte control);
  * public static System.Runtime.Intrinsics.Vector128<float> Range (System.Runtime.Intrinsics.Vector128<float> left, System.Runtime.Intrinsics.Vector128<float> right, byte control);
  * public static System.Runtime.Intrinsics.Vector256<double> Range (System.Runtime.Intrinsics.Vector256<double> left, System.Runtime.Intrinsics.Vector256<double> right, byte control);
  * public static System.Runtime.Intrinsics.Vector256<float> Range (System.Runtime.Intrinsics.Vector256<float> left, System.Runtime.Intrinsics.Vector256<float> right, byte control);
  * public static System.Runtime.Intrinsics.Vector128<double> Reduce (System.Runtime.Intrinsics.Vector128<double> value, byte control);
  * public static System.Runtime.Intrinsics.Vector128<float> Reduce (System.Runtime.Intrinsics.Vector128<float> value, byte control);
  * public static System.Runtime.Intrinsics.Vector256<double> Reduce (System.Runtime.Intrinsics.Vector256<double> value, byte control);
  * public static System.Runtime.Intrinsics.Vector256<float> Reduce (System.Runtime.Intrinsics.Vector256<float> value, byte control);
* System.Runtime.Intrinsics.X86.Avx512DQ+X64
  * public static bool IsSupported { get; }
* System.Runtime.Intrinsics.X86.Avx512DQ
  * public static System.Runtime.Intrinsics.Vector512<double> And (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right);
  * public static System.Runtime.Intrinsics.Vector512<float> And (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right);
  * public static System.Runtime.Intrinsics.Vector512<double> AndNot (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right);
  * public static System.Runtime.Intrinsics.Vector512<float> AndNot (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right);
  * public static System.Runtime.Intrinsics.Vector512<int> BroadcastPairScalarToVector512 (System.Runtime.Intrinsics.Vector128<int> value);
  * public static System.Runtime.Intrinsics.Vector512<float> BroadcastPairScalarToVector512 (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector512<uint> BroadcastPairScalarToVector512 (System.Runtime.Intrinsics.Vector128<uint> value);
  * public static System.Runtime.Intrinsics.Vector512<double> BroadcastVector128ToVector512 (double* address);
  * public static System.Runtime.Intrinsics.Vector512<long> BroadcastVector128ToVector512 (long* address);
  * public static System.Runtime.Intrinsics.Vector512<ulong> BroadcastVector128ToVector512 (ulong* address);
  * public static System.Runtime.Intrinsics.Vector512<int> BroadcastVector256ToVector512 (int* address);
  * public static System.Runtime.Intrinsics.Vector512<float> BroadcastVector256ToVector512 (float* address);
  * public static System.Runtime.Intrinsics.Vector512<uint> BroadcastVector256ToVector512 (uint* address);
  * public static System.Runtime.Intrinsics.Vector256<float> ConvertToVector256Single (System.Runtime.Intrinsics.Vector512<long> value);
  * public static System.Runtime.Intrinsics.Vector256<float> ConvertToVector256Single (System.Runtime.Intrinsics.Vector512<ulong> value);
  * public static System.Runtime.Intrinsics.Vector512<double> ConvertToVector512Double (System.Runtime.Intrinsics.Vector512<long> value);
  * public static System.Runtime.Intrinsics.Vector512<double> ConvertToVector512Double (System.Runtime.Intrinsics.Vector512<ulong> value);
  * public static System.Runtime.Intrinsics.Vector512<long> ConvertToVector512Int64 (System.Runtime.Intrinsics.Vector256<float> value);
  * public static System.Runtime.Intrinsics.Vector512<long> ConvertToVector512Int64 (System.Runtime.Intrinsics.Vector512<double> value);
  * public static System.Runtime.Intrinsics.Vector512<long> ConvertToVector512Int64WithTruncation (System.Runtime.Intrinsics.Vector256<float> value);
  * public static System.Runtime.Intrinsics.Vector512<long> ConvertToVector512Int64WithTruncation (System.Runtime.Intrinsics.Vector512<double> value);
  * public static System.Runtime.Intrinsics.Vector512<ulong> ConvertToVector512UInt64 (System.Runtime.Intrinsics.Vector256<float> value);
  * public static System.Runtime.Intrinsics.Vector512<ulong> ConvertToVector512UInt64 (System.Runtime.Intrinsics.Vector512<double> value);
  * public static System.Runtime.Intrinsics.Vector512<ulong> ConvertToVector512UInt64WithTruncation (System.Runtime.Intrinsics.Vector256<float> value);
  * public static System.Runtime.Intrinsics.Vector512<ulong> ConvertToVector512UInt64WithTruncation (System.Runtime.Intrinsics.Vector512<double> value);
  * public static System.Runtime.Intrinsics.Vector128<double> ExtractVector128 (System.Runtime.Intrinsics.Vector512<double> value, byte index);
  * public static System.Runtime.Intrinsics.Vector128<long> ExtractVector128 (System.Runtime.Intrinsics.Vector512<long> value, byte index);
  * public static System.Runtime.Intrinsics.Vector128<ulong> ExtractVector128 (System.Runtime.Intrinsics.Vector512<ulong> value, byte index);
  * public static System.Runtime.Intrinsics.Vector256<int> ExtractVector256 (System.Runtime.Intrinsics.Vector512<int> value, byte index);
  * public static System.Runtime.Intrinsics.Vector256<float> ExtractVector256 (System.Runtime.Intrinsics.Vector512<float> value, byte index);
  * public static System.Runtime.Intrinsics.Vector256<uint> ExtractVector256 (System.Runtime.Intrinsics.Vector512<uint> value, byte index);
  * public static System.Runtime.Intrinsics.Vector512<double> InsertVector128 (System.Runtime.Intrinsics.Vector512<double> value, System.Runtime.Intrinsics.Vector128<double> data, byte index);
  * public static System.Runtime.Intrinsics.Vector512<long> InsertVector128 (System.Runtime.Intrinsics.Vector512<long> value, System.Runtime.Intrinsics.Vector128<long> data, byte index);
  * public static System.Runtime.Intrinsics.Vector512<ulong> InsertVector128 (System.Runtime.Intrinsics.Vector512<ulong> value, System.Runtime.Intrinsics.Vector128<ulong> data, byte index);
  * public static System.Runtime.Intrinsics.Vector512<int> InsertVector256 (System.Runtime.Intrinsics.Vector512<int> value, System.Runtime.Intrinsics.Vector256<int> data, byte index);
  * public static System.Runtime.Intrinsics.Vector512<float> InsertVector256 (System.Runtime.Intrinsics.Vector512<float> value, System.Runtime.Intrinsics.Vector256<float> data, byte index);
  * public static System.Runtime.Intrinsics.Vector512<uint> InsertVector256 (System.Runtime.Intrinsics.Vector512<uint> value, System.Runtime.Intrinsics.Vector256<uint> data, byte index);
  * public static bool IsSupported { get; }
  * public static System.Runtime.Intrinsics.Vector512<long> MultiplyLow (System.Runtime.Intrinsics.Vector512<long> left, System.Runtime.Intrinsics.Vector512<long> right);
  * public static System.Runtime.Intrinsics.Vector512<ulong> MultiplyLow (System.Runtime.Intrinsics.Vector512<ulong> left, System.Runtime.Intrinsics.Vector512<ulong> right);
  * public static System.Runtime.Intrinsics.Vector512<double> Or (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right);
  * public static System.Runtime.Intrinsics.Vector512<float> Or (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right);
  * public static System.Runtime.Intrinsics.Vector512<double> Range (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right, byte control);
  * public static System.Runtime.Intrinsics.Vector512<float> Range (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right, byte control);
  * public static System.Runtime.Intrinsics.Vector128<double> RangeScalar (System.Runtime.Intrinsics.Vector128<double> left, System.Runtime.Intrinsics.Vector128<double> right, byte control);
  * public static System.Runtime.Intrinsics.Vector128<float> RangeScalar (System.Runtime.Intrinsics.Vector128<float> left, System.Runtime.Intrinsics.Vector128<float> right, byte control);
  * public static System.Runtime.Intrinsics.Vector512<double> Reduce (System.Runtime.Intrinsics.Vector512<double> value, byte control);
  * public static System.Runtime.Intrinsics.Vector512<float> Reduce (System.Runtime.Intrinsics.Vector512<float> value, byte control);
  * public static System.Runtime.Intrinsics.Vector128<double> ReduceScalar (System.Runtime.Intrinsics.Vector128<double> value, byte control);
  * public static System.Runtime.Intrinsics.Vector128<float> ReduceScalar (System.Runtime.Intrinsics.Vector128<float> value, byte control);
  * public static System.Runtime.Intrinsics.Vector128<double> ReduceScalar (System.Runtime.Intrinsics.Vector128<double> upper, System.Runtime.Intrinsics.Vector128<double> value, byte control);
  * public static System.Runtime.Intrinsics.Vector128<float> ReduceScalar (System.Runtime.Intrinsics.Vector128<float> upper, System.Runtime.Intrinsics.Vector128<float> value, byte control);
  * public static System.Runtime.Intrinsics.Vector512<double> Xor (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right);
  * public static System.Runtime.Intrinsics.Vector512<float> Xor (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right);
* System.Runtime.Intrinsics.X86.Avx512F+VL
  * public static System.Runtime.Intrinsics.Vector128<ulong> Abs (System.Runtime.Intrinsics.Vector128<long> value);
  * public static System.Runtime.Intrinsics.Vector256<ulong> Abs (System.Runtime.Intrinsics.Vector256<long> value);
  * public static System.Runtime.Intrinsics.Vector128<int> AlignRight32 (System.Runtime.Intrinsics.Vector128<int> left, System.Runtime.Intrinsics.Vector128<int> right, byte mask);
  * public static System.Runtime.Intrinsics.Vector128<uint> AlignRight32 (System.Runtime.Intrinsics.Vector128<uint> left, System.Runtime.Intrinsics.Vector128<uint> right, byte mask);
  * public static System.Runtime.Intrinsics.Vector256<int> AlignRight32 (System.Runtime.Intrinsics.Vector256<int> left, System.Runtime.Intrinsics.Vector256<int> right, byte mask);
  * public static System.Runtime.Intrinsics.Vector256<uint> AlignRight32 (System.Runtime.Intrinsics.Vector256<uint> left, System.Runtime.Intrinsics.Vector256<uint> right, byte mask);
  * public static System.Runtime.Intrinsics.Vector128<long> AlignRight64 (System.Runtime.Intrinsics.Vector128<long> left, System.Runtime.Intrinsics.Vector128<long> right, byte mask);
  * public static System.Runtime.Intrinsics.Vector128<ulong> AlignRight64 (System.Runtime.Intrinsics.Vector128<ulong> left, System.Runtime.Intrinsics.Vector128<ulong> right, byte mask);
  * public static System.Runtime.Intrinsics.Vector256<long> AlignRight64 (System.Runtime.Intrinsics.Vector256<long> left, System.Runtime.Intrinsics.Vector256<long> right, byte mask);
  * public static System.Runtime.Intrinsics.Vector256<ulong> AlignRight64 (System.Runtime.Intrinsics.Vector256<ulong> left, System.Runtime.Intrinsics.Vector256<ulong> right, byte mask);
  * public static System.Runtime.Intrinsics.Vector128<uint> CompareGreaterThan (System.Runtime.Intrinsics.Vector128<uint> left, System.Runtime.Intrinsics.Vector128<uint> right);
  * public static System.Runtime.Intrinsics.Vector128<ulong> CompareGreaterThan (System.Runtime.Intrinsics.Vector128<ulong> left, System.Runtime.Intrinsics.Vector128<ulong> right);
  * public static System.Runtime.Intrinsics.Vector256<uint> CompareGreaterThan (System.Runtime.Intrinsics.Vector256<uint> left, System.Runtime.Intrinsics.Vector256<uint> right);
  * public static System.Runtime.Intrinsics.Vector256<ulong> CompareGreaterThan (System.Runtime.Intrinsics.Vector256<ulong> left, System.Runtime.Intrinsics.Vector256<ulong> right);
  * public static System.Runtime.Intrinsics.Vector128<int> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector128<int> left, System.Runtime.Intrinsics.Vector128<int> right);
  * public static System.Runtime.Intrinsics.Vector128<long> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector128<long> left, System.Runtime.Intrinsics.Vector128<long> right);
  * public static System.Runtime.Intrinsics.Vector128<uint> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector128<uint> left, System.Runtime.Intrinsics.Vector128<uint> right);
  * public static System.Runtime.Intrinsics.Vector128<ulong> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector128<ulong> left, System.Runtime.Intrinsics.Vector128<ulong> right);
  * public static System.Runtime.Intrinsics.Vector256<int> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector256<int> left, System.Runtime.Intrinsics.Vector256<int> right);
  * public static System.Runtime.Intrinsics.Vector256<long> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector256<long> left, System.Runtime.Intrinsics.Vector256<long> right);
  * public static System.Runtime.Intrinsics.Vector256<uint> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector256<uint> left, System.Runtime.Intrinsics.Vector256<uint> right);
  * public static System.Runtime.Intrinsics.Vector256<ulong> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector256<ulong> left, System.Runtime.Intrinsics.Vector256<ulong> right);
  * public static System.Runtime.Intrinsics.Vector128<int> CompareLessThan (System.Runtime.Intrinsics.Vector128<int> left, System.Runtime.Intrinsics.Vector128<int> right);
  * public static System.Runtime.Intrinsics.Vector128<long> CompareLessThan (System.Runtime.Intrinsics.Vector128<long> left, System.Runtime.Intrinsics.Vector128<long> right);
  * public static System.Runtime.Intrinsics.Vector128<uint> CompareLessThan (System.Runtime.Intrinsics.Vector128<uint> left, System.Runtime.Intrinsics.Vector128<uint> right);
  * public static System.Runtime.Intrinsics.Vector128<ulong> CompareLessThan (System.Runtime.Intrinsics.Vector128<ulong> left, System.Runtime.Intrinsics.Vector128<ulong> right);
  * public static System.Runtime.Intrinsics.Vector256<int> CompareLessThan (System.Runtime.Intrinsics.Vector256<int> left, System.Runtime.Intrinsics.Vector256<int> right);
  * public static System.Runtime.Intrinsics.Vector256<long> CompareLessThan (System.Runtime.Intrinsics.Vector256<long> left, System.Runtime.Intrinsics.Vector256<long> right);
  * public static System.Runtime.Intrinsics.Vector256<uint> CompareLessThan (System.Runtime.Intrinsics.Vector256<uint> left, System.Runtime.Intrinsics.Vector256<uint> right);
  * public static System.Runtime.Intrinsics.Vector256<ulong> CompareLessThan (System.Runtime.Intrinsics.Vector256<ulong> left, System.Runtime.Intrinsics.Vector256<ulong> right);
  * public static System.Runtime.Intrinsics.Vector128<int> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector128<int> left, System.Runtime.Intrinsics.Vector128<int> right);
  * public static System.Runtime.Intrinsics.Vector128<long> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector128<long> left, System.Runtime.Intrinsics.Vector128<long> right);
  * public static System.Runtime.Intrinsics.Vector128<uint> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector128<uint> left, System.Runtime.Intrinsics.Vector128<uint> right);
  * public static System.Runtime.Intrinsics.Vector128<ulong> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector128<ulong> left, System.Runtime.Intrinsics.Vector128<ulong> right);
  * public static System.Runtime.Intrinsics.Vector256<int> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector256<int> left, System.Runtime.Intrinsics.Vector256<int> right);
  * public static System.Runtime.Intrinsics.Vector256<long> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector256<long> left, System.Runtime.Intrinsics.Vector256<long> right);
  * public static System.Runtime.Intrinsics.Vector256<uint> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector256<uint> left, System.Runtime.Intrinsics.Vector256<uint> right);
  * public static System.Runtime.Intrinsics.Vector256<ulong> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector256<ulong> left, System.Runtime.Intrinsics.Vector256<ulong> right);
  * public static System.Runtime.Intrinsics.Vector128<int> CompareNotEqual (System.Runtime.Intrinsics.Vector128<int> left, System.Runtime.Intrinsics.Vector128<int> right);
  * public static System.Runtime.Intrinsics.Vector128<long> CompareNotEqual (System.Runtime.Intrinsics.Vector128<long> left, System.Runtime.Intrinsics.Vector128<long> right);
  * public static System.Runtime.Intrinsics.Vector128<uint> CompareNotEqual (System.Runtime.Intrinsics.Vector128<uint> left, System.Runtime.Intrinsics.Vector128<uint> right);
  * public static System.Runtime.Intrinsics.Vector128<ulong> CompareNotEqual (System.Runtime.Intrinsics.Vector128<ulong> left, System.Runtime.Intrinsics.Vector128<ulong> right);
  * public static System.Runtime.Intrinsics.Vector256<int> CompareNotEqual (System.Runtime.Intrinsics.Vector256<int> left, System.Runtime.Intrinsics.Vector256<int> right);
  * public static System.Runtime.Intrinsics.Vector256<long> CompareNotEqual (System.Runtime.Intrinsics.Vector256<long> left, System.Runtime.Intrinsics.Vector256<long> right);
  * public static System.Runtime.Intrinsics.Vector256<uint> CompareNotEqual (System.Runtime.Intrinsics.Vector256<uint> left, System.Runtime.Intrinsics.Vector256<uint> right);
  * public static System.Runtime.Intrinsics.Vector256<ulong> CompareNotEqual (System.Runtime.Intrinsics.Vector256<ulong> left, System.Runtime.Intrinsics.Vector256<ulong> right);
  * public static System.Runtime.Intrinsics.Vector128<byte> ConvertToVector128Byte (System.Runtime.Intrinsics.Vector128<int> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> ConvertToVector128Byte (System.Runtime.Intrinsics.Vector128<long> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> ConvertToVector128Byte (System.Runtime.Intrinsics.Vector128<uint> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> ConvertToVector128Byte (System.Runtime.Intrinsics.Vector128<ulong> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> ConvertToVector128Byte (System.Runtime.Intrinsics.Vector256<int> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> ConvertToVector128Byte (System.Runtime.Intrinsics.Vector256<long> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> ConvertToVector128Byte (System.Runtime.Intrinsics.Vector256<uint> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> ConvertToVector128Byte (System.Runtime.Intrinsics.Vector256<ulong> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> ConvertToVector128ByteWithSaturation (System.Runtime.Intrinsics.Vector128<uint> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> ConvertToVector128ByteWithSaturation (System.Runtime.Intrinsics.Vector128<ulong> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> ConvertToVector128ByteWithSaturation (System.Runtime.Intrinsics.Vector256<uint> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> ConvertToVector128ByteWithSaturation (System.Runtime.Intrinsics.Vector256<ulong> value);
  * public static System.Runtime.Intrinsics.Vector128<double> ConvertToVector128Double (System.Runtime.Intrinsics.Vector128<uint> value);
  * public static System.Runtime.Intrinsics.Vector128<short> ConvertToVector128Int16 (System.Runtime.Intrinsics.Vector128<int> value);
  * public static System.Runtime.Intrinsics.Vector128<short> ConvertToVector128Int16 (System.Runtime.Intrinsics.Vector128<long> value);
  * public static System.Runtime.Intrinsics.Vector128<short> ConvertToVector128Int16 (System.Runtime.Intrinsics.Vector128<uint> value);
  * public static System.Runtime.Intrinsics.Vector128<short> ConvertToVector128Int16 (System.Runtime.Intrinsics.Vector128<ulong> value);
  * public static System.Runtime.Intrinsics.Vector128<short> ConvertToVector128Int16 (System.Runtime.Intrinsics.Vector256<int> value);
  * public static System.Runtime.Intrinsics.Vector128<short> ConvertToVector128Int16 (System.Runtime.Intrinsics.Vector256<long> value);
  * public static System.Runtime.Intrinsics.Vector128<short> ConvertToVector128Int16 (System.Runtime.Intrinsics.Vector256<uint> value);
  * public static System.Runtime.Intrinsics.Vector128<short> ConvertToVector128Int16 (System.Runtime.Intrinsics.Vector256<ulong> value);
  * public static System.Runtime.Intrinsics.Vector128<short> ConvertToVector128Int16WithSaturation (System.Runtime.Intrinsics.Vector128<int> value);
  * public static System.Runtime.Intrinsics.Vector128<short> ConvertToVector128Int16WithSaturation (System.Runtime.Intrinsics.Vector128<long> value);
  * public static System.Runtime.Intrinsics.Vector128<short> ConvertToVector128Int16WithSaturation (System.Runtime.Intrinsics.Vector256<int> value);
  * public static System.Runtime.Intrinsics.Vector128<short> ConvertToVector128Int16WithSaturation (System.Runtime.Intrinsics.Vector256<long> value);
  * public static System.Runtime.Intrinsics.Vector128<int> ConvertToVector128Int32 (System.Runtime.Intrinsics.Vector128<long> value);
  * public static System.Runtime.Intrinsics.Vector128<int> ConvertToVector128Int32 (System.Runtime.Intrinsics.Vector128<ulong> value);
  * public static System.Runtime.Intrinsics.Vector128<int> ConvertToVector128Int32 (System.Runtime.Intrinsics.Vector256<long> value);
  * public static System.Runtime.Intrinsics.Vector128<int> ConvertToVector128Int32 (System.Runtime.Intrinsics.Vector256<ulong> value);
  * public static System.Runtime.Intrinsics.Vector128<int> ConvertToVector128Int32WithSaturation (System.Runtime.Intrinsics.Vector128<long> value);
  * public static System.Runtime.Intrinsics.Vector128<int> ConvertToVector128Int32WithSaturation (System.Runtime.Intrinsics.Vector256<long> value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ConvertToVector128SByte (System.Runtime.Intrinsics.Vector128<int> value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ConvertToVector128SByte (System.Runtime.Intrinsics.Vector128<long> value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ConvertToVector128SByte (System.Runtime.Intrinsics.Vector128<uint> value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ConvertToVector128SByte (System.Runtime.Intrinsics.Vector128<ulong> value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ConvertToVector128SByte (System.Runtime.Intrinsics.Vector256<int> value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ConvertToVector128SByte (System.Runtime.Intrinsics.Vector256<long> value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ConvertToVector128SByte (System.Runtime.Intrinsics.Vector256<uint> value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ConvertToVector128SByte (System.Runtime.Intrinsics.Vector256<ulong> value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ConvertToVector128SByteWithSaturation (System.Runtime.Intrinsics.Vector128<int> value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ConvertToVector128SByteWithSaturation (System.Runtime.Intrinsics.Vector128<long> value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ConvertToVector128SByteWithSaturation (System.Runtime.Intrinsics.Vector256<int> value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ConvertToVector128SByteWithSaturation (System.Runtime.Intrinsics.Vector256<long> value);
  * public static System.Runtime.Intrinsics.Vector128<float> ConvertToVector128Single (System.Runtime.Intrinsics.Vector128<uint> value);
  * public static System.Runtime.Intrinsics.Vector128<ushort> ConvertToVector128UInt16 (System.Runtime.Intrinsics.Vector128<int> value);
  * public static System.Runtime.Intrinsics.Vector128<ushort> ConvertToVector128UInt16 (System.Runtime.Intrinsics.Vector128<long> value);
  * public static System.Runtime.Intrinsics.Vector128<ushort> ConvertToVector128UInt16 (System.Runtime.Intrinsics.Vector128<uint> value);
  * public static System.Runtime.Intrinsics.Vector128<ushort> ConvertToVector128UInt16 (System.Runtime.Intrinsics.Vector128<ulong> value);
  * public static System.Runtime.Intrinsics.Vector128<ushort> ConvertToVector128UInt16 (System.Runtime.Intrinsics.Vector256<int> value);
  * public static System.Runtime.Intrinsics.Vector128<ushort> ConvertToVector128UInt16 (System.Runtime.Intrinsics.Vector256<long> value);
  * public static System.Runtime.Intrinsics.Vector128<ushort> ConvertToVector128UInt16 (System.Runtime.Intrinsics.Vector256<uint> value);
  * public static System.Runtime.Intrinsics.Vector128<ushort> ConvertToVector128UInt16 (System.Runtime.Intrinsics.Vector256<ulong> value);
  * public static System.Runtime.Intrinsics.Vector128<ushort> ConvertToVector128UInt16WithSaturation (System.Runtime.Intrinsics.Vector128<uint> value);
  * public static System.Runtime.Intrinsics.Vector128<ushort> ConvertToVector128UInt16WithSaturation (System.Runtime.Intrinsics.Vector128<ulong> value);
  * public static System.Runtime.Intrinsics.Vector128<ushort> ConvertToVector128UInt16WithSaturation (System.Runtime.Intrinsics.Vector256<uint> value);
  * public static System.Runtime.Intrinsics.Vector128<ushort> ConvertToVector128UInt16WithSaturation (System.Runtime.Intrinsics.Vector256<ulong> value);
  * public static System.Runtime.Intrinsics.Vector128<uint> ConvertToVector128UInt32 (System.Runtime.Intrinsics.Vector128<double> value);
  * public static System.Runtime.Intrinsics.Vector128<uint> ConvertToVector128UInt32 (System.Runtime.Intrinsics.Vector128<long> value);
  * public static System.Runtime.Intrinsics.Vector128<uint> ConvertToVector128UInt32 (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector128<uint> ConvertToVector128UInt32 (System.Runtime.Intrinsics.Vector128<ulong> value);
  * public static System.Runtime.Intrinsics.Vector128<uint> ConvertToVector128UInt32 (System.Runtime.Intrinsics.Vector256<double> value);
  * public static System.Runtime.Intrinsics.Vector128<uint> ConvertToVector128UInt32 (System.Runtime.Intrinsics.Vector256<long> value);
  * public static System.Runtime.Intrinsics.Vector128<uint> ConvertToVector128UInt32 (System.Runtime.Intrinsics.Vector256<ulong> value);
  * public static System.Runtime.Intrinsics.Vector128<uint> ConvertToVector128UInt32WithSaturation (System.Runtime.Intrinsics.Vector128<ulong> value);
  * public static System.Runtime.Intrinsics.Vector128<uint> ConvertToVector128UInt32WithSaturation (System.Runtime.Intrinsics.Vector256<ulong> value);
  * public static System.Runtime.Intrinsics.Vector128<uint> ConvertToVector128UInt32WithTruncation (System.Runtime.Intrinsics.Vector128<double> value);
  * public static System.Runtime.Intrinsics.Vector128<uint> ConvertToVector128UInt32WithTruncation (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector128<uint> ConvertToVector128UInt32WithTruncation (System.Runtime.Intrinsics.Vector256<double> value);
  * public static System.Runtime.Intrinsics.Vector256<double> ConvertToVector256Double (System.Runtime.Intrinsics.Vector128<uint> value);
  * public static System.Runtime.Intrinsics.Vector256<float> ConvertToVector256Single (System.Runtime.Intrinsics.Vector256<uint> value);
  * public static System.Runtime.Intrinsics.Vector256<uint> ConvertToVector256UInt32 (System.Runtime.Intrinsics.Vector256<float> value);
  * public static System.Runtime.Intrinsics.Vector256<uint> ConvertToVector256UInt32WithTruncation (System.Runtime.Intrinsics.Vector256<float> value);
  * public static System.Runtime.Intrinsics.Vector128<double> Fixup (System.Runtime.Intrinsics.Vector128<double> left, System.Runtime.Intrinsics.Vector128<double> right, System.Runtime.Intrinsics.Vector128<long> table, byte control);
  * public static System.Runtime.Intrinsics.Vector128<float> Fixup (System.Runtime.Intrinsics.Vector128<float> left, System.Runtime.Intrinsics.Vector128<float> right, System.Runtime.Intrinsics.Vector128<int> table, byte control);
  * public static System.Runtime.Intrinsics.Vector256<double> Fixup (System.Runtime.Intrinsics.Vector256<double> left, System.Runtime.Intrinsics.Vector256<double> right, System.Runtime.Intrinsics.Vector256<long> table, byte control);
  * public static System.Runtime.Intrinsics.Vector256<float> Fixup (System.Runtime.Intrinsics.Vector256<float> left, System.Runtime.Intrinsics.Vector256<float> right, System.Runtime.Intrinsics.Vector256<int> table, byte control);
  * public static System.Runtime.Intrinsics.Vector128<double> GetExponent (System.Runtime.Intrinsics.Vector128<double> value);
  * public static System.Runtime.Intrinsics.Vector128<float> GetExponent (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector256<double> GetExponent (System.Runtime.Intrinsics.Vector256<double> value);
  * public static System.Runtime.Intrinsics.Vector256<float> GetExponent (System.Runtime.Intrinsics.Vector256<float> value);
  * public static System.Runtime.Intrinsics.Vector128<double> GetMantissa (System.Runtime.Intrinsics.Vector128<double> value, byte control);
  * public static System.Runtime.Intrinsics.Vector128<float> GetMantissa (System.Runtime.Intrinsics.Vector128<float> value, byte control);
  * public static System.Runtime.Intrinsics.Vector256<double> GetMantissa (System.Runtime.Intrinsics.Vector256<double> value, byte control);
  * public static System.Runtime.Intrinsics.Vector256<float> GetMantissa (System.Runtime.Intrinsics.Vector256<float> value, byte control);
  * public static bool IsSupported { get; }
  * public static System.Runtime.Intrinsics.Vector128<long> Max (System.Runtime.Intrinsics.Vector128<long> left, System.Runtime.Intrinsics.Vector128<long> right);
  * public static System.Runtime.Intrinsics.Vector128<ulong> Max (System.Runtime.Intrinsics.Vector128<ulong> left, System.Runtime.Intrinsics.Vector128<ulong> right);
  * public static System.Runtime.Intrinsics.Vector256<long> Max (System.Runtime.Intrinsics.Vector256<long> left, System.Runtime.Intrinsics.Vector256<long> right);
  * public static System.Runtime.Intrinsics.Vector256<ulong> Max (System.Runtime.Intrinsics.Vector256<ulong> left, System.Runtime.Intrinsics.Vector256<ulong> right);
  * public static System.Runtime.Intrinsics.Vector128<long> Min (System.Runtime.Intrinsics.Vector128<long> left, System.Runtime.Intrinsics.Vector128<long> right);
  * public static System.Runtime.Intrinsics.Vector128<ulong> Min (System.Runtime.Intrinsics.Vector128<ulong> left, System.Runtime.Intrinsics.Vector128<ulong> right);
  * public static System.Runtime.Intrinsics.Vector256<long> Min (System.Runtime.Intrinsics.Vector256<long> left, System.Runtime.Intrinsics.Vector256<long> right);
  * public static System.Runtime.Intrinsics.Vector256<ulong> Min (System.Runtime.Intrinsics.Vector256<ulong> left, System.Runtime.Intrinsics.Vector256<ulong> right);
  * public static System.Runtime.Intrinsics.Vector128<double> PermuteVar2x64x2 (System.Runtime.Intrinsics.Vector128<double> lower, System.Runtime.Intrinsics.Vector128<long> indices, System.Runtime.Intrinsics.Vector128<double> upper);
  * public static System.Runtime.Intrinsics.Vector128<long> PermuteVar2x64x2 (System.Runtime.Intrinsics.Vector128<long> lower, System.Runtime.Intrinsics.Vector128<long> indices, System.Runtime.Intrinsics.Vector128<long> upper);
  * public static System.Runtime.Intrinsics.Vector128<ulong> PermuteVar2x64x2 (System.Runtime.Intrinsics.Vector128<ulong> lower, System.Runtime.Intrinsics.Vector128<ulong> indices, System.Runtime.Intrinsics.Vector128<ulong> upper);
  * public static System.Runtime.Intrinsics.Vector128<int> PermuteVar4x32x2 (System.Runtime.Intrinsics.Vector128<int> lower, System.Runtime.Intrinsics.Vector128<int> indices, System.Runtime.Intrinsics.Vector128<int> upper);
  * public static System.Runtime.Intrinsics.Vector128<float> PermuteVar4x32x2 (System.Runtime.Intrinsics.Vector128<float> lower, System.Runtime.Intrinsics.Vector128<int> indices, System.Runtime.Intrinsics.Vector128<float> upper);
  * public static System.Runtime.Intrinsics.Vector128<uint> PermuteVar4x32x2 (System.Runtime.Intrinsics.Vector128<uint> lower, System.Runtime.Intrinsics.Vector128<uint> indices, System.Runtime.Intrinsics.Vector128<uint> upper);
  * public static System.Runtime.Intrinsics.Vector256<double> PermuteVar4x64 (System.Runtime.Intrinsics.Vector256<double> value, System.Runtime.Intrinsics.Vector256<long> control);
  * public static System.Runtime.Intrinsics.Vector256<long> PermuteVar4x64 (System.Runtime.Intrinsics.Vector256<long> value, System.Runtime.Intrinsics.Vector256<long> control);
  * public static System.Runtime.Intrinsics.Vector256<ulong> PermuteVar4x64 (System.Runtime.Intrinsics.Vector256<ulong> value, System.Runtime.Intrinsics.Vector256<ulong> control);
  * public static System.Runtime.Intrinsics.Vector256<double> PermuteVar4x64x2 (System.Runtime.Intrinsics.Vector256<double> lower, System.Runtime.Intrinsics.Vector256<long> indices, System.Runtime.Intrinsics.Vector256<double> upper);
  * public static System.Runtime.Intrinsics.Vector256<long> PermuteVar4x64x2 (System.Runtime.Intrinsics.Vector256<long> lower, System.Runtime.Intrinsics.Vector256<long> indices, System.Runtime.Intrinsics.Vector256<long> upper);
  * public static System.Runtime.Intrinsics.Vector256<ulong> PermuteVar4x64x2 (System.Runtime.Intrinsics.Vector256<ulong> lower, System.Runtime.Intrinsics.Vector256<ulong> indices, System.Runtime.Intrinsics.Vector256<ulong> upper);
  * public static System.Runtime.Intrinsics.Vector256<int> PermuteVar8x32x2 (System.Runtime.Intrinsics.Vector256<int> lower, System.Runtime.Intrinsics.Vector256<int> indices, System.Runtime.Intrinsics.Vector256<int> upper);
  * public static System.Runtime.Intrinsics.Vector256<float> PermuteVar8x32x2 (System.Runtime.Intrinsics.Vector256<float> lower, System.Runtime.Intrinsics.Vector256<int> indices, System.Runtime.Intrinsics.Vector256<float> upper);
  * public static System.Runtime.Intrinsics.Vector256<uint> PermuteVar8x32x2 (System.Runtime.Intrinsics.Vector256<uint> lower, System.Runtime.Intrinsics.Vector256<uint> indices, System.Runtime.Intrinsics.Vector256<uint> upper);
  * public static System.Runtime.Intrinsics.Vector128<double> Reciprocal14 (System.Runtime.Intrinsics.Vector128<double> value);
  * public static System.Runtime.Intrinsics.Vector128<float> Reciprocal14 (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector256<double> Reciprocal14 (System.Runtime.Intrinsics.Vector256<double> value);
  * public static System.Runtime.Intrinsics.Vector256<float> Reciprocal14 (System.Runtime.Intrinsics.Vector256<float> value);
  * public static System.Runtime.Intrinsics.Vector128<double> ReciprocalSqrt14 (System.Runtime.Intrinsics.Vector128<double> value);
  * public static System.Runtime.Intrinsics.Vector128<float> ReciprocalSqrt14 (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector256<double> ReciprocalSqrt14 (System.Runtime.Intrinsics.Vector256<double> value);
  * public static System.Runtime.Intrinsics.Vector256<float> ReciprocalSqrt14 (System.Runtime.Intrinsics.Vector256<float> value);
  * public static System.Runtime.Intrinsics.Vector128<int> RotateLeft (System.Runtime.Intrinsics.Vector128<int> value, byte count);
  * public static System.Runtime.Intrinsics.Vector128<long> RotateLeft (System.Runtime.Intrinsics.Vector128<long> value, byte count);
  * public static System.Runtime.Intrinsics.Vector128<uint> RotateLeft (System.Runtime.Intrinsics.Vector128<uint> value, byte count);
  * public static System.Runtime.Intrinsics.Vector128<ulong> RotateLeft (System.Runtime.Intrinsics.Vector128<ulong> value, byte count);
  * public static System.Runtime.Intrinsics.Vector256<int> RotateLeft (System.Runtime.Intrinsics.Vector256<int> value, byte count);
  * public static System.Runtime.Intrinsics.Vector256<long> RotateLeft (System.Runtime.Intrinsics.Vector256<long> value, byte count);
  * public static System.Runtime.Intrinsics.Vector256<uint> RotateLeft (System.Runtime.Intrinsics.Vector256<uint> value, byte count);
  * public static System.Runtime.Intrinsics.Vector256<ulong> RotateLeft (System.Runtime.Intrinsics.Vector256<ulong> value, byte count);
  * public static System.Runtime.Intrinsics.Vector128<int> RotateLeftVariable (System.Runtime.Intrinsics.Vector128<int> value, System.Runtime.Intrinsics.Vector128<uint> count);
  * public static System.Runtime.Intrinsics.Vector128<long> RotateLeftVariable (System.Runtime.Intrinsics.Vector128<long> value, System.Runtime.Intrinsics.Vector128<ulong> count);
  * public static System.Runtime.Intrinsics.Vector128<uint> RotateLeftVariable (System.Runtime.Intrinsics.Vector128<uint> value, System.Runtime.Intrinsics.Vector128<uint> count);
  * public static System.Runtime.Intrinsics.Vector128<ulong> RotateLeftVariable (System.Runtime.Intrinsics.Vector128<ulong> value, System.Runtime.Intrinsics.Vector128<ulong> count);
  * public static System.Runtime.Intrinsics.Vector256<int> RotateLeftVariable (System.Runtime.Intrinsics.Vector256<int> value, System.Runtime.Intrinsics.Vector256<uint> count);
  * public static System.Runtime.Intrinsics.Vector256<long> RotateLeftVariable (System.Runtime.Intrinsics.Vector256<long> value, System.Runtime.Intrinsics.Vector256<ulong> count);
  * public static System.Runtime.Intrinsics.Vector256<uint> RotateLeftVariable (System.Runtime.Intrinsics.Vector256<uint> value, System.Runtime.Intrinsics.Vector256<uint> count);
  * public static System.Runtime.Intrinsics.Vector256<ulong> RotateLeftVariable (System.Runtime.Intrinsics.Vector256<ulong> value, System.Runtime.Intrinsics.Vector256<ulong> count);
  * public static System.Runtime.Intrinsics.Vector128<int> RotateRight (System.Runtime.Intrinsics.Vector128<int> value, byte count);
  * public static System.Runtime.Intrinsics.Vector128<long> RotateRight (System.Runtime.Intrinsics.Vector128<long> value, byte count);
  * public static System.Runtime.Intrinsics.Vector128<uint> RotateRight (System.Runtime.Intrinsics.Vector128<uint> value, byte count);
  * public static System.Runtime.Intrinsics.Vector128<ulong> RotateRight (System.Runtime.Intrinsics.Vector128<ulong> value, byte count);
  * public static System.Runtime.Intrinsics.Vector256<int> RotateRight (System.Runtime.Intrinsics.Vector256<int> value, byte count);
  * public static System.Runtime.Intrinsics.Vector256<long> RotateRight (System.Runtime.Intrinsics.Vector256<long> value, byte count);
  * public static System.Runtime.Intrinsics.Vector256<uint> RotateRight (System.Runtime.Intrinsics.Vector256<uint> value, byte count);
  * public static System.Runtime.Intrinsics.Vector256<ulong> RotateRight (System.Runtime.Intrinsics.Vector256<ulong> value, byte count);
  * public static System.Runtime.Intrinsics.Vector128<int> RotateRightVariable (System.Runtime.Intrinsics.Vector128<int> value, System.Runtime.Intrinsics.Vector128<uint> count);
  * public static System.Runtime.Intrinsics.Vector128<long> RotateRightVariable (System.Runtime.Intrinsics.Vector128<long> value, System.Runtime.Intrinsics.Vector128<ulong> count);
  * public static System.Runtime.Intrinsics.Vector128<uint> RotateRightVariable (System.Runtime.Intrinsics.Vector128<uint> value, System.Runtime.Intrinsics.Vector128<uint> count);
  * public static System.Runtime.Intrinsics.Vector128<ulong> RotateRightVariable (System.Runtime.Intrinsics.Vector128<ulong> value, System.Runtime.Intrinsics.Vector128<ulong> count);
  * public static System.Runtime.Intrinsics.Vector256<int> RotateRightVariable (System.Runtime.Intrinsics.Vector256<int> value, System.Runtime.Intrinsics.Vector256<uint> count);
  * public static System.Runtime.Intrinsics.Vector256<long> RotateRightVariable (System.Runtime.Intrinsics.Vector256<long> value, System.Runtime.Intrinsics.Vector256<ulong> count);
  * public static System.Runtime.Intrinsics.Vector256<uint> RotateRightVariable (System.Runtime.Intrinsics.Vector256<uint> value, System.Runtime.Intrinsics.Vector256<uint> count);
  * public static System.Runtime.Intrinsics.Vector256<ulong> RotateRightVariable (System.Runtime.Intrinsics.Vector256<ulong> value, System.Runtime.Intrinsics.Vector256<ulong> count);
  * public static System.Runtime.Intrinsics.Vector128<double> RoundScale (System.Runtime.Intrinsics.Vector128<double> value, byte control);
  * public static System.Runtime.Intrinsics.Vector128<float> RoundScale (System.Runtime.Intrinsics.Vector128<float> value, byte control);
  * public static System.Runtime.Intrinsics.Vector256<double> RoundScale (System.Runtime.Intrinsics.Vector256<double> value, byte control);
  * public static System.Runtime.Intrinsics.Vector256<float> RoundScale (System.Runtime.Intrinsics.Vector256<float> value, byte control);
  * public static System.Runtime.Intrinsics.Vector128<double> Scale (System.Runtime.Intrinsics.Vector128<double> left, System.Runtime.Intrinsics.Vector128<double> right);
  * public static System.Runtime.Intrinsics.Vector128<float> Scale (System.Runtime.Intrinsics.Vector128<float> left, System.Runtime.Intrinsics.Vector128<float> right);
  * public static System.Runtime.Intrinsics.Vector256<double> Scale (System.Runtime.Intrinsics.Vector256<double> left, System.Runtime.Intrinsics.Vector256<double> right);
  * public static System.Runtime.Intrinsics.Vector256<float> Scale (System.Runtime.Intrinsics.Vector256<float> left, System.Runtime.Intrinsics.Vector256<float> right);
  * public static System.Runtime.Intrinsics.Vector128<long> ShiftRightArithmetic (System.Runtime.Intrinsics.Vector128<long> value, byte count);
  * public static System.Runtime.Intrinsics.Vector128<long> ShiftRightArithmetic (System.Runtime.Intrinsics.Vector128<long> value, System.Runtime.Intrinsics.Vector128<long> count);
  * public static System.Runtime.Intrinsics.Vector256<long> ShiftRightArithmetic (System.Runtime.Intrinsics.Vector256<long> value, byte count);
  * public static System.Runtime.Intrinsics.Vector256<long> ShiftRightArithmetic (System.Runtime.Intrinsics.Vector256<long> value, System.Runtime.Intrinsics.Vector128<long> count);
  * public static System.Runtime.Intrinsics.Vector128<long> ShiftRightArithmeticVariable (System.Runtime.Intrinsics.Vector128<long> value, System.Runtime.Intrinsics.Vector128<ulong> count);
  * public static System.Runtime.Intrinsics.Vector256<long> ShiftRightArithmeticVariable (System.Runtime.Intrinsics.Vector256<long> value, System.Runtime.Intrinsics.Vector256<ulong> count);
  * public static System.Runtime.Intrinsics.Vector256<double> Shuffle2x128 (System.Runtime.Intrinsics.Vector256<double> left, System.Runtime.Intrinsics.Vector256<double> right, byte control);
  * public static System.Runtime.Intrinsics.Vector256<int> Shuffle2x128 (System.Runtime.Intrinsics.Vector256<int> left, System.Runtime.Intrinsics.Vector256<int> right, byte control);
  * public static System.Runtime.Intrinsics.Vector256<long> Shuffle2x128 (System.Runtime.Intrinsics.Vector256<long> left, System.Runtime.Intrinsics.Vector256<long> right, byte control);
  * public static System.Runtime.Intrinsics.Vector256<float> Shuffle2x128 (System.Runtime.Intrinsics.Vector256<float> left, System.Runtime.Intrinsics.Vector256<float> right, byte control);
  * public static System.Runtime.Intrinsics.Vector256<uint> Shuffle2x128 (System.Runtime.Intrinsics.Vector256<uint> left, System.Runtime.Intrinsics.Vector256<uint> right, byte control);
  * public static System.Runtime.Intrinsics.Vector256<ulong> Shuffle2x128 (System.Runtime.Intrinsics.Vector256<ulong> left, System.Runtime.Intrinsics.Vector256<ulong> right, byte control);
  * public static System.Runtime.Intrinsics.Vector128<byte> TernaryLogic (System.Runtime.Intrinsics.Vector128<byte> a, System.Runtime.Intrinsics.Vector128<byte> b, System.Runtime.Intrinsics.Vector128<byte> c, byte control);
  * public static System.Runtime.Intrinsics.Vector128<double> TernaryLogic (System.Runtime.Intrinsics.Vector128<double> a, System.Runtime.Intrinsics.Vector128<double> b, System.Runtime.Intrinsics.Vector128<double> c, byte control);
  * public static System.Runtime.Intrinsics.Vector128<short> TernaryLogic (System.Runtime.Intrinsics.Vector128<short> a, System.Runtime.Intrinsics.Vector128<short> b, System.Runtime.Intrinsics.Vector128<short> c, byte control);
  * public static System.Runtime.Intrinsics.Vector128<int> TernaryLogic (System.Runtime.Intrinsics.Vector128<int> a, System.Runtime.Intrinsics.Vector128<int> b, System.Runtime.Intrinsics.Vector128<int> c, byte control);
  * public static System.Runtime.Intrinsics.Vector128<long> TernaryLogic (System.Runtime.Intrinsics.Vector128<long> a, System.Runtime.Intrinsics.Vector128<long> b, System.Runtime.Intrinsics.Vector128<long> c, byte control);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> TernaryLogic (System.Runtime.Intrinsics.Vector128<sbyte> a, System.Runtime.Intrinsics.Vector128<sbyte> b, System.Runtime.Intrinsics.Vector128<sbyte> c, byte control);
  * public static System.Runtime.Intrinsics.Vector128<float> TernaryLogic (System.Runtime.Intrinsics.Vector128<float> a, System.Runtime.Intrinsics.Vector128<float> b, System.Runtime.Intrinsics.Vector128<float> c, byte control);
  * public static System.Runtime.Intrinsics.Vector128<ushort> TernaryLogic (System.Runtime.Intrinsics.Vector128<ushort> a, System.Runtime.Intrinsics.Vector128<ushort> b, System.Runtime.Intrinsics.Vector128<ushort> c, byte control);
  * public static System.Runtime.Intrinsics.Vector128<uint> TernaryLogic (System.Runtime.Intrinsics.Vector128<uint> a, System.Runtime.Intrinsics.Vector128<uint> b, System.Runtime.Intrinsics.Vector128<uint> c, byte control);
  * public static System.Runtime.Intrinsics.Vector128<ulong> TernaryLogic (System.Runtime.Intrinsics.Vector128<ulong> a, System.Runtime.Intrinsics.Vector128<ulong> b, System.Runtime.Intrinsics.Vector128<ulong> c, byte control);
  * public static System.Runtime.Intrinsics.Vector256<byte> TernaryLogic (System.Runtime.Intrinsics.Vector256<byte> a, System.Runtime.Intrinsics.Vector256<byte> b, System.Runtime.Intrinsics.Vector256<byte> c, byte control);
  * public static System.Runtime.Intrinsics.Vector256<double> TernaryLogic (System.Runtime.Intrinsics.Vector256<double> a, System.Runtime.Intrinsics.Vector256<double> b, System.Runtime.Intrinsics.Vector256<double> c, byte control);
  * public static System.Runtime.Intrinsics.Vector256<short> TernaryLogic (System.Runtime.Intrinsics.Vector256<short> a, System.Runtime.Intrinsics.Vector256<short> b, System.Runtime.Intrinsics.Vector256<short> c, byte control);
  * public static System.Runtime.Intrinsics.Vector256<int> TernaryLogic (System.Runtime.Intrinsics.Vector256<int> a, System.Runtime.Intrinsics.Vector256<int> b, System.Runtime.Intrinsics.Vector256<int> c, byte control);
  * public static System.Runtime.Intrinsics.Vector256<long> TernaryLogic (System.Runtime.Intrinsics.Vector256<long> a, System.Runtime.Intrinsics.Vector256<long> b, System.Runtime.Intrinsics.Vector256<long> c, byte control);
  * public static System.Runtime.Intrinsics.Vector256<sbyte> TernaryLogic (System.Runtime.Intrinsics.Vector256<sbyte> a, System.Runtime.Intrinsics.Vector256<sbyte> b, System.Runtime.Intrinsics.Vector256<sbyte> c, byte control);
  * public static System.Runtime.Intrinsics.Vector256<float> TernaryLogic (System.Runtime.Intrinsics.Vector256<float> a, System.Runtime.Intrinsics.Vector256<float> b, System.Runtime.Intrinsics.Vector256<float> c, byte control);
  * public static System.Runtime.Intrinsics.Vector256<ushort> TernaryLogic (System.Runtime.Intrinsics.Vector256<ushort> a, System.Runtime.Intrinsics.Vector256<ushort> b, System.Runtime.Intrinsics.Vector256<ushort> c, byte control);
  * public static System.Runtime.Intrinsics.Vector256<uint> TernaryLogic (System.Runtime.Intrinsics.Vector256<uint> a, System.Runtime.Intrinsics.Vector256<uint> b, System.Runtime.Intrinsics.Vector256<uint> c, byte control);
  * public static System.Runtime.Intrinsics.Vector256<ulong> TernaryLogic (System.Runtime.Intrinsics.Vector256<ulong> a, System.Runtime.Intrinsics.Vector256<ulong> b, System.Runtime.Intrinsics.Vector256<ulong> c, byte control);
* System.Runtime.Intrinsics.X86.Avx512F+X64
  * public static System.Runtime.Intrinsics.Vector128<double> ConvertScalarToVector128Double (System.Runtime.Intrinsics.Vector128<double> upper, ulong value);
  * public static System.Runtime.Intrinsics.Vector128<float> ConvertScalarToVector128Single (System.Runtime.Intrinsics.Vector128<float> upper, ulong value);
  * public static ulong ConvertToUInt64 (System.Runtime.Intrinsics.Vector128<double> value);
  * public static ulong ConvertToUInt64 (System.Runtime.Intrinsics.Vector128<float> value);
  * public static ulong ConvertToUInt64WithTruncation (System.Runtime.Intrinsics.Vector128<double> value);
  * public static ulong ConvertToUInt64WithTruncation (System.Runtime.Intrinsics.Vector128<float> value);
  * public static bool IsSupported { get; }
* System.Runtime.Intrinsics.X86.Avx512F
  * public static System.Runtime.Intrinsics.Vector512<uint> Abs (System.Runtime.Intrinsics.Vector512<int> value);
  * public static System.Runtime.Intrinsics.Vector512<ulong> Abs (System.Runtime.Intrinsics.Vector512<long> value);
  * public static System.Runtime.Intrinsics.Vector512<double> Add (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right);
  * public static System.Runtime.Intrinsics.Vector512<int> Add (System.Runtime.Intrinsics.Vector512<int> left, System.Runtime.Intrinsics.Vector512<int> right);
  * public static System.Runtime.Intrinsics.Vector512<long> Add (System.Runtime.Intrinsics.Vector512<long> left, System.Runtime.Intrinsics.Vector512<long> right);
  * public static System.Runtime.Intrinsics.Vector512<float> Add (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right);
  * public static System.Runtime.Intrinsics.Vector512<uint> Add (System.Runtime.Intrinsics.Vector512<uint> left, System.Runtime.Intrinsics.Vector512<uint> right);
  * public static System.Runtime.Intrinsics.Vector512<ulong> Add (System.Runtime.Intrinsics.Vector512<ulong> left, System.Runtime.Intrinsics.Vector512<ulong> right);
  * public static System.Runtime.Intrinsics.Vector512<int> AlignRight32 (System.Runtime.Intrinsics.Vector512<int> left, System.Runtime.Intrinsics.Vector512<int> right, byte mask);
  * public static System.Runtime.Intrinsics.Vector512<uint> AlignRight32 (System.Runtime.Intrinsics.Vector512<uint> left, System.Runtime.Intrinsics.Vector512<uint> right, byte mask);
  * public static System.Runtime.Intrinsics.Vector512<long> AlignRight64 (System.Runtime.Intrinsics.Vector512<long> left, System.Runtime.Intrinsics.Vector512<long> right, byte mask);
  * public static System.Runtime.Intrinsics.Vector512<ulong> AlignRight64 (System.Runtime.Intrinsics.Vector512<ulong> left, System.Runtime.Intrinsics.Vector512<ulong> right, byte mask);
  * public static System.Runtime.Intrinsics.Vector512<byte> And (System.Runtime.Intrinsics.Vector512<byte> left, System.Runtime.Intrinsics.Vector512<byte> right);
  * public static System.Runtime.Intrinsics.Vector512<short> And (System.Runtime.Intrinsics.Vector512<short> left, System.Runtime.Intrinsics.Vector512<short> right);
  * public static System.Runtime.Intrinsics.Vector512<int> And (System.Runtime.Intrinsics.Vector512<int> left, System.Runtime.Intrinsics.Vector512<int> right);
  * public static System.Runtime.Intrinsics.Vector512<long> And (System.Runtime.Intrinsics.Vector512<long> left, System.Runtime.Intrinsics.Vector512<long> right);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> And (System.Runtime.Intrinsics.Vector512<sbyte> left, System.Runtime.Intrinsics.Vector512<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector512<ushort> And (System.Runtime.Intrinsics.Vector512<ushort> left, System.Runtime.Intrinsics.Vector512<ushort> right);
  * public static System.Runtime.Intrinsics.Vector512<uint> And (System.Runtime.Intrinsics.Vector512<uint> left, System.Runtime.Intrinsics.Vector512<uint> right);
  * public static System.Runtime.Intrinsics.Vector512<ulong> And (System.Runtime.Intrinsics.Vector512<ulong> left, System.Runtime.Intrinsics.Vector512<ulong> right);
  * public static System.Runtime.Intrinsics.Vector512<byte> AndNot (System.Runtime.Intrinsics.Vector512<byte> left, System.Runtime.Intrinsics.Vector512<byte> right);
  * public static System.Runtime.Intrinsics.Vector512<short> AndNot (System.Runtime.Intrinsics.Vector512<short> left, System.Runtime.Intrinsics.Vector512<short> right);
  * public static System.Runtime.Intrinsics.Vector512<int> AndNot (System.Runtime.Intrinsics.Vector512<int> left, System.Runtime.Intrinsics.Vector512<int> right);
  * public static System.Runtime.Intrinsics.Vector512<long> AndNot (System.Runtime.Intrinsics.Vector512<long> left, System.Runtime.Intrinsics.Vector512<long> right);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> AndNot (System.Runtime.Intrinsics.Vector512<sbyte> left, System.Runtime.Intrinsics.Vector512<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector512<ushort> AndNot (System.Runtime.Intrinsics.Vector512<ushort> left, System.Runtime.Intrinsics.Vector512<ushort> right);
  * public static System.Runtime.Intrinsics.Vector512<uint> AndNot (System.Runtime.Intrinsics.Vector512<uint> left, System.Runtime.Intrinsics.Vector512<uint> right);
  * public static System.Runtime.Intrinsics.Vector512<ulong> AndNot (System.Runtime.Intrinsics.Vector512<ulong> left, System.Runtime.Intrinsics.Vector512<ulong> right);
  * public static System.Runtime.Intrinsics.Vector512<double> BlendVariable (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right, System.Runtime.Intrinsics.Vector512<double> mask);
  * public static System.Runtime.Intrinsics.Vector512<int> BlendVariable (System.Runtime.Intrinsics.Vector512<int> left, System.Runtime.Intrinsics.Vector512<int> right, System.Runtime.Intrinsics.Vector512<int> mask);
  * public static System.Runtime.Intrinsics.Vector512<long> BlendVariable (System.Runtime.Intrinsics.Vector512<long> left, System.Runtime.Intrinsics.Vector512<long> right, System.Runtime.Intrinsics.Vector512<long> mask);
  * public static System.Runtime.Intrinsics.Vector512<float> BlendVariable (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right, System.Runtime.Intrinsics.Vector512<float> mask);
  * public static System.Runtime.Intrinsics.Vector512<uint> BlendVariable (System.Runtime.Intrinsics.Vector512<uint> left, System.Runtime.Intrinsics.Vector512<uint> right, System.Runtime.Intrinsics.Vector512<uint> mask);
  * public static System.Runtime.Intrinsics.Vector512<ulong> BlendVariable (System.Runtime.Intrinsics.Vector512<ulong> left, System.Runtime.Intrinsics.Vector512<ulong> right, System.Runtime.Intrinsics.Vector512<ulong> mask);
  * public static System.Runtime.Intrinsics.Vector512<double> BroadcastScalarToVector512 (System.Runtime.Intrinsics.Vector128<double> value);
  * public static System.Runtime.Intrinsics.Vector512<int> BroadcastScalarToVector512 (System.Runtime.Intrinsics.Vector128<int> value);
  * public static System.Runtime.Intrinsics.Vector512<long> BroadcastScalarToVector512 (System.Runtime.Intrinsics.Vector128<long> value);
  * public static System.Runtime.Intrinsics.Vector512<float> BroadcastScalarToVector512 (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector512<uint> BroadcastScalarToVector512 (System.Runtime.Intrinsics.Vector128<uint> value);
  * public static System.Runtime.Intrinsics.Vector512<ulong> BroadcastScalarToVector512 (System.Runtime.Intrinsics.Vector128<ulong> value);
  * public static System.Runtime.Intrinsics.Vector512<int> BroadcastVector128ToVector512 (int* address);
  * public static System.Runtime.Intrinsics.Vector512<float> BroadcastVector128ToVector512 (float* address);
  * public static System.Runtime.Intrinsics.Vector512<uint> BroadcastVector128ToVector512 (uint* address);
  * public static System.Runtime.Intrinsics.Vector512<double> BroadcastVector256ToVector512 (double* address);
  * public static System.Runtime.Intrinsics.Vector512<long> BroadcastVector256ToVector512 (long* address);
  * public static System.Runtime.Intrinsics.Vector512<ulong> BroadcastVector256ToVector512 (ulong* address);
  * public static System.Runtime.Intrinsics.Vector512<double> Compare (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right, System.Runtime.Intrinsics.X86.FloatComparisonMode mode);
  * public static System.Runtime.Intrinsics.Vector512<float> Compare (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right, System.Runtime.Intrinsics.X86.FloatComparisonMode mode);
  * public static System.Runtime.Intrinsics.Vector512<double> CompareEqual (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right);
  * public static System.Runtime.Intrinsics.Vector512<int> CompareEqual (System.Runtime.Intrinsics.Vector512<int> left, System.Runtime.Intrinsics.Vector512<int> right);
  * public static System.Runtime.Intrinsics.Vector512<long> CompareEqual (System.Runtime.Intrinsics.Vector512<long> left, System.Runtime.Intrinsics.Vector512<long> right);
  * public static System.Runtime.Intrinsics.Vector512<float> CompareEqual (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right);
  * public static System.Runtime.Intrinsics.Vector512<uint> CompareEqual (System.Runtime.Intrinsics.Vector512<uint> left, System.Runtime.Intrinsics.Vector512<uint> right);
  * public static System.Runtime.Intrinsics.Vector512<ulong> CompareEqual (System.Runtime.Intrinsics.Vector512<ulong> left, System.Runtime.Intrinsics.Vector512<ulong> right);
  * public static System.Runtime.Intrinsics.Vector512<double> CompareGreaterThan (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right);
  * public static System.Runtime.Intrinsics.Vector512<int> CompareGreaterThan (System.Runtime.Intrinsics.Vector512<int> left, System.Runtime.Intrinsics.Vector512<int> right);
  * public static System.Runtime.Intrinsics.Vector512<long> CompareGreaterThan (System.Runtime.Intrinsics.Vector512<long> left, System.Runtime.Intrinsics.Vector512<long> right);
  * public static System.Runtime.Intrinsics.Vector512<float> CompareGreaterThan (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right);
  * public static System.Runtime.Intrinsics.Vector512<uint> CompareGreaterThan (System.Runtime.Intrinsics.Vector512<uint> left, System.Runtime.Intrinsics.Vector512<uint> right);
  * public static System.Runtime.Intrinsics.Vector512<ulong> CompareGreaterThan (System.Runtime.Intrinsics.Vector512<ulong> left, System.Runtime.Intrinsics.Vector512<ulong> right);
  * public static System.Runtime.Intrinsics.Vector512<double> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right);
  * public static System.Runtime.Intrinsics.Vector512<int> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector512<int> left, System.Runtime.Intrinsics.Vector512<int> right);
  * public static System.Runtime.Intrinsics.Vector512<long> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector512<long> left, System.Runtime.Intrinsics.Vector512<long> right);
  * public static System.Runtime.Intrinsics.Vector512<float> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right);
  * public static System.Runtime.Intrinsics.Vector512<uint> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector512<uint> left, System.Runtime.Intrinsics.Vector512<uint> right);
  * public static System.Runtime.Intrinsics.Vector512<ulong> CompareGreaterThanOrEqual (System.Runtime.Intrinsics.Vector512<ulong> left, System.Runtime.Intrinsics.Vector512<ulong> right);
  * public static System.Runtime.Intrinsics.Vector512<double> CompareLessThan (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right);
  * public static System.Runtime.Intrinsics.Vector512<int> CompareLessThan (System.Runtime.Intrinsics.Vector512<int> left, System.Runtime.Intrinsics.Vector512<int> right);
  * public static System.Runtime.Intrinsics.Vector512<long> CompareLessThan (System.Runtime.Intrinsics.Vector512<long> left, System.Runtime.Intrinsics.Vector512<long> right);
  * public static System.Runtime.Intrinsics.Vector512<float> CompareLessThan (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right);
  * public static System.Runtime.Intrinsics.Vector512<uint> CompareLessThan (System.Runtime.Intrinsics.Vector512<uint> left, System.Runtime.Intrinsics.Vector512<uint> right);
  * public static System.Runtime.Intrinsics.Vector512<ulong> CompareLessThan (System.Runtime.Intrinsics.Vector512<ulong> left, System.Runtime.Intrinsics.Vector512<ulong> right);
  * public static System.Runtime.Intrinsics.Vector512<double> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right);
  * public static System.Runtime.Intrinsics.Vector512<int> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector512<int> left, System.Runtime.Intrinsics.Vector512<int> right);
  * public static System.Runtime.Intrinsics.Vector512<long> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector512<long> left, System.Runtime.Intrinsics.Vector512<long> right);
  * public static System.Runtime.Intrinsics.Vector512<float> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right);
  * public static System.Runtime.Intrinsics.Vector512<uint> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector512<uint> left, System.Runtime.Intrinsics.Vector512<uint> right);
  * public static System.Runtime.Intrinsics.Vector512<ulong> CompareLessThanOrEqual (System.Runtime.Intrinsics.Vector512<ulong> left, System.Runtime.Intrinsics.Vector512<ulong> right);
  * public static System.Runtime.Intrinsics.Vector512<double> CompareNotEqual (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right);
  * public static System.Runtime.Intrinsics.Vector512<int> CompareNotEqual (System.Runtime.Intrinsics.Vector512<int> left, System.Runtime.Intrinsics.Vector512<int> right);
  * public static System.Runtime.Intrinsics.Vector512<long> CompareNotEqual (System.Runtime.Intrinsics.Vector512<long> left, System.Runtime.Intrinsics.Vector512<long> right);
  * public static System.Runtime.Intrinsics.Vector512<float> CompareNotEqual (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right);
  * public static System.Runtime.Intrinsics.Vector512<uint> CompareNotEqual (System.Runtime.Intrinsics.Vector512<uint> left, System.Runtime.Intrinsics.Vector512<uint> right);
  * public static System.Runtime.Intrinsics.Vector512<ulong> CompareNotEqual (System.Runtime.Intrinsics.Vector512<ulong> left, System.Runtime.Intrinsics.Vector512<ulong> right);
  * public static System.Runtime.Intrinsics.Vector512<double> CompareNotGreaterThan (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right);
  * public static System.Runtime.Intrinsics.Vector512<float> CompareNotGreaterThan (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right);
  * public static System.Runtime.Intrinsics.Vector512<double> CompareNotGreaterThanOrEqual (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right);
  * public static System.Runtime.Intrinsics.Vector512<float> CompareNotGreaterThanOrEqual (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right);
  * public static System.Runtime.Intrinsics.Vector512<double> CompareNotLessThan (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right);
  * public static System.Runtime.Intrinsics.Vector512<float> CompareNotLessThan (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right);
  * public static System.Runtime.Intrinsics.Vector512<double> CompareNotLessThanOrEqual (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right);
  * public static System.Runtime.Intrinsics.Vector512<float> CompareNotLessThanOrEqual (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right);
  * public static System.Runtime.Intrinsics.Vector512<double> CompareOrdered (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right);
  * public static System.Runtime.Intrinsics.Vector512<float> CompareOrdered (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right);
  * public static System.Runtime.Intrinsics.Vector512<double> CompareUnordered (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right);
  * public static System.Runtime.Intrinsics.Vector512<float> CompareUnordered (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right);
  * public static System.Runtime.Intrinsics.Vector128<double> ConvertScalarToVector128Double (System.Runtime.Intrinsics.Vector128<double> upper, uint value);
  * public static System.Runtime.Intrinsics.Vector128<float> ConvertScalarToVector128Single (System.Runtime.Intrinsics.Vector128<float> upper, uint value);
  * public static uint ConvertToUInt32 (System.Runtime.Intrinsics.Vector128<double> value);
  * public static uint ConvertToUInt32 (System.Runtime.Intrinsics.Vector128<float> value);
  * public static uint ConvertToUInt32WithTruncation (System.Runtime.Intrinsics.Vector128<double> value);
  * public static uint ConvertToUInt32WithTruncation (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> ConvertToVector128Byte (System.Runtime.Intrinsics.Vector512<int> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> ConvertToVector128Byte (System.Runtime.Intrinsics.Vector512<long> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> ConvertToVector128Byte (System.Runtime.Intrinsics.Vector512<uint> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> ConvertToVector128Byte (System.Runtime.Intrinsics.Vector512<ulong> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> ConvertToVector128ByteWithSaturation (System.Runtime.Intrinsics.Vector512<uint> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> ConvertToVector128ByteWithSaturation (System.Runtime.Intrinsics.Vector512<ulong> value);
  * public static System.Runtime.Intrinsics.Vector128<short> ConvertToVector128Int16 (System.Runtime.Intrinsics.Vector512<long> value);
  * public static System.Runtime.Intrinsics.Vector128<short> ConvertToVector128Int16 (System.Runtime.Intrinsics.Vector512<ulong> value);
  * public static System.Runtime.Intrinsics.Vector128<short> ConvertToVector128Int16WithSaturation (System.Runtime.Intrinsics.Vector512<long> value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ConvertToVector128SByte (System.Runtime.Intrinsics.Vector512<int> value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ConvertToVector128SByte (System.Runtime.Intrinsics.Vector512<long> value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ConvertToVector128SByte (System.Runtime.Intrinsics.Vector512<uint> value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ConvertToVector128SByte (System.Runtime.Intrinsics.Vector512<ulong> value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ConvertToVector128SByteWithSaturation (System.Runtime.Intrinsics.Vector512<int> value);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ConvertToVector128SByteWithSaturation (System.Runtime.Intrinsics.Vector512<long> value);
  * public static System.Runtime.Intrinsics.Vector128<ushort> ConvertToVector128UInt16 (System.Runtime.Intrinsics.Vector512<long> value);
  * public static System.Runtime.Intrinsics.Vector128<ushort> ConvertToVector128UInt16 (System.Runtime.Intrinsics.Vector512<ulong> value);
  * public static System.Runtime.Intrinsics.Vector128<ushort> ConvertToVector128UInt16WithSaturation (System.Runtime.Intrinsics.Vector512<ulong> value);
  * public static System.Runtime.Intrinsics.Vector256<short> ConvertToVector256Int16 (System.Runtime.Intrinsics.Vector512<int> value);
  * public static System.Runtime.Intrinsics.Vector256<short> ConvertToVector256Int16 (System.Runtime.Intrinsics.Vector512<uint> value);
  * public static System.Runtime.Intrinsics.Vector256<short> ConvertToVector256Int16WithSaturation (System.Runtime.Intrinsics.Vector512<int> value);
  * public static System.Runtime.Intrinsics.Vector256<int> ConvertToVector256Int32 (System.Runtime.Intrinsics.Vector512<double> value);
  * public static System.Runtime.Intrinsics.Vector256<int> ConvertToVector256Int32 (System.Runtime.Intrinsics.Vector512<long> value);
  * public static System.Runtime.Intrinsics.Vector256<int> ConvertToVector256Int32 (System.Runtime.Intrinsics.Vector512<ulong> value);
  * public static System.Runtime.Intrinsics.Vector256<int> ConvertToVector256Int32WithSaturation (System.Runtime.Intrinsics.Vector512<long> value);
  * public static System.Runtime.Intrinsics.Vector256<int> ConvertToVector256Int32WithTruncation (System.Runtime.Intrinsics.Vector512<double> value);
  * public static System.Runtime.Intrinsics.Vector256<float> ConvertToVector256Single (System.Runtime.Intrinsics.Vector512<double> value);
  * public static System.Runtime.Intrinsics.Vector256<ushort> ConvertToVector256UInt16 (System.Runtime.Intrinsics.Vector512<int> value);
  * public static System.Runtime.Intrinsics.Vector256<ushort> ConvertToVector256UInt16 (System.Runtime.Intrinsics.Vector512<uint> value);
  * public static System.Runtime.Intrinsics.Vector256<ushort> ConvertToVector256UInt16WithSaturation (System.Runtime.Intrinsics.Vector512<uint> value);
  * public static System.Runtime.Intrinsics.Vector256<uint> ConvertToVector256UInt32 (System.Runtime.Intrinsics.Vector512<double> value);
  * public static System.Runtime.Intrinsics.Vector256<uint> ConvertToVector256UInt32 (System.Runtime.Intrinsics.Vector512<long> value);
  * public static System.Runtime.Intrinsics.Vector256<uint> ConvertToVector256UInt32 (System.Runtime.Intrinsics.Vector512<ulong> value);
  * public static System.Runtime.Intrinsics.Vector256<uint> ConvertToVector256UInt32WithSaturation (System.Runtime.Intrinsics.Vector512<ulong> value);
  * public static System.Runtime.Intrinsics.Vector256<uint> ConvertToVector256UInt32WithTruncation (System.Runtime.Intrinsics.Vector512<double> value);
  * public static System.Runtime.Intrinsics.Vector512<double> ConvertToVector512Double (System.Runtime.Intrinsics.Vector256<int> value);
  * public static System.Runtime.Intrinsics.Vector512<double> ConvertToVector512Double (System.Runtime.Intrinsics.Vector256<float> value);
  * public static System.Runtime.Intrinsics.Vector512<double> ConvertToVector512Double (System.Runtime.Intrinsics.Vector256<uint> value);
  * public static System.Runtime.Intrinsics.Vector512<int> ConvertToVector512Int32 (System.Runtime.Intrinsics.Vector128<byte> value);
  * public static System.Runtime.Intrinsics.Vector512<int> ConvertToVector512Int32 (System.Runtime.Intrinsics.Vector128<sbyte> value);
  * public static System.Runtime.Intrinsics.Vector512<int> ConvertToVector512Int32 (System.Runtime.Intrinsics.Vector256<short> value);
  * public static System.Runtime.Intrinsics.Vector512<int> ConvertToVector512Int32 (System.Runtime.Intrinsics.Vector256<ushort> value);
  * public static System.Runtime.Intrinsics.Vector512<int> ConvertToVector512Int32 (System.Runtime.Intrinsics.Vector512<float> value);
  * public static System.Runtime.Intrinsics.Vector512<int> ConvertToVector512Int32WithTruncation (System.Runtime.Intrinsics.Vector512<float> value);
  * public static System.Runtime.Intrinsics.Vector512<long> ConvertToVector512Int64 (System.Runtime.Intrinsics.Vector128<byte> value);
  * public static System.Runtime.Intrinsics.Vector512<long> ConvertToVector512Int64 (System.Runtime.Intrinsics.Vector128<short> value);
  * public static System.Runtime.Intrinsics.Vector512<long> ConvertToVector512Int64 (System.Runtime.Intrinsics.Vector128<sbyte> value);
  * public static System.Runtime.Intrinsics.Vector512<long> ConvertToVector512Int64 (System.Runtime.Intrinsics.Vector128<ushort> value);
  * public static System.Runtime.Intrinsics.Vector512<long> ConvertToVector512Int64 (System.Runtime.Intrinsics.Vector256<int> value);
  * public static System.Runtime.Intrinsics.Vector512<long> ConvertToVector512Int64 (System.Runtime.Intrinsics.Vector256<uint> value);
  * public static System.Runtime.Intrinsics.Vector512<float> ConvertToVector512Single (System.Runtime.Intrinsics.Vector512<int> value);
  * public static System.Runtime.Intrinsics.Vector512<float> ConvertToVector512Single (System.Runtime.Intrinsics.Vector512<uint> value);
  * public static System.Runtime.Intrinsics.Vector512<uint> ConvertToVector512UInt32 (System.Runtime.Intrinsics.Vector128<byte> value);
  * public static System.Runtime.Intrinsics.Vector512<uint> ConvertToVector512UInt32 (System.Runtime.Intrinsics.Vector128<sbyte> value);
  * public static System.Runtime.Intrinsics.Vector512<uint> ConvertToVector512UInt32 (System.Runtime.Intrinsics.Vector256<short> value);
  * public static System.Runtime.Intrinsics.Vector512<uint> ConvertToVector512UInt32 (System.Runtime.Intrinsics.Vector256<ushort> value);
  * public static System.Runtime.Intrinsics.Vector512<uint> ConvertToVector512UInt32 (System.Runtime.Intrinsics.Vector512<float> value);
  * public static System.Runtime.Intrinsics.Vector512<uint> ConvertToVector512UInt32WithTruncation (System.Runtime.Intrinsics.Vector512<float> value);
  * public static System.Runtime.Intrinsics.Vector512<ulong> ConvertToVector512UInt64 (System.Runtime.Intrinsics.Vector128<byte> value);
  * public static System.Runtime.Intrinsics.Vector512<ulong> ConvertToVector512UInt64 (System.Runtime.Intrinsics.Vector128<short> value);
  * public static System.Runtime.Intrinsics.Vector512<ulong> ConvertToVector512UInt64 (System.Runtime.Intrinsics.Vector128<sbyte> value);
  * public static System.Runtime.Intrinsics.Vector512<ulong> ConvertToVector512UInt64 (System.Runtime.Intrinsics.Vector128<ushort> value);
  * public static System.Runtime.Intrinsics.Vector512<ulong> ConvertToVector512UInt64 (System.Runtime.Intrinsics.Vector256<int> value);
  * public static System.Runtime.Intrinsics.Vector512<ulong> ConvertToVector512UInt64 (System.Runtime.Intrinsics.Vector256<uint> value);
  * public static System.Runtime.Intrinsics.Vector512<double> Divide (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right);
  * public static System.Runtime.Intrinsics.Vector512<float> Divide (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right);
  * public static System.Runtime.Intrinsics.Vector512<double> DuplicateEvenIndexed (System.Runtime.Intrinsics.Vector512<double> value);
  * public static System.Runtime.Intrinsics.Vector512<float> DuplicateEvenIndexed (System.Runtime.Intrinsics.Vector512<float> value);
  * public static System.Runtime.Intrinsics.Vector512<float> DuplicateOddIndexed (System.Runtime.Intrinsics.Vector512<float> value);
  * public static System.Runtime.Intrinsics.Vector128<byte> ExtractVector128 (System.Runtime.Intrinsics.Vector512<byte> value, byte index);
  * public static System.Runtime.Intrinsics.Vector128<double> ExtractVector128 (System.Runtime.Intrinsics.Vector512<double> value, byte index);
  * public static System.Runtime.Intrinsics.Vector128<short> ExtractVector128 (System.Runtime.Intrinsics.Vector512<short> value, byte index);
  * public static System.Runtime.Intrinsics.Vector128<int> ExtractVector128 (System.Runtime.Intrinsics.Vector512<int> value, byte index);
  * public static System.Runtime.Intrinsics.Vector128<long> ExtractVector128 (System.Runtime.Intrinsics.Vector512<long> value, byte index);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> ExtractVector128 (System.Runtime.Intrinsics.Vector512<sbyte> value, byte index);
  * public static System.Runtime.Intrinsics.Vector128<float> ExtractVector128 (System.Runtime.Intrinsics.Vector512<float> value, byte index);
  * public static System.Runtime.Intrinsics.Vector128<ushort> ExtractVector128 (System.Runtime.Intrinsics.Vector512<ushort> value, byte index);
  * public static System.Runtime.Intrinsics.Vector128<uint> ExtractVector128 (System.Runtime.Intrinsics.Vector512<uint> value, byte index);
  * public static System.Runtime.Intrinsics.Vector128<ulong> ExtractVector128 (System.Runtime.Intrinsics.Vector512<ulong> value, byte index);
  * public static System.Runtime.Intrinsics.Vector256<byte> ExtractVector256 (System.Runtime.Intrinsics.Vector512<byte> value, byte index);
  * public static System.Runtime.Intrinsics.Vector256<double> ExtractVector256 (System.Runtime.Intrinsics.Vector512<double> value, byte index);
  * public static System.Runtime.Intrinsics.Vector256<short> ExtractVector256 (System.Runtime.Intrinsics.Vector512<short> value, byte index);
  * public static System.Runtime.Intrinsics.Vector256<int> ExtractVector256 (System.Runtime.Intrinsics.Vector512<int> value, byte index);
  * public static System.Runtime.Intrinsics.Vector256<long> ExtractVector256 (System.Runtime.Intrinsics.Vector512<long> value, byte index);
  * public static System.Runtime.Intrinsics.Vector256<sbyte> ExtractVector256 (System.Runtime.Intrinsics.Vector512<sbyte> value, byte index);
  * public static System.Runtime.Intrinsics.Vector256<float> ExtractVector256 (System.Runtime.Intrinsics.Vector512<float> value, byte index);
  * public static System.Runtime.Intrinsics.Vector256<ushort> ExtractVector256 (System.Runtime.Intrinsics.Vector512<ushort> value, byte index);
  * public static System.Runtime.Intrinsics.Vector256<uint> ExtractVector256 (System.Runtime.Intrinsics.Vector512<uint> value, byte index);
  * public static System.Runtime.Intrinsics.Vector256<ulong> ExtractVector256 (System.Runtime.Intrinsics.Vector512<ulong> value, byte index);
  * public static System.Runtime.Intrinsics.Vector512<double> Fixup (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right, System.Runtime.Intrinsics.Vector512<long> table, byte control);
  * public static System.Runtime.Intrinsics.Vector512<float> Fixup (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right, System.Runtime.Intrinsics.Vector512<int> table, byte control);
  * public static System.Runtime.Intrinsics.Vector128<double> FixupScalar (System.Runtime.Intrinsics.Vector128<double> left, System.Runtime.Intrinsics.Vector128<double> right, System.Runtime.Intrinsics.Vector128<long> table, byte control);
  * public static System.Runtime.Intrinsics.Vector128<float> FixupScalar (System.Runtime.Intrinsics.Vector128<float> left, System.Runtime.Intrinsics.Vector128<float> right, System.Runtime.Intrinsics.Vector128<int> table, byte control);
  * public static System.Runtime.Intrinsics.Vector512<double> FusedMultiplyAdd (System.Runtime.Intrinsics.Vector512<double> a, System.Runtime.Intrinsics.Vector512<double> b, System.Runtime.Intrinsics.Vector512<double> c);
  * public static System.Runtime.Intrinsics.Vector512<float> FusedMultiplyAdd (System.Runtime.Intrinsics.Vector512<float> a, System.Runtime.Intrinsics.Vector512<float> b, System.Runtime.Intrinsics.Vector512<float> c);
  * public static System.Runtime.Intrinsics.Vector512<double> FusedMultiplyAddNegated (System.Runtime.Intrinsics.Vector512<double> a, System.Runtime.Intrinsics.Vector512<double> b, System.Runtime.Intrinsics.Vector512<double> c);
  * public static System.Runtime.Intrinsics.Vector512<float> FusedMultiplyAddNegated (System.Runtime.Intrinsics.Vector512<float> a, System.Runtime.Intrinsics.Vector512<float> b, System.Runtime.Intrinsics.Vector512<float> c);
  * public static System.Runtime.Intrinsics.Vector512<double> FusedMultiplyAddSubtract (System.Runtime.Intrinsics.Vector512<double> a, System.Runtime.Intrinsics.Vector512<double> b, System.Runtime.Intrinsics.Vector512<double> c);
  * public static System.Runtime.Intrinsics.Vector512<float> FusedMultiplyAddSubtract (System.Runtime.Intrinsics.Vector512<float> a, System.Runtime.Intrinsics.Vector512<float> b, System.Runtime.Intrinsics.Vector512<float> c);
  * public static System.Runtime.Intrinsics.Vector512<double> FusedMultiplySubtract (System.Runtime.Intrinsics.Vector512<double> a, System.Runtime.Intrinsics.Vector512<double> b, System.Runtime.Intrinsics.Vector512<double> c);
  * public static System.Runtime.Intrinsics.Vector512<float> FusedMultiplySubtract (System.Runtime.Intrinsics.Vector512<float> a, System.Runtime.Intrinsics.Vector512<float> b, System.Runtime.Intrinsics.Vector512<float> c);
  * public static System.Runtime.Intrinsics.Vector512<double> FusedMultiplySubtractAdd (System.Runtime.Intrinsics.Vector512<double> a, System.Runtime.Intrinsics.Vector512<double> b, System.Runtime.Intrinsics.Vector512<double> c);
  * public static System.Runtime.Intrinsics.Vector512<float> FusedMultiplySubtractAdd (System.Runtime.Intrinsics.Vector512<float> a, System.Runtime.Intrinsics.Vector512<float> b, System.Runtime.Intrinsics.Vector512<float> c);
  * public static System.Runtime.Intrinsics.Vector512<double> FusedMultiplySubtractNegated (System.Runtime.Intrinsics.Vector512<double> a, System.Runtime.Intrinsics.Vector512<double> b, System.Runtime.Intrinsics.Vector512<double> c);
  * public static System.Runtime.Intrinsics.Vector512<float> FusedMultiplySubtractNegated (System.Runtime.Intrinsics.Vector512<float> a, System.Runtime.Intrinsics.Vector512<float> b, System.Runtime.Intrinsics.Vector512<float> c);
  * public static System.Runtime.Intrinsics.Vector512<double> GetExponent (System.Runtime.Intrinsics.Vector512<double> value);
  * public static System.Runtime.Intrinsics.Vector512<float> GetExponent (System.Runtime.Intrinsics.Vector512<float> value);
  * public static System.Runtime.Intrinsics.Vector128<double> GetExponentScalar (System.Runtime.Intrinsics.Vector128<double> value);
  * public static System.Runtime.Intrinsics.Vector128<float> GetExponentScalar (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector128<double> GetExponentScalar (System.Runtime.Intrinsics.Vector128<double> upper, System.Runtime.Intrinsics.Vector128<double> value);
  * public static System.Runtime.Intrinsics.Vector128<float> GetExponentScalar (System.Runtime.Intrinsics.Vector128<float> upper, System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector512<double> GetMantissa (System.Runtime.Intrinsics.Vector512<double> value, byte control);
  * public static System.Runtime.Intrinsics.Vector512<float> GetMantissa (System.Runtime.Intrinsics.Vector512<float> value, byte control);
  * public static System.Runtime.Intrinsics.Vector128<double> GetMantissaScalar (System.Runtime.Intrinsics.Vector128<double> value, byte control);
  * public static System.Runtime.Intrinsics.Vector128<float> GetMantissaScalar (System.Runtime.Intrinsics.Vector128<float> value, byte control);
  * public static System.Runtime.Intrinsics.Vector128<double> GetMantissaScalar (System.Runtime.Intrinsics.Vector128<double> upper, System.Runtime.Intrinsics.Vector128<double> value, byte control);
  * public static System.Runtime.Intrinsics.Vector128<float> GetMantissaScalar (System.Runtime.Intrinsics.Vector128<float> upper, System.Runtime.Intrinsics.Vector128<float> value, byte control);
  * public static System.Runtime.Intrinsics.Vector512<byte> InsertVector128 (System.Runtime.Intrinsics.Vector512<byte> value, System.Runtime.Intrinsics.Vector128<byte> data, byte index);
  * public static System.Runtime.Intrinsics.Vector512<double> InsertVector128 (System.Runtime.Intrinsics.Vector512<double> value, System.Runtime.Intrinsics.Vector128<double> data, byte index);
  * public static System.Runtime.Intrinsics.Vector512<short> InsertVector128 (System.Runtime.Intrinsics.Vector512<short> value, System.Runtime.Intrinsics.Vector128<short> data, byte index);
  * public static System.Runtime.Intrinsics.Vector512<int> InsertVector128 (System.Runtime.Intrinsics.Vector512<int> value, System.Runtime.Intrinsics.Vector128<int> data, byte index);
  * public static System.Runtime.Intrinsics.Vector512<long> InsertVector128 (System.Runtime.Intrinsics.Vector512<long> value, System.Runtime.Intrinsics.Vector128<long> data, byte index);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> InsertVector128 (System.Runtime.Intrinsics.Vector512<sbyte> value, System.Runtime.Intrinsics.Vector128<sbyte> data, byte index);
  * public static System.Runtime.Intrinsics.Vector512<float> InsertVector128 (System.Runtime.Intrinsics.Vector512<float> value, System.Runtime.Intrinsics.Vector128<float> data, byte index);
  * public static System.Runtime.Intrinsics.Vector512<ushort> InsertVector128 (System.Runtime.Intrinsics.Vector512<ushort> value, System.Runtime.Intrinsics.Vector128<ushort> data, byte index);
  * public static System.Runtime.Intrinsics.Vector512<uint> InsertVector128 (System.Runtime.Intrinsics.Vector512<uint> value, System.Runtime.Intrinsics.Vector128<uint> data, byte index);
  * public static System.Runtime.Intrinsics.Vector512<ulong> InsertVector128 (System.Runtime.Intrinsics.Vector512<ulong> value, System.Runtime.Intrinsics.Vector128<ulong> data, byte index);
  * public static System.Runtime.Intrinsics.Vector512<byte> InsertVector256 (System.Runtime.Intrinsics.Vector512<byte> value, System.Runtime.Intrinsics.Vector256<byte> data, byte index);
  * public static System.Runtime.Intrinsics.Vector512<double> InsertVector256 (System.Runtime.Intrinsics.Vector512<double> value, System.Runtime.Intrinsics.Vector256<double> data, byte index);
  * public static System.Runtime.Intrinsics.Vector512<short> InsertVector256 (System.Runtime.Intrinsics.Vector512<short> value, System.Runtime.Intrinsics.Vector256<short> data, byte index);
  * public static System.Runtime.Intrinsics.Vector512<int> InsertVector256 (System.Runtime.Intrinsics.Vector512<int> value, System.Runtime.Intrinsics.Vector256<int> data, byte index);
  * public static System.Runtime.Intrinsics.Vector512<long> InsertVector256 (System.Runtime.Intrinsics.Vector512<long> value, System.Runtime.Intrinsics.Vector256<long> data, byte index);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> InsertVector256 (System.Runtime.Intrinsics.Vector512<sbyte> value, System.Runtime.Intrinsics.Vector256<sbyte> data, byte index);
  * public static System.Runtime.Intrinsics.Vector512<float> InsertVector256 (System.Runtime.Intrinsics.Vector512<float> value, System.Runtime.Intrinsics.Vector256<float> data, byte index);
  * public static System.Runtime.Intrinsics.Vector512<ushort> InsertVector256 (System.Runtime.Intrinsics.Vector512<ushort> value, System.Runtime.Intrinsics.Vector256<ushort> data, byte index);
  * public static System.Runtime.Intrinsics.Vector512<uint> InsertVector256 (System.Runtime.Intrinsics.Vector512<uint> value, System.Runtime.Intrinsics.Vector256<uint> data, byte index);
  * public static System.Runtime.Intrinsics.Vector512<ulong> InsertVector256 (System.Runtime.Intrinsics.Vector512<ulong> value, System.Runtime.Intrinsics.Vector256<ulong> data, byte index);
  * public static bool IsSupported { get; }
  * public static System.Runtime.Intrinsics.Vector512<byte> LoadAlignedVector512 (byte* address);
  * public static System.Runtime.Intrinsics.Vector512<double> LoadAlignedVector512 (double* address);
  * public static System.Runtime.Intrinsics.Vector512<short> LoadAlignedVector512 (short* address);
  * public static System.Runtime.Intrinsics.Vector512<int> LoadAlignedVector512 (int* address);
  * public static System.Runtime.Intrinsics.Vector512<long> LoadAlignedVector512 (long* address);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> LoadAlignedVector512 (sbyte* address);
  * public static System.Runtime.Intrinsics.Vector512<float> LoadAlignedVector512 (float* address);
  * public static System.Runtime.Intrinsics.Vector512<ushort> LoadAlignedVector512 (ushort* address);
  * public static System.Runtime.Intrinsics.Vector512<uint> LoadAlignedVector512 (uint* address);
  * public static System.Runtime.Intrinsics.Vector512<ulong> LoadAlignedVector512 (ulong* address);
  * public static System.Runtime.Intrinsics.Vector512<byte> LoadAlignedVector512NonTemporal (byte* address);
  * public static System.Runtime.Intrinsics.Vector512<short> LoadAlignedVector512NonTemporal (short* address);
  * public static System.Runtime.Intrinsics.Vector512<int> LoadAlignedVector512NonTemporal (int* address);
  * public static System.Runtime.Intrinsics.Vector512<long> LoadAlignedVector512NonTemporal (long* address);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> LoadAlignedVector512NonTemporal (sbyte* address);
  * public static System.Runtime.Intrinsics.Vector512<ushort> LoadAlignedVector512NonTemporal (ushort* address);
  * public static System.Runtime.Intrinsics.Vector512<uint> LoadAlignedVector512NonTemporal (uint* address);
  * public static System.Runtime.Intrinsics.Vector512<ulong> LoadAlignedVector512NonTemporal (ulong* address);
  * public static System.Runtime.Intrinsics.Vector512<byte> LoadVector512 (byte* address);
  * public static System.Runtime.Intrinsics.Vector512<double> LoadVector512 (double* address);
  * public static System.Runtime.Intrinsics.Vector512<short> LoadVector512 (short* address);
  * public static System.Runtime.Intrinsics.Vector512<int> LoadVector512 (int* address);
  * public static System.Runtime.Intrinsics.Vector512<long> LoadVector512 (long* address);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> LoadVector512 (sbyte* address);
  * public static System.Runtime.Intrinsics.Vector512<float> LoadVector512 (float* address);
  * public static System.Runtime.Intrinsics.Vector512<ushort> LoadVector512 (ushort* address);
  * public static System.Runtime.Intrinsics.Vector512<uint> LoadVector512 (uint* address);
  * public static System.Runtime.Intrinsics.Vector512<ulong> LoadVector512 (ulong* address);
  * public static System.Runtime.Intrinsics.Vector512<double> Max (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right);
  * public static System.Runtime.Intrinsics.Vector512<int> Max (System.Runtime.Intrinsics.Vector512<int> left, System.Runtime.Intrinsics.Vector512<int> right);
  * public static System.Runtime.Intrinsics.Vector512<long> Max (System.Runtime.Intrinsics.Vector512<long> left, System.Runtime.Intrinsics.Vector512<long> right);
  * public static System.Runtime.Intrinsics.Vector512<float> Max (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right);
  * public static System.Runtime.Intrinsics.Vector512<uint> Max (System.Runtime.Intrinsics.Vector512<uint> left, System.Runtime.Intrinsics.Vector512<uint> right);
  * public static System.Runtime.Intrinsics.Vector512<ulong> Max (System.Runtime.Intrinsics.Vector512<ulong> left, System.Runtime.Intrinsics.Vector512<ulong> right);
  * public static System.Runtime.Intrinsics.Vector512<double> Min (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right);
  * public static System.Runtime.Intrinsics.Vector512<int> Min (System.Runtime.Intrinsics.Vector512<int> left, System.Runtime.Intrinsics.Vector512<int> right);
  * public static System.Runtime.Intrinsics.Vector512<long> Min (System.Runtime.Intrinsics.Vector512<long> left, System.Runtime.Intrinsics.Vector512<long> right);
  * public static System.Runtime.Intrinsics.Vector512<float> Min (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right);
  * public static System.Runtime.Intrinsics.Vector512<uint> Min (System.Runtime.Intrinsics.Vector512<uint> left, System.Runtime.Intrinsics.Vector512<uint> right);
  * public static System.Runtime.Intrinsics.Vector512<ulong> Min (System.Runtime.Intrinsics.Vector512<ulong> left, System.Runtime.Intrinsics.Vector512<ulong> right);
  * public static System.Runtime.Intrinsics.Vector512<double> Multiply (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right);
  * public static System.Runtime.Intrinsics.Vector512<long> Multiply (System.Runtime.Intrinsics.Vector512<int> left, System.Runtime.Intrinsics.Vector512<int> right);
  * public static System.Runtime.Intrinsics.Vector512<float> Multiply (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right);
  * public static System.Runtime.Intrinsics.Vector512<ulong> Multiply (System.Runtime.Intrinsics.Vector512<uint> left, System.Runtime.Intrinsics.Vector512<uint> right);
  * public static System.Runtime.Intrinsics.Vector512<int> MultiplyLow (System.Runtime.Intrinsics.Vector512<int> left, System.Runtime.Intrinsics.Vector512<int> right);
  * public static System.Runtime.Intrinsics.Vector512<uint> MultiplyLow (System.Runtime.Intrinsics.Vector512<uint> left, System.Runtime.Intrinsics.Vector512<uint> right);
  * public static System.Runtime.Intrinsics.Vector512<byte> Or (System.Runtime.Intrinsics.Vector512<byte> left, System.Runtime.Intrinsics.Vector512<byte> right);
  * public static System.Runtime.Intrinsics.Vector512<short> Or (System.Runtime.Intrinsics.Vector512<short> left, System.Runtime.Intrinsics.Vector512<short> right);
  * public static System.Runtime.Intrinsics.Vector512<int> Or (System.Runtime.Intrinsics.Vector512<int> left, System.Runtime.Intrinsics.Vector512<int> right);
  * public static System.Runtime.Intrinsics.Vector512<long> Or (System.Runtime.Intrinsics.Vector512<long> left, System.Runtime.Intrinsics.Vector512<long> right);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> Or (System.Runtime.Intrinsics.Vector512<sbyte> left, System.Runtime.Intrinsics.Vector512<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector512<ushort> Or (System.Runtime.Intrinsics.Vector512<ushort> left, System.Runtime.Intrinsics.Vector512<ushort> right);
  * public static System.Runtime.Intrinsics.Vector512<uint> Or (System.Runtime.Intrinsics.Vector512<uint> left, System.Runtime.Intrinsics.Vector512<uint> right);
  * public static System.Runtime.Intrinsics.Vector512<ulong> Or (System.Runtime.Intrinsics.Vector512<ulong> left, System.Runtime.Intrinsics.Vector512<ulong> right);
  * public static System.Runtime.Intrinsics.Vector512<double> Permute2x64 (System.Runtime.Intrinsics.Vector512<double> value, byte control);
  * public static System.Runtime.Intrinsics.Vector512<float> Permute4x32 (System.Runtime.Intrinsics.Vector512<float> value, byte control);
  * public static System.Runtime.Intrinsics.Vector512<double> Permute4x64 (System.Runtime.Intrinsics.Vector512<double> value, byte control);
  * public static System.Runtime.Intrinsics.Vector512<long> Permute4x64 (System.Runtime.Intrinsics.Vector512<long> value, byte control);
  * public static System.Runtime.Intrinsics.Vector512<ulong> Permute4x64 (System.Runtime.Intrinsics.Vector512<ulong> value, byte control);
  * public static System.Runtime.Intrinsics.Vector512<int> PermuteVar16x32 (System.Runtime.Intrinsics.Vector512<int> left, System.Runtime.Intrinsics.Vector512<int> control);
  * public static System.Runtime.Intrinsics.Vector512<float> PermuteVar16x32 (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<int> control);
  * public static System.Runtime.Intrinsics.Vector512<uint> PermuteVar16x32 (System.Runtime.Intrinsics.Vector512<uint> left, System.Runtime.Intrinsics.Vector512<uint> control);
  * public static System.Runtime.Intrinsics.Vector512<int> PermuteVar16x32x2 (System.Runtime.Intrinsics.Vector512<int> lower, System.Runtime.Intrinsics.Vector512<int> indices, System.Runtime.Intrinsics.Vector512<int> upper);
  * public static System.Runtime.Intrinsics.Vector512<float> PermuteVar16x32x2 (System.Runtime.Intrinsics.Vector512<float> lower, System.Runtime.Intrinsics.Vector512<int> indices, System.Runtime.Intrinsics.Vector512<float> upper);
  * public static System.Runtime.Intrinsics.Vector512<uint> PermuteVar16x32x2 (System.Runtime.Intrinsics.Vector512<uint> lower, System.Runtime.Intrinsics.Vector512<uint> indices, System.Runtime.Intrinsics.Vector512<uint> upper);
  * public static System.Runtime.Intrinsics.Vector512<double> PermuteVar2x64 (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<long> control);
  * public static System.Runtime.Intrinsics.Vector512<float> PermuteVar4x32 (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<int> control);
  * public static System.Runtime.Intrinsics.Vector512<double> PermuteVar8x64 (System.Runtime.Intrinsics.Vector512<double> value, System.Runtime.Intrinsics.Vector512<long> control);
  * public static System.Runtime.Intrinsics.Vector512<long> PermuteVar8x64 (System.Runtime.Intrinsics.Vector512<long> value, System.Runtime.Intrinsics.Vector512<long> control);
  * public static System.Runtime.Intrinsics.Vector512<ulong> PermuteVar8x64 (System.Runtime.Intrinsics.Vector512<ulong> value, System.Runtime.Intrinsics.Vector512<ulong> control);
  * public static System.Runtime.Intrinsics.Vector512<double> PermuteVar8x64x2 (System.Runtime.Intrinsics.Vector512<double> lower, System.Runtime.Intrinsics.Vector512<long> indices, System.Runtime.Intrinsics.Vector512<double> upper);
  * public static System.Runtime.Intrinsics.Vector512<long> PermuteVar8x64x2 (System.Runtime.Intrinsics.Vector512<long> lower, System.Runtime.Intrinsics.Vector512<long> indices, System.Runtime.Intrinsics.Vector512<long> upper);
  * public static System.Runtime.Intrinsics.Vector512<ulong> PermuteVar8x64x2 (System.Runtime.Intrinsics.Vector512<ulong> lower, System.Runtime.Intrinsics.Vector512<ulong> indices, System.Runtime.Intrinsics.Vector512<ulong> upper);
  * public static System.Runtime.Intrinsics.Vector512<double> Reciprocal14 (System.Runtime.Intrinsics.Vector512<double> value);
  * public static System.Runtime.Intrinsics.Vector512<float> Reciprocal14 (System.Runtime.Intrinsics.Vector512<float> value);
  * public static System.Runtime.Intrinsics.Vector128<double> Reciprocal14Scalar (System.Runtime.Intrinsics.Vector128<double> value);
  * public static System.Runtime.Intrinsics.Vector128<float> Reciprocal14Scalar (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector128<double> Reciprocal14Scalar (System.Runtime.Intrinsics.Vector128<double> upper, System.Runtime.Intrinsics.Vector128<double> value);
  * public static System.Runtime.Intrinsics.Vector128<float> Reciprocal14Scalar (System.Runtime.Intrinsics.Vector128<float> upper, System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector512<double> ReciprocalSqrt14 (System.Runtime.Intrinsics.Vector512<double> value);
  * public static System.Runtime.Intrinsics.Vector512<float> ReciprocalSqrt14 (System.Runtime.Intrinsics.Vector512<float> value);
  * public static System.Runtime.Intrinsics.Vector128<double> ReciprocalSqrt14Scalar (System.Runtime.Intrinsics.Vector128<double> value);
  * public static System.Runtime.Intrinsics.Vector128<float> ReciprocalSqrt14Scalar (System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector128<double> ReciprocalSqrt14Scalar (System.Runtime.Intrinsics.Vector128<double> upper, System.Runtime.Intrinsics.Vector128<double> value);
  * public static System.Runtime.Intrinsics.Vector128<float> ReciprocalSqrt14Scalar (System.Runtime.Intrinsics.Vector128<float> upper, System.Runtime.Intrinsics.Vector128<float> value);
  * public static System.Runtime.Intrinsics.Vector512<int> RotateLeft (System.Runtime.Intrinsics.Vector512<int> value, byte count);
  * public static System.Runtime.Intrinsics.Vector512<long> RotateLeft (System.Runtime.Intrinsics.Vector512<long> value, byte count);
  * public static System.Runtime.Intrinsics.Vector512<uint> RotateLeft (System.Runtime.Intrinsics.Vector512<uint> value, byte count);
  * public static System.Runtime.Intrinsics.Vector512<ulong> RotateLeft (System.Runtime.Intrinsics.Vector512<ulong> value, byte count);
  * public static System.Runtime.Intrinsics.Vector512<int> RotateLeftVariable (System.Runtime.Intrinsics.Vector512<int> value, System.Runtime.Intrinsics.Vector512<uint> count);
  * public static System.Runtime.Intrinsics.Vector512<long> RotateLeftVariable (System.Runtime.Intrinsics.Vector512<long> value, System.Runtime.Intrinsics.Vector512<ulong> count);
  * public static System.Runtime.Intrinsics.Vector512<uint> RotateLeftVariable (System.Runtime.Intrinsics.Vector512<uint> value, System.Runtime.Intrinsics.Vector512<uint> count);
  * public static System.Runtime.Intrinsics.Vector512<ulong> RotateLeftVariable (System.Runtime.Intrinsics.Vector512<ulong> value, System.Runtime.Intrinsics.Vector512<ulong> count);
  * public static System.Runtime.Intrinsics.Vector512<int> RotateRight (System.Runtime.Intrinsics.Vector512<int> value, byte count);
  * public static System.Runtime.Intrinsics.Vector512<long> RotateRight (System.Runtime.Intrinsics.Vector512<long> value, byte count);
  * public static System.Runtime.Intrinsics.Vector512<uint> RotateRight (System.Runtime.Intrinsics.Vector512<uint> value, byte count);
  * public static System.Runtime.Intrinsics.Vector512<ulong> RotateRight (System.Runtime.Intrinsics.Vector512<ulong> value, byte count);
  * public static System.Runtime.Intrinsics.Vector512<int> RotateRightVariable (System.Runtime.Intrinsics.Vector512<int> value, System.Runtime.Intrinsics.Vector512<uint> count);
  * public static System.Runtime.Intrinsics.Vector512<long> RotateRightVariable (System.Runtime.Intrinsics.Vector512<long> value, System.Runtime.Intrinsics.Vector512<ulong> count);
  * public static System.Runtime.Intrinsics.Vector512<uint> RotateRightVariable (System.Runtime.Intrinsics.Vector512<uint> value, System.Runtime.Intrinsics.Vector512<uint> count);
  * public static System.Runtime.Intrinsics.Vector512<ulong> RotateRightVariable (System.Runtime.Intrinsics.Vector512<ulong> value, System.Runtime.Intrinsics.Vector512<ulong> count);
  * public static System.Runtime.Intrinsics.Vector512<double> RoundScale (System.Runtime.Intrinsics.Vector512<double> value, byte control);
  * public static System.Runtime.Intrinsics.Vector512<float> RoundScale (System.Runtime.Intrinsics.Vector512<float> value, byte control);
  * public static System.Runtime.Intrinsics.Vector128<double> RoundScaleScalar (System.Runtime.Intrinsics.Vector128<double> value, byte control);
  * public static System.Runtime.Intrinsics.Vector128<float> RoundScaleScalar (System.Runtime.Intrinsics.Vector128<float> value, byte control);
  * public static System.Runtime.Intrinsics.Vector128<double> RoundScaleScalar (System.Runtime.Intrinsics.Vector128<double> upper, System.Runtime.Intrinsics.Vector128<double> value, byte control);
  * public static System.Runtime.Intrinsics.Vector128<float> RoundScaleScalar (System.Runtime.Intrinsics.Vector128<float> upper, System.Runtime.Intrinsics.Vector128<float> value, byte control);
  * public static System.Runtime.Intrinsics.Vector512<double> Scale (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right);
  * public static System.Runtime.Intrinsics.Vector512<float> Scale (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right);
  * public static System.Runtime.Intrinsics.Vector128<double> ScaleScalar (System.Runtime.Intrinsics.Vector128<double> left, System.Runtime.Intrinsics.Vector128<double> right);
  * public static System.Runtime.Intrinsics.Vector128<float> ScaleScalar (System.Runtime.Intrinsics.Vector128<float> left, System.Runtime.Intrinsics.Vector128<float> right);
  * public static System.Runtime.Intrinsics.Vector512<int> ShiftLeftLogical (System.Runtime.Intrinsics.Vector512<int> value, byte count);
  * public static System.Runtime.Intrinsics.Vector512<int> ShiftLeftLogical (System.Runtime.Intrinsics.Vector512<int> value, System.Runtime.Intrinsics.Vector128<int> count);
  * public static System.Runtime.Intrinsics.Vector512<long> ShiftLeftLogical (System.Runtime.Intrinsics.Vector512<long> value, byte count);
  * public static System.Runtime.Intrinsics.Vector512<long> ShiftLeftLogical (System.Runtime.Intrinsics.Vector512<long> value, System.Runtime.Intrinsics.Vector128<long> count);
  * public static System.Runtime.Intrinsics.Vector512<uint> ShiftLeftLogical (System.Runtime.Intrinsics.Vector512<uint> value, byte count);
  * public static System.Runtime.Intrinsics.Vector512<uint> ShiftLeftLogical (System.Runtime.Intrinsics.Vector512<uint> value, System.Runtime.Intrinsics.Vector128<uint> count);
  * public static System.Runtime.Intrinsics.Vector512<ulong> ShiftLeftLogical (System.Runtime.Intrinsics.Vector512<ulong> value, byte count);
  * public static System.Runtime.Intrinsics.Vector512<ulong> ShiftLeftLogical (System.Runtime.Intrinsics.Vector512<ulong> value, System.Runtime.Intrinsics.Vector128<ulong> count);
  * public static System.Runtime.Intrinsics.Vector512<int> ShiftLeftLogicalVariable (System.Runtime.Intrinsics.Vector512<int> value, System.Runtime.Intrinsics.Vector512<uint> count);
  * public static System.Runtime.Intrinsics.Vector512<long> ShiftLeftLogicalVariable (System.Runtime.Intrinsics.Vector512<long> value, System.Runtime.Intrinsics.Vector512<ulong> count);
  * public static System.Runtime.Intrinsics.Vector512<uint> ShiftLeftLogicalVariable (System.Runtime.Intrinsics.Vector512<uint> value, System.Runtime.Intrinsics.Vector512<uint> count);
  * public static System.Runtime.Intrinsics.Vector512<ulong> ShiftLeftLogicalVariable (System.Runtime.Intrinsics.Vector512<ulong> value, System.Runtime.Intrinsics.Vector512<ulong> count);
  * public static System.Runtime.Intrinsics.Vector512<int> ShiftRightArithmetic (System.Runtime.Intrinsics.Vector512<int> value, byte count);
  * public static System.Runtime.Intrinsics.Vector512<int> ShiftRightArithmetic (System.Runtime.Intrinsics.Vector512<int> value, System.Runtime.Intrinsics.Vector128<int> count);
  * public static System.Runtime.Intrinsics.Vector512<long> ShiftRightArithmetic (System.Runtime.Intrinsics.Vector512<long> value, byte count);
  * public static System.Runtime.Intrinsics.Vector512<long> ShiftRightArithmetic (System.Runtime.Intrinsics.Vector512<long> value, System.Runtime.Intrinsics.Vector128<long> count);
  * public static System.Runtime.Intrinsics.Vector512<int> ShiftRightArithmeticVariable (System.Runtime.Intrinsics.Vector512<int> value, System.Runtime.Intrinsics.Vector512<uint> count);
  * public static System.Runtime.Intrinsics.Vector512<long> ShiftRightArithmeticVariable (System.Runtime.Intrinsics.Vector512<long> value, System.Runtime.Intrinsics.Vector512<ulong> count);
  * public static System.Runtime.Intrinsics.Vector512<int> ShiftRightLogical (System.Runtime.Intrinsics.Vector512<int> value, byte count);
  * public static System.Runtime.Intrinsics.Vector512<int> ShiftRightLogical (System.Runtime.Intrinsics.Vector512<int> value, System.Runtime.Intrinsics.Vector128<int> count);
  * public static System.Runtime.Intrinsics.Vector512<long> ShiftRightLogical (System.Runtime.Intrinsics.Vector512<long> value, byte count);
  * public static System.Runtime.Intrinsics.Vector512<long> ShiftRightLogical (System.Runtime.Intrinsics.Vector512<long> value, System.Runtime.Intrinsics.Vector128<long> count);
  * public static System.Runtime.Intrinsics.Vector512<uint> ShiftRightLogical (System.Runtime.Intrinsics.Vector512<uint> value, byte count);
  * public static System.Runtime.Intrinsics.Vector512<uint> ShiftRightLogical (System.Runtime.Intrinsics.Vector512<uint> value, System.Runtime.Intrinsics.Vector128<uint> count);
  * public static System.Runtime.Intrinsics.Vector512<ulong> ShiftRightLogical (System.Runtime.Intrinsics.Vector512<ulong> value, byte count);
  * public static System.Runtime.Intrinsics.Vector512<ulong> ShiftRightLogical (System.Runtime.Intrinsics.Vector512<ulong> value, System.Runtime.Intrinsics.Vector128<ulong> count);
  * public static System.Runtime.Intrinsics.Vector512<int> ShiftRightLogicalVariable (System.Runtime.Intrinsics.Vector512<int> value, System.Runtime.Intrinsics.Vector512<uint> count);
  * public static System.Runtime.Intrinsics.Vector512<long> ShiftRightLogicalVariable (System.Runtime.Intrinsics.Vector512<long> value, System.Runtime.Intrinsics.Vector512<ulong> count);
  * public static System.Runtime.Intrinsics.Vector512<uint> ShiftRightLogicalVariable (System.Runtime.Intrinsics.Vector512<uint> value, System.Runtime.Intrinsics.Vector512<uint> count);
  * public static System.Runtime.Intrinsics.Vector512<ulong> ShiftRightLogicalVariable (System.Runtime.Intrinsics.Vector512<ulong> value, System.Runtime.Intrinsics.Vector512<ulong> count);
  * public static System.Runtime.Intrinsics.Vector512<int> Shuffle (System.Runtime.Intrinsics.Vector512<int> value, byte control);
  * public static System.Runtime.Intrinsics.Vector512<uint> Shuffle (System.Runtime.Intrinsics.Vector512<uint> value, byte control);
  * public static System.Runtime.Intrinsics.Vector512<double> Shuffle (System.Runtime.Intrinsics.Vector512<double> value, System.Runtime.Intrinsics.Vector512<double> right, byte control);
  * public static System.Runtime.Intrinsics.Vector512<float> Shuffle (System.Runtime.Intrinsics.Vector512<float> value, System.Runtime.Intrinsics.Vector512<float> right, byte control);
  * public static System.Runtime.Intrinsics.Vector512<double> Shuffle4x128 (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right, byte control);
  * public static System.Runtime.Intrinsics.Vector512<int> Shuffle4x128 (System.Runtime.Intrinsics.Vector512<int> left, System.Runtime.Intrinsics.Vector512<int> right, byte control);
  * public static System.Runtime.Intrinsics.Vector512<long> Shuffle4x128 (System.Runtime.Intrinsics.Vector512<long> left, System.Runtime.Intrinsics.Vector512<long> right, byte control);
  * public static System.Runtime.Intrinsics.Vector512<float> Shuffle4x128 (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right, byte control);
  * public static System.Runtime.Intrinsics.Vector512<uint> Shuffle4x128 (System.Runtime.Intrinsics.Vector512<uint> left, System.Runtime.Intrinsics.Vector512<uint> right, byte control);
  * public static System.Runtime.Intrinsics.Vector512<ulong> Shuffle4x128 (System.Runtime.Intrinsics.Vector512<ulong> left, System.Runtime.Intrinsics.Vector512<ulong> right, byte control);
  * public static System.Runtime.Intrinsics.Vector512<double> Sqrt (System.Runtime.Intrinsics.Vector512<double> value);
  * public static System.Runtime.Intrinsics.Vector512<float> Sqrt (System.Runtime.Intrinsics.Vector512<float> value);
  * public static void Store (byte* address, System.Runtime.Intrinsics.Vector512<byte> source);
  * public static void Store (double* address, System.Runtime.Intrinsics.Vector512<double> source);
  * public static void Store (short* address, System.Runtime.Intrinsics.Vector512<short> source);
  * public static void Store (int* address, System.Runtime.Intrinsics.Vector512<int> source);
  * public static void Store (long* address, System.Runtime.Intrinsics.Vector512<long> source);
  * public static void Store (sbyte* address, System.Runtime.Intrinsics.Vector512<sbyte> source);
  * public static void Store (float* address, System.Runtime.Intrinsics.Vector512<float> source);
  * public static void Store (ushort* address, System.Runtime.Intrinsics.Vector512<ushort> source);
  * public static void Store (uint* address, System.Runtime.Intrinsics.Vector512<uint> source);
  * public static void Store (ulong* address, System.Runtime.Intrinsics.Vector512<ulong> source);
  * public static void StoreAligned (byte* address, System.Runtime.Intrinsics.Vector512<byte> source);
  * public static void StoreAligned (double* address, System.Runtime.Intrinsics.Vector512<double> source);
  * public static void StoreAligned (short* address, System.Runtime.Intrinsics.Vector512<short> source);
  * public static void StoreAligned (int* address, System.Runtime.Intrinsics.Vector512<int> source);
  * public static void StoreAligned (long* address, System.Runtime.Intrinsics.Vector512<long> source);
  * public static void StoreAligned (sbyte* address, System.Runtime.Intrinsics.Vector512<sbyte> source);
  * public static void StoreAligned (float* address, System.Runtime.Intrinsics.Vector512<float> source);
  * public static void StoreAligned (ushort* address, System.Runtime.Intrinsics.Vector512<ushort> source);
  * public static void StoreAligned (uint* address, System.Runtime.Intrinsics.Vector512<uint> source);
  * public static void StoreAligned (ulong* address, System.Runtime.Intrinsics.Vector512<ulong> source);
  * public static void StoreAlignedNonTemporal (byte* address, System.Runtime.Intrinsics.Vector512<byte> source);
  * public static void StoreAlignedNonTemporal (double* address, System.Runtime.Intrinsics.Vector512<double> source);
  * public static void StoreAlignedNonTemporal (short* address, System.Runtime.Intrinsics.Vector512<short> source);
  * public static void StoreAlignedNonTemporal (int* address, System.Runtime.Intrinsics.Vector512<int> source);
  * public static void StoreAlignedNonTemporal (long* address, System.Runtime.Intrinsics.Vector512<long> source);
  * public static void StoreAlignedNonTemporal (sbyte* address, System.Runtime.Intrinsics.Vector512<sbyte> source);
  * public static void StoreAlignedNonTemporal (float* address, System.Runtime.Intrinsics.Vector512<float> source);
  * public static void StoreAlignedNonTemporal (ushort* address, System.Runtime.Intrinsics.Vector512<ushort> source);
  * public static void StoreAlignedNonTemporal (uint* address, System.Runtime.Intrinsics.Vector512<uint> source);
  * public static void StoreAlignedNonTemporal (ulong* address, System.Runtime.Intrinsics.Vector512<ulong> source);
  * public static System.Runtime.Intrinsics.Vector512<double> Subtract (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right);
  * public static System.Runtime.Intrinsics.Vector512<int> Subtract (System.Runtime.Intrinsics.Vector512<int> left, System.Runtime.Intrinsics.Vector512<int> right);
  * public static System.Runtime.Intrinsics.Vector512<long> Subtract (System.Runtime.Intrinsics.Vector512<long> left, System.Runtime.Intrinsics.Vector512<long> right);
  * public static System.Runtime.Intrinsics.Vector512<float> Subtract (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right);
  * public static System.Runtime.Intrinsics.Vector512<uint> Subtract (System.Runtime.Intrinsics.Vector512<uint> left, System.Runtime.Intrinsics.Vector512<uint> right);
  * public static System.Runtime.Intrinsics.Vector512<ulong> Subtract (System.Runtime.Intrinsics.Vector512<ulong> left, System.Runtime.Intrinsics.Vector512<ulong> right);
  * public static System.Runtime.Intrinsics.Vector512<byte> TernaryLogic (System.Runtime.Intrinsics.Vector512<byte> a, System.Runtime.Intrinsics.Vector512<byte> b, System.Runtime.Intrinsics.Vector512<byte> c, byte control);
  * public static System.Runtime.Intrinsics.Vector512<double> TernaryLogic (System.Runtime.Intrinsics.Vector512<double> a, System.Runtime.Intrinsics.Vector512<double> b, System.Runtime.Intrinsics.Vector512<double> c, byte control);
  * public static System.Runtime.Intrinsics.Vector512<short> TernaryLogic (System.Runtime.Intrinsics.Vector512<short> a, System.Runtime.Intrinsics.Vector512<short> b, System.Runtime.Intrinsics.Vector512<short> c, byte control);
  * public static System.Runtime.Intrinsics.Vector512<int> TernaryLogic (System.Runtime.Intrinsics.Vector512<int> a, System.Runtime.Intrinsics.Vector512<int> b, System.Runtime.Intrinsics.Vector512<int> c, byte control);
  * public static System.Runtime.Intrinsics.Vector512<long> TernaryLogic (System.Runtime.Intrinsics.Vector512<long> a, System.Runtime.Intrinsics.Vector512<long> b, System.Runtime.Intrinsics.Vector512<long> c, byte control);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> TernaryLogic (System.Runtime.Intrinsics.Vector512<sbyte> a, System.Runtime.Intrinsics.Vector512<sbyte> b, System.Runtime.Intrinsics.Vector512<sbyte> c, byte control);
  * public static System.Runtime.Intrinsics.Vector512<float> TernaryLogic (System.Runtime.Intrinsics.Vector512<float> a, System.Runtime.Intrinsics.Vector512<float> b, System.Runtime.Intrinsics.Vector512<float> c, byte control);
  * public static System.Runtime.Intrinsics.Vector512<ushort> TernaryLogic (System.Runtime.Intrinsics.Vector512<ushort> a, System.Runtime.Intrinsics.Vector512<ushort> b, System.Runtime.Intrinsics.Vector512<ushort> c, byte control);
  * public static System.Runtime.Intrinsics.Vector512<uint> TernaryLogic (System.Runtime.Intrinsics.Vector512<uint> a, System.Runtime.Intrinsics.Vector512<uint> b, System.Runtime.Intrinsics.Vector512<uint> c, byte control);
  * public static System.Runtime.Intrinsics.Vector512<ulong> TernaryLogic (System.Runtime.Intrinsics.Vector512<ulong> a, System.Runtime.Intrinsics.Vector512<ulong> b, System.Runtime.Intrinsics.Vector512<ulong> c, byte control);
  * public static System.Runtime.Intrinsics.Vector512<double> UnpackHigh (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right);
  * public static System.Runtime.Intrinsics.Vector512<int> UnpackHigh (System.Runtime.Intrinsics.Vector512<int> left, System.Runtime.Intrinsics.Vector512<int> right);
  * public static System.Runtime.Intrinsics.Vector512<long> UnpackHigh (System.Runtime.Intrinsics.Vector512<long> left, System.Runtime.Intrinsics.Vector512<long> right);
  * public static System.Runtime.Intrinsics.Vector512<float> UnpackHigh (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right);
  * public static System.Runtime.Intrinsics.Vector512<uint> UnpackHigh (System.Runtime.Intrinsics.Vector512<uint> left, System.Runtime.Intrinsics.Vector512<uint> right);
  * public static System.Runtime.Intrinsics.Vector512<ulong> UnpackHigh (System.Runtime.Intrinsics.Vector512<ulong> left, System.Runtime.Intrinsics.Vector512<ulong> right);
  * public static System.Runtime.Intrinsics.Vector512<double> UnpackLow (System.Runtime.Intrinsics.Vector512<double> left, System.Runtime.Intrinsics.Vector512<double> right);
  * public static System.Runtime.Intrinsics.Vector512<int> UnpackLow (System.Runtime.Intrinsics.Vector512<int> left, System.Runtime.Intrinsics.Vector512<int> right);
  * public static System.Runtime.Intrinsics.Vector512<long> UnpackLow (System.Runtime.Intrinsics.Vector512<long> left, System.Runtime.Intrinsics.Vector512<long> right);
  * public static System.Runtime.Intrinsics.Vector512<float> UnpackLow (System.Runtime.Intrinsics.Vector512<float> left, System.Runtime.Intrinsics.Vector512<float> right);
  * public static System.Runtime.Intrinsics.Vector512<uint> UnpackLow (System.Runtime.Intrinsics.Vector512<uint> left, System.Runtime.Intrinsics.Vector512<uint> right);
  * public static System.Runtime.Intrinsics.Vector512<ulong> UnpackLow (System.Runtime.Intrinsics.Vector512<ulong> left, System.Runtime.Intrinsics.Vector512<ulong> right);
  * public static System.Runtime.Intrinsics.Vector512<byte> Xor (System.Runtime.Intrinsics.Vector512<byte> left, System.Runtime.Intrinsics.Vector512<byte> right);
  * public static System.Runtime.Intrinsics.Vector512<short> Xor (System.Runtime.Intrinsics.Vector512<short> left, System.Runtime.Intrinsics.Vector512<short> right);
  * public static System.Runtime.Intrinsics.Vector512<int> Xor (System.Runtime.Intrinsics.Vector512<int> left, System.Runtime.Intrinsics.Vector512<int> right);
  * public static System.Runtime.Intrinsics.Vector512<long> Xor (System.Runtime.Intrinsics.Vector512<long> left, System.Runtime.Intrinsics.Vector512<long> right);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> Xor (System.Runtime.Intrinsics.Vector512<sbyte> left, System.Runtime.Intrinsics.Vector512<sbyte> right);
  * public static System.Runtime.Intrinsics.Vector512<ushort> Xor (System.Runtime.Intrinsics.Vector512<ushort> left, System.Runtime.Intrinsics.Vector512<ushort> right);
  * public static System.Runtime.Intrinsics.Vector512<uint> Xor (System.Runtime.Intrinsics.Vector512<uint> left, System.Runtime.Intrinsics.Vector512<uint> right);
  * public static System.Runtime.Intrinsics.Vector512<ulong> Xor (System.Runtime.Intrinsics.Vector512<ulong> left, System.Runtime.Intrinsics.Vector512<ulong> right);
* System.Runtime.Intrinsics.X86.Avx512Vbmi+VL
  * public static bool IsSupported { get; }
  * public static System.Runtime.Intrinsics.Vector128<byte> PermuteVar16x8 (System.Runtime.Intrinsics.Vector128<byte> left, System.Runtime.Intrinsics.Vector128<byte> control);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> PermuteVar16x8 (System.Runtime.Intrinsics.Vector128<sbyte> left, System.Runtime.Intrinsics.Vector128<sbyte> control);
  * public static System.Runtime.Intrinsics.Vector128<byte> PermuteVar16x8x2 (System.Runtime.Intrinsics.Vector128<byte> lower, System.Runtime.Intrinsics.Vector128<byte> indices, System.Runtime.Intrinsics.Vector128<byte> upper);
  * public static System.Runtime.Intrinsics.Vector128<sbyte> PermuteVar16x8x2 (System.Runtime.Intrinsics.Vector128<sbyte> lower, System.Runtime.Intrinsics.Vector128<sbyte> indices, System.Runtime.Intrinsics.Vector128<sbyte> upper);
  * public static System.Runtime.Intrinsics.Vector256<byte> PermuteVar32x8 (System.Runtime.Intrinsics.Vector256<byte> left, System.Runtime.Intrinsics.Vector256<byte> control);
  * public static System.Runtime.Intrinsics.Vector256<sbyte> PermuteVar32x8 (System.Runtime.Intrinsics.Vector256<sbyte> left, System.Runtime.Intrinsics.Vector256<sbyte> control);
  * public static System.Runtime.Intrinsics.Vector256<byte> PermuteVar32x8x2 (System.Runtime.Intrinsics.Vector256<byte> lower, System.Runtime.Intrinsics.Vector256<byte> indices, System.Runtime.Intrinsics.Vector256<byte> upper);
  * public static System.Runtime.Intrinsics.Vector256<sbyte> PermuteVar32x8x2 (System.Runtime.Intrinsics.Vector256<sbyte> lower, System.Runtime.Intrinsics.Vector256<sbyte> indices, System.Runtime.Intrinsics.Vector256<sbyte> upper);
* System.Runtime.Intrinsics.X86.Avx512Vbmi+X64
  * public static bool IsSupported { get; }
* System.Runtime.Intrinsics.X86.Avx512Vbmi
  * public static bool IsSupported { get; }
  * public static System.Runtime.Intrinsics.Vector512<byte> PermuteVar64x8 (System.Runtime.Intrinsics.Vector512<byte> left, System.Runtime.Intrinsics.Vector512<byte> control);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> PermuteVar64x8 (System.Runtime.Intrinsics.Vector512<sbyte> left, System.Runtime.Intrinsics.Vector512<sbyte> control);
  * public static System.Runtime.Intrinsics.Vector512<byte> PermuteVar64x8x2 (System.Runtime.Intrinsics.Vector512<byte> lower, System.Runtime.Intrinsics.Vector512<byte> indices, System.Runtime.Intrinsics.Vector512<byte> upper);
  * public static System.Runtime.Intrinsics.Vector512<sbyte> PermuteVar64x8x2 (System.Runtime.Intrinsics.Vector512<sbyte> lower, System.Runtime.Intrinsics.Vector512<sbyte> indices, System.Runtime.Intrinsics.Vector512<sbyte> upper);
* System.Runtime.Intrinsics.X86.X86Base+X64
  * public static (long Quotient, long Remainder) DivRem (ulong lower, long upper, long divisor);
  * public static (ulong Quotient, ulong Remainder) DivRem (ulong lower, ulong upper, ulong divisor);
* System.Runtime.Intrinsics.X86.X86Base
  * public static (int Quotient, int Remainder) DivRem (uint lower, int upper, int divisor);
  * public static (uint Quotient, uint Remainder) DivRem (uint lower, uint upper, uint divisor);
  * public static (IntPtr Quotient, IntPtr Remainder) DivRem (UIntPtr lower, IntPtr upper, IntPtr divisor);
  * public static (UIntPtr Quotient, UIntPtr Remainder) DivRem (UIntPtr lower, UIntPtr upper, UIntPtr divisor);
* System.Security.Cryptography.AesGcm
  * public AesGcm (byte[] key, int tagSizeInBytes);
  * public AesGcm (ReadOnlySpan<byte> key, int tagSizeInBytes);
  * public int? TagSizeInBytes { get; }
* System.Security.Cryptography.AsymmetricAlgorithm
  * public string ExportEncryptedPkcs8PrivateKeyPem (ReadOnlySpan<byte> passwordBytes, System.Security.Cryptography.PbeParameters pbeParameters);
  * public bool TryExportEncryptedPkcs8PrivateKeyPem (ReadOnlySpan<byte> passwordBytes, System.Security.Cryptography.PbeParameters pbeParameters, Span<char> destination, out int charsWritten);
* System.Security.Cryptography.AuthenticationTagMismatchException
  * public AuthenticationTagMismatchException ();
  * public AuthenticationTagMismatchException (string? message);
  * public AuthenticationTagMismatchException (string? message, Exception? inner);
* System.Security.Cryptography.ECDiffieHellman
  * public virtual byte[] DeriveRawSecretAgreement (System.Security.Cryptography.ECDiffieHellmanPublicKey otherPartyPublicKey);
* System.Security.Cryptography.HashAlgorithmName
  * public static System.Security.Cryptography.HashAlgorithmName SHA3_256 { get; }
  * public static System.Security.Cryptography.HashAlgorithmName SHA3_384 { get; }
  * public static System.Security.Cryptography.HashAlgorithmName SHA3_512 { get; }
* System.Security.Cryptography.HMACSHA3_256
  * public HMACSHA3_256 ();
  * public HMACSHA3_256 (byte[] key);
  * protected override void Dispose (bool disposing);
  * protected override void HashCore (ReadOnlySpan<byte> source);
  * protected override void HashCore (byte[] rgb, int ib, int cb);
  * public static byte[] HashData (byte[] key, byte[] source);
  * public static byte[] HashData (byte[] key, System.IO.Stream source);
  * public static byte[] HashData (ReadOnlySpan<byte> key, System.IO.Stream source);
  * public static byte[] HashData (ReadOnlySpan<byte> key, ReadOnlySpan<byte> source);
  * public static int HashData (ReadOnlySpan<byte> key, System.IO.Stream source, Span<byte> destination);
  * public static int HashData (ReadOnlySpan<byte> key, ReadOnlySpan<byte> source, Span<byte> destination);
  * public static System.Threading.Tasks.ValueTask<byte[]> HashDataAsync (byte[] key, System.IO.Stream source, System.Threading.CancellationToken cancellationToken = default);
  * public static System.Threading.Tasks.ValueTask<byte[]> HashDataAsync (ReadOnlyMemory<byte> key, System.IO.Stream source, System.Threading.CancellationToken cancellationToken = default);
  * public static System.Threading.Tasks.ValueTask<int> HashDataAsync (ReadOnlyMemory<byte> key, System.IO.Stream source, Memory<byte> destination, System.Threading.CancellationToken cancellationToken = default);
  * protected override byte[] HashFinal ();
  * public const int HashSizeInBits = 256;
  * public const int HashSizeInBytes = 32;
  * public override void Initialize ();
  * public static bool IsSupported { get; }
  * public override byte[] Key { get; set; }
  * public static bool TryHashData (ReadOnlySpan<byte> key, ReadOnlySpan<byte> source, Span<byte> destination, out int bytesWritten);
  * protected override bool TryHashFinal (Span<byte> destination, out int bytesWritten);
* System.Security.Cryptography.HMACSHA3_384
  * public HMACSHA3_384 ();
  * public HMACSHA3_384 (byte[] key);
  * protected override void Dispose (bool disposing);
  * protected override void HashCore (ReadOnlySpan<byte> source);
  * protected override void HashCore (byte[] rgb, int ib, int cb);
  * public static byte[] HashData (byte[] key, byte[] source);
  * public static byte[] HashData (byte[] key, System.IO.Stream source);
  * public static byte[] HashData (ReadOnlySpan<byte> key, System.IO.Stream source);
  * public static byte[] HashData (ReadOnlySpan<byte> key, ReadOnlySpan<byte> source);
  * public static int HashData (ReadOnlySpan<byte> key, System.IO.Stream source, Span<byte> destination);
  * public static int HashData (ReadOnlySpan<byte> key, ReadOnlySpan<byte> source, Span<byte> destination);
  * public static System.Threading.Tasks.ValueTask<byte[]> HashDataAsync (byte[] key, System.IO.Stream source, System.Threading.CancellationToken cancellationToken = default);
  * public static System.Threading.Tasks.ValueTask<byte[]> HashDataAsync (ReadOnlyMemory<byte> key, System.IO.Stream source, System.Threading.CancellationToken cancellationToken = default);
  * public static System.Threading.Tasks.ValueTask<int> HashDataAsync (ReadOnlyMemory<byte> key, System.IO.Stream source, Memory<byte> destination, System.Threading.CancellationToken cancellationToken = default);
  * protected override byte[] HashFinal ();
  * public const int HashSizeInBits = 384;
  * public const int HashSizeInBytes = 48;
  * public override void Initialize ();
  * public static bool IsSupported { get; }
  * public override byte[] Key { get; set; }
  * public static bool TryHashData (ReadOnlySpan<byte> key, ReadOnlySpan<byte> source, Span<byte> destination, out int bytesWritten);
  * protected override bool TryHashFinal (Span<byte> destination, out int bytesWritten);
* System.Security.Cryptography.HMACSHA3_512
  * public HMACSHA3_512 ();
  * public HMACSHA3_512 (byte[] key);
  * protected override void Dispose (bool disposing);
  * protected override void HashCore (ReadOnlySpan<byte> source);
  * protected override void HashCore (byte[] rgb, int ib, int cb);
  * public static byte[] HashData (byte[] key, byte[] source);
  * public static byte[] HashData (byte[] key, System.IO.Stream source);
  * public static byte[] HashData (ReadOnlySpan<byte> key, System.IO.Stream source);
  * public static byte[] HashData (ReadOnlySpan<byte> key, ReadOnlySpan<byte> source);
  * public static int HashData (ReadOnlySpan<byte> key, System.IO.Stream source, Span<byte> destination);
  * public static int HashData (ReadOnlySpan<byte> key, ReadOnlySpan<byte> source, Span<byte> destination);
  * public static System.Threading.Tasks.ValueTask<byte[]> HashDataAsync (byte[] key, System.IO.Stream source, System.Threading.CancellationToken cancellationToken = default);
  * public static System.Threading.Tasks.ValueTask<byte[]> HashDataAsync (ReadOnlyMemory<byte> key, System.IO.Stream source, System.Threading.CancellationToken cancellationToken = default);
  * public static System.Threading.Tasks.ValueTask<int> HashDataAsync (ReadOnlyMemory<byte> key, System.IO.Stream source, Memory<byte> destination, System.Threading.CancellationToken cancellationToken = default);
  * protected override byte[] HashFinal ();
  * public const int HashSizeInBits = 512;
  * public const int HashSizeInBytes = 64;
  * public override void Initialize ();
  * public static bool IsSupported { get; }
  * public override byte[] Key { get; set; }
  * public static bool TryHashData (ReadOnlySpan<byte> key, ReadOnlySpan<byte> source, Span<byte> destination, out int bytesWritten);
  * protected override bool TryHashFinal (Span<byte> destination, out int bytesWritten);
* System.Security.Cryptography.RandomNumberGenerator
  * public static string GetHexString (int stringLength, bool lowercase = false);
  * public static void GetHexString (Span<char> destination, bool lowercase = false);
  * public static T[] GetItems<T> (ReadOnlySpan<T> choices, int length);
  * public static void GetItems<T> (ReadOnlySpan<T> choices, Span<T> destination);
  * public static string GetString (ReadOnlySpan<char> choices, int length);
  * public static void Shuffle<T> (Span<T> values);
* System.Security.Cryptography.RSA
  * public int GetMaxOutputSize ();
* System.Security.Cryptography.RSAEncryptionPadding
  * public static System.Security.Cryptography.RSAEncryptionPadding OaepSHA3_256 { get; }
  * public static System.Security.Cryptography.RSAEncryptionPadding OaepSHA3_384 { get; }
  * public static System.Security.Cryptography.RSAEncryptionPadding OaepSHA3_512 { get; }
* System.Security.Cryptography.SafeEvpPKeyHandle
  * public static System.Security.Cryptography.SafeEvpPKeyHandle OpenPrivateKeyFromEngine (string engineName, string keyId);
  * public static System.Security.Cryptography.SafeEvpPKeyHandle OpenPublicKeyFromEngine (string engineName, string keyId);
* System.Security.Cryptography.SHA3_256
  * protected SHA3_256 ();
  * public static System.Security.Cryptography.SHA3_256 Create ();
  * public static byte[] HashData (byte[] source);
  * public static byte[] HashData (System.IO.Stream source);
  * public static byte[] HashData (ReadOnlySpan<byte> source);
  * public static int HashData (System.IO.Stream source, Span<byte> destination);
  * public static int HashData (ReadOnlySpan<byte> source, Span<byte> destination);
  * public static System.Threading.Tasks.ValueTask<byte[]> HashDataAsync (System.IO.Stream source, System.Threading.CancellationToken cancellationToken = default);
  * public static System.Threading.Tasks.ValueTask<int> HashDataAsync (System.IO.Stream source, Memory<byte> destination, System.Threading.CancellationToken cancellationToken = default);
  * public const int HashSizeInBits = 256;
  * public const int HashSizeInBytes = 32;
  * public static bool IsSupported { get; }
  * public static bool TryHashData (ReadOnlySpan<byte> source, Span<byte> destination, out int bytesWritten);
* System.Security.Cryptography.SHA3_384
  * protected SHA3_384 ();
  * public static System.Security.Cryptography.SHA3_384 Create ();
  * public static byte[] HashData (byte[] source);
  * public static byte[] HashData (System.IO.Stream source);
  * public static byte[] HashData (ReadOnlySpan<byte> source);
  * public static int HashData (System.IO.Stream source, Span<byte> destination);
  * public static int HashData (ReadOnlySpan<byte> source, Span<byte> destination);
  * public static System.Threading.Tasks.ValueTask<byte[]> HashDataAsync (System.IO.Stream source, System.Threading.CancellationToken cancellationToken = default);
  * public static System.Threading.Tasks.ValueTask<int> HashDataAsync (System.IO.Stream source, Memory<byte> destination, System.Threading.CancellationToken cancellationToken = default);
  * public const int HashSizeInBits = 384;
  * public const int HashSizeInBytes = 48;
  * public static bool IsSupported { get; }
  * public static bool TryHashData (ReadOnlySpan<byte> source, Span<byte> destination, out int bytesWritten);
* System.Security.Cryptography.SHA3_512
  * protected SHA3_512 ();
  * public static System.Security.Cryptography.SHA3_512 Create ();
  * public static byte[] HashData (byte[] source);
  * public static byte[] HashData (System.IO.Stream source);
  * public static byte[] HashData (ReadOnlySpan<byte> source);
  * public static int HashData (System.IO.Stream source, Span<byte> destination);
  * public static int HashData (ReadOnlySpan<byte> source, Span<byte> destination);
  * public static System.Threading.Tasks.ValueTask<byte[]> HashDataAsync (System.IO.Stream source, System.Threading.CancellationToken cancellationToken = default);
  * public static System.Threading.Tasks.ValueTask<int> HashDataAsync (System.IO.Stream source, Memory<byte> destination, System.Threading.CancellationToken cancellationToken = default);
  * public const int HashSizeInBits = 512;
  * public const int HashSizeInBytes = 64;
  * public static bool IsSupported { get; }
  * public static bool TryHashData (ReadOnlySpan<byte> source, Span<byte> destination, out int bytesWritten);
* System.Security.Cryptography.Shake128
  * public Shake128 ();
  * public void AppendData (byte[] data);
  * public void AppendData (ReadOnlySpan<byte> data);
  * public void Dispose ();
  * public byte[] GetCurrentHash (int outputLength);
  * public void GetCurrentHash (Span<byte> destination);
  * public byte[] GetHashAndReset (int outputLength);
  * public void GetHashAndReset (Span<byte> destination);
  * public static byte[] HashData (byte[] source, int outputLength);
  * public static byte[] HashData (System.IO.Stream source, int outputLength);
  * public static void HashData (System.IO.Stream source, Span<byte> destination);
  * public static byte[] HashData (ReadOnlySpan<byte> source, int outputLength);
  * public static void HashData (ReadOnlySpan<byte> source, Span<byte> destination);
  * public static System.Threading.Tasks.ValueTask<byte[]> HashDataAsync (System.IO.Stream source, int outputLength, System.Threading.CancellationToken cancellationToken = default);
  * public static System.Threading.Tasks.ValueTask HashDataAsync (System.IO.Stream source, Memory<byte> destination, System.Threading.CancellationToken cancellationToken = default);
  * public static bool IsSupported { get; }
* System.Security.Cryptography.Shake256
  * public Shake256 ();
  * public void AppendData (byte[] data);
  * public void AppendData (ReadOnlySpan<byte> data);
  * public void Dispose ();
  * public byte[] GetCurrentHash (int outputLength);
  * public void GetCurrentHash (Span<byte> destination);
  * public byte[] GetHashAndReset (int outputLength);
  * public void GetHashAndReset (Span<byte> destination);
  * public static byte[] HashData (byte[] source, int outputLength);
  * public static byte[] HashData (System.IO.Stream source, int outputLength);
  * public static void HashData (System.IO.Stream source, Span<byte> destination);
  * public static byte[] HashData (ReadOnlySpan<byte> source, int outputLength);
  * public static void HashData (ReadOnlySpan<byte> source, Span<byte> destination);
  * public static System.Threading.Tasks.ValueTask<byte[]> HashDataAsync (System.IO.Stream source, int outputLength, System.Threading.CancellationToken cancellationToken = default);
  * public static System.Threading.Tasks.ValueTask HashDataAsync (System.IO.Stream source, Memory<byte> destination, System.Threading.CancellationToken cancellationToken = default);
  * public static bool IsSupported { get; }
* System.Security.Cryptography.SP800108HmacCounterKdf
  * public SP800108HmacCounterKdf (byte[] key, System.Security.Cryptography.HashAlgorithmName hashAlgorithm);
  * public SP800108HmacCounterKdf (ReadOnlySpan<byte> key, System.Security.Cryptography.HashAlgorithmName hashAlgorithm);
  * public static byte[] DeriveBytes (byte[] key, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, byte[] label, byte[] context, int derivedKeyLengthInBytes);
  * public static byte[] DeriveBytes (byte[] key, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, string label, string context, int derivedKeyLengthInBytes);
  * public static byte[] DeriveBytes (ReadOnlySpan<byte> key, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, ReadOnlySpan<byte> label, ReadOnlySpan<byte> context, int derivedKeyLengthInBytes);
  * public static void DeriveBytes (ReadOnlySpan<byte> key, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, ReadOnlySpan<byte> label, ReadOnlySpan<byte> context, Span<byte> destination);
  * public static byte[] DeriveBytes (ReadOnlySpan<byte> key, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, ReadOnlySpan<char> label, ReadOnlySpan<char> context, int derivedKeyLengthInBytes);
  * public static void DeriveBytes (ReadOnlySpan<byte> key, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, ReadOnlySpan<char> label, ReadOnlySpan<char> context, Span<byte> destination);
  * public byte[] DeriveKey (byte[] label, byte[] context, int derivedKeyLengthInBytes);
  * public byte[] DeriveKey (ReadOnlySpan<byte> label, ReadOnlySpan<byte> context, int derivedKeyLengthInBytes);
  * public void DeriveKey (ReadOnlySpan<byte> label, ReadOnlySpan<byte> context, Span<byte> destination);
  * public byte[] DeriveKey (ReadOnlySpan<char> label, ReadOnlySpan<char> context, int derivedKeyLengthInBytes);
  * public void DeriveKey (ReadOnlySpan<char> label, ReadOnlySpan<char> context, Span<byte> destination);
  * public byte[] DeriveKey (string label, string context, int derivedKeyLengthInBytes);
  * public void Dispose ();
* System.Text.Ascii
  * public static bool Equals (ReadOnlySpan<byte> left, ReadOnlySpan<byte> right);
  * public static bool Equals (ReadOnlySpan<byte> left, ReadOnlySpan<char> right);
  * public static bool Equals (ReadOnlySpan<char> left, ReadOnlySpan<byte> right);
  * public static bool Equals (ReadOnlySpan<char> left, ReadOnlySpan<char> right);
  * public static bool EqualsIgnoreCase (ReadOnlySpan<byte> left, ReadOnlySpan<byte> right);
  * public static bool EqualsIgnoreCase (ReadOnlySpan<byte> left, ReadOnlySpan<char> right);
  * public static bool EqualsIgnoreCase (ReadOnlySpan<char> left, ReadOnlySpan<byte> right);
  * public static bool EqualsIgnoreCase (ReadOnlySpan<char> left, ReadOnlySpan<char> right);
  * public static System.Buffers.OperationStatus FromUtf16 (ReadOnlySpan<char> source, Span<byte> destination, out int bytesWritten);
  * public static bool IsValid (byte value);
  * public static bool IsValid (char value);
  * public static bool IsValid (ReadOnlySpan<byte> value);
  * public static bool IsValid (ReadOnlySpan<char> value);
  * public static System.Buffers.OperationStatus ToLower (ReadOnlySpan<byte> source, Span<byte> destination, out int bytesWritten);
  * public static System.Buffers.OperationStatus ToLower (ReadOnlySpan<byte> source, Span<char> destination, out int charsWritten);
  * public static System.Buffers.OperationStatus ToLower (ReadOnlySpan<char> source, Span<byte> destination, out int bytesWritten);
  * public static System.Buffers.OperationStatus ToLower (ReadOnlySpan<char> source, Span<char> destination, out int charsWritten);
  * public static System.Buffers.OperationStatus ToLowerInPlace (Span<byte> value, out int bytesWritten);
  * public static System.Buffers.OperationStatus ToLowerInPlace (Span<char> value, out int charsWritten);
  * public static System.Buffers.OperationStatus ToUpper (ReadOnlySpan<byte> source, Span<byte> destination, out int bytesWritten);
  * public static System.Buffers.OperationStatus ToUpper (ReadOnlySpan<byte> source, Span<char> destination, out int charsWritten);
  * public static System.Buffers.OperationStatus ToUpper (ReadOnlySpan<char> source, Span<byte> destination, out int bytesWritten);
  * public static System.Buffers.OperationStatus ToUpper (ReadOnlySpan<char> source, Span<char> destination, out int charsWritten);
  * public static System.Buffers.OperationStatus ToUpperInPlace (Span<byte> value, out int bytesWritten);
  * public static System.Buffers.OperationStatus ToUpperInPlace (Span<char> value, out int charsWritten);
  * public static System.Buffers.OperationStatus ToUtf16 (ReadOnlySpan<byte> source, Span<char> destination, out int charsWritten);
  * public static Range Trim (ReadOnlySpan<byte> value);
  * public static Range Trim (ReadOnlySpan<char> value);
  * public static Range TrimEnd (ReadOnlySpan<byte> value);
  * public static Range TrimEnd (ReadOnlySpan<char> value);
  * public static Range TrimStart (ReadOnlySpan<byte> value);
  * public static Range TrimStart (ReadOnlySpan<char> value);
* System.Text.ASCIIEncoding
  * public override bool TryGetBytes (ReadOnlySpan<char> chars, Span<byte> bytes, out int bytesWritten);
  * public override bool TryGetChars (ReadOnlySpan<byte> bytes, Span<char> chars, out int charsWritten);
* System.Text.CompositeFormat
  * public string Format { get; }
  * public int MinimumArgumentCount { get; }
  * public static System.Text.CompositeFormat Parse (string format);
* System.Text.Encoding
  * public virtual bool TryGetBytes (ReadOnlySpan<char> chars, Span<byte> bytes, out int bytesWritten);
  * public virtual bool TryGetChars (ReadOnlySpan<byte> bytes, Span<char> chars, out int charsWritten);
* System.Text.RedactionStringBuilderExtensions
  * public static System.Text.StringBuilder AppendRedacted (this System.Text.StringBuilder stringBuilder, Microsoft.Extensions.Compliance.Redaction.Redactor redactor, ReadOnlySpan<char> value);
  * public static System.Text.StringBuilder AppendRedacted (this System.Text.StringBuilder stringBuilder, Microsoft.Extensions.Compliance.Redaction.Redactor redactor, string? value);
* System.Text.Rune
  * bool IUtf8SpanFormattable.TryFormat (Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider provider);
* System.Text.StringBuilder
  * public System.Text.StringBuilder AppendFormat (IFormatProvider? provider, System.Text.CompositeFormat format, params object?[] args);
  * public System.Text.StringBuilder AppendFormat (IFormatProvider? provider, System.Text.CompositeFormat format, ReadOnlySpan<object?> args);
  * public System.Text.StringBuilder AppendFormat<TArg0> (IFormatProvider? provider, System.Text.CompositeFormat format, TArg0 arg0);
  * public System.Text.StringBuilder AppendFormat<TArg0,TArg1> (IFormatProvider? provider, System.Text.CompositeFormat format, TArg0 arg0, TArg1 arg1);
  * public System.Text.StringBuilder AppendFormat<TArg0,TArg1,TArg2> (IFormatProvider? provider, System.Text.CompositeFormat format, TArg0 arg0, TArg1 arg1, TArg2 arg2);
* System.Text.UTF8Encoding
  * public override bool TryGetBytes (ReadOnlySpan<char> chars, Span<byte> bytes, out int bytesWritten);
  * public override bool TryGetChars (ReadOnlySpan<byte> bytes, Span<char> chars, out int charsWritten);
* System.Text.Json.JsonEncodedText
  * public string Value { get; }
* System.Text.Json.JsonNamingPolicy
  * public static System.Text.Json.JsonNamingPolicy KebabCaseLower { get; }
  * public static System.Text.Json.JsonNamingPolicy KebabCaseUpper { get; }
  * public static System.Text.Json.JsonNamingPolicy SnakeCaseLower { get; }
  * public static System.Text.Json.JsonNamingPolicy SnakeCaseUpper { get; }
* System.Text.Json.JsonSerializer
  * public static object? Deserialize (System.IO.Stream utf8Json, System.Text.Json.Serialization.Metadata.JsonTypeInfo jsonTypeInfo);
  * public static object? Deserialize (ReadOnlySpan<byte> utf8Json, System.Text.Json.Serialization.Metadata.JsonTypeInfo jsonTypeInfo);
  * public static object? Deserialize (ReadOnlySpan<char> json, System.Text.Json.Serialization.Metadata.JsonTypeInfo jsonTypeInfo);
  * public static object? Deserialize (string json, System.Text.Json.Serialization.Metadata.JsonTypeInfo jsonTypeInfo);
  * public static object? Deserialize (this System.Text.Json.JsonDocument document, System.Text.Json.Serialization.Metadata.JsonTypeInfo jsonTypeInfo);
  * public static object? Deserialize (this System.Text.Json.JsonElement element, System.Text.Json.Serialization.Metadata.JsonTypeInfo jsonTypeInfo);
  * public static object? Deserialize (this System.Text.Json.Nodes.JsonNode? node, System.Text.Json.Serialization.Metadata.JsonTypeInfo jsonTypeInfo);
  * public static object? Deserialize (ref System.Text.Json.Utf8JsonReader reader, System.Text.Json.Serialization.Metadata.JsonTypeInfo jsonTypeInfo);
  * public static System.Threading.Tasks.ValueTask<object?> DeserializeAsync (System.IO.Stream utf8Json, System.Text.Json.Serialization.Metadata.JsonTypeInfo jsonTypeInfo, System.Threading.CancellationToken cancellationToken = default);
  * public static bool IsReflectionEnabledByDefault { get; }
  * public static string Serialize (object? value, System.Text.Json.Serialization.Metadata.JsonTypeInfo jsonTypeInfo);
  * public static void Serialize (System.IO.Stream utf8Json, object? value, System.Text.Json.Serialization.Metadata.JsonTypeInfo jsonTypeInfo);
  * public static void Serialize (System.Text.Json.Utf8JsonWriter writer, object? value, System.Text.Json.Serialization.Metadata.JsonTypeInfo jsonTypeInfo);
  * public static System.Threading.Tasks.Task SerializeAsync (System.IO.Stream utf8Json, object? value, System.Text.Json.Serialization.Metadata.JsonTypeInfo jsonTypeInfo, System.Threading.CancellationToken cancellationToken = default);
  * public static System.Text.Json.JsonDocument SerializeToDocument (object? value, System.Text.Json.Serialization.Metadata.JsonTypeInfo jsonTypeInfo);
  * public static System.Text.Json.JsonElement SerializeToElement (object? value, System.Text.Json.Serialization.Metadata.JsonTypeInfo jsonTypeInfo);
  * public static System.Text.Json.Nodes.JsonNode? SerializeToNode (object? value, System.Text.Json.Serialization.Metadata.JsonTypeInfo jsonTypeInfo);
  * public static byte[] SerializeToUtf8Bytes (object? value, System.Text.Json.Serialization.Metadata.JsonTypeInfo jsonTypeInfo);
* System.Text.Json.JsonSerializerOptions
  * public bool IsReadOnly { get; }
  * public void MakeReadOnly ();
  * public void MakeReadOnly (bool populateMissingResolver);
  * public System.Text.Json.Serialization.JsonObjectCreationHandling PreferredObjectCreationHandling { get; set; }
  * public bool TryGetTypeInfo (Type type, out System.Text.Json.Serialization.Metadata.JsonTypeInfo? typeInfo);
  * public System.Collections.Generic.IList<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> TypeInfoResolverChain { get; }
  * public System.Text.Json.Serialization.JsonUnmappedMemberHandling UnmappedMemberHandling { get; set; }
* System.Text.Json.Utf8JsonWriter
  * public void WriteRawValue (System.Buffers.ReadOnlySequence<byte> utf8Json, bool skipInputValidation = false);
* System.Text.Json.Nodes.JsonArray
  * public System.Collections.Generic.IEnumerable<T> GetValues<T> ();
* System.Text.Json.Nodes.JsonNode
  * public System.Text.Json.Nodes.JsonNode DeepClone ();
  * public static bool DeepEquals (System.Text.Json.Nodes.JsonNode? node1, System.Text.Json.Nodes.JsonNode? node2);
  * public int GetElementIndex ();
  * public string GetPropertyName ();
  * public System.Text.Json.JsonValueKind GetValueKind ();
  * public static System.Threading.Tasks.Task<System.Text.Json.Nodes.JsonNode?> ParseAsync (System.IO.Stream utf8Json, System.Text.Json.Nodes.JsonNodeOptions? nodeOptions = default, System.Text.Json.JsonDocumentOptions documentOptions = default, System.Threading.CancellationToken cancellationToken = default);
  * public void ReplaceWith<T> (T value);
* System.Text.Json.Serialization.BinaryDataJsonConverter
  * public BinaryDataJsonConverter ();
  * public override BinaryData? Read (ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options);
  * public override void Write (System.Text.Json.Utf8JsonWriter writer, BinaryData value, System.Text.Json.JsonSerializerOptions options);
* System.Text.Json.Serialization.JsonConverter
  * public abstract Type? Type { get; }
* System.Text.Json.Serialization.JsonConverterFactory
  * public override sealed Type? Type { get; }
* System.Text.Json.Serialization.JsonConverter<T>
  * public override sealed Type Type { get; }
* System.Text.Json.Serialization.JsonKnownNamingPolicy
  * KebabCaseLower
  * KebabCaseUpper
  * SnakeCaseLower
  * SnakeCaseUpper
* System.Text.Json.Serialization.JsonNumberEnumConverter<TEnum>
  * public JsonNumberEnumConverter ();
  * public override bool CanConvert (Type typeToConvert);
  * public override System.Text.Json.Serialization.JsonConverter? CreateConverter (Type typeToConvert, System.Text.Json.JsonSerializerOptions options);
* System.Text.Json.Serialization.JsonObjectCreationHandling
  * Populate
  * Replace
* System.Text.Json.Serialization.JsonObjectCreationHandlingAttribute
  * public JsonObjectCreationHandlingAttribute (System.Text.Json.Serialization.JsonObjectCreationHandling handling);
  * public System.Text.Json.Serialization.JsonObjectCreationHandling Handling { get; }
* System.Text.Json.Serialization.JsonSourceGenerationOptionsAttribute
  * public JsonSourceGenerationOptionsAttribute (System.Text.Json.JsonSerializerDefaults defaults);
  * public bool AllowTrailingCommas { get; set; }
  * public Type[]? Converters { get; set; }
  * public int DefaultBufferSize { get; set; }
  * public System.Text.Json.Serialization.JsonKnownNamingPolicy DictionaryKeyPolicy { get; set; }
  * public int MaxDepth { get; set; }
  * public System.Text.Json.Serialization.JsonNumberHandling NumberHandling { get; set; }
  * public System.Text.Json.Serialization.JsonObjectCreationHandling PreferredObjectCreationHandling { get; set; }
  * public bool PropertyNameCaseInsensitive { get; set; }
  * public System.Text.Json.JsonCommentHandling ReadCommentHandling { get; set; }
  * public System.Text.Json.Serialization.JsonUnknownTypeHandling UnknownTypeHandling { get; set; }
  * public System.Text.Json.Serialization.JsonUnmappedMemberHandling UnmappedMemberHandling { get; set; }
  * public bool UseStringEnumConverter { get; set; }
* System.Text.Json.Serialization.JsonStringEnumConverter<TEnum>
  * public JsonStringEnumConverter ();
  * public JsonStringEnumConverter (System.Text.Json.JsonNamingPolicy? namingPolicy = default, bool allowIntegerValues = true);
  * public override sealed bool CanConvert (Type typeToConvert);
  * public override sealed System.Text.Json.Serialization.JsonConverter CreateConverter (Type typeToConvert, System.Text.Json.JsonSerializerOptions options);
* System.Text.Json.Serialization.JsonUnmappedMemberHandling
  * Disallow
  * Skip
* System.Text.Json.Serialization.JsonUnmappedMemberHandlingAttribute
  * public JsonUnmappedMemberHandlingAttribute (System.Text.Json.Serialization.JsonUnmappedMemberHandling unmappedMemberHandling);
  * public System.Text.Json.Serialization.JsonUnmappedMemberHandling UnmappedMemberHandling { get; }
* System.Text.Json.Serialization.Metadata.JsonMetadataServices
  * public static System.Text.Json.Serialization.Metadata.JsonTypeInfo<Memory<TElement>> CreateMemoryInfo<TElement> (System.Text.Json.JsonSerializerOptions options, System.Text.Json.Serialization.Metadata.JsonCollectionInfoValues<Memory<TElement>> collectionInfo);
  * public static System.Text.Json.Serialization.Metadata.JsonTypeInfo<ReadOnlyMemory<TElement>> CreateReadOnlyMemoryInfo<TElement> (System.Text.Json.JsonSerializerOptions options, System.Text.Json.Serialization.Metadata.JsonCollectionInfoValues<ReadOnlyMemory<TElement>> collectionInfo);
  * public static System.Text.Json.Serialization.JsonConverter<Half> HalfConverter { get; }
  * public static System.Text.Json.Serialization.JsonConverter<Int128> Int128Converter { get; }
  * public static System.Text.Json.Serialization.JsonConverter<Memory<byte>> MemoryByteConverter { get; }
  * public static System.Text.Json.Serialization.JsonConverter<ReadOnlyMemory<byte>> ReadOnlyMemoryByteConverter { get; }
  * public static System.Text.Json.Serialization.JsonConverter<UInt128> UInt128Converter { get; }
* System.Text.Json.Serialization.Metadata.JsonPropertyInfo
  * public System.Text.Json.Serialization.JsonObjectCreationHandling? ObjectCreationHandling { get; set; }
* System.Text.Json.Serialization.Metadata.JsonTypeInfo
  * public System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver? OriginatingResolver { get; set; }
  * public System.Text.Json.Serialization.JsonObjectCreationHandling? PreferredPropertyObjectCreationHandling { get; set; }
  * public System.Text.Json.Serialization.JsonUnmappedMemberHandling? UnmappedMemberHandling { get; set; }
* System.Text.Json.Serialization.Metadata.JsonTypeInfoResolver
  * public static System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver WithAddedModifier (this System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver resolver, Action<System.Text.Json.Serialization.Metadata.JsonTypeInfo> modifier);
* System.Text.Unicode.Utf8+TryWriteInterpolatedStringHandler
  * public TryWriteInterpolatedStringHandler (int literalLength, int formattedCount, Span<byte> destination, out bool shouldAppend);
  * public TryWriteInterpolatedStringHandler (int literalLength, int formattedCount, Span<byte> destination, IFormatProvider? provider, out bool shouldAppend);
  * public bool AppendFormatted (scoped ReadOnlySpan<byte> utf8Value);
  * public bool AppendFormatted (scoped ReadOnlySpan<char> value);
  * public bool AppendFormatted (string? value);
  * public bool AppendFormatted (object? value, int alignment = 0, string? format = default);
  * public bool AppendFormatted (scoped ReadOnlySpan<byte> utf8Value, int alignment = 0, string? format = default);
  * public bool AppendFormatted (scoped ReadOnlySpan<char> value, int alignment = 0, string? format = default);
  * public bool AppendFormatted (string? value, int alignment = 0, string? format = default);
  * public bool AppendFormatted<T> (T value);
  * public bool AppendFormatted<T> (T value, int alignment);
  * public bool AppendFormatted<T> (T value, string? format);
  * public bool AppendFormatted<T> (T value, int alignment, string? format);
  * public bool AppendLiteral (string value);
* System.Text.Unicode.Utf8
  * public static bool IsValid (ReadOnlySpan<byte> value);
  * public static bool TryWrite (Span<byte> destination, ref System.Text.Unicode.Utf8.TryWriteInterpolatedStringHandler handler, out int bytesWritten);
  * public static bool TryWrite (Span<byte> destination, IFormatProvider? provider, ref System.Text.Unicode.Utf8.TryWriteInterpolatedStringHandler handler, out int bytesWritten);
* System.Threading.CancellationTokenSource
  * public CancellationTokenSource (TimeSpan delay, TimeProvider timeProvider);
  * public System.Threading.Tasks.Task CancelAsync ();
* System.Threading.ITimer
  * public bool Change (TimeSpan dueTime, TimeSpan period);
* System.Threading.PeriodicTimer
  * public PeriodicTimer (TimeSpan period, TimeProvider timeProvider);
  * public TimeSpan Period { get; set; }
* System.Threading.Tasks.ConfigureAwaitOptions
  * ContinueOnCapturedContext
  * ForceYielding
  * None
  * SuppressThrowing
* System.Threading.Tasks.Parallel
  * public static System.Threading.Tasks.Task ForAsync<T> (T fromInclusive, T toExclusive, Func<T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask> body) where T : System.Numerics.IBinaryInteger<T>;
  * public static System.Threading.Tasks.Task ForAsync<T> (T fromInclusive, T toExclusive, System.Threading.CancellationToken cancellationToken, Func<T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask> body) where T : System.Numerics.IBinaryInteger<T>;
  * public static System.Threading.Tasks.Task ForAsync<T> (T fromInclusive, T toExclusive, System.Threading.Tasks.ParallelOptions parallelOptions, Func<T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask> body) where T : System.Numerics.IBinaryInteger<T>;
* System.Threading.Tasks.Task
  * public System.Runtime.CompilerServices.ConfiguredTaskAwaitable ConfigureAwait (System.Threading.Tasks.ConfigureAwaitOptions options);
  * public static System.Threading.Tasks.Task Delay (TimeSpan delay, TimeProvider timeProvider);
  * public static System.Threading.Tasks.Task Delay (TimeSpan delay, TimeProvider timeProvider, System.Threading.CancellationToken cancellationToken);
  * public System.Threading.Tasks.Task WaitAsync (TimeSpan timeout, TimeProvider timeProvider);
  * public System.Threading.Tasks.Task WaitAsync (TimeSpan timeout, TimeProvider timeProvider, System.Threading.CancellationToken cancellationToken);
* System.Threading.Tasks.TaskToAsyncResult
  * public static IAsyncResult Begin (System.Threading.Tasks.Task task, AsyncCallback? callback, object? state);
  * public static void End (IAsyncResult asyncResult);
  * public static TResult End<TResult> (IAsyncResult asyncResult);
  * public static System.Threading.Tasks.Task Unwrap (IAsyncResult asyncResult);
  * public static System.Threading.Tasks.Task<TResult> Unwrap<TResult> (IAsyncResult asyncResult);
* System.Threading.Tasks.Task<TResult>
  * public System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult> ConfigureAwait (System.Threading.Tasks.ConfigureAwaitOptions options);
  * public System.Threading.Tasks.Task<TResult> WaitAsync (TimeSpan timeout, TimeProvider timeProvider);
  * public System.Threading.Tasks.Task<TResult> WaitAsync (TimeSpan timeout, TimeProvider timeProvider, System.Threading.CancellationToken cancellationToken);
* System.Windows.Forms.AxHost+State
  * public void Dispose ();
  * protected virtual void Dispose (bool disposing);
* System.Windows.Forms.ButtonBase+ButtonBaseAccessibleObject
  * public override string? KeyboardShortcut { get; }
  * public override string? Name { get; }
* System.Windows.Forms.ContextMenuStrip
  * protected override void OnClosed (System.Windows.Forms.ToolStripDropDownClosedEventArgs e);
  * protected override void OnOpened (EventArgs e);
* System.Windows.Forms.MaskedTextBox
  * protected override System.Windows.Forms.AccessibleObject CreateAccessibilityInstance ();
  * protected override void OnGotFocus (EventArgs e);
  * protected override void OnMouseDown (System.Windows.Forms.MouseEventArgs e);
* System.Windows.Forms.NativeWindow
  * protected virtual void WmDpiChangedAfterParent (ref System.Windows.Forms.Message m);
  * protected virtual void WmDpiChangedBeforeParent (ref System.Windows.Forms.Message m);
* System.Windows.Forms.PrintPreviewControl
  * protected override void OnGotFocus (EventArgs e);
  * protected override void OnLostFocus (EventArgs e);
  * protected override void OnMouseDown (System.Windows.Forms.MouseEventArgs e);
  * protected override void OnPaintBackground (System.Windows.Forms.PaintEventArgs e);
  * public bool TabStop { get; set; }
* System.Windows.Forms.RadioButton+RadioButtonAccessibleObject
  * public override string? KeyboardShortcut { get; }
  * public override string? Name { get; }
* System.Windows.Forms.ScrollBar
  * protected override void ScaleControl (System.Drawing.SizeF factor, System.Windows.Forms.BoundsSpecified specified);
* System.Windows.Forms.TaskDialogLinkClickedEventArgs
  * public TaskDialogLinkClickedEventArgs (string linkHref);
  * public string LinkHref { get; }
* System.Windows.Forms.TaskDialogPage
  * public bool EnableLinks { get; set; }
  * public event EventHandler<System.Windows.Forms.TaskDialogLinkClickedEventArgs>? LinkClicked;
  * protected internal void OnLinkClicked (System.Windows.Forms.TaskDialogLinkClickedEventArgs e);
* System.Windows.Forms.TextBox
  * protected override System.Windows.Forms.AccessibleObject CreateAccessibilityInstance ();
* System.Windows.Forms.TextBoxBase
  * protected bool ContainsNavigationKeyCode (System.Windows.Forms.Keys keyCode);
* System.Windows.Forms.ToolStripButton
  * protected internal override bool ProcessDialogKey (System.Windows.Forms.Keys keyData);
* System.Xml.XmlResolver
  * public static System.Xml.XmlResolver FileSystemResolver { get; }
