using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eccomerce.Models;
using Eccomerce.Data;
namespace Eccomerce.Services
{
    public class SellerService
    {
        private readonly EccomerceContext _context;

        public SellerService(EccomerceContext context)
        {
            _context = context;
        }


        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }



    }
}
