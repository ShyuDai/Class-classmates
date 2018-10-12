

//CheckBox全选
function CA(){
var frm=document.forms[0];
for (var i=0;i<frm.elements.length;i++)
{
var e=frm.elements[i];
if ((e.name != 'allbox') && (e.type=='checkbox'))
{
e.checked=frm.allbox.checked;
if (frm.allbox.checked)
{
hL(e);
}//endif
else
{
dL(e);
}//endelse

}//endif
}//endfor
}


//CheckBox选择项
function CCA(CB) {
    return false;
}


function hL(E){
while (E.tagName!="TR")
{E=E.parentElement;}
E.className="H";
}

function dL(E){
while (E.tagName!="TR")
{E=E.parentElement;}
E.className="";
}
