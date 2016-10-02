....MOVED TO [blog](http://blog.koakh.com/blog/post/aspnet-core-aurelia-typescript-webpack-tutorial)

----
#### GitHub

koakh/NetCoreAsp-AureliaStartup	
https://github.com/koakh/NetCoreAsp-AureliaStartup.git

or create a new repository on the command line

echo "# NetCoreAsp-AureliaStartup" >> README.md
git init
git add README.md
git commit -m "first commit"
git remote add origin https://github.com/koakh/NetCoreAsp-AureliaStartup.git
git push -u origin master

or push an existing repository from the command line

git remote add origin https://github.com/koakh/NetCoreAsp-AureliaStartup.git
git push -u origin master

done

now use github windows to sync and pull
vscode with synchronize (local) 
	C+S+P GIT: Sync
and Pull (Remote)
	C+S+P GIT: GIT: Pull

----
#### Servers

**Start Client Side WebPack Server**

package.json
	...
	"start": "npm run server:dev",
}, 

```
npm start
...

http://localhost:9000/
webpack result is served from /
content is served from C:\Users\mario\Desktop\myData\Development\VisualCodeProjects\NetCoreAsp\Aurelia\NetCoreAsp-AureliaStartup
404s will fallback to /index.html
```

**Start Server Side WebPack Server**

use tasks\build and launch from vscode 

or

```
coreclr "C:\Users\mario\Desktop\myData\Development\VisualCodeProjects\NetCoreAsp\Aurelia\NetCoreAsp-AureliaStartup\bin\Debug\netcoreapp1.0\modern.dll"
```
