﻿namespace AlSat.Server
{
	///// <summary>
	///// Configures the Swagger generation options.
	///// </summary>
	///// <remarks>This allows API versioning to define a Swagger document per API version after the
	///// <see cref="IApiVersionDescriptionProvider"/> service has been resolved from the service container.</remarks>
	//public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
	//{
	//	readonly IApiVersionDescriptionProvider provider;

	//	/// <summary>
	//	/// Initializes a new instance of the <see cref="ConfigureSwaggerOptions"/> class.
	//	/// </summary>
	//	/// <param name="provider">The <see cref="IApiVersionDescriptionProvider">provider</see> used to generate Swagger documents.</param>
	//	public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider) => this.provider = provider;

	//	/// <inheritdoc />
	//	public void Configure(SwaggerGenOptions options)
	//	{
	//		// add a swagger document for each discovered API version
	//		// note: you might choose to skip or document deprecated API versions differently
	//		foreach (var description in provider.ApiVersionDescriptions)
	//		{
	//			options.SwaggerDoc(description.GroupName, CreateInfoForApiVersion(description));
	//		}
	//	}

	//	static OpenApiInfo CreateInfoForApiVersion(ApiVersionDescription description)
	//	{
	//		var info = new OpenApiInfo()
	//		{
	//			Title = "AlSat API",
	//			Version = description.ApiVersion.ToString(),
	//			Description = "AlSat API documentation.",
	//			TermsOfService = new Uri("https://alsat.com/terms"),
	//			Contact = new OpenApiContact
	//			{
	//				Name = "Alim Akyol",
	//				Email = string.Empty,
	//				Url = new Uri("https://twitter.com/AlimAkyol"),
	//			},
	//			License = new OpenApiLicense
	//			{
	//				Name = "Use under Proprietary license.",
	//				Url = new Uri("https://alsat.com/license"),
	//			}
	//		};

	//		if (description.IsDeprecated)
	//		{
	//			info.Description += " This API version has been deprecated.";
	//		}

	//		return info;
	//	}
	//}
}
