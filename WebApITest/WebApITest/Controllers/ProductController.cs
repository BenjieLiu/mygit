using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WebApITest.Models;

namespace WebApITest.Controllers
{
    public class ProductController : ApiController
    {
        Product[] products = new Product[]
       {
            new Product {label="printOutParameterResult1", kind="Function", detail="<class 'function'>", documentation="", insertText="printOutParameterResult1", range=""},
            new Product {label="printOutParameterResult2", kind="Function", detail="<class 'function'>", documentation="", insertText="printOutParameterResult2", range=""},
            new Product {label="printOutParameterResult3", kind="Function", detail="<class 'function'>", documentation="", insertText="printOutParameterResult3", range=""},
            new Product {label="printOutParameterResult4", kind="Function", detail="<class 'function'>", documentation="", insertText="printOutParameterResult4", range=""},
            new Product {label="printOutParameterResult5", kind="Function", detail="<class 'function'>", documentation="", insertText="printOutParameterResult5", range=""},
            new Product {label="getMemberType", kind="Function", detail="<class 'function'>", documentation="", insertText="getMemberType", range=""},
            new Product {label="calculate", kind="Function", detail="<class 'function'>", documentation="", insertText="calculate", range=""},
            new Product {label="encode", kind="Function", detail="<class 'method_descriptor'>", documentation="", insertText="encode", range=""},
            new Product {label="replace", kind="Function", detail="<class 'method_descriptor'>", documentation="", insertText="replace", range=""},
            new Product {label="split", kind="Function", detail="<class 'method_descriptor'>", documentation="", insertText="split", range=""},
            new Product {label="rsplit", kind="Function", detail="<class 'method_descriptor'>", documentation="", insertText="rsplit", range=""},
            new Product {label="join", kind="Function", detail="<class 'method_descriptor'>", documentation="", insertText="join", range=""},
            new Product {label="capitalize", kind="Function", detail="<class 'method_descriptor'>", documentation="", insertText="capitalize", range=""},
            new Product {label="addNum", kind="Function", detail="<class 'method_descriptor'>", documentation="", insertText="addNum", range=""},
            new Product {label="RevertData", kind="Function", detail="<class 'method_descriptor'>", documentation="", insertText="RevertData", range=""},


       };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(string label)
        {
            var product = products.FirstOrDefault((p) => p.label == label);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
