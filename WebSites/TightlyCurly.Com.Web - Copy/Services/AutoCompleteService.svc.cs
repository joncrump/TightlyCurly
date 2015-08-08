using System;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using TightlyCurly.Com.Common;

namespace TightlyCurly.Com.Web.Services
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class AutoCompleteService
    {
        //private readonly IConfigurationHelper _configurationHelper;
        //private readonly IQuestionDataProvider _questionDataProvider;

        public AutoCompleteService()
        {
            //_configurationHelper = Container.Resolve<IConfigurationHelper>();
            //_questionDataProvider = Container.Resolve<IQuestionDataProvider>();
        }

        // TODO: Modify this method when ADO.NET Data Services is decommissioned.
        // Performance is not good.
        [OperationContract]
        public string[] GetIngredientsNameList(string prefixText, int count)
        {
            throw new NotImplementedException();
            //var connectionString = _configurationHelper.ProductService;
            //var context = new DataEntitiesDataContext(new Uri(connectionString, UriKind.Absolute));

            //var ingredientsList = (from i in context.Ingredients
            //                      select i).ToList();
            //var filteredList = ingredientsList.Select(i => i.Title).Where(i => i.ToLower().Contains(prefixText.ToLower()));
            //return filteredList.ToArray();
        }

        [OperationContract]
        public string[] GetQuestionsList(string prefixText, int count)
        {
            throw new NotImplementedException();
            //return _questionDataProvider.GetQuestionsByCriteria(prefixText).Select(q => q.Value).ToArray();
        }
    }
}
