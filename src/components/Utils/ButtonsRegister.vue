<template>
  <button type="button" class="button next" :class="buttonClass">
    <slot></slot>
  </button>
</template>
<script lang="ts">
import { defineComponent } from "vue";

export default defineComponent({
  // eslint-disable-next-line vue/multi-word-component-names
  name: "ButtonsRegister",
  props: ['buttonClass']
});
</script>

<style scoped>
button {
  width: 12em;
  font-size: 16px;
  font-weight: 600;
  border: none;
  background-color: #e74718;
  color: #fff;
}

button:hover {
  background-color: #051B26;
  color: #fff;
}
</style>
