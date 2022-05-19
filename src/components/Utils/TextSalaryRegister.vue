<template>
  <div class="input-boxes">
    <label for="" class="checkbox">
      <input type="checkbox"/>
      <slot></slot>
    </label>
    <TextRegister :placeholder="value" :icon="icon"></TextRegister>
  </div>
</template>
<script lang="ts">
import { defineComponent } from "vue";
import TextRegister from "./TextRegister.vue";

export default defineComponent({
  // eslint-disable-next-line vue/multi-word-component-names
  name: "TextSalaryRegister",
  components: { TextRegister },
  data() {
    return {
      value: "0,00",
      icon: "fas fa-dollar",
    };
  },
});
</script>

<style scoped>
label {
  padding: 0 2em 0;
  margin: 0 0 -2em;
  display: flex;
}
input{
  margin: 0 0.5em 0;
}

.checkbox-tag{
  border: 1px;
}

.input-box {
  display: flex;
  align-items: center;
  height: 50px;
  width: 100%;
  margin: 2em 0 2em;
  padding: 0 2em 0;
  position: relative;
}
.input-box input {
  height: 100%;
  width: 100%;
  outline: none;
  border: none;
  padding: 0 40px;
  font-size: 16px;
  font-weight: 500;
  border-bottom: 2px solid rgba(0, 0, 0, 0.2);
  transition: all 0.3s ease;
}

</style>
