   M S B A M L   `   `   `  ����D  @OficinaV2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:OficinaV2	OficinaV2  5   	       OficinaV2.EcraMovimento   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v21.2, Version=21.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:OficinaV2     5   	   l hDevExpress.Xpf.Grid.v21.2.Extensions, Version=21.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49af bDevExpress.Xpf.Grid.v21.2.Core, Version=21.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v21.2, Version=21.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a@dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid    5   	   l	 hDevExpress.Xpf.Core.v21.2.Extensions, Version=21.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a=dx2http://schemas.devexpress.com/winfx/2008/xaml/core  	 5   	   ]
 YDevExpress.Mvvm.v21.2, Version=21.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aAdxmvvm2http://schemas.devexpress.com/winfx/2008/xaml/mvvm 
  5	   	   ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  5
   	   <dxb2http://schemas.devexpress.com/winfx/2008/xaml/bars  5   	     � Title$  Controlo Stock��5   	   $	��550��6    $	��900��6-   .��5      �  � ColumnDefinitions 5      �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5      �� 5      $��* �6   �� 5      $��4* �6   .+�5      �� $��Bottom=�6   $��Center=�6)   $��0��6F   $��0��6V   $��Dados��6c   $��	10 0 10 5q�6s   $
��Bold"�6�   $	��400��6�   
���   ���5      u� 5       u� Bottom$ 1Q�6   5    	   �� 5"      $	��Top=�6   $��0��6+    �� Orientation$ Vertical=�6<   $��105,27,280,0q�6S   $��85��6i   $��1��6u   .+�5#      �� $��Right=�6   $��0q�64   $��ID Peça��6@   $��0 0 0 10q�6R   �� 5$      $��Right=�6   $��0q�64   $��Descrição��6@   5%   	   �� 5'      $��1��6   $��0��6    $
��Left=�60   $ Vertical=�6K   $��180,22,0,336q�6b   .+�5(      �� -   5         ��Name$ ComboBoxIdPeca��5(   G   $
��Left=�6_   $��0 0 0 5q�6z   $��45��6�   ��5)      �� 5*      .R�5+      �� .+�5,      �� ��6!   �� *	Id_peca+5-      5.      50      �� 51      -   5         ��Name$ descricao_peca_txt��51   %    �� 
IsReadOnly . $��0,0,0,1q�6a   $	��160��6{   ��6A   �� *Descricao_peca+6{   52   	   �� 54      $��Bottom=�6   $��Center=�6)   $��1��6F   $��0��6V   $��Controlo de stock��6c   $��	10 0 10 5q�6   $
��Bold"�55      $	��385��6    
���   ���56      u� 57      $ 1Q�6   59   	   �� 5;      $	��Top=�6   $	��390��6+   $��1��67   $��1��6G   $��
30,12,30,0q�6T   $��30��6h   .+�5<      �� -   5        
�������$
��Left=�5<   %   $��Center=�6@   $��4q�6x   $��20��6�   $��20��6�   .��5=      (�  (� Stretch$ Uniform=�6   .��5>      F� s������     �ڴ    �ڴ��� � H���� � H�z�ѠIz�ѠI H�Ѱ��  H�Ѱ�� z��    z��    ��� Ѱ�� ��� 	
���   �
���   �$��0��5?   +   5@      5A      5B   	   %  DevExpress.Xpf.Grid.GridControl  5D      -   5        	  Name$	 MovimentosGridControl��5D      $��Center=�67   $��1��6T   $��1��6d   $	��380��6q   $��
0,57,0,185q�6}   
   Columns.
 5E      $  DevExpress.Xpf.Grid.GridColumn  $  DevExpress.Xpf.Grid.ColumnBase   AllowEditing] YDevExpress.Data.v21.2, Version=21.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a5  /DevExpress.Utils.Design.DefaultBooleanConverter$
 True 6      	FieldName$ Descricao_movimento��6.   $  DevExpress.Xpf.Grid.BaseColumn   Header)  #DevExpress.Xpf.Core.ObjectConverter$ Descrição 6N      Width2  ,DevExpress.Xpf.Grid.GridColumnWidthConverter$
 auto 6a     5F      $
 True 6   $ Quantidade_movimento��6.   $ 
Quantidade 6O     5G      $
 True 6   $ Data_movimento��6.   $
 Data 6I     5H      $
 True 6   $ Operacao��6.   $ 
Operação 6C     5I      $ QuantidadeVezesOperacao��6   $ quanti*operacao 6>      Visible .  6W      View 5K      #  DevExpress.Xpf.Grid.TableView  5L      -   5          Name$ Vista��5M   J      ShowUpdateRowButtons$ OnCellEditorOpen=�5L   <   &	   DevExpress.Xpf.Grid.DataViewBase 	  NavigationStyle$
 Cell=�6d    	  AllowEditing .  	  ShowFixedTotalSummary .    	AutoWidth . $��Center=�5M   Y   $	��388��6v      FormatConditions 5O      )
  #DevExpress.Xpf.Grid.FormatCondition
  5P      -  'DevExpress.Xpf.Grid.FormatConditionBase   	FieldName$ Operacao��6(    
  	ValueRule$ Equal=�6=    
  Value1$ 1��6O   1  +DevExpress.Xpf.Grid.ExpressionConditionBase   Format. 5Q      6  0DevExpress.Xpf.Core.ConditionalFormatting.Format     Icon 6!   *  $DevExpress.Xpf.Core.IconSetExtension     Name$ 	Arrows3_1��5R      
  5S      $ Operacao��6(   $ Equal=�6=   $ -1��6O   . 5T         6!     $ 	Arrows3_3��5U      5W       � ContextMenu 5Y      �� 5Z      .@�5[      m� -   5        $��Remover��5[      6+   5\         TotalSummary 5^      )  #DevExpress.Xpf.Grid.GridSummaryItem  5_      )  #DevExpress.Xpf.Grid.SummaryItemBase    SummaryType5  /DevExpress.Data.Design.SummaryItemTypeConverter$  Count 6"   !   	Alignment$! Right=�66   "   DisplayFormat$" Total movimentos: {0}��6H     5`      $
! Left=�6"   $	  Sum 63   $" Quantidade stock: {0}��6E   #   	FieldName$# QuantidadeVezesOperacao��6k   5b   	   5h      5i      