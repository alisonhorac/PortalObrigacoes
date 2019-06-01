$('input[name="Phone"]').keyup(function(e)
                                {
  if (/\D/g.test(this.value))
  {
    this.value = this.value.replace(/\D/g, '');
  }
});

$('input[name="DDDPhone"]').keyup(function (e) {
    if (/\D/g.test(this.value)) {
        this.value = this.value.replace(/\D/g, '');
    }
});