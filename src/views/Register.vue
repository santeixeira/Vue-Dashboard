<template>
  <router-view/>
</template>

<script lang="ts">
import { defineComponent } from "vue";
export default defineComponent({
  // eslint-disable-next-line vue/multi-word-component-names
  name: "Register",
  
});
</script>

<style scoped>
.box {
  margin: 2em 25em 10em;
  height: 40em;
}
.content-dev {
  margin: 3em;
}

.button {
  width: calc();
}

.progressbar li {
  float: left;
  width: 20%;
  position: relative;
  text-align: center;
}

.input::placeholder {
  font-size: small;
  font-weight: 700;
}

.input, .textarea{
  width: 25em;
}
</style>
