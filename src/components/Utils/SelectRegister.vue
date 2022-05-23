<template>
  <div class="input-box">
    <i v-bind:class="icon"></i>
    <select :placeholder="placeholder" required>
      <slot></slot>
    </select>
  </div>
</template>
<script lang="ts">
import { defineComponent } from "vue";
export default defineComponent({
  // eslint-disable-next-line vue/multi-word-component-names
  name: "SelectRegister",
  props: ["icon", "placeholder"],
});
</script>

<style scoped></style>
