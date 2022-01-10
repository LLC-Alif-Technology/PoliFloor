using System.Collections.Generic;
using KagamaModels.Entities;

namespace KagamaAdmin.ViewModel
{
    public class ContactsView
    {
        public Page Page { get; set; }

        public IEnumerable<Contact> Contacts { get; set; }
    }
}
