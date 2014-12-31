A sample project that shows how to create a "floating"/"contextual" menu within Xamarin.Forms. It uses only stock Xamarin components and does not rely on custom renderers, etc.

The important code to look at is under the FloatMenu project and is split between the SamplePage.xaml and SamplePage.xaml.cs files. The xaml shows an example of a few elements that you would want to show (e.g. a ListView). The code-behind file is responsible for showing the "menu" in the right place (in this example we opt to show the menu just below the selected ListView selected item). There is a separate GestureRecognizer there for dismissing the menu.

It would also be possible to show this in a more "modal style" if desired by just changing the "modal" box that is rendered (it currently has no background or anything specified).
