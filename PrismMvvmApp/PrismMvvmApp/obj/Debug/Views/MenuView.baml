   M S B A M L   `   `   `  ����G  CPrismMvvmApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:PrismMvvmApp.ViewsPrismMvvmApp.Views  5      !    PrismMvvmApp.Views.MenuView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:PrismMvvmApp.Views     5      [ WPrism.DryIoc.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59T PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel$
  TrueX�5       � 	Resources 5      ��%    5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      $��25 �6   �� 5      $��25 �6   �� 5      $��25 �6   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5!   
   	� $��0��6   $��2��6$   $��Center=�68   $��Center=�6Z   #��[Bd�6~   ��6�   �� *GotoEquipManagementCommand+��5#      �� 5$      $��EqUip Management��6   5&      	� 5'   
   $��1��6   $��2��6#   $��Center=�67   $��Center=�6Y   #��[Bd�6}   ��5(      �� 5)      $��I/O Management��6   5+      	� 5,   
   $��2��6   $��1��6#   $��Center=�63   $
��Left=�6U   #��[Bd�6w   ��6�   �� *GotoIOInputManagementCommand+��5-      �� 5.      $��	▶ Input��6   50      	� 51   
   $��3��6   $��1��6#   $��Center=�63   $
��Left=�6U   #��[Bd�6w   ��6�   �� *GotoIOOutputManagementCommand+��52      �� 53      $��
▶ Output��6   55      	� 56   
   $��4��6   $��1��6#   $��Center=�63   $
��Left=�6U   #��[Bd�6w   ��6�   �� *" GotoIOParameterManagementCommand+��57      �� 58      $��▶ Parameter��6   5:      	� 5;   
   $��5��6   $��2��6#   $��Center=�67   $��Center=�6Y   #��[Bd�6}   ��6�   �� *GotoBaseModelCommand+��5<      �� 5=      $��	BaseModel��6   5?      	� 5@   
   $��6��6   $��2��6#   $��Center=�67   $��Center=�6Y   #��[Bd�6}   ��6�   �� *GotoCustomModelCommand+��5A      �� 5B      $��CustomModel��6   5D      	� 5E   
   $��7��6   $��2��6#   $��Center=�67   $��Center=�6Y   #��[Bd�6}   ��6�   �� *GotoLayoutDesignCommand+��5F      �� 5G      $��LayoutDesign��6   5I      	� 5J   
   $��8��6   $��2��6#   $��Center=�67   $��Center=�6Y   #��[Bd�6}   ��6�   �� *GotoTestSimmulatorCommand+��5K      �� 5L      $��TestSimmulator��6   5N      	� 5O   
   $��9��6   $��2��6#   $��Center=�67   $��Center=�6Y   #��[Bd�6}   ��6�   �� *GotoMonitoringCommand+��5P      �� 5Q      $��
Monitoring��6   5S      5T      5U      