Other....MOVED TO [blog](http://blog.koakh.com/blog/post/aspnet-core-aurelia-typescript-webpack-tutorial)

Urls
- [ClientSide](http://localhost:9000)

```
npm start

http://localhost:9000/
webpack result is served from /
content is served from C:\Users\mario\Desktop\myData\Development\VisualCodeProjects\NetCoreAsp\Aurelia\NetCoreAsp-AureliaStartup
404s will fallback to /index.html
```

> to start **webpack-dev-server**

- [ServerSide](http://localhost:5000/api/greetings)

> F5 or Debug

```
npm run server:dev
```
or

```
coreclr "C:\Users\mario\Desktop\myData\Development\VisualCodeProjects\NetCoreAsp\Aurelia\NetCoreAsp-AureliaStartup\bin\Debug\netcoreapp1.0\modern.dll"
```

```
package.json
	...
	"start": "npm run server:dev",
}, 
```

----
#### GitHub

- [koakh/NetCoreAsp-AureliaStartup](https://github.com/koakh/NetCoreAsp-AureliaStartup.git)

Create a new repository on the command line

```
echo "# NetCoreAsp-AureliaStartup" >> README.md
git init
git add README.md
git commit -m "first commit"
git remote add origin https://github.com/koakh/NetCoreAsp-AureliaStartup.git
git push -u origin master
```

or push an existing repository from the command line

```
git remote add origin https://github.com/koakh/NetCoreAsp-AureliaStartup.git
git push -u origin master
```

Now use github windows to sync and pull
vscode with synchronize (local) 
	C+S+P GIT: Sync
and Pull (Remote)
	C+S+P GIT: GIT: Pull

