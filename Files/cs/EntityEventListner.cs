using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terrasoft.Core.Entities;
using Terrasoft.Core.Entities.Events;

namespace DevPackageClio.Files.cs
{
    [EntityEventListener(SchemaName ="Contacts")]
    public class EntityEventListner: BaseEntityEventListener
    {
        public override void OnSaved(object sender, EntityAfterEventArgs e)
        {
            base.OnSaved(sender, e);
            var entity = (Entity)sender;
            var contactName = entity.GetTypedColumnValue<string>("Name");
            var oldContactName = entity.GetTypedOldColumnValue<string>("Name");
            entity.SetColumnValue("Name", contactName + "Modified On" + DateTime.Now);
        }
    }
}
