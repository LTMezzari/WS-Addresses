using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ws_addresses.Models;

namespace ws_addresses.Controllers
{
    public class AddressesController : ApiController {
        public DbAddressContext Database = new DbAddressContext();

        [ResponseType(typeof(Address))]
        public IHttpActionResult PostAddress(Address address) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            Database.Addresses.Add(address);
            Database.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { Id = address.Id }, address);
        }

        [ResponseType(typeof(List<Address>))]
        public IHttpActionResult GetAddress() {
            return Ok(Database.Addresses);
        }
    }
}
