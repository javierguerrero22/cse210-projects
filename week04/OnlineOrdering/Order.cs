using System;

class Order {
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;

        foreach (var product in _products)
        {
            totalPrice += product.GetTotalCost();
        }

        totalPrice += _customer.IsFromUSA() ? 5 : 35;
        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string label = $"Packing Label\n";

        foreach (var product in _products)
        {
            label += $"- {product.GetProductInfo()}\n";
        }
        return label;
    }
    
    public string GetShippingLabel()
    {
        return $"\nShipping Label:\n{_customer.GetName()}\n{_customer.GetAddress()}";

    }
}
