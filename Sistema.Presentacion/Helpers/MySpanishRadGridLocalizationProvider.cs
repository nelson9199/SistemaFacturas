﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI.Localization;

namespace Sistema.Presentacion.Helpers
{
    public class MySpanishRadGridLocalizationProvider : RadGridLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadGridStringId.ConditionalFormattingPleaseSelectValidCellValue: return "Please select valid cell value";
                case RadGridStringId.ConditionalFormattingPleaseSetValidCellValue: return "Please set a valid cell value";
                case RadGridStringId.ConditionalFormattingPleaseSetValidCellValues: return "Please set a valid cell values";
                case RadGridStringId.ConditionalFormattingPleaseSetValidExpression: return "Please set a valid expression";
                case RadGridStringId.ConditionalFormattingItem: return "Item";
                case RadGridStringId.ConditionalFormattingInvalidParameters: return "Parámetros Inválidos";
                case RadGridStringId.FilterFunctionBetween: return "Entre";
                case RadGridStringId.FilterFunctionContains: return "Contiene";
                case RadGridStringId.FilterFunctionDoesNotContain: return "No Contiene";
                case RadGridStringId.FilterFunctionEndsWith: return "Termina En";
                case RadGridStringId.FilterFunctionEqualTo: return "Es igual a";
                case RadGridStringId.FilterFunctionGreaterThan: return "Mayor Que";
                case RadGridStringId.FilterFunctionGreaterThanOrEqualTo: return "Mayor o igual que";
                case RadGridStringId.FilterFunctionIsEmpty: return "Está vacio";
                case RadGridStringId.FilterFunctionIsNull: return "Es null";
                case RadGridStringId.FilterFunctionLessThan: return "Menor Que";
                case RadGridStringId.FilterFunctionLessThanOrEqualTo: return "Menor o igual que";
                case RadGridStringId.FilterFunctionNoFilter: return "Sin Filtro";
                case RadGridStringId.FilterFunctionNotBetween: return "No entre";
                case RadGridStringId.FilterFunctionNotEqualTo: return "Diferente de";
                case RadGridStringId.FilterFunctionNotIsEmpty: return "Diferente de vacio";
                case RadGridStringId.FilterFunctionNotIsNull: return "Diferente de nulo";
                case RadGridStringId.FilterFunctionStartsWith: return "Empieza con";
                case RadGridStringId.FilterFunctionCustom: return "Personalizado";
                case RadGridStringId.FilterOperatorBetween: return "Entre";
                case RadGridStringId.FilterOperatorContains: return "Contiene";
                case RadGridStringId.FilterOperatorDoesNotContain: return "No Contiene";
                case RadGridStringId.FilterOperatorEndsWith: return "Termina en";
                case RadGridStringId.FilterOperatorEqualTo: return "Es igual a";
                case RadGridStringId.FilterOperatorGreaterThan: return "Mayor que";
                case RadGridStringId.FilterOperatorGreaterThanOrEqualTo: return "Mayor o igual";
                case RadGridStringId.FilterOperatorIsEmpty: return "Está vacio";
                case RadGridStringId.FilterOperatorIsNull: return "Es nulo";
                case RadGridStringId.FilterOperatorLessThan: return "Menor que";
                case RadGridStringId.FilterOperatorLessThanOrEqualTo: return "Menor o igual";
                case RadGridStringId.FilterOperatorNoFilter: return "Sin filtro";
                case RadGridStringId.FilterOperatorNotBetween: return "No entre";
                case RadGridStringId.FilterOperatorNotEqualTo: return "No es igual";
                case RadGridStringId.FilterOperatorNotIsEmpty: return "NotEmpty";
                case RadGridStringId.FilterOperatorNotIsNull: return "No es nulo";
                case RadGridStringId.FilterOperatorStartsWith: return "Empieza con";
                case RadGridStringId.FilterOperatorIsLike: return "similar a";
                case RadGridStringId.FilterOperatorNotIsLike: return "no similar a";
                case RadGridStringId.FilterOperatorIsContainedIn: return "Contenido en";
                case RadGridStringId.FilterOperatorNotIsContainedIn: return "No contenido en";
                case RadGridStringId.FilterOperatorCustom: return "Personalizado";
                case RadGridStringId.CustomFilterMenuItem: return "Personalizado";
                case RadGridStringId.CustomFilterDialogCaption: return "Ventana de Filtrado [{0}]";
                case RadGridStringId.CustomFilterDialogLabel: return "Mostrar filas cuando:";
                case RadGridStringId.CustomFilterDialogRbAnd: return "Y";
                case RadGridStringId.CustomFilterDialogRbOr: return "O";
                case RadGridStringId.CustomFilterDialogBtnOk: return "Aceptar";
                case RadGridStringId.CustomFilterDialogBtnCancel: return "Cancelar";
                case RadGridStringId.CustomFilterDialogCheckBoxNot: return "No";
                case RadGridStringId.CustomFilterDialogTrue: return "Verdadero";
                case RadGridStringId.CustomFilterDialogFalse: return "Falso";
                case RadGridStringId.FilterMenuBlanks: return "Vacio";
                case RadGridStringId.FilterMenuAvailableFilters: return "Filtros disponibles";
                case RadGridStringId.FilterMenuSearchBoxText: return "Buscar...";
                case RadGridStringId.FilterMenuClearFilters: return "Limpiar Filtro";
                case RadGridStringId.FilterMenuButtonOK: return "Aceptar";
                case RadGridStringId.FilterMenuButtonCancel: return "Cancelar";
                case RadGridStringId.FilterMenuSelectionAll: return "Todos";
                case RadGridStringId.FilterMenuSelectionAllSearched: return "Todos los resultados de la busqueda";
                case RadGridStringId.FilterMenuSelectionNull: return "Nulo";
                case RadGridStringId.FilterMenuSelectionNotNull: return "No Nulo";
                case RadGridStringId.FilterFunctionSelectedDates: return "Filtrar por fechas especificas:";
                case RadGridStringId.FilterFunctionToday: return "Hoy";
                case RadGridStringId.FilterFunctionYesterday: return "Ayer";
                case RadGridStringId.FilterFunctionDuringLast7days: return "Durante los últimos 7 dias";
                case RadGridStringId.FilterLogicalOperatorAnd: return "Y";
                case RadGridStringId.FilterLogicalOperatorOr: return "O";
                case RadGridStringId.FilterCompositeNotOperator: return "NO";
                case RadGridStringId.DeleteRowMenuItem: return "Borrar Fila";
                case RadGridStringId.SortAscendingMenuItem: return "Ordenar Ascendente";
                case RadGridStringId.SortDescendingMenuItem: return "Oredenar Descendiente";
                case RadGridStringId.ClearSortingMenuItem: return "Limpiar Ordenamiento";
                case RadGridStringId.ConditionalFormattingMenuItem: return "Conditional Formatting";
                case RadGridStringId.GroupByThisColumnMenuItem: return "Ordenar por esta columna";
                case RadGridStringId.UngroupThisColumn: return "No ordenar por esta columna";
                case RadGridStringId.ColumnChooserMenuItem: return "Escojer Columnas";
                case RadGridStringId.HideMenuItem: return "Ocultar Columna";
                case RadGridStringId.HideGroupMenuItem: return "Ocultar Grupo";
                case RadGridStringId.UnpinMenuItem: return "Unpin Column";
                case RadGridStringId.UnpinRowMenuItem: return "Unpin Row";
                case RadGridStringId.PinMenuItem: return "Pinned state";
                case RadGridStringId.PinAtLeftMenuItem: return "Pin at left";
                case RadGridStringId.PinAtRightMenuItem: return "Pin at right";
                case RadGridStringId.PinAtBottomMenuItem: return "Pin at bottom";
                case RadGridStringId.PinAtTopMenuItem: return "Pin at top";
                case RadGridStringId.BestFitMenuItem: return "Best Fit";
                case RadGridStringId.PasteMenuItem: return "Pegar";
                case RadGridStringId.EditMenuItem: return "Editar";
                case RadGridStringId.ClearValueMenuItem: return "Limpiar Valor";
                case RadGridStringId.CopyMenuItem: return "Copiar";
                case RadGridStringId.CutMenuItem: return "Cortar";
                case RadGridStringId.AddNewRowString: return "Click aqui para añadir nueva fila";
                case RadGridStringId.ConditionalFormattingSortAlphabetically: return "Ordenar Columnas afabeticamente";
                case RadGridStringId.ConditionalFormattingCaption: return "Conditional Formatting Rules Manager";
                case RadGridStringId.ConditionalFormattingLblColumn: return "Format only cells with";
                case RadGridStringId.ConditionalFormattingLblName: return "Rule name";
                case RadGridStringId.ConditionalFormattingLblType: return "Cell value";
                case RadGridStringId.ConditionalFormattingLblValue1: return "Value 1";
                case RadGridStringId.ConditionalFormattingLblValue2: return "Value 2";
                case RadGridStringId.ConditionalFormattingGrpConditions: return "Rules";
                case RadGridStringId.ConditionalFormattingGrpProperties: return "Rule Properties";
                case RadGridStringId.ConditionalFormattingChkApplyToRow: return "Apply this formatting to entire row";
                case RadGridStringId.ConditionalFormattingChkApplyOnSelectedRows: return "Apply this formatting if the row is selected";
                case RadGridStringId.ConditionalFormattingBtnAdd: return "Add new rule";
                case RadGridStringId.ConditionalFormattingBtnRemove: return "Remove";
                case RadGridStringId.ConditionalFormattingBtnOK: return "OK";
                case RadGridStringId.ConditionalFormattingBtnCancel: return "Cancel";
                case RadGridStringId.ConditionalFormattingBtnApply: return "Apply";
                case RadGridStringId.ConditionalFormattingRuleAppliesOn: return "Rule applies to";
                case RadGridStringId.ConditionalFormattingCondition: return "Condición";
                case RadGridStringId.ConditionalFormattingExpression: return "Expresión";
                case RadGridStringId.ConditionalFormattingChooseOne: return "[Elige uno(a)]";
                case RadGridStringId.ConditionalFormattingEqualsTo: return "Igual a [Value1]";
                case RadGridStringId.ConditionalFormattingIsNotEqualTo: return "No es igual a [Value1]";
                case RadGridStringId.ConditionalFormattingStartsWith: return "Empieza con [Value1]";
                case RadGridStringId.ConditionalFormattingEndsWith: return "Termina con [Value1]";
                case RadGridStringId.ConditionalFormattingContains: return "Contiene [Value1]";
                case RadGridStringId.ConditionalFormattingDoesNotContain: return "No contiene [Value1]";
                case RadGridStringId.ConditionalFormattingIsGreaterThan: return "Es mayor que [Value1]";
                case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual: return "Es mayor o igual [Value1]";
                case RadGridStringId.ConditionalFormattingIsLessThan: return "Es menor que [Value1]";
                case RadGridStringId.ConditionalFormattingIsLessThanOrEqual: return "Es menor o igual [Value1]";
                case RadGridStringId.ConditionalFormattingIsBetween: return "Está etnre [Value1] y [Value2]";
                case RadGridStringId.ConditionalFormattingIsNotBetween: return "No está entre [Value1] y [Value1]";
                case RadGridStringId.ConditionalFormattingLblFormat: return "Formatear";
                case RadGridStringId.ConditionalFormattingBtnExpression: return "Expression editor";
                case RadGridStringId.ConditionalFormattingTextBoxExpression: return "Expression";
                case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitive: return "CaseSensitive";
                case RadGridStringId.ConditionalFormattingPropertyGridCellBackColor: return "CellBackColor";
                case RadGridStringId.ConditionalFormattingPropertyGridCellForeColor: return "CellForeColor";
                case RadGridStringId.ConditionalFormattingPropertyGridEnabled: return "Enabled";
                case RadGridStringId.ConditionalFormattingPropertyGridRowBackColor: return "RowBackColor";
                case RadGridStringId.ConditionalFormattingPropertyGridRowForeColor: return "RowForeColor";
                case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignment: return "RowTextAlignment";
                case RadGridStringId.ConditionalFormattingPropertyGridTextAlignment: return "TextAlignment";
                case RadGridStringId.ConditionalFormattingPropertyGridCellFont: return "My Cell Font";
                case RadGridStringId.ConditionalFormattingPropertyGridCellFontDescription: return "My Font Description";
                case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitiveDescription: return "Determines whether case-sensitive comparisons will be made when evaluating string values.";
                case RadGridStringId.ConditionalFormattingPropertyGridCellBackColorDescription: return "Enter the background color to be used for the cell.";
                case RadGridStringId.ConditionalFormattingPropertyGridCellForeColorDescription: return "Enter the foreground color to be used for the cell.";
                case RadGridStringId.ConditionalFormattingPropertyGridEnabledDescription: return "Determines whether the condition is enabled (can be evaluated and applied).";
                case RadGridStringId.ConditionalFormattingPropertyGridRowBackColorDescription: return "Enter the background color to be used for the entire row.";
                case RadGridStringId.ConditionalFormattingPropertyGridRowForeColorDescription: return "Enter the foreground color to be used for the entire row.";
                case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignmentDescription: return "Enter the alignment to be used for the cell values, when ApplyToRow is true.";
                case RadGridStringId.ConditionalFormattingPropertyGridTextAlignmentDescription: return "Enter the alignment to be used for the cell values.";
                case RadGridStringId.ColumnChooserFormCaption: return "Column Chooser";
                case RadGridStringId.ColumnChooserFormMessage: return "Drag a column header from the\ngrid here to remove it from\nthe current view.";
                case RadGridStringId.GroupingPanelDefaultMessage: return "Arrastra una columna aqui para agrupar por ella.";
                case RadGridStringId.GroupingPanelHeader: return "Agrupar por:";
                case RadGridStringId.PagingPanelPagesLabel: return "Página";
                case RadGridStringId.PagingPanelOfPagesLabel: return "de";
                case RadGridStringId.NoDataText: return "No hay datos que mostrar";
                case RadGridStringId.CompositeFilterFormErrorCaption: return "Error de filtro";
                case RadGridStringId.CompositeFilterFormInvalidFilter: return "The composite filter descriptor is not valid.";
                case RadGridStringId.ExpressionMenuItem: return "Expression";
                case RadGridStringId.ExpressionFormTitle: return "Expression Builder";
                case RadGridStringId.ExpressionFormFunctions: return "Functions";
                case RadGridStringId.ExpressionFormFunctionsText: return "Text";
                case RadGridStringId.ExpressionFormFunctionsAggregate: return "Aggregate";
                case RadGridStringId.ExpressionFormFunctionsDateTime: return "Date-Time";
                case RadGridStringId.ExpressionFormFunctionsLogical: return "Logical";
                case RadGridStringId.ExpressionFormFunctionsMath: return "Math";
                case RadGridStringId.ExpressionFormFunctionsOther: return "Other";
                case RadGridStringId.ExpressionFormOperators: return "Operators";
                case RadGridStringId.ExpressionFormConstants: return "Constants";
                case RadGridStringId.ExpressionFormFields: return "Fields";
                case RadGridStringId.ExpressionFormDescription: return "Description";
                case RadGridStringId.ExpressionFormResultPreview: return "Result preview";
                case RadGridStringId.ExpressionFormTooltipPlus: return "Plus";
                case RadGridStringId.ExpressionFormTooltipMinus: return "Minus";
                case RadGridStringId.ExpressionFormTooltipMultiply: return "Multiply";
                case RadGridStringId.ExpressionFormTooltipDivide: return "Divide";
                case RadGridStringId.ExpressionFormTooltipModulo: return "Modulo";
                case RadGridStringId.ExpressionFormTooltipEqual: return "Equal";
                case RadGridStringId.ExpressionFormTooltipNotEqual: return "Not Equal";
                case RadGridStringId.ExpressionFormTooltipLess: return "Less";
                case RadGridStringId.ExpressionFormTooltipLessOrEqual: return "Less Or Equal";
                case RadGridStringId.ExpressionFormTooltipGreaterOrEqual: return "Greater Or Equal";
                case RadGridStringId.ExpressionFormTooltipGreater: return "Greater";
                case RadGridStringId.ExpressionFormTooltipAnd: return "Logical \"AND\"";
                case RadGridStringId.ExpressionFormTooltipOr: return "Logical \"OR\"";
                case RadGridStringId.ExpressionFormTooltipNot: return "Logical \"NOT\"";
                case RadGridStringId.ExpressionFormAndButton: return string.Empty; //if empty, default button image is used
                case RadGridStringId.ExpressionFormOrButton: return string.Empty; //if empty, default button image is used
                case RadGridStringId.ExpressionFormNotButton: return string.Empty; //if empty, default button image is used
                case RadGridStringId.ExpressionFormOKButton: return "OK";
                case RadGridStringId.ExpressionFormCancelButton: return "Cancel";
                case RadGridStringId.SearchRowChooseColumns: return "SearchRowChooseColumns";
                case RadGridStringId.SearchRowSearchFromCurrentPosition: return "SearchRowSearchFromCurrentPosition";
                case RadGridStringId.SearchRowMenuItemMasterTemplate: return "SearchRowMenuItemMasterTemplate";
                case RadGridStringId.SearchRowMenuItemChildTemplates: return "SearchRowMenuItemChildTemplates";
                case RadGridStringId.SearchRowMenuItemAllColumns: return "SearchRowMenuItemAllColumns";
                case RadGridStringId.SearchRowTextBoxNullText: return "SearchRowTextBoxNullText";
                case RadGridStringId.SearchRowResultsOfLabel: return "SearchRowResultsOfLabel";
                case RadGridStringId.SearchRowMatchCase: return "Match case";
            }
            return string.Empty;
        }
    }
}