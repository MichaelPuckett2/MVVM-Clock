   M S B A M L   `   `   `  ����@  <Clock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Clock.Views.ConvertersClock.Views.Converters  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0898    2Clock.Views.Converters.PercentageOfDoubleConverter   PercentageOfDoubleConverter9   3Clock.Views.Converters.MinuteSecondToAngleConverter   MinuteSecondToAngleConverter8  2Clock.Views.Converters.MillisecondToAngleConverter  MillisecondToAngleConverter1   +Clock.Views.Converters.HourToAngleConverter  HourToAngleConverter  	ClockSize  ClockBackgroundColor  � Color � Offset  ClockGlassColor  HourHandStyle �� 
TargetType �� Property �� Value �� Angle �� 	Converter  MinuteHandStyle 	 SecondHandStyle 
 MillisecondHandStyle  ClockTemplate � RowDefinitions �� Mode	 �� RelativeSource
 �� RadiusX �� RadiusY �� ConverterParameter �� Source�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      3
Converters$clr-namespace:Clock.Views.Converters  5      1System&clr-namespace:System;assembly=mscorlib  5      %
  &	        &	      &	 &     &	 9     &	 L     &	 g     &	 �     &	 �    7  &	 �    7  &		 �    7  &	
 �    7  &	 �    7  7  7  7   7  7  7   7  7 	 7   7  7     5      6-     5      6.     5
      6-     5      6&   X�5      325Q�6+   �� 5      .��5   
   � $  	#FF7BC3FF��6   � 5   
   $  	#FF406B8F��6   $ 1Q�5      5      �� 5      .��5   
   � $  	#1EFFFFFF��6   $ 0.218Q�5      � 5   
   $  	#1EFFFFFF��6   $
 0.51Q�5      � 5   
   $ 0.104Q�6   � 5   
   $ 0.275Q�6   � 5   
   $
 0.40Q�6   � 5   
   $
 0.57Q�6   5      �� 5!      " ��5"      .�5#   
   ��  �@J�RenderTransformOrigin$ 0.5, 1&�5$      �� 5%   
    � z� 5&      V� 5'      .~�5(      �� �� 5)      �� 5*       6&   �� *Hour+8   T� 5+      5,      5.      5/      �� 51      " ��52      .�53   
   ��  �@J�RenderTransformOrigin$ 0.5, 1&�54      �� 55   
    � z� 56      V� 57      .~�58      �� �� 59      �� 5:       6&   �� *Minute+8   T� 5;      5<      5>      5?      �� 5A      " ��5B      .�5C   
   ��  �@J�RenderTransformOrigin$ 0.5, 1&�5D      �� 5E   
    � z� 5F      V� 5G      .~�5H      �� �� 5I      �� 5J       6&   �� *Second+8   T� 5K      5L      5N      5O      �� 5Q      " ��5R      .�5S   
   ��  �@J�RenderTransformOrigin$ 0.5, 1&�5T      �� 5U   
    � z� 5V      V� 5W      .~�5X      �� �� 5Y      �� 5Z       6&   �� *Millisecond+8   T� 5[      5\      5^      5_      �� 5a      .R�5b   
   � 8��   5c      �� 5d      �� 5e      .+�5h      A� $��2��6   8�� ��5j      �� *ActualHeight+$ OneWay=�	 �� *Self+�� 5l      8�� .��5m      �� $��7��6   
���   �$��Bottom=�5p      $
 7��5q      $ 7��5r      ��5n      �� $ 35��8  $ OneWay=�8  5r      5s      �� 5u      8�� .��5v      �� $��3��6   
���   �$��Bottom=�5y      $
 7��5z      $ 7��5{      ��5w      �� $ 47��8  $ OneWay=�8  5{      5|      �� 5~      8�� .��5      �� $��1��6   
���   �$��Bottom=�5�      $
 7��5�      $ 7��5�      ��5�      �� $ 47��8 	 $ OneWay=�8 
 5�      5�      A� 5�      $��2��6   $��3q�5�      8�� ��5�      �� *ActualHeight+$ OneWay=�	 �� *Self+5�      5�      5�      