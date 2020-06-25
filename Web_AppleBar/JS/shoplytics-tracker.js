(function(){'use strict';function e(e,t,n){return t in e?Object.defineProperty(e,t,{value:n,enumerable:!0,configurable:!0,writable:!0}):e[t]=n,e}function t(e,t){var n=Object.keys(e);if(Object.getOwnPropertySymbols){var r=Object.getOwnPropertySymbols(e);t&&(r=r.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),n.push.apply(n,r)}return n}function n(n){for(var r=1;r<arguments.length;r++){var o=null!=arguments[r]?arguments[r]:{};r%2?t(o,!0).forEach((function(t){e(n,t,o[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(n,Object.getOwnPropertyDescriptors(o)):t(o).forEach((function(e){Object.defineProperty(n,e,Object.getOwnPropertyDescriptor(o,e))}))}return n}console;var r,o=(function(e,t){var n;n=function(){function e(){for(var e=0,t={};e<arguments.length;e++){var n=arguments[e];for(var r in n)t[r]=n[r]}return t}function t(e){return e.replace(/(%[0-9A-Z]{2})+/g,decodeURIComponent)}return function n(r){function o(){}function i(t,n,i){if('undefined'!=typeof document){'number'==typeof(i=e({path:'/'},o.defaults,i)).expires&&(i.expires=new Date(1*new Date+864e5*i.expires)),i.expires=i.expires?i.expires.toUTCString():'';try{var a=JSON.stringify(n);/^[\{\[]/.test(a)&&(n=a)}catch(e){}n=r.write?r.write(n,t):encodeURIComponent(String(n)).replace(/%(23|24|26|2B|3A|3C|3E|3D|2F|3F|40|5B|5D|5E|60|7B|7D|7C)/g,decodeURIComponent),t=encodeURIComponent(String(t)).replace(/%(23|24|26|2B|5E|60|7C)/g,decodeURIComponent).replace(/[\(\)]/g,escape);var c='';for(var s in i)i[s]&&(c+='; '+s,!0!==i[s]&&(c+='='+i[s].split(';')[0]));return document.cookie=t+'='+n+c}}function a(e,n){if('undefined'!=typeof document){for(var o={},i=document.cookie?document.cookie.split('; '):[],a=0;a<i.length;a++){var c=i[a].split('='),s=c.slice(1).join('=');n||'"'!==s.charAt(0)||(s=s.slice(1,-1));try{var u=t(c[0]);if(s=(r.read||r)(s,u)||t(s),n)try{s=JSON.parse(s)}catch(e){}if(o[u]=s,e===u)break}catch(e){}}return e?o[e]:o}}return o.set=i,o.get=function(e){return a(e,!1)},o.getJSON=function(e){return a(e,!0)},o.remove=function(t,n){i(t,'',e(n,{expires:-1}))},o.defaults={},o.withConverter=n,o}((function(){}))},e.exports=n()}(r={exports:{}}),r.exports),i=function(e){var t=!1;try{t=void 0!==window[e]}catch(e){}return t},a=i('localStorage'),c=i('sessionStorage'),s=navigator.cookieEnabled,u=function(e,t){var r,o,i,a,c,s=(t||{}).register;Object.defineProperty(this,'s',{value:e,writable:!1}),this.i=n({},{is_mobile:(c=navigator.userAgent||navigator.vendor||window.opera,/(android|bb\d+|meego).+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|mobile.+firefox|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|series(4|6)0|symbian|treo|up\.(browser|link)|vodafone|wap|windows ce|xda|xiino/i.test(c)||/1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-/i.test(c.substr(0,4)))},{},(o=(r=window.location).pathname,i=r.origin,a=r.search,{url_path:o,http_referer:document.referrer,http_domain:i,http_search:a})),this.r=n({},s)},p=function(e,t){Object.keys(t).forEach((function(n){e(t[n],n)}))},l={Accept:'application/json','Content-Type':'application/x-www-form-urlencoded'},f=function(e,t){try{var n=e;if(!n)return;Array.isArray(n)||(n=[n]),p((function(e){'function'==typeof e&&e(t)}),n)}catch(e){}},d=function(e){var t={};return p((function(e,n){(e&&'undefined'!==e&&'null'!==e||0===e)&&(t[n]=e)}),e),t},m=Object.freeze({__proto__:null,init:u,register:function(e){var t=this;p((function(e,n){void 0===e?delete t.r[n]:t.r[n]=e}),e)},track:function(e,t){'PageView'===e&&(e='View');var r,i=function(e,t){if(s)return o.get('_spt',void 0)}()||function(e){if(a)return localStorage.getItem('_spt')}()||function(e){if(c)return sessionStorage.getItem('_spt')}(),u=n({event_name:e,scope:this.s},this.i,{},this.r,{},t);i&&(u.sid=i),function(e){switch(e.scope){case'shop':if(!e.merchant_id)return!1;break;default:return!1}return!0}(u)?(r={data:d(u)},function(e,t){var n,r,o=t||{},i=o.method,a=void 0===i?'GET':i,c=o.timeout,s=void 0===c?2e3:c,u=o.data,d=function(){var e={queue:[]},t={then:function(n){return e.queue.push(n),t},catch:function(n){return e.catch=n,t},finally:function(n){return e.finally=n,t}};return{handler:e,handlerSetter:t}}(),m=d.handler,h=d.handlerSetter,g=function(e){f(m.catch,e.type),f(m.finally)},v=new XMLHttpRequest,b=(n=encodeURIComponent,(r=u,Object.keys(r).map((function(e){return function(e,t){return n(t)+'='+n(e)}(r[e],e)}))).join('&'));return v.open(a,'https://events.shoplytics.com/api/v1/tr?'+b,!0),p((function(e,t){v.setRequestHeader(t,e)}),l),v.withCredentials=!0,v.timeout=s,v.onload=function(e){if(200===v.status){var t=e.srcElement||e.target,n=JSON.parse(t.response);f(m.queue,n)}else f(m.catch,e);f(m.finally)},v.onerror=g,v.onabort=g,v.ontimeout=g,v.send(b),h}(0,{method:r.method||'GET',timeout:r.timeout||2e3,data:r.data})).then((function(e){var t;(function(e,t,n){s&&o.set('_spt',t,void 0)})(0,t=e.sid),function(e,t){a&&localStorage.setItem('_spt',t)}(0,t),function(e,t){c&&sessionStorage.setItem('_spt',t)}(0,t)})).catch((function(e){})):u.scope}}),h=function(e,t,n){var r=this.s;if(r&&'init'!==e){var o=m[e];o&&'function'==typeof o&&o.apply(this,[t,n])}else r||'init'!==e||u.apply(this,[t,n])};try{!function(e){var t=e.shoplytics||h;e.shoplytics=t,(t.q||[]).forEach((function(e){h.apply(t,e)})),delete t.q,Object.defineProperty(t,'exec',{value:h,writable:!1})}(window)}catch(e){}})();
