﻿using System.ServiceModel;
using System.ServiceModel.Web;
using StayWell.Interface;
using StayWell.ServiceDefinitions.Languages.Objects;

namespace StayWell.ServiceDefinitions.Languages
{
	[ServiceContract(Name = "Languages", Namespace = "http://www.kramesstaywell.com")]
	public interface IPublicLanguageService
	{
		[WebInvoke(UriTemplate = "", Method = "GET")]
		[OperationContract]
		[Allow(ClientType = ClientType.Internal, Rights = "Read_Content", SpecialAccess = AllowedSpecialAccess.Jsonp)]
		LanguageList GetLanguages(string bucketIdOrSlug, string contentIdOrSlug);
	}
}
