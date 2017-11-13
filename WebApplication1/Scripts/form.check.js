/**function checkUsername() {
    var u = document.getElementById("username");
    var ut = document.getElementById("username_tip");
    var reg = /^[a-z]{6,10}$/;

    if (!reg.test(u.value)) {
        showUncorrect(u, ut, "用户名为6-10个小写字母");
    } else {
        showOk(ut);
    }
}**/

function checkPwd() {
    var p = document.getElementById("pwd");
    var pt = document.getElementById("pwd_tip");
    var reg = /^[0-9]{6}$/;

    if (!reg.test(p.value)) {
        showUncorrect(p, pt, "密码为6位数字");
    } else {
        showOk(pt);
    }
}

function checkRePwd() {
    var p = document.getElementById("pwd");
    var rp = document.getElementById("rePwd");
    var rpt = document.getElementById("re_pwd_tip");

    if (p.value != rp.value) {
        showUncorrect(rp, rpt, "密码不一致");
    } else {
        showOk(rpt);
    }
}

function checkEmail() {
    var e = document.getElementById("email");
    var et = document.getElementById("email_tip");
    var reg = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;

    if (!reg.test(e.value)) {
        showUncorrect(e, et, "邮箱格式错误");
    } else {
        showOk(et);
    } 
}

function checkTel() {
    var t = document.getElementById("tel");
    var tt = document.getElementById("tel_tip");
    var reg = /^1569[0-9]{7}$/;

    if (!reg.test(t.value)) {
        showUncorrect(t, tt, "以1569开头，11位");
    } else {
        showOk(tt);
    }
}

function showUncorrect(e, tip, str) {
    tip.style.color = "red";
    tip.innerHTML = str;
    e.focus();
}

function showOk(t) {
    t.style.color = "green";
    t.innerHTML = "OK";
}