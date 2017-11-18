function showTime()
{
    document.getElementById('datetime').innerHTML = "现在是 ";
    var now = new Date();
    //当前日期时间对象now
    var year = now.getFullYear();
    var month = now.getMonth()+1;
    var day = now.getDate();
    //年月日
    var weekday = now.getDay();
    //星期
    var hour = plus_zero(now.getHours());
    var minute = plus_zero(now.getMinutes());
    var second = plus_zero(now.getSeconds());
    //时分秒
    document.getElementById('datetime').innerHTML += year + "年" + month + "月" + day + "日 ";
    switch(weekday)
    {
        case 0:
            document.getElementById('datetime').innerHTML += "星期日 ";
            break;
        case 1:
            document.getElementById('datetime').innerHTML += "星期一 ";
            break;
        case 2:
            document.getElementById('datetime').innerHTML += "星期二 ";
            break;
        case 3:
            document.getElementById('datetime').innerHTML += "星期三 ";
            break;
        case 4:
            document.getElementById('datetime').innerHTML += "星期四 ";
            break;
        case 5:
            document.getElementById('datetime').innerHTML += "星期五 ";
            break;
        case 6:
            document.getElementById('datetime').innerHTML += "星期六 ";
            break;
    }
    document.getElementById('datetime').innerHTML += hour + ":" + minute + ":" + second;
    t = setTimeout('showTime()', 1000);
}

function plus_zero(num)
{
    if(num<10)
    {
        num = "0" + num;
    }
    return num;
}