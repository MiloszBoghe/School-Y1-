function byTagName(node, tagName) {
    let array = [];
    if (node.nodeName === "BODY") {
        node = node.children;// altijd children gebruiken ipv childNodes
        for (let n of node) {
            if (n.nodeName === tagName.toUpperCase()) {
                array.push(n);
            }
        }
    } else {
        for (let n of node) {
            if (n.nodeName === tagName.toUpperCase()) {
                array.push(n);
            } else {
                let children = Array.from(n.children);
                children.forEach(child => {
                    if (child.nodeName === tagName.toUpperCase()) {
                        array.push(child);
                    }
                });
            }
        }
    }
    return array;
}

console.log(byTagName(document.getElementsByTagName("div"), "p"));

