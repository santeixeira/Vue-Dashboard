<template>
  <button type="button" class="button next">
    <slot></slot>
  </button>
</template>
<script lang="ts">
import { defineComponent } from "vue";

export default defineComponent({
  // eslint-disable-next-line vue/multi-word-component-names
  name: "ButtonsRegister",
});
</script>

<style scoped>
button {
  width: 12em;
  margin: 2em;
  font-size: 16px;
  font-weight: 600;
}

button.next {
  background-color: #e74718;
  color: #fff;
}
.next:hover {
  background-color: #051c27;
}
</style>
