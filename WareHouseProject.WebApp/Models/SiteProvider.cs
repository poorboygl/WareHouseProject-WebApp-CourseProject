using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WareHouseProject.WebApp.Models;

namespace WareHouseProject.WebApp.Models
{
    public class SiteProvider :BaseProvider
    {
        public SiteProvider(IConfiguration configuration):base(configuration)
        {

        }
        DimProductCategoryRepository productCategoryRepository;
        DimProductSubcategoryRepository productSubcategoryRepository;
        DimProductRepository productRepository;
        DimGeographyRepository geographyRepository;
        DimCustomerRepository customerRepository;
        DimDepartmentGroupRepository departmentGroupRepository;
        DimCompanyOrganizationRepository companyOrganizationRepository;
        DimEmployeeRepository dimEmployeeRepository;
        AccountRepository account;
        CartRepository cart;
        WardRepository ward;
        DistrictRepository district;
        ProvinceRepository province;
        PhotoRepository photo;
        public PhotoRepository Photo
        {
            get
            {
                if (photo is null)
                {
                    photo = new PhotoRepository(Connection);
                }
                return photo;
            }
        }
        public ProvinceRepository Province
        {
            get
            {
                if (province is null)
                {
                    province = new ProvinceRepository(Connection);
                }
                return province;
            }
        }
        public DistrictRepository District
        {
            get
            {
                if (district is null)
                {
                    district = new DistrictRepository(Connection);
                }
                return district;
            }
        }
        public WardRepository Ward
        {
            get
            {
                if (ward is null)
                {
                    ward = new WardRepository(Connection);
                }
                return ward;
            }
        }
        public CartRepository Cart
        {
            get
            {
                if (cart is null)
                {
                    cart = new CartRepository(Connection);
                }
                return cart;
            }
        }
        public AccountRepository Account
        {
            get
            {
                if (account is null)
                {
                    account = new AccountRepository(Connection);
                }
                return account;
            }
        }
        public DimEmployeeRepository DimEmployeeRepository
        {
            get
            {
                if (dimEmployeeRepository is null)
                {
                    dimEmployeeRepository = new DimEmployeeRepository(Connection);
                }
                return dimEmployeeRepository;
            }
        }
        public DimCompanyOrganizationRepository CompanyOrganizationRepository
        {
            get
            {
                if (companyOrganizationRepository is null)
                {
                    companyOrganizationRepository = new DimCompanyOrganizationRepository(Connection);
                }
                return companyOrganizationRepository;
            }
        }
        public DimDepartmentGroupRepository DepartmentGroupRepository
        {
            get
            {
                if (departmentGroupRepository is null)
                {
                    departmentGroupRepository = new DimDepartmentGroupRepository(Connection);
                }
                return departmentGroupRepository;
            }
        }
        public DimCustomerRepository CustomerRepository
        {
            get
            {
                if (customerRepository is null)
                {
                    customerRepository = new DimCustomerRepository(Connection);
                }
                return customerRepository;
            }
        }
        public DimGeographyRepository GeographyRepository
        {
            get
            {
                if (geographyRepository is null)
                {
                    geographyRepository = new DimGeographyRepository(Connection);
                }
                return geographyRepository;
            }
        }
        public DimProductRepository ProductRepository
        {
            get
            {
                if (productRepository is null)
                {
                    productRepository = new DimProductRepository(Connection);
                }
                return productRepository;
            }
        }
        public DimProductSubcategoryRepository ProductSubcategoryRepository
        {
            get
            {
                if (productSubcategoryRepository is null)
                {
                    productSubcategoryRepository = new DimProductSubcategoryRepository(Connection);
                }
                return productSubcategoryRepository;
            }
        }
        public DimProductCategoryRepository ProductCategoryRepository
        {
            get
            {
                if (productCategoryRepository is null)
                {
                    productCategoryRepository = new DimProductCategoryRepository(Connection);
                }
                return productCategoryRepository;
            }
        }



    }
}
