using System.Text.Json.Serialization;
using Pos_System.API.Enums;
using Pos_System.API.Helpers;
using Pos_System.API.Utils;
using Pos_System.Domain.Models;

namespace Pos_System.API.Payload.Response.Menus;

public class GetMenuDetailResponse
{
	public Guid Id { get; set; }
	public string Code { get; set; }
	public int Priority { get; set; }
	public bool IsBaseMenu { get; set; }
	public List<DateFilter> DateFilter { get; set; }
	public TimeOnly StartTime { get; set; }
	public TimeOnly EndTime { get; set; }
	public MenuStatus Status { get; set; }
	public string? CreatedBy { get; set; }
	public DateTime? CreatedAt { get; set; }
	public string UpdatedBy { get; set; }
	public DateTime? UpdatedAt { get; set; }
	[JsonPropertyName("products")]
	public List<ProductInMenu> ProductsInMenu { get; set; }
	[JsonPropertyName("stores")]
	public List<StoreInMenu> StoresInMenus { get; set; }

	public GetMenuDetailResponse(Guid id, string code, int priority,int dateFilter, int startTime, int endTime, string status, string? createdBy, DateTime? createdAt, string updatedBy, DateTime? updatedAt, List<MenuProduct> productsInMenu, List<MenuStore> storesInMenus)
	{
		Id = id;
		Code = code;
		Priority = priority;
        IsBaseMenu = priority.Equals(0) ? true : false;
		DateFilter = DateTimeHelper.GetDatesFromDateFilter(dateFilter);
		StartTime = DateTimeHelper.ConvertIntToTimeOnly(startTime);
		EndTime = DateTimeHelper.ConvertIntToTimeOnly(endTime);
		Status = EnumUtil.ParseEnum<MenuStatus>(status);
		CreatedBy = createdBy;
		CreatedAt = createdAt;
		UpdatedBy = updatedBy;
		UpdatedAt = updatedAt;
		SetProductsInMenu(productsInMenu);
		SetStoresInMenu(storesInMenus);
	}

	public void SetProductsInMenu(List<MenuProduct> products)
	{
		ProductsInMenu = new List<ProductInMenu>();
		if (products != null)
		{
			foreach (var product in products)
			{
				ProductsInMenu.Add(new ProductInMenu(product.ProductId, product.SellingPrice, product.DiscountPrice, product.HistoricalPrice, product.CreatedBy, product.CreatedAt, product.UpdatedBy, product.UpdatedAt, product.Product.Type, product.Product.Category.Name, EnumUtil.ParseEnum<MenuProductStatus>(product.Status)));
			}
		}
	}

    public void SetStoresInMenu(List<MenuStore> menuStores)
	{
		StoresInMenus = new List<StoreInMenu>();
		if (menuStores != null)
		{
			foreach (var menuStore in menuStores)
			{
				StoresInMenus.Add(new StoreInMenu(menuStore.StoreId, menuStore.Store.Name, menuStore.Store.ShortName, menuStore.Store.Address));
			}
		}
	}
}

public class ProductInMenu
{
	public Guid Id { get; set; }
	public double SellingPrice { get; set; }
	public double DiscountPrice { get; set; }
	public double HistoricalPrice { get; set; }
	public ProductType Type { get; set; }
	public string CategoryName { get; set; }
	public string? CreatedBy { get; set; }
	public DateTime? CreatedAt { get; set; }
	public string? UpdatedBy { get; set; }
	public DateTime? UpdatedAt { get; set; }
	public MenuProductStatus Status { get; set; }

	public ProductInMenu(Guid id, double sellingPrice, double discountPrice, double historicalPrice, string? createdBy, DateTime? createdAt, string? updatedBy, DateTime? updatedAt, string productType, string categoryName, MenuProductStatus status)
	{
		Id = id;
		SellingPrice = sellingPrice;
		DiscountPrice = discountPrice;
		HistoricalPrice = historicalPrice;
		CreatedBy = createdBy;
		CreatedAt = createdAt;
		UpdatedBy = updatedBy;
		UpdatedAt = updatedAt;
		Type = EnumUtil.ParseEnum<ProductType>(productType);
		CategoryName = categoryName;
		Status = status;
	}
}

public class StoreInMenu
{
	public Guid Id { get; set; }
	public string Name { get; set; }
	public string ShortName { get; set; }
	public string? Address { get; set; }

	public StoreInMenu(Guid id, string name, string shortName, string? address)
	{
		Id = id;
		Name = name;
		ShortName = shortName;
		Address = address;
	}
}