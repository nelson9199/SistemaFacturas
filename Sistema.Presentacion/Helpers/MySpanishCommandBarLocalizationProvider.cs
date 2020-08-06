using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;

namespace Sistema.Presentacion.Helpers
{
    public class MySpanishCommandBarLocalizationProvider : CommandBarLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case CommandBarStringId.CustomizeDialogChooseToolstripLabelText: return "Escoja una boton de herramienta para organizar:";
                case CommandBarStringId.CustomizeDialogCloseButtonText: return "Cerrar";
                case CommandBarStringId.CustomizeDialogItemsPageTitle: return "Items";
                case CommandBarStringId.CustomizeDialogMoveDownButtonText: return "Mover Abajo";
                case CommandBarStringId.CustomizeDialogMoveUpButtonText: return "Mover Arriba";
                case CommandBarStringId.CustomizeDialogResetButtonText: return "Restaurar";
                case CommandBarStringId.CustomizeDialogTitle: return "Customizar1";
                case CommandBarStringId.CustomizeDialogToolstripsPageTitle: return "Botones de Herramientas";
                case CommandBarStringId.OverflowMenuAddOrRemoveButtonsText: return "Añada o Remueva botones";
                case CommandBarStringId.OverflowMenuCustomizeText: return "Customizar...";
                case CommandBarStringId.ContextMenuCustomizeText: return "Customizar...";
                default: return base.GetLocalizedString(id);
            }
        }
    }
}
