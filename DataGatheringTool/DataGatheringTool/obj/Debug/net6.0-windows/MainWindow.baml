   M S B A M L   `   `   `  ����L  HDataGatheringTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:DataGatheringToolDataGatheringTool  5   	   "    DataGatheringTool.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:DataGatheringTool     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$ Data Gathering Tool��5	   	   $	��200��6%   $	��320��62   .��5
      � $��5q�6   .+�5   
   �� $��Center=�6   $	��Top=�61   $��20��6I   $	��280��6U   $��0,5,0,0q�6a   $
��URL:��6r   �� 5   
   -   5         ��Name$	 URL��5      $��Center=�6   $	��Top=�6<   $��20��6T   $	��275��6`   $��0,25,0,0q�6l   $�� ��6~   �� 5   
   $��Center=�6   $	��Top=�61   $��20��6I   $	��280��6U   $��0,55,0,0q�6a   $��Temperature Separation:��6s   �� 5   
   -   5        $
 Temp��5      $��Center=�6    $	��Top=�6=   $��20��6U   $��30��6a   $��	15,55,0,0q�6l   $��37��6   �� 5   
   $��Center=�6   $	��Top=�61   $��20��6I   $��15��6U   $��	70,55,0,0q�6`   $	��°C��6s   �� 5   
   $��Center=�6   $	��Top=�61   $��20��6I   $	��280��6U   $��0,80,0,0q�6a   $��Sort By:��6s   �� 5   
   $
��Left=�6   $	��Top=�60   $��
20,100,0,0q�6H   .+�5      	� -   5         	�Name$ ID��5   J    	� 	GroupName$
 Sort��6    d� 	IsChecked$
 TrueY�6+   .��6V   ID6Z   	� 5      -   5        $	 Age��5   9   $
 Sort��6   .��6F   Age6K   	� 5      -   5        $ Temperature��5   9   $
 Sort��6   .��6N   Temperature6[   5      �� 5   
   -   5         ��Name$ GatherDataButton��5      $��Gather Data��6>   $��Right=�6T   $��Bottom=�6p   $��0,0,0,0q�6�   $��20��6�   $	��100��6�   5      5      