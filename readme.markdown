This is the code I wrote as part of my [MIX 11 talk](http://channel9.msdn.com/events/MIX/MIX11/HTM10) on WebSockets.

I don't have a license to redistribute the two binaries that I reference:

    Microsoft.ServiceModel.Tcp.dll
    Microsoft.ServiceModel.WebSockets.dll
    

But these are included in the [HTML5 Labs WebSocket prototype](http://html5labs.interoperabilitybridges.com/html5labs/prototypes/websockets/websockets/download/).

Once the install is complete, you'll have the prototype bits at: 
**C:\\Program Files (x86)\\Microsoft SDKs\\WCF WebSockets** or 
**C:\\Program Files\\Microsoft SDKs\\WCF WebSockets** if you are on a 32-bit OS.

If you are going to use the Silverlight plugin to simulate WebSockets, you'll need to drop the **clientaccesspolicy.xml** file (found in the bin folder) into your **c:\\inetpub\\wwwroot** folder.

This demo uses the 07 prototype.

You can use a [private build](http://www.ducksong.com/misc/websockets-builds/ws-07/5.0.a2.03/) of Firefox with support for 07 WebSockets.




