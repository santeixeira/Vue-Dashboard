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
  props: {
    placeholder: {
      type: String,
    },
    icon: {
      type: String,
    },
    options: {
      type: [Array, Object, Function],
      required: false,
      default: () => [],
    },
  },
});
</script>

<style scoped></style>
