   M S B A M L   `   `   `  ����D  @OficinaV2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:OficinaV2	OficinaV2  5   	       OficinaV2.EcraReparacoes2   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v21.2, Version=21.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   l hDevExpress.Xpf.Grid.v21.2.Extensions, Version=21.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49af bDevExpress.Xpf.Grid.v21.2.Core, Version=21.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v21.2, Version=21.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a@dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid    5   	   l	 hDevExpress.Xpf.Core.v21.2.Extensions, Version=21.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a=dx2http://schemas.devexpress.com/winfx/2008/xaml/core  	 5   	   ]
 YDevExpress.Mvvm.v21.2, Version=21.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aAdxmvvm2http://schemas.devexpress.com/winfx/2008/xaml/mvvm 
  5   	   ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  5	   	   <dxb2http://schemas.devexpress.com/winfx/2008/xaml/bars  5
   	   #localclr-namespace:OficinaV2  5   	     � Title$  Reparações��5   	   $	��550��6   $	��900��6)   .��5      �  � RowDefinitions 5      �� 5      $	��.8* �6   �� 5      $��* �6   �� 5      $��2* �6    � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� $
��Left=�6   $��Bottom=�6.    �� Orientation$ 
Horizontal=�6I   $��0��6b   $��	20,0,0,40q�6o   $	��195��6�   .+�5      �� -   5        
�������$��6q�5   :   $��5 0 0 0q�6F   $��30��6W   $��30��6c   .��5      (�  (� Stretch$ Uniform=�6   .��5      F� �����d����@J�x�d����@�Ѷ���Ѷ��J�x0���B� @1����?Q �� 1����?Q �� �^��^ @���B� @�^��^ @�        ����@    ���@�ֱ \�#@Q����ֱ \�#@Ѷ��    �o �    �o � H��     H�	
���   �
���   �$��0��5   +   5       5!      �� 5#      -   5        
�������$��6q�5#   :   $��5 0 0 0q�6F   $��30��6W   $��30��6c   .��5$      (� $ Uniform=�6   .��5%      F� �������    �JLM    U^� ����?�T�W"P��@@S�N�L�g�w�@ H���  H���� � H��� V���� ?����lĚ��K��I� �7�d\� �7���� ��7�(�� S�
�� >�!@�G|�9�R@S��`�Y� h@��;Far��@��Far��@SW�� Far��@��� �Y� h@0� �9�R@S�� �e��� @�r X8"@!� 2V��Wy!@�޵ �v� �k�    �k-��@�?�����
@�
�0�@ퟧ�� @���o�@-���@��`d@B�P *� � @W"P��@@S��  ����?X+� ��	
���   �
���   �$��0��5&   +   5'      5(      �� 5*      -   5        
�������$��6q�5*   =   $��5 0 0 0q�6I   $��30��6[   $��30��6g   .��5+      (� $ Uniform=�6   .��5,      F� �����X�7�Ѧ���7�Ѧ���1��X�1�����e��#@�7���� �7���� �1�����e��#@�1��    �Cz�MPq#0@�Cz�MPq#0@�5��    �5��	`�    S:����`Jt�ָ��}f�2�?�Y�w�Y���?3���$@@"Ҁ�_b�?3���$@@�(*v��@��W$���@�S^�  P@ӊ�� �Q��� ��RYY� [YCӕҪ ��AHŧ  P@�>� Z�>�c%��@�� ����bd@�z�  �`���@ʀ� �s�ڃ�@L5� ފiK��@w����"@�1�Mcc@h����"@���#0@Z�� у�� A�� Q	қh�v����?S����}f�2�?�*����`Jt�	`�	
���   �
���   �$��0��5.   +   5/      50      51   	   �� 53      $��Bottom=�6   $��Center=�6)   $��0��6F   $��0��6V   $��Dados��6c   $��
10 0 10 10q�6s   $
��Bold"�6�   $	��400��6�   ��54      �� 55       �� Color$ Black��6   ��57      u� 58       u� Bottom$ 1Q�6   5:   	   � 5=      $��0��6   $��45,112,0,281q�6   $��3��63    5>      �� 5?      $
��.55* �6   �� 5@      $��2* �6    5C      �� 5D      �� 5E      �� 5F      �� 5G      .+�5J      �� $��25 0 0 0q�6   $
��Left=�6#   $��0��6>   $��0��6K   $��Right=�6[   $��
Matrícula��6~   6�   �� 5K      $��25 0 0 0q�6   $
��Left=�6#   $��1��6>   $��0��6K   $��Right=�6[   $��Marca��6~   6�   �� 5L      $��25 0 0 0q�6   $
��Left=�6#   $��2��6>   $��0��6K   $��Right=�6[   $	��Cor��6~   6�   �� 5M      $��25 0 0 0q�6   $
��Left=�6#   $��3��6>   $��0��6K   $��Right=�6[   $
��Data��6~   6�   �� 5O      -   5         ��Name$ matricula_txt��5O   ]   $��0 0 0 10q�6   $
��Left=�6%   $��0��6@   $��1��6M   $��0,0,0,1q�6u   $	��160��6�   $��0,5,0,0q�6�   �� 5P      -   5        $ 	marca_txt��5P   ]   $��0 0 0 10q�6   $
��Left=�6%   $��1��6@   $��1��6M   $��0,0,0,1q�6p   $	��160��6�   $��0,5,0,0q�6�   �� 5Q      -   5        $ cor_txt��5Q   ]   $��0 0 0 10q�6   $
��Left=�6%   $��2��6@   $��1��6M   $��0,0,0,1q�6n   $	��160��6�   $��0,5,0,0q�6�   (  "System.Windows.Controls.DatePicker  5S      -   5          Name$ data_txt��5S   5   $��88,5,0,0q�6   $��3��6(   $
��Left=�6G   $	��113��6b   $��2��6n   5T   	   �� 5W      $��
112,21,0,0q�6   $
��Left=�6"   $��2��6=   $��0��6J   $��Right=�6Z   $��Estado:��6}   6�   �� 5X      -   5        $ 
estado_txt��5X   C   $��2��6   $��
Sem estado��6   	 �� 
IsReadOnly	 . 
 �� TextAlignment$
 Center=�6W   $��Center=�6n   $��160,21,195,220q�6�   �� 5[      $��
10 0 10 10q�6   $��Bottom=�6"   $��Center=�6=   $��0��6[   $��1��6h   $��Lista peças��6x   $
��Bold"�6�   $	��400��6�   ��5\      �� 5]      $ Black��6   ��5_      u� 5`      $ 1Q�6   5b   	   %  DevExpress.Xpf.Grid.GridControl  5e      -	   5          Name$ PecasGridControl��5e      $��2��62   $��1��6C   $��Center=�6S   $��	0,8,0,195q�6q   $	��240��6�   $��1��6�      Columns. 5g      $  DevExpress.Xpf.Grid.GridColumn  $  DevExpress.Xpf.Grid.ColumnBase   	FieldName$ Descricao_peca��6   $  DevExpress.Xpf.Grid.BaseColumn   Header)  #DevExpress.Xpf.Core.ObjectConverter$ Descrição 65      Width2  ,DevExpress.Xpf.Grid.GridColumnWidthConverter$ 3* 6H      EditSettings 5h      :  4DevExpress.Xpf.Editors.Settings.ComboBoxEditSettings  5i      -
   5          Name$ PecasCombobox��5i   ]   8	  2DevExpress.Xpf.Editors.Settings.ButtonEditSettings 	  IsTextEditable$ FalseX�6*   6
  0DevExpress.Xpf.Editors.Settings.BaseEditSettings 
  NullText$ Escolha uma peça��6A   <  6DevExpress.Xpf.Editors.Settings.LookUpEditSettingsBase   DisplayMember$ Descricao_peca��6t      ValueMember$ Descricao_peca��6�   5k        5m      $! Quantidade_pecas_reparacoes��6   $ 
Quantidade 6B   $
 auto 6V      View 5o      #  DevExpress.Xpf.Grid.TableView  5p      -   5          Name$ Vista��5p         ShowUpdateRowButtons$ OnCellEditorOpen=�6K      	AutoWidth . $��Center=�6�   $
��auto��6�   5q      5s   	   �� 5v      $��105,50,280,180q�6   $��2��6+   $��1��68   �� 5w      -   5        $	��Top=�5w      ���	#FFEFEFEF$
��Left=�6>   $��6q�6q   $��30��6}   $��30��6�   $��1��6�   $��	345,8,0,0q�6�   $��1��6�   .��5x      (� $ Uniform=�6   .��5y      F� s������     �ڴ    �ڴ��� � H���� � H�z�ѠIz�ѠI H�Ѱ��  H�Ѱ�� z��    z��    ��� Ѱ�� ��� 	���	#FF5B5B5B
���   �$��0��5z   /   5{      5|   	   5}      5~      