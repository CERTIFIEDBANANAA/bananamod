document.addEventListener("DOMContentLoaded", () => {
    const files = [
        { name: "dlls", size: "", type: "folder" },
        { name: "raw_csharp", size: "", type: "folder" }
    ];

    const fileList = document.getElementById("file-list");

    files.forEach(file => {
        const li = document.createElement("li");

        const icon = document.createElement("span");
        icon.classList.add("icon");
        icon.innerHTML = file.type === "folder" ? "📁" : "📄";
        
        const name = document.createElement("span");
        name.classList.add("file-name");
        name.textContent = file.name;

        const size = document.createElement("span");
        size.classList.add("file-size");
        size.textContent = file.size;

        li.appendChild(icon);
        li.appendChild(name);
        li.appendChild(size);

        fileList.appendChild(li);
    });
});
