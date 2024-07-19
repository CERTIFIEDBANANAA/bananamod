document.addEventListener("DOMContentLoaded", () => {
    const files = [
        { name: "Banana Menu 1.0.0.csproj", size: "12.9 KB", type: "file", link:"/raw/Banana Menu 1.0.0.csproj"},
        { name: "PluginInfo.cs", size: "329 bytes", type: "file", link:"/raw/PluginInfo.cs"},
        { name: "Directory.Build.props", size: "610 bytes", type: "file", link:"/raw/Directory.Build.props"},
        { name: "Directory.Build.targets", size: "298 bytes", type: "file", link:"/raw/Directory.Build.targets"},
        { name: "StupidTemplate.sln", size: "1.1 kb", type: "file", link:"/raw/StupidTemplate.sln"},
    ];

    const fileList = document.getElementById("file-list");

    files.forEach(file => {
        const li = document.createElement("li");

        const icon = document.createElement("span");
        const a = document.createElement("a");
        a.href=file.link
      
        icon.classList.add("icon");
        icon.innerHTML = file.type === "folder" ? "📁" : "💾";
        
        const name = document.createElement("span");
        name.classList.add("file-name");
        name.textContent = file.name;

        const size = document.createElement("span");
        size.classList.add("file-size");
        size.textContent = file.size;

        li.appendChild(icon);
        li.appendChild(size);
        li.appendChild(a)
        a.appendChild(name);

        fileList.appendChild(li);
    });
});
