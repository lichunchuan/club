
 alert(50)

var alertTrigger = document.getElementsByTagName('LoginBtn')


if (alertTrigger) {
  alertTrigger.addEventListener('click', function () {
    alert('Nice, you triggered this alert message!', 'success')
  })
}
