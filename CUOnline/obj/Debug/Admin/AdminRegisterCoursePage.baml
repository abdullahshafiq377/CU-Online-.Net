   M S B A M L   `   `   `  ����C  ?CUOnline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CUOnlineCUOnline  5      &     CUOnline.AdminRegisterCoursePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:CUOnline     5        N� Title$  AdminRegisterCoursePage��5
      .��5      �    WhiteColour#��[  6   .+�5   
   �� $��Register Courses��6     Heading1Style#��[ 5      $��	50 20 0 0q�5      �� 5   
   $	��100��6   $	��Top=�5      $��0 90 0 0q�5       �� Orientation$ 
Horizontal=�5      .+�5      �� $	��300��6   $
��Left=�5      $��	200 0 0 0q�5      .+�5      �� $��Registration No.��6     BodyText2Style#��[ 5      $��0 10 0 0q�5      $	��150��5      $
��Left=�5      �� 5      $ 
Horizontal=�6   $	��300��5      $
��Left=�5      $��0 0 0 0q�5       .+�5!      �� -   5         ��Name$ Session_ComboBox��5!      $��40��5"      $��60��5#      $
��Left=�5$      $��Center=�5%      $��18(�5&      .@�5'      �� $��FA��6'   �� 5(      $��SP��6'   5)      �� 5*      -   5        $ Year_ComboBox��5*      $��40��5+      $��60��5,      $
��Left=�5-      $��Center=�5.      $��18(�5/      $��15 0 0 0q�50      .@�52      �� $��17��6'   �� 53      $��18��6'   �� 54      $��19��6'   �� 55      $��20��6'   �� 56      $��21��6'   57      �� 58      -   5        $ Program_ComboBox��58      $��40��59      $��70��5:      $
��Left=�5;      $��Center=�5<      $��18(�5=      $��15 0 0 0q�5>      .@�5?      �� $	��BCS��6'   �� 5@      $	��BSE��6'   �� 5A      $	��BCE��6'   5B      �� 5D      -   5         ��Name$ RollNo_TextBox��5D        TextBoxStyle#��[ 5E      $��60��5F      $
��Left=�5G      $��15 0 0 0q�5H      5I      5J      �� 5M      -   5         ��Name$ SearchStudentButton��5M      $��Search��5N      $��
400 30 0 0q�5O        PrimaryButtonStyle#��[ 5P      $	��Top=�5Q      5R      5T      �� 5U   
   $ 
Horizontal=�6   .+�5V      �� $	��150��6   $	��250��5W      $
��Left=�5X      $	��Top=�5Y      $��350 220 0 0q�5Z      .+�5\      �� $��Registration No:��6     BodyText1Style#��[ 5]      �� 5_      $��Name:��6   #��[ 5`      $��0 20 0 0q�5a      �� 5c      $��Father's Name:��6   #��[ 5d      $��0 20 0 0q�5e      5f      �� 5h      $	��150��6   $	��250��5i      $
��Left=�5j      $	��Top=�5k      $��100 220 0 0q�5l      .+�5n      �� -   5         ��Name$ RegistrationNo_Label��5n      $�� ��5o      #��[ 5p      �� 5r      -   5        $ 
Name_Label��5r      $�� ��5s      #��[ 5t      $��0 20 0 0q�5u      �� 5w      -   5        $ FatherName_Label��5w      $�� ��5x      #��[ 5y      $��0 20 0 0q�5z      5{      5~      �� 5   
   -	   5         ��Name$ MainStackPanel��5      $	��300��5�      {�.  $��	0 400 0 0q�5�      .+�5�      �� $��Courses:��6   #��[ 5�      $��	350 0 0 0q�5�      $	��150��5�      $
��Left=�5�      �� 5�      -
   5        $ Courses_ComboBox��5�      $��40��5�      $	��400��5�      $
��Left=�5�      $��Center=�5�      $��18(�5�      $��
350 10 0 0q�5�      5�      �� 5�      -   5        $ RegisterCourseButton��5�      $��Register��5�      $��	0 150 0 0q�5�      #��[ 5�      $	��Top=�5�      5�      5�      5�      5�      