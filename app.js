!function(f,b,e,v,n,t,s)
        {if(f.fbq)return;n=f.fbq=function(){n.callMethod?
        n.callMethod.apply(n,arguments):n.queue.push(arguments)};
        if(!f._fbq)f._fbq=n;n.push=n;n.loaded=!0;n.version='2.0';
        n.queue=[];t=b.createElement(e);t.async=!0;
        t.src=v;s=b.getElementsByTagName(e)[0];
        s.parentNode.insertBefore(t,s)}(window,document,'script',
        'https://connect.facebook.net/en_US/fbevents.js');
         fbq('init', '1187491087929823'); 
        fbq('track', 'PageView');
        fbq('track', 'Lead');
        fbq('track', 'Search');
        fbq('track', 'CompleteRegistration');


window.dataLayer = window.dataLayer || [];
function gtag(){dataLayer.push(arguments);}
gtag('js', new Date());

gtag('config', 'AW-993325609');

window._vwo_code = window._vwo_code || (function(){
    var account_id=438316,
    settings_tolerance=2000,
    library_tolerance=2500,
    use_existing_jquery=false,
    is_spa=1,
    hide_element='body',

    /* DO NOT EDIT BELOW THIS LINE */
    f=false,d=document,code={use_existing_jquery:function(){return use_existing_jquery;},library_tolerance:function(){return library_tolerance;},finish:function(){if(!f){f=true;var a=d.getElementById('_vis_opt_path_hides');if(a)a.parentNode.removeChild(a);}},finished:function(){return f;},load:function(a){var b=d.createElement('script');b.src=a;b.type='text/javascript';b.innerText;b.onerror=function(){_vwo_code.finish();};d.getElementsByTagName('head')[0].appendChild(b);},init:function(){
    settings_timer=setTimeout('_vwo_code.finish()',settings_tolerance);var a=d.createElement('style'),b=hide_element?hide_element+'{opacity:0 !important;filter:alpha(opacity=0) !important;background:none !important;}':'',h=d.getElementsByTagName('head')[0];a.setAttribute('id','_vis_opt_path_hides');a.setAttribute('type','text/css');if(a.styleSheet)a.styleSheet.cssText=b;else a.appendChild(d.createTextNode(b));h.appendChild(a);this.load('//dev.visualwebsiteoptimizer.com/j.php?a='+account_id+'&u='+encodeURIComponent(d.URL)+'&f='+(+is_spa)+'&r='+Math.random());return settings_timer; }};window._vwo_settings_timer = code.init(); return code; }());
    

function AumentaRow() {
    document.getElementById('div_pagamento').setAttribute("style", "height:500px");
}

function Formatar(src, mask) {

    if (event.keyCode > 47 && event.keyCode < 58) 
    {
        event.returnValue = true;
    }    
    else 
    {        
           event.returnValue = false;       
    }     

    var i = src.value.length;
    var saida = mask.substring(0, 1);
    saida = '#';
    var texto = mask.substring(i)
    if (texto.substring(0, 1) != saida)
    {
        src.value += texto.substring(0, 1);
    }	
}


function mascara(o, f) {
v_obj = o
v_fun = f
setTimeout("execmascara()", 1)
}
function execmascara() {
    v_obj.value = v_fun(v_obj.value)
}
function mtel(v) {
    v = v.replace(/\D/g, "");             //Remove tudo o que não é dígito
    v = v.replace(/^(\d{2})(\d)/g, "($1) $2"); //Coloca parênteses em volta dos dois primeiros dígitos
    v = v.replace(/(\d)(\d{4})$/, "$1.$2");    //Coloca hífen entre o quarto e o quinto dígitos
    return v;
}

function ValidateCheckboxes() 
{
    var inputElems = document.getElementById("chTermoCompromisso");
    if (inputElems.type === "checkbox" && inputElems.checked === false)
    {
        alert("Por favor, marque o termo de compromisso.");
        return false;
    }
    return true;
}


(function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
    (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
    m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
    })(window,document,'script','https://www.google-analytics.com/analytics.js','ga');

    ga('create', 'UA-16804633-2', 'auto');
    ga('send', 'pageview');