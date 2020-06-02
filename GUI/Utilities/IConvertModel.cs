using GUI.ProductLineServiceReferencee;
using GUI.ModelLayer;

namespace GUI.Utilities
{
    interface IConvertModel
    {
        Product ConvertFromServiceProduct(ServiceProduct serviceProduct);
        ServiceProduct ConvertToServiceProduct(Product desktopProduct);

    }
}
